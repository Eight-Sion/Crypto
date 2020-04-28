namespace CryptTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Crypt256Button = new System.Windows.Forms.Button();
            this.BeforeText = new System.Windows.Forms.TextBox();
            this.AfterText = new System.Windows.Forms.TextBox();
            this.PublicKeyResultTextBox = new System.Windows.Forms.RichTextBox();
            this.PrivateKeyResultTextBox = new System.Windows.Forms.RichTextBox();
            this.SaltText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.henn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KeygenForRSAButton = new System.Windows.Forms.Button();
            this.CreateSignatureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultCreateSignatureTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrivateKeyForCreateSignatureTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MessageForCreateSignatureTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MessageForVerifyTextBox = new System.Windows.Forms.TextBox();
            this.RSAVerifyButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SignatureForVerifyTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PublicKeyForVerifyTextBox = new System.Windows.Forms.RichTextBox();
            this.VerifyResultLabel = new System.Windows.Forms.Label();
            this.RSADecryptButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PrivateKeyForDecryptRSATextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PublicKeyForEnCryptRSATextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BeforeSaltEnCryptRSATextBox = new System.Windows.Forms.TextBox();
            this.BeforeMessageEnCryptRSATextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BeforeMessageDecryptRSATextBox = new System.Windows.Forms.TextBox();
            this.EnCryptRSAButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ResultDecryptRSATextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ResultEncryptRSATextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Crypt256Button
            // 
            this.Crypt256Button.Location = new System.Drawing.Point(12, 62);
            this.Crypt256Button.Name = "Crypt256Button";
            this.Crypt256Button.Size = new System.Drawing.Size(227, 23);
            this.Crypt256Button.TabIndex = 0;
            this.Crypt256Button.Text = "SHA256";
            this.Crypt256Button.UseVisualStyleBackColor = true;
            this.Crypt256Button.Click += new System.EventHandler(this.Crypt256Button_Click);
            // 
            // BeforeText
            // 
            this.BeforeText.Location = new System.Drawing.Point(12, 27);
            this.BeforeText.Name = "BeforeText";
            this.BeforeText.Size = new System.Drawing.Size(113, 19);
            this.BeforeText.TabIndex = 1;
            // 
            // AfterText
            // 
            this.AfterText.Location = new System.Drawing.Point(12, 108);
            this.AfterText.Name = "AfterText";
            this.AfterText.Size = new System.Drawing.Size(227, 19);
            this.AfterText.TabIndex = 2;
            // 
            // PublicKeyResultTextBox
            // 
            this.PublicKeyResultTextBox.Location = new System.Drawing.Point(14, 225);
            this.PublicKeyResultTextBox.Name = "PublicKeyResultTextBox";
            this.PublicKeyResultTextBox.Size = new System.Drawing.Size(227, 90);
            this.PublicKeyResultTextBox.TabIndex = 3;
            this.PublicKeyResultTextBox.Text = "";
            // 
            // PrivateKeyResultTextBox
            // 
            this.PrivateKeyResultTextBox.Location = new System.Drawing.Point(14, 339);
            this.PrivateKeyResultTextBox.Name = "PrivateKeyResultTextBox";
            this.PrivateKeyResultTextBox.Size = new System.Drawing.Size(227, 104);
            this.PrivateKeyResultTextBox.TabIndex = 5;
            this.PrivateKeyResultTextBox.Text = "";
            // 
            // SaltText
            // 
            this.SaltText.Location = new System.Drawing.Point(126, 27);
            this.SaltText.Name = "SaltText";
            this.SaltText.Size = new System.Drawing.Size(113, 19);
            this.SaltText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "暗号化する文字列";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "ソルト";
            // 
            // henn
            // 
            this.henn.AutoSize = true;
            this.henn.Location = new System.Drawing.Point(12, 93);
            this.henn.Name = "henn";
            this.henn.Size = new System.Drawing.Size(65, 12);
            this.henn.TabIndex = 9;
            this.henn.Text = "暗号化結果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "公開鍵";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "秘密鍵";
            // 
            // KeygenForRSAButton
            // 
            this.KeygenForRSAButton.Location = new System.Drawing.Point(14, 179);
            this.KeygenForRSAButton.Name = "KeygenForRSAButton";
            this.KeygenForRSAButton.Size = new System.Drawing.Size(227, 23);
            this.KeygenForRSAButton.TabIndex = 11;
            this.KeygenForRSAButton.Text = "RSA鍵作成";
            this.KeygenForRSAButton.UseVisualStyleBackColor = true;
            this.KeygenForRSAButton.Click += new System.EventHandler(this.KeygenForRSAButton_Click);
            // 
            // CreateSignatureButton
            // 
            this.CreateSignatureButton.Location = new System.Drawing.Point(289, 182);
            this.CreateSignatureButton.Name = "CreateSignatureButton";
            this.CreateSignatureButton.Size = new System.Drawing.Size(227, 23);
            this.CreateSignatureButton.TabIndex = 16;
            this.CreateSignatureButton.Text = "署名作成";
            this.CreateSignatureButton.UseVisualStyleBackColor = true;
            this.CreateSignatureButton.Click += new System.EventHandler(this.CreateSignatureButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "署名";
            // 
            // ResultCreateSignatureTextBox
            // 
            this.ResultCreateSignatureTextBox.Location = new System.Drawing.Point(287, 236);
            this.ResultCreateSignatureTextBox.Name = "ResultCreateSignatureTextBox";
            this.ResultCreateSignatureTextBox.Size = new System.Drawing.Size(227, 104);
            this.ResultCreateSignatureTextBox.TabIndex = 14;
            this.ResultCreateSignatureTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "秘密鍵";
            // 
            // PrivateKeyForCreateSignatureTextBox
            // 
            this.PrivateKeyForCreateSignatureTextBox.Location = new System.Drawing.Point(287, 86);
            this.PrivateKeyForCreateSignatureTextBox.Name = "PrivateKeyForCreateSignatureTextBox";
            this.PrivateKeyForCreateSignatureTextBox.Size = new System.Drawing.Size(227, 90);
            this.PrivateKeyForCreateSignatureTextBox.TabIndex = 12;
            this.PrivateKeyForCreateSignatureTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "署名内容";
            // 
            // MessageForCreateSignatureTextBox
            // 
            this.MessageForCreateSignatureTextBox.Location = new System.Drawing.Point(285, 27);
            this.MessageForCreateSignatureTextBox.Name = "MessageForCreateSignatureTextBox";
            this.MessageForCreateSignatureTextBox.Size = new System.Drawing.Size(229, 19);
            this.MessageForCreateSignatureTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "署名内容";
            // 
            // MessageForVerifyTextBox
            // 
            this.MessageForVerifyTextBox.Location = new System.Drawing.Point(543, 27);
            this.MessageForVerifyTextBox.Name = "MessageForVerifyTextBox";
            this.MessageForVerifyTextBox.Size = new System.Drawing.Size(227, 19);
            this.MessageForVerifyTextBox.TabIndex = 24;
            // 
            // RSAVerifyButton
            // 
            this.RSAVerifyButton.Location = new System.Drawing.Point(543, 319);
            this.RSAVerifyButton.Name = "RSAVerifyButton";
            this.RSAVerifyButton.Size = new System.Drawing.Size(227, 23);
            this.RSAVerifyButton.TabIndex = 23;
            this.RSAVerifyButton.Text = "RSA認証";
            this.RSAVerifyButton.UseVisualStyleBackColor = true;
            this.RSAVerifyButton.Click += new System.EventHandler(this.RSAVerifyButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "署名";
            // 
            // SignatureForVerifyTextBox
            // 
            this.SignatureForVerifyTextBox.Location = new System.Drawing.Point(545, 205);
            this.SignatureForVerifyTextBox.Name = "SignatureForVerifyTextBox";
            this.SignatureForVerifyTextBox.Size = new System.Drawing.Size(227, 104);
            this.SignatureForVerifyTextBox.TabIndex = 21;
            this.SignatureForVerifyTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "公開鍵";
            // 
            // PublicKeyForVerifyTextBox
            // 
            this.PublicKeyForVerifyTextBox.Location = new System.Drawing.Point(545, 86);
            this.PublicKeyForVerifyTextBox.Name = "PublicKeyForVerifyTextBox";
            this.PublicKeyForVerifyTextBox.Size = new System.Drawing.Size(227, 90);
            this.PublicKeyForVerifyTextBox.TabIndex = 19;
            this.PublicKeyForVerifyTextBox.Text = "";
            // 
            // VerifyResultLabel
            // 
            this.VerifyResultLabel.AutoSize = true;
            this.VerifyResultLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VerifyResultLabel.Location = new System.Drawing.Point(543, 362);
            this.VerifyResultLabel.Name = "VerifyResultLabel";
            this.VerifyResultLabel.Size = new System.Drawing.Size(0, 24);
            this.VerifyResultLabel.TabIndex = 26;
            // 
            // RSADecryptButton
            // 
            this.RSADecryptButton.Location = new System.Drawing.Point(1068, 182);
            this.RSADecryptButton.Name = "RSADecryptButton";
            this.RSADecryptButton.Size = new System.Drawing.Size(227, 23);
            this.RSADecryptButton.TabIndex = 28;
            this.RSADecryptButton.Text = "RSA複合化";
            this.RSADecryptButton.UseVisualStyleBackColor = true;
            this.RSADecryptButton.Click += new System.EventHandler(this.RSADecryptButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1068, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "秘密鍵";
            // 
            // PrivateKeyForDecryptRSATextBox
            // 
            this.PrivateKeyForDecryptRSATextBox.Location = new System.Drawing.Point(1068, 86);
            this.PrivateKeyForDecryptRSATextBox.Name = "PrivateKeyForDecryptRSATextBox";
            this.PrivateKeyForDecryptRSATextBox.Size = new System.Drawing.Size(227, 90);
            this.PrivateKeyForDecryptRSATextBox.TabIndex = 30;
            this.PrivateKeyForDecryptRSATextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(803, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "公開鍵";
            // 
            // PublicKeyForEnCryptRSATextBox
            // 
            this.PublicKeyForEnCryptRSATextBox.Location = new System.Drawing.Point(803, 86);
            this.PublicKeyForEnCryptRSATextBox.Name = "PublicKeyForEnCryptRSATextBox";
            this.PublicKeyForEnCryptRSATextBox.Size = new System.Drawing.Size(227, 90);
            this.PublicKeyForEnCryptRSATextBox.TabIndex = 32;
            this.PublicKeyForEnCryptRSATextBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(915, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 12);
            this.label13.TabIndex = 37;
            this.label13.Text = "ソルト";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(803, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "暗号化する文字列";
            // 
            // BeforeSaltEnCryptRSATextBox
            // 
            this.BeforeSaltEnCryptRSATextBox.Location = new System.Drawing.Point(917, 27);
            this.BeforeSaltEnCryptRSATextBox.Name = "BeforeSaltEnCryptRSATextBox";
            this.BeforeSaltEnCryptRSATextBox.Size = new System.Drawing.Size(113, 19);
            this.BeforeSaltEnCryptRSATextBox.TabIndex = 35;
            // 
            // BeforeMessageEnCryptRSATextBox
            // 
            this.BeforeMessageEnCryptRSATextBox.Location = new System.Drawing.Point(803, 27);
            this.BeforeMessageEnCryptRSATextBox.Name = "BeforeMessageEnCryptRSATextBox";
            this.BeforeMessageEnCryptRSATextBox.Size = new System.Drawing.Size(113, 19);
            this.BeforeMessageEnCryptRSATextBox.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1068, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "暗号文字列";
            // 
            // BeforeMessageDecryptRSATextBox
            // 
            this.BeforeMessageDecryptRSATextBox.Location = new System.Drawing.Point(1068, 27);
            this.BeforeMessageDecryptRSATextBox.Name = "BeforeMessageDecryptRSATextBox";
            this.BeforeMessageDecryptRSATextBox.Size = new System.Drawing.Size(227, 19);
            this.BeforeMessageDecryptRSATextBox.TabIndex = 38;
            // 
            // EnCryptRSAButton
            // 
            this.EnCryptRSAButton.Location = new System.Drawing.Point(803, 182);
            this.EnCryptRSAButton.Name = "EnCryptRSAButton";
            this.EnCryptRSAButton.Size = new System.Drawing.Size(227, 23);
            this.EnCryptRSAButton.TabIndex = 40;
            this.EnCryptRSAButton.Text = "RSA暗号化";
            this.EnCryptRSAButton.UseVisualStyleBackColor = true;
            this.EnCryptRSAButton.Click += new System.EventHandler(this.EnCryptRSAButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1070, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 42;
            this.label16.Text = "複合結果";
            // 
            // ResultDecryptRSATextBox
            // 
            this.ResultDecryptRSATextBox.Location = new System.Drawing.Point(1070, 236);
            this.ResultDecryptRSATextBox.Name = "ResultDecryptRSATextBox";
            this.ResultDecryptRSATextBox.Size = new System.Drawing.Size(225, 19);
            this.ResultDecryptRSATextBox.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(805, 218);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 44;
            this.label17.Text = "暗号文字列";
            // 
            // ResultEncryptRSATextBox
            // 
            this.ResultEncryptRSATextBox.Location = new System.Drawing.Point(805, 236);
            this.ResultEncryptRSATextBox.Name = "ResultEncryptRSATextBox";
            this.ResultEncryptRSATextBox.Size = new System.Drawing.Size(225, 19);
            this.ResultEncryptRSATextBox.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ResultEncryptRSATextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ResultDecryptRSATextBox);
            this.Controls.Add(this.EnCryptRSAButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BeforeMessageDecryptRSATextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BeforeSaltEnCryptRSATextBox);
            this.Controls.Add(this.BeforeMessageEnCryptRSATextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PublicKeyForEnCryptRSATextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PrivateKeyForDecryptRSATextBox);
            this.Controls.Add(this.RSADecryptButton);
            this.Controls.Add(this.VerifyResultLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MessageForVerifyTextBox);
            this.Controls.Add(this.RSAVerifyButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SignatureForVerifyTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PublicKeyForVerifyTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MessageForCreateSignatureTextBox);
            this.Controls.Add(this.CreateSignatureButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultCreateSignatureTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrivateKeyForCreateSignatureTextBox);
            this.Controls.Add(this.KeygenForRSAButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.henn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaltText);
            this.Controls.Add(this.PrivateKeyResultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PublicKeyResultTextBox);
            this.Controls.Add(this.AfterText);
            this.Controls.Add(this.BeforeText);
            this.Controls.Add(this.Crypt256Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Crypt256Button;
        private System.Windows.Forms.TextBox BeforeText;
        private System.Windows.Forms.TextBox AfterText;
        private System.Windows.Forms.RichTextBox PublicKeyResultTextBox;
        private System.Windows.Forms.RichTextBox PrivateKeyResultTextBox;
        private System.Windows.Forms.TextBox SaltText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label henn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KeygenForRSAButton;
        private System.Windows.Forms.Button CreateSignatureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ResultCreateSignatureTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox PrivateKeyForCreateSignatureTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MessageForCreateSignatureTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MessageForVerifyTextBox;
        private System.Windows.Forms.Button RSAVerifyButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox SignatureForVerifyTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox PublicKeyForVerifyTextBox;
        private System.Windows.Forms.Label VerifyResultLabel;
        private System.Windows.Forms.Button RSADecryptButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox PrivateKeyForDecryptRSATextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox PublicKeyForEnCryptRSATextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BeforeSaltEnCryptRSATextBox;
        private System.Windows.Forms.TextBox BeforeMessageEnCryptRSATextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BeforeMessageDecryptRSATextBox;
        private System.Windows.Forms.Button EnCryptRSAButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ResultDecryptRSATextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ResultEncryptRSATextBox;
    }
}

