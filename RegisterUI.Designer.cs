namespace Windows_2FA
{
    partial class RegisterUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUI));
            AuthPic = new PictureBox();
            RegButton = new Button();
            ScanPic = new PictureBox();
            RegDonePic = new PictureBox();
            Step1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Step2 = new Label();
            label5 = new Label();
            RegDone = new Label();
            RevokeButton = new Button();
            BackupButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AuthPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScanPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegDonePic).BeginInit();
            SuspendLayout();
            // 
            // AuthPic
            // 
            AuthPic.Image = (Image)resources.GetObject("AuthPic.Image");
            AuthPic.Location = new Point(52, 131);
            AuthPic.Margin = new Padding(3, 2, 3, 2);
            AuthPic.Name = "AuthPic";
            AuthPic.Size = new Size(278, 214);
            AuthPic.SizeMode = PictureBoxSizeMode.StretchImage;
            AuthPic.TabIndex = 1;
            AuthPic.TabStop = false;
            AuthPic.Click += pictureBox1_Click_1;
            // 
            // RegButton
            // 
            RegButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegButton.Location = new Point(468, 459);
            RegButton.Margin = new Padding(3, 2, 3, 2);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(173, 61);
            RegButton.TabIndex = 3;
            RegButton.Text = "Register";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // ScanPic
            // 
            ScanPic.Image = (Image)resources.GetObject("ScanPic.Image");
            ScanPic.Location = new Point(414, 131);
            ScanPic.Margin = new Padding(3, 2, 3, 2);
            ScanPic.Name = "ScanPic";
            ScanPic.Size = new Size(278, 214);
            ScanPic.SizeMode = PictureBoxSizeMode.Zoom;
            ScanPic.TabIndex = 7;
            ScanPic.TabStop = false;
            ScanPic.Click += pictureBox3_Click;
            // 
            // RegDonePic
            // 
            RegDonePic.BackgroundImageLayout = ImageLayout.None;
            RegDonePic.Image = (Image)resources.GetObject("RegDonePic.Image");
            RegDonePic.Location = new Point(772, 131);
            RegDonePic.Margin = new Padding(3, 2, 3, 2);
            RegDonePic.Name = "RegDonePic";
            RegDonePic.Size = new Size(278, 214);
            RegDonePic.SizeMode = PictureBoxSizeMode.Zoom;
            RegDonePic.TabIndex = 12;
            RegDonePic.TabStop = false;
            // 
            // Step1
            // 
            Step1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step1.Location = new Point(52, 54);
            Step1.Name = "Step1";
            Step1.Size = new Size(278, 75);
            Step1.TabIndex = 13;
            Step1.Text = "STEP 1 : Authenticator App";
            Step1.TextAlign = ContentAlignment.MiddleCenter;
            Step1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 347);
            label2.Name = "label2";
            label2.Size = new Size(278, 91);
            label2.TabIndex = 14;
            label2.Text = "Install / Download any authenticator app on your smartphone.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(772, 347);
            label3.Name = "label3";
            label3.Size = new Size(278, 91);
            label3.TabIndex = 15;
            label3.Text = "Well Done! You have registered your device successfully.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Step2
            // 
            Step2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step2.Location = new Point(414, 48);
            Step2.Name = "Step2";
            Step2.Size = new Size(278, 87);
            Step2.TabIndex = 16;
            Step2.Text = " STEP 2  : Device Registration";
            Step2.TextAlign = ContentAlignment.MiddleCenter;
            Step2.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(414, 347);
            label5.Name = "label5";
            label5.Size = new Size(278, 91);
            label5.TabIndex = 17;
            label5.Text = "Click Register and scan the qr code from the authenticator app. ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegDone
            // 
            RegDone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegDone.Location = new Point(772, 42);
            RegDone.Name = "RegDone";
            RegDone.Size = new Size(278, 87);
            RegDone.TabIndex = 18;
            RegDone.Text = "Congratulations!";
            RegDone.TextAlign = ContentAlignment.MiddleCenter;
            RegDone.Click += label6_Click;
            // 
            // RevokeButton
            // 
            RevokeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RevokeButton.Location = new Point(826, 459);
            RevokeButton.Name = "RevokeButton";
            RevokeButton.Size = new Size(173, 61);
            RevokeButton.TabIndex = 20;
            RevokeButton.Text = "Revoke Registration";
            RevokeButton.UseVisualStyleBackColor = true;
            RevokeButton.Click += RevokeButton_Click;
            // 
            // BackupButton
            // 
            BackupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackupButton.Location = new Point(110, 459);
            BackupButton.Name = "BackupButton";
            BackupButton.Size = new Size(173, 61);
            BackupButton.TabIndex = 21;
            BackupButton.Text = "Backup Code";
            BackupButton.UseVisualStyleBackColor = true;
            BackupButton.Click += BackupButton_Click;
            // 
            // RegisterUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 573);
            Controls.Add(BackupButton);
            Controls.Add(RevokeButton);
            Controls.Add(RegDone);
            Controls.Add(label5);
            Controls.Add(Step2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Step1);
            Controls.Add(RegDonePic);
            Controls.Add(ScanPic);
            Controls.Add(RegButton);
            Controls.Add(AuthPic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegisterUI";
            Text = "Windows 2FA";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AuthPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScanPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegDonePic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox AuthPic;
        private Button RegButton;
        private PictureBox ScanPic;
        private PictureBox RegDonePic;
        private Label Step1;
        private Label label2;
        private Label label3;
        private Label Step2;
        private Label label5;
        private Label RegDone;
        private Button RevokeButton;
        private Button BackupButton;
    }
}
