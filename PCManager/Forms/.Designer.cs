namespace PCManager.Forms
{
    partial class DataEncryption
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.rtxtEncrypted = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtPassword = new System.Windows.Forms.RichTextBox();
            this.rtxtPin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(58, 94);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(139, 94);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rtxtEncrypted
            // 
            this.rtxtEncrypted.Location = new System.Drawing.Point(58, 123);
            this.rtxtEncrypted.Name = "rtxtEncrypted";
            this.rtxtEncrypted.Size = new System.Drawing.Size(539, 35);
            this.rtxtEncrypted.TabIndex = 10;
            this.rtxtEncrypted.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(58, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rtxtPassword
            // 
            this.rtxtPassword.Location = new System.Drawing.Point(58, 12);
            this.rtxtPassword.Name = "rtxtPassword";
            this.rtxtPassword.Size = new System.Drawing.Size(539, 35);
            this.rtxtPassword.TabIndex = 15;
            this.rtxtPassword.Text = "";
            // 
            // rtxtPin
            // 
            this.rtxtPin.Location = new System.Drawing.Point(58, 53);
            this.rtxtPin.Name = "rtxtPin";
            this.rtxtPin.Size = new System.Drawing.Size(539, 35);
            this.rtxtPin.TabIndex = 16;
            this.rtxtPin.Text = "";
            // 
            // DataEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtPin);
            this.Controls.Add(this.rtxtPassword);
            this.Controls.Add(this.rtxtEncrypted);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "DataEncryption";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox rtxtEncrypted;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtPassword;
        private System.Windows.Forms.RichTextBox rtxtPin;
    }
}