using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private string EncryptPassword(string password, string pin)
        {
            string saltedPassword = password + pin;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string login = txtELogin.Text;
            string password = txtEPassword.Text;
            string pin = txtEPin.Text;

            string encryptedLogin = EncryptPassword(login, pin);
            string encryptedPassword = EncryptPassword(password, pin);

            rtxtELogin.Text = encryptedLogin;
            rtxtEPassword.Text = encryptedPassword;

            MessageBox.Show("Hasło zostało zaszyfrowane i gotowe do zapisu!");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedlogin = txtDLogin.Text;
            string encryptedPassword = txtDPassword.Text;
            string pin = txtDPin.Text;

            string decryptedLogin = EncryptPassword(encryptedlogin, pin);
            string decryptedPassword = EncryptPassword(encryptedPassword, pin);

            rtxtDLogin.Text = decryptedLogin;
            rtxtDPassword.Text = decryptedPassword;

            MessageBox.Show("Hasło zostało odszyfrowane!");
        }
        private void ClearAllTextBoxesAndRichTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                if (control is RichTextBox richTextBox)
                {
                    richTextBox.Text = string.Empty;
                }
            }

            foreach (Control control in gbEncrypted.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Text = string.Empty;
                }
            }

            foreach (Control control in gbDecrypted.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Text = string.Empty;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxesAndRichTextBoxes();
        }
    }
}
