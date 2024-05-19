using System.Runtime.InteropServices;

namespace Windows_2FA
{
    internal class Logout
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        public void LogoutUser()
        {
            // Specify the flags for logging off the user
            const uint EWX_LOGOFF = 0x00000000;
            const uint SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00050000;
            const uint SHTDN_REASON_MINOR_UPGRADE = 0x00000003;
            const uint SHTDN_REASON_FLAG_PLANNED = 0x80000000;

            // Perform the logoff
            ExitWindowsEx(EWX_LOGOFF,
                SHTDN_REASON_MAJOR_OPERATINGSYSTEM |
                SHTDN_REASON_MINOR_UPGRADE |
                SHTDN_REASON_FLAG_PLANNED);
        }


    }
}
