namespace PCManager.Forms
{
    partial class Status
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
            this.txtCheckServiceStatus = new System.Windows.Forms.TextBox();
            this.lblCheckServiceStatus = new System.Windows.Forms.Label();
            this.lblAddressIP = new System.Windows.Forms.Label();
            this.txtAddressIP = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblProcessorArchitecture = new System.Windows.Forms.Label();
            this.lblWindowsVersion = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCheckServiceStatus
            // 
            this.txtCheckServiceStatus.Location = new System.Drawing.Point(118, 34);
            this.txtCheckServiceStatus.Name = "txtCheckServiceStatus";
            this.txtCheckServiceStatus.ReadOnly = true;
            this.txtCheckServiceStatus.Size = new System.Drawing.Size(100, 20);
            this.txtCheckServiceStatus.TabIndex = 0;
            // 
            // lblCheckServiceStatus
            // 
            this.lblCheckServiceStatus.AutoSize = true;
            this.lblCheckServiceStatus.Location = new System.Drawing.Point(19, 37);
            this.lblCheckServiceStatus.Name = "lblCheckServiceStatus";
            this.lblCheckServiceStatus.Size = new System.Drawing.Size(83, 13);
            this.lblCheckServiceStatus.TabIndex = 1;
            this.lblCheckServiceStatus.Text = "Uwierzytelnianie";
            // 
            // lblAddressIP
            // 
            this.lblAddressIP.AutoSize = true;
            this.lblAddressIP.Location = new System.Drawing.Point(19, 62);
            this.lblAddressIP.Name = "lblAddressIP";
            this.lblAddressIP.Size = new System.Drawing.Size(47, 13);
            this.lblAddressIP.TabIndex = 3;
            this.lblAddressIP.Text = "Adres IP";
            // 
            // txtAddressIP
            // 
            this.txtAddressIP.Location = new System.Drawing.Point(118, 59);
            this.txtAddressIP.Name = "txtAddressIP";
            this.txtAddressIP.ReadOnly = true;
            this.txtAddressIP.Size = new System.Drawing.Size(100, 20);
            this.txtAddressIP.TabIndex = 2;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(19, 88);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(93, 13);
            this.lblHostname.TabIndex = 5;
            this.lblHostname.Text = "Nazwa komputera";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(118, 85);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(100, 20);
            this.txtHostname.TabIndex = 4;
            // 
            // lblProcessorArchitecture
            // 
            this.lblProcessorArchitecture.AutoSize = true;
            this.lblProcessorArchitecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProcessorArchitecture.Location = new System.Drawing.Point(19, 170);
            this.lblProcessorArchitecture.Name = "lblProcessorArchitecture";
            this.lblProcessorArchitecture.Size = new System.Drawing.Size(111, 13);
            this.lblProcessorArchitecture.TabIndex = 6;
            this.lblProcessorArchitecture.Text = "ProcessorArchitecture";
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWindowsVersion.Location = new System.Drawing.Point(19, 144);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(89, 13);
            this.lblWindowsVersion.TabIndex = 7;
            this.lblWindowsVersion.Text = "Windows Version";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProcessor.Location = new System.Drawing.Point(19, 194);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(54, 13);
            this.lblProcessor.TabIndex = 8;
            this.lblProcessor.Text = "Processor";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblWindowsVersion);
            this.Controls.Add(this.lblProcessorArchitecture);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblAddressIP);
            this.Controls.Add(this.txtAddressIP);
            this.Controls.Add(this.lblCheckServiceStatus);
            this.Controls.Add(this.txtCheckServiceStatus);
            this.Name = "Status";
            this.Text = "Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCheckServiceStatus;
        private System.Windows.Forms.Label lblCheckServiceStatus;
        private System.Windows.Forms.Label lblAddressIP;
        private System.Windows.Forms.TextBox txtAddressIP;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblProcessorArchitecture;
        private System.Windows.Forms.Label lblWindowsVersion;
        private System.Windows.Forms.Label lblProcessor;
    }
}