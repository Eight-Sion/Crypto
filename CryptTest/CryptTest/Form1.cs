using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CryptTest.Service;

namespace CryptTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Crypt256Button_Click(object sender, EventArgs e)
        {
            AfterText.Text = CryptoService.CryptSHA256(BeforeText.Text);
        }

        private void KeygenForRSAButton_Click(object sender, EventArgs e)
        {
            (PublicKeyResultTextBox.Text, PrivateKeyResultTextBox.Text) = CryptoService.CreateKeys();
        }

        private void CreateSignatureButton_Click(object sender, EventArgs e)
        {
            ResultCreateSignatureTextBox.Text = CryptoService
                .CreateDigitalSignature(
                MessageForCreateSignatureTextBox.Text, 
                PrivateKeyForCreateSignatureTextBox.Text);
        }

        private void RSAVerifyButton_Click(object sender, EventArgs e)
        {
            VerifyResultLabel.Text = CryptoService.VerifyDigitalSignature(
                MessageForVerifyTextBox.Text, 
                SignatureForVerifyTextBox.Text, 
                PublicKeyForVerifyTextBox.Text) ? "認証成功" : "認証失敗";
        }


        private void EnCryptRSAButton_Click(object sender, EventArgs e)
        {
            ResultEncryptRSATextBox.Text = CryptoService.Encrypt(
                BeforeMessageEnCryptRSATextBox.Text + BeforeSaltEnCryptRSATextBox.Text, 
                PublicKeyForEnCryptRSATextBox.Text);
        }

        private void RSADecryptButton_Click(object sender, EventArgs e)
        {
            ResultDecryptRSATextBox.Text = CryptoService.Decrypt(
                BeforeMessageDecryptRSATextBox.Text, 
                PrivateKeyForDecryptRSATextBox.Text);
            if (ResultDecryptRSATextBox.Text == "") MessageBox.Show("複合化に失敗しました。");
        }
    }
}
