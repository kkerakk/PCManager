using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PCManager.Forms
{
    public partial class DataEncryption : Form
    {
        public DataEncryption()
        {
            InitializeComponent();
        }

        // Obsługa zdarzenia kliknięcia przycisku btnEncrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string password = rtxtPassword.Text;
            string pin = rtxtPin.Text;

            if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(pin))
            {
                string encryptedPassword = EncryptPassword(password, pin);
                rtxtEncrypted.Text = encryptedPassword;
            }
            else
            {
                MessageBox.Show("Wprowadź hasło i pin.");
            }
        }

        // Obsługa zdarzenia kliknięcia przycisku btnDecrypt
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedPassword = rtxtEncrypted.Text;
            string pin = rtxtPin.Text;

            if (!string.IsNullOrEmpty(encryptedPassword) && !string.IsNullOrEmpty(pin))
            {
                string decryptedPassword = DecryptPassword(encryptedPassword, pin);

                if (!string.IsNullOrEmpty(decryptedPassword))
                {
                    rtxtPassword.Text = decryptedPassword;
                }
                else
                {
                    MessageBox.Show("Błąd odszyfrowywania. Sprawdź poprawność pinu.");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź zaszyfrowane hasło i pin.");
            }
        }

        // Obsługa zdarzenia kliknięcia przycisku btnClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtPassword.Text = string.Empty;
            rtxtPin.Text = string.Empty;
            rtxtEncrypted.Text = string.Empty;
        }

        // Metoda do szyfrowania hasła przy użyciu pinu jako klucza
        private string EncryptPassword(string password, string pin)
        {
            // Przekształć pin na klucz szyfrowania
            byte[] pinBytes = Encoding.UTF8.GetBytes(pin);
            SHA256 sha256 = SHA256.Create();
            byte[] key = sha256.ComputeHash(pinBytes);

            // Szyfruj hasło za pomocą klucza
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] encryptedBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(BitConverter.GetBytes(aes.IV.Length), 0, sizeof(int));
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(passwordBytes, 0, passwordBytes.Length);
                        cs.FlushFinalBlock();
                    }

                    encryptedBytes = ms.ToArray();
                }
            }

            // Zwróć zaszyfrowane dane jako Base64 string
            return Convert.ToBase64String(encryptedBytes);
        }

        // Metoda do odszyfrowywania hasła przy użyciu pinu jako klucza
        private string DecryptPassword(string encryptedPassword, string pin)
        {
            // Przekształć pin na klucz szyfrowania
            byte[] pinBytes = Encoding.UTF8.GetBytes(pin);
            SHA256 sha256 = SHA256.Create();
            byte[] key = sha256.ComputeHash(pinBytes);

            // Odszyfruj hasło przy użyciu klucza
            byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);
            byte[] passwordBytes;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.Mode = CipherMode.CBC;

                int ivLength = BitConverter.ToInt32(encryptedBytes, 0);
                aes.IV = new byte[ivLength];
                Buffer.BlockCopy(encryptedBytes, sizeof(int), aes.IV, 0, ivLength);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(encryptedBytes, ivLength + sizeof(int), encryptedBytes.Length - ivLength - sizeof(int));
                        cs.FlushFinalBlock();
                    }

                    passwordBytes = ms.ToArray();
                }
            }

            // Zwróć odszyfrowane hasło jako string
            return Encoding.UTF8.GetString(passwordBytes);
        }
    }
}
