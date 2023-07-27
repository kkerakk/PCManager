namespace PCManager.Forms
{
    partial class Settings
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
            this.txtELogin = new System.Windows.Forms.TextBox();
            this.txtEPassword = new System.Windows.Forms.TextBox();
            this.txtEPin = new System.Windows.Forms.TextBox();
            this.txtDPin = new System.Windows.Forms.TextBox();
            this.txtDPassword = new System.Windows.Forms.TextBox();
            this.txtDLogin = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.rtxtELogin = new System.Windows.Forms.RichTextBox();
            this.rtxtEPassword = new System.Windows.Forms.RichTextBox();
            this.gbEncrypted = new System.Windows.Forms.GroupBox();
            this.gbDecrypted = new System.Windows.Forms.GroupBox();
            this.rtxtDLogin = new System.Windows.Forms.RichTextBox();
            this.rtxtDPassword = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbEncrypted.SuspendLayout();
            this.gbDecrypted.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtELogin
            // 
            this.txtELogin.Location = new System.Drawing.Point(26, 29);
            this.txtELogin.Name = "txtELogin";
            this.txtELogin.Size = new System.Drawing.Size(220, 20);
            this.txtELogin.TabIndex = 0;
            // 
            // txtEPassword
            // 
            this.txtEPassword.Location = new System.Drawing.Point(26, 64);
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.Size = new System.Drawing.Size(220, 20);
            this.txtEPassword.TabIndex = 1;
            // 
            // txtEPin
            // 
            this.txtEPin.Location = new System.Drawing.Point(26, 102);
            this.txtEPin.Name = "txtEPin";
            this.txtEPin.Size = new System.Drawing.Size(220, 20);
            this.txtEPin.TabIndex = 2;
            // 
            // txtDPin
            // 
            this.txtDPin.Location = new System.Drawing.Point(480, 102);
            this.txtDPin.Name = "txtDPin";
            this.txtDPin.Size = new System.Drawing.Size(220, 20);
            this.txtDPin.TabIndex = 7;
            // 
            // txtDPassword
            // 
            this.txtDPassword.Location = new System.Drawing.Point(480, 64);
            this.txtDPassword.Name = "txtDPassword";
            this.txtDPassword.Size = new System.Drawing.Size(220, 20);
            this.txtDPassword.TabIndex = 6;
            // 
            // txtDLogin
            // 
            this.txtDLogin.Location = new System.Drawing.Point(480, 29);
            this.txtDLogin.Name = "txtDLogin";
            this.txtDLogin.Size = new System.Drawing.Size(220, 20);
            this.txtDLogin.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(100, 170);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(556, 170);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rtxtELogin
            // 
            this.rtxtELogin.Location = new System.Drawing.Point(14, 19);
            this.rtxtELogin.Name = "rtxtELogin";
            this.rtxtELogin.Size = new System.Drawing.Size(674, 35);
            this.rtxtELogin.TabIndex = 10;
            this.rtxtELogin.Text = "";
            // 
            // rtxtEPassword
            // 
            this.rtxtEPassword.Location = new System.Drawing.Point(14, 60);
            this.rtxtEPassword.Name = "rtxtEPassword";
            this.rtxtEPassword.Size = new System.Drawing.Size(674, 35);
            this.rtxtEPassword.TabIndex = 11;
            this.rtxtEPassword.Text = "";
            // 
            // gbEncrypted
            // 
            this.gbEncrypted.Controls.Add(this.rtxtELogin);
            this.gbEncrypted.Controls.Add(this.rtxtEPassword);
            this.gbEncrypted.Location = new System.Drawing.Point(12, 199);
            this.gbEncrypted.Name = "gbEncrypted";
            this.gbEncrypted.Size = new System.Drawing.Size(700, 100);
            this.gbEncrypted.TabIndex = 12;
            this.gbEncrypted.TabStop = false;
            this.gbEncrypted.Text = "Encrpted Data";
            // 
            // gbDecrypted
            // 
            this.gbDecrypted.Controls.Add(this.rtxtDLogin);
            this.gbDecrypted.Controls.Add(this.rtxtDPassword);
            this.gbDecrypted.Location = new System.Drawing.Point(12, 305);
            this.gbDecrypted.Name = "gbDecrypted";
            this.gbDecrypted.Size = new System.Drawing.Size(700, 100);
            this.gbDecrypted.TabIndex = 13;
            this.gbDecrypted.TabStop = false;
            this.gbDecrypted.Text = "Decrypted Data";
            // 
            // rtxtDLogin
            // 
            this.rtxtDLogin.Location = new System.Drawing.Point(14, 19);
            this.rtxtDLogin.Name = "rtxtDLogin";
            this.rtxtDLogin.Size = new System.Drawing.Size(674, 35);
            this.rtxtDLogin.TabIndex = 10;
            this.rtxtDLogin.Text = "";
            // 
            // rtxtDPassword
            // 
            this.rtxtDPassword.Location = new System.Drawing.Point(14, 60);
            this.rtxtDPassword.Name = "rtxtDPassword";
            this.rtxtDPassword.Size = new System.Drawing.Size(674, 35);
            this.rtxtDPassword.TabIndex = 11;
            this.rtxtDPassword.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbDecrypted);
            this.Controls.Add(this.gbEncrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDPin);
            this.Controls.Add(this.txtDPassword);
            this.Controls.Add(this.txtDLogin);
            this.Controls.Add(this.txtEPin);
            this.Controls.Add(this.txtEPassword);
            this.Controls.Add(this.txtELogin);
            this.Name = "Settings";
            this.Text = "Settings";
            this.gbEncrypted.ResumeLayout(false);
            this.gbDecrypted.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtELogin;
        private System.Windows.Forms.TextBox txtEPassword;
        private System.Windows.Forms.TextBox txtEPin;
        private System.Windows.Forms.TextBox txtDPin;
        private System.Windows.Forms.TextBox txtDPassword;
        private System.Windows.Forms.TextBox txtDLogin;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox rtxtELogin;
        private System.Windows.Forms.RichTextBox rtxtEPassword;
        private System.Windows.Forms.GroupBox gbEncrypted;
        private System.Windows.Forms.GroupBox gbDecrypted;
        private System.Windows.Forms.RichTextBox rtxtDLogin;
        private System.Windows.Forms.RichTextBox rtxtDPassword;
        private System.Windows.Forms.Button btnClear;
    }
}