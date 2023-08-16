using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace SecurePNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imageFilePathLabel1.Text = filePath;
                string outputFilePath = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath) + ".spng";
                imageFilePathLabel4.Text = outputFilePath;

                string secretKey = keyTextBox1.Text;

                try
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashedKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(secretKey));
                        byte[] aesKey = new byte[16];
                        Array.Copy(hashedKey, aesKey, 16);

                        byte[] encryptedBytes = EncryptFileAES(filePath, aesKey);

                        using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create))
                        {
                            byte[] spngHeader = Encoding.UTF8.GetBytes("SPNG");
                            outputFileStream.Write(spngHeader, 0, spngHeader.Length);
                            outputFileStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                        }

                        pictureBox1.Image = System.Drawing.Image.FromFile(filePath);

                        MessageBox.Show("File encrypted and saved as:\n" + outputFilePath, "Encryption Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encrypted PNG Files (*.spng)|*.spng";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imageFilePathLabel2.Text = filePath;

                string secretKey = keyTextBox2.Text;

                try
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        byte[] header = new byte[4];
                        fs.Read(header, 0, header.Length);
                        string headerStr = Encoding.UTF8.GetString(header);

                        if (headerStr == "SPNG")
                        {
                            byte[] encryptedBytes = new byte[fs.Length - 4];
                            fs.Read(encryptedBytes, 0, encryptedBytes.Length);

                            using (SHA256 sha256 = SHA256.Create())
                            {
                                byte[] hashedKey = sha256.ComputeHash(Encoding.UTF8.GetBytes(secretKey));
                                byte[] aesKey = new byte[16];
                                Array.Copy(hashedKey, aesKey, 16);

                                try
                                {
                                    byte[] decryptedBytes = DecryptBytesAES(encryptedBytes, aesKey);

                                    using (MemoryStream ms = new MemoryStream(decryptedBytes))
                                    {
                                        pictureBox2.Image = Image.FromStream(ms);

                                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                                        saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                        {
                                            string outputFilePath = saveFileDialog.FileName;
                                            imageFilePathLabel3.Text = outputFilePath;
                                            pictureBox2.Image.Save(outputFilePath, ImageFormat.Png);
                                            // MessageBox.Show("File decrypted and saved as:\n" + outputFilePath, "Decryption and Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                                catch (CryptographicException)
                                {
                                    MessageBox.Show("Invalid key. Decryption failed.", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid SPNG file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] EncryptFileAES(string filePath, byte[] key)
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (FileStream fsInput = new FileStream(filePath, FileMode.Open))
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Write the IV as part of the encrypted data
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        fsInput.CopyTo(csEncrypt);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        private byte[] DecryptBytesAES(byte[] encryptedBytes, byte[] key)
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                // Read the IV from the beginning of the encrypted data
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(encryptedBytes, iv, iv.Length);
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream())
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write))
                    {
                        csDecrypt.Write(encryptedBytes, iv.Length, encryptedBytes.Length - iv.Length);
                    }
                    return msDecrypt.ToArray();
                }
            }
        }
    }
}