
namespace Windows_2FA
{
    public partial class RegisterUI : Form
    {
        private BackupCodeManager backupCodeManager;


        public RegisterUI()
        {
            InitializeComponent();

            // Set the start position to center on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            backupCodeManager = new BackupCodeManager();

            // Check if a secret key file exists in the default location
            UpdateUI();
        }

        public void UpdateUI()
        {
            // Enable or disable the register button based on the existence of the secret key file
            RegButton.Enabled = !SecretKeyExists();
        }

        public bool SecretKeyExists()
        {
            string secretKeyFilePath = GetSecretKeyFilePath();
            return File.Exists(secretKeyFilePath);
        }

        public string GetSecretKeyFilePath()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataFolder, "secret.key");
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        private void RegButton_Click(object sender, EventArgs e)
        {
            {

                // Create an instance of Form2
                QRUI qrform = new QRUI((this));

                // Subscribe to the FormClosed event
                qrform.FormClosed += QRUI_FormClosed;

                // Show Form2 as a dialog
                qrform.Show();
            }
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {

            //Delete the secret key file if it exists
            string secretKeyFilePath = GetSecretKeyFilePath();
            if (File.Exists(secretKeyFilePath))
            {
                File.Delete(secretKeyFilePath);
                MessageBox.Show("Registration revoked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update the UI
                UpdateUI();

            }
            else
            {
                MessageBox.Show("No registration found to revoke.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Event handler for the FormClosed event of the QRUI form
        private void QRUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Trigger the backup button click event
            BackupButton.PerformClick();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            try
            {
                string backupCode;
                // Check if backup code file exists
                if (File.Exists(backupCodeManager.GetBackupCodeFilePath()))
                {
                    backupCode = backupCodeManager.LoadBackupCode();
                    MessageBox.Show($"Your Backup Code is: {backupCode}", "Backup Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Generate a new backup code if file doesn't exist
                    backupCode = backupCodeManager.GenerateBackupCode();
                    MessageBox.Show($"A new backup code has been generated: {backupCode}", "Backup Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions and display an error message box
                MessageBox.Show($"Error loading backup code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


 
    }
}
