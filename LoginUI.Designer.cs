namespace Windows_2FA
{
    partial class LoginUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logout = new Button();
            label1 = new Label();
            LoginTOTP = new TextBox();
            Login = new Button();
            label2 = new Label();
            BackupLogin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.Anchor = AnchorStyles.None;
            Logout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.Location = new Point(773, 851);
            Logout.Name = "Logout";
            Logout.Size = new Size(395, 86);
            Logout.TabIndex = 1;
            Logout.Text = "Logout ";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 277);
            label1.Name = "label1";
            label1.Size = new Size(252, 47);
            label1.TabIndex = 2;
            label1.Text = "Enter the OTP !";
            // 
            // LoginTOTP
            // 
            LoginTOTP.Anchor = AnchorStyles.None;
            LoginTOTP.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginTOTP.Location = new Point(233, 385);
            LoginTOTP.Name = "LoginTOTP";
            LoginTOTP.Size = new Size(250, 57);
            LoginTOTP.TabIndex = 5;
            LoginTOTP.TextAlign = HorizontalAlignment.Center;
            LoginTOTP.TextChanged += LoginTOTP_TextChanged;
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.None;
            Login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(177, 647);
            Login.Name = "Login";
            Login.Size = new Size(1571, 86);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1353, 148);
            label2.Name = "label2";
            label2.Size = new Size(395, 47);
            label2.TabIndex = 7;
            label2.Text = "Login with Backup Code";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackupLogin
            // 
            BackupLogin.Anchor = AnchorStyles.None;
            BackupLogin.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackupLogin.Location = new Point(1438, 385);
            BackupLogin.Name = "BackupLogin";
            BackupLogin.Size = new Size(250, 57);
            BackupLogin.TabIndex = 8;
            BackupLogin.TextChanged += BackupLogin_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 148);
            label4.Name = "label4";
            label4.Size = new Size(345, 47);
            label4.TabIndex = 10;
            label4.Text = "Login with OTP Code";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1354, 277);
            label5.Name = "label5";
            label5.Size = new Size(394, 47);
            label5.TabIndex = 11;
            label5.Tag = " ";
            label5.Text = "Enter the Backup Code !";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(900, 305);
            label6.Name = "label6";
            label6.Size = new Size(67, 47);
            label6.TabIndex = 12;
            label6.Text = "OR";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BackupLogin);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(LoginTOTP);
            Controls.Add(label1);
            Controls.Add(Logout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginUI";
            ShowInTaskbar = false;
            Text = "LoginUI";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Logout;
        private Label label1;
        private TextBox LoginTOTP;
        private Button Login;
        private Label label2;
        private TextBox BackupLogin;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}