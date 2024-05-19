using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Windows_2FA
{
    internal class KeyboardHook
    {
        private delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_LWIN = 0x5B;
        private const int VK_RWIN = 0x5C;
        private const int VK_CONTROL = 0x11;
        private const int VK_MENU = 0x12;
        private const int VK_ESCAPE = 0x1B;
        private const int VK_F4 = 0x73;
        private const int VK_SHIFT = 0x10;
        private const int VK_ALT = 0x12;
        private const int VK_LSHIFT = 0xA0;
        private const int VK_RSHIFT = 0xA1;
        private const int VK_LCONTROL = 0xA2;
        private const int VK_RCONTROL = 0xA3;
        private const int VK_LMENU = 0xA4;
        private const int VK_RMENU = 0xA5;

        private IntPtr hookId = IntPtr.Zero;

        private int KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_LWIN || vkCode == VK_RWIN || vkCode == VK_CONTROL || vkCode == VK_MENU ||
                    vkCode == VK_ESCAPE || vkCode == VK_F4 || vkCode == VK_SHIFT || vkCode == VK_ALT ||
                    vkCode == VK_LSHIFT || vkCode == VK_RSHIFT || vkCode == VK_LCONTROL || vkCode == VK_RCONTROL ||
                    vkCode == VK_LMENU || vkCode == VK_RMENU)
                {
                    return 1;
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        public void InstallHook()
        {
            using (Process currentProcess = Process.GetCurrentProcess())
            using (ProcessModule currentModule = currentProcess.MainModule)
            {
                hookId = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookCallback, GetModuleHandle(currentModule.ModuleName), 0);
            }
        }

    }
    
}
