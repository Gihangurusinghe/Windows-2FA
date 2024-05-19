namespace Windows_2FA
{
    partial class QRUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRUI));
            Step1Desc = new Label();
            Step1 = new Label();
            Step2 = new Label();
            Step2Desc = new Label();
            RegTOTP = new TextBox();
            RegVerify = new Button();
            QRCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)QRCode).BeginInit();
            SuspendLayout();
            // 
            // Step1Desc
            // 
            Step1Desc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step1Desc.Location = new Point(74, 71);
            Step1Desc.Name = "Step1Desc";
            Step1Desc.Size = new Size(355, 78);
            Step1Desc.TabIndex = 1;
            Step1Desc.Text = "Scan the QR Code from your authenticator app. ";
            Step1Desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Step1
            // 
            Step1.AutoSize = true;
            Step1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step1.Location = new Point(206, 39);
            Step1.Name = "Step1";
            Step1.Size = new Size(85, 32);
            Step1.TabIndex = 2;
            Step1.Text = "STEP 1";
            // 
            // Step2
            // 
            Step2.AutoSize = true;
            Step2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step2.Location = new Point(206, 149);
            Step2.Name = "Step2";
            Step2.Size = new Size(85, 32);
            Step2.TabIndex = 3;
            Step2.Text = "STEP 2";
            // 
            // Step2Desc
            // 
            Step2Desc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Step2Desc.Location = new Point(74, 193);
            Step2Desc.Name = "Step2Desc";
            Step2Desc.Size = new Size(355, 88);
            Step2Desc.TabIndex = 4;
            Step2Desc.Text = "Enter the OTP Code generated on your smartphone to complete the registration. ";
            Step2Desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegTOTP
            // 
            RegTOTP.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegTOTP.Location = new Point(140, 296);
            RegTOTP.Margin = new Padding(3, 2, 3, 2);
            RegTOTP.MaximumSize = new Size(567, 56);
            RegTOTP.Name = "RegTOTP";
            RegTOTP.Size = new Size(217, 56);
            RegTOTP.TabIndex = 5;
            RegTOTP.TextAlign = HorizontalAlignment.Center;
            RegTOTP.TextChanged += RegTOTP_TextChanged;
            // 
            // RegVerify
            // 
            RegVerify.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegVerify.Location = new Point(140, 380);
            RegVerify.Margin = new Padding(3, 2, 3, 2);
            RegVerify.Name = "RegVerify";
            RegVerify.Size = new Size(217, 50);
            RegVerify.TabIndex = 6;
            RegVerify.Text = "Verify";
            RegVerify.UseVisualStyleBackColor = true;
            RegVerify.Click += RegVerify_Click;
            // 
            // QRCode
            // 
            QRCode.Image = (Image)resources.GetObject("QRCode.Image");
            QRCode.Location = new Point(484, 39);
            QRCode.Name = "QRCode";
            QRCode.Size = new Size(469, 391);
            QRCode.SizeMode = PictureBoxSizeMode.StretchImage;
            QRCode.TabIndex = 8;
            QRCode.TabStop = false;
            QRCode.Click += QRCode_Click;
            // 
            // QRUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 503);
            Controls.Add(QRCode);
            Controls.Add(RegVerify);
            Controls.Add(RegTOTP);
            Controls.Add(Step2Desc);
            Controls.Add(Step2);
            Controls.Add(Step1);
            Controls.Add(Step1Desc);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(865, 410);
            Name = "QRUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows 2FA";
            Load += QRUI_Load;
            ((System.ComponentModel.ISupportInitialize)QRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Step1Desc;
        private Label Step1;
        private Label Step2;
        private Label Step2Desc;
        private TextBox RegTOTP;
        private Button RegVerify;
        private PictureBox QRCode;
    }
}