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
            this.lblPasswordExpired = new System.Windows.Forms.Label();
            this.txtPasswordExpiration = new System.Windows.Forms.TextBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblRemoteAssistance = new System.Windows.Forms.Label();
            this.txtRemoteAssistance = new System.Windows.Forms.TextBox();
            this.lblNetworkLevelAuth = new System.Windows.Forms.Label();
            this.txtNetworkLevelAuth = new System.Windows.Forms.TextBox();
            this.lblRemoteDesktop = new System.Windows.Forms.Label();
            this.txtRemoteDesktop = new System.Windows.Forms.TextBox();
            this.grbRemote = new System.Windows.Forms.GroupBox();
            this.grbServices = new System.Windows.Forms.GroupBox();
            this.grbDeviceSpecification = new System.Windows.Forms.GroupBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.grbSystemInfo = new System.Windows.Forms.GroupBox();
            this.lblSystemActivated = new System.Windows.Forms.Label();
            this.txtSystemActivated = new System.Windows.Forms.TextBox();
            this.grbSystem = new System.Windows.Forms.GroupBox();
            this.grbAccounts = new System.Windows.Forms.GroupBox();
            this.txtIsChangePassEnabled = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbRemote.SuspendLayout();
            this.grbServices.SuspendLayout();
            this.grbDeviceSpecification.SuspendLayout();
            this.grbSystemInfo.SuspendLayout();
            this.grbSystem.SuspendLayout();
            this.grbAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCheckServiceStatus
            // 
            this.txtCheckServiceStatus.Location = new System.Drawing.Point(179, 20);
            this.txtCheckServiceStatus.Name = "txtCheckServiceStatus";
            this.txtCheckServiceStatus.ReadOnly = true;
            this.txtCheckServiceStatus.Size = new System.Drawing.Size(100, 20);
            this.txtCheckServiceStatus.TabIndex = 0;
            // 
            // lblCheckServiceStatus
            // 
            this.lblCheckServiceStatus.AutoSize = true;
            this.lblCheckServiceStatus.Location = new System.Drawing.Point(6, 23);
            this.lblCheckServiceStatus.Name = "lblCheckServiceStatus";
            this.lblCheckServiceStatus.Size = new System.Drawing.Size(83, 13);
            this.lblCheckServiceStatus.TabIndex = 1;
            this.lblCheckServiceStatus.Text = "Uwierzytelnianie";
            // 
            // lblAddressIP
            // 
            this.lblAddressIP.AutoSize = true;
            this.lblAddressIP.Location = new System.Drawing.Point(6, 26);
            this.lblAddressIP.Name = "lblAddressIP";
            this.lblAddressIP.Size = new System.Drawing.Size(47, 13);
            this.lblAddressIP.TabIndex = 3;
            this.lblAddressIP.Text = "Adres IP";
            // 
            // txtAddressIP
            // 
            this.txtAddressIP.Location = new System.Drawing.Point(179, 23);
            this.txtAddressIP.Name = "txtAddressIP";
            this.txtAddressIP.ReadOnly = true;
            this.txtAddressIP.Size = new System.Drawing.Size(100, 20);
            this.txtAddressIP.TabIndex = 2;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(6, 52);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(93, 13);
            this.lblHostname.TabIndex = 5;
            this.lblHostname.Text = "Nazwa komputera";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(179, 49);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Size = new System.Drawing.Size(100, 20);
            this.txtHostname.TabIndex = 4;
            // 
            // lblProcessorArchitecture
            // 
            this.lblProcessorArchitecture.AutoSize = true;
            this.lblProcessorArchitecture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProcessorArchitecture.Location = new System.Drawing.Point(6, 48);
            this.lblProcessorArchitecture.Name = "lblProcessorArchitecture";
            this.lblProcessorArchitecture.Size = new System.Drawing.Size(111, 13);
            this.lblProcessorArchitecture.TabIndex = 6;
            this.lblProcessorArchitecture.Text = "ProcessorArchitecture";
            // 
            // lblWindowsVersion
            // 
            this.lblWindowsVersion.AutoSize = true;
            this.lblWindowsVersion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWindowsVersion.Location = new System.Drawing.Point(14, 22);
            this.lblWindowsVersion.Name = "lblWindowsVersion";
            this.lblWindowsVersion.Size = new System.Drawing.Size(130, 13);
            this.lblWindowsVersion.TabIndex = 7;
            this.lblWindowsVersion.Text = "Wersja Systemu Windows";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProcessor.Location = new System.Drawing.Point(6, 25);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(54, 13);
            this.lblProcessor.TabIndex = 8;
            this.lblProcessor.Text = "Processor";
            // 
            // lblPasswordExpired
            // 
            this.lblPasswordExpired.AutoSize = true;
            this.lblPasswordExpired.Location = new System.Drawing.Point(6, 78);
            this.lblPasswordExpired.Name = "lblPasswordExpired";
            this.lblPasswordExpired.Size = new System.Drawing.Size(75, 13);
            this.lblPasswordExpired.TabIndex = 11;
            this.lblPasswordExpired.Text = "Hasło wygasa";
            // 
            // txtPasswordExpiration
            // 
            this.txtPasswordExpiration.Location = new System.Drawing.Point(179, 75);
            this.txtPasswordExpiration.Name = "txtPasswordExpiration";
            this.txtPasswordExpiration.ReadOnly = true;
            this.txtPasswordExpiration.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordExpiration.TabIndex = 10;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMemory.Location = new System.Drawing.Point(6, 71);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(44, 13);
            this.lblMemory.TabIndex = 12;
            this.lblMemory.Text = "Memory";
            // 
            // lblRemoteAssistance
            // 
            this.lblRemoteAssistance.AutoSize = true;
            this.lblRemoteAssistance.Location = new System.Drawing.Point(6, 22);
            this.lblRemoteAssistance.Name = "lblRemoteAssistance";
            this.lblRemoteAssistance.Size = new System.Drawing.Size(76, 13);
            this.lblRemoteAssistance.TabIndex = 14;
            this.lblRemoteAssistance.Text = "Pomoc Zdalna";
            // 
            // txtRemoteAssistance
            // 
            this.txtRemoteAssistance.Location = new System.Drawing.Point(179, 19);
            this.txtRemoteAssistance.Name = "txtRemoteAssistance";
            this.txtRemoteAssistance.ReadOnly = true;
            this.txtRemoteAssistance.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteAssistance.TabIndex = 13;
            // 
            // lblNetworkLevelAuth
            // 
            this.lblNetworkLevelAuth.AutoSize = true;
            this.lblNetworkLevelAuth.Location = new System.Drawing.Point(6, 74);
            this.lblNetworkLevelAuth.Name = "lblNetworkLevelAuth";
            this.lblNetworkLevelAuth.Size = new System.Drawing.Size(107, 13);
            this.lblNetworkLevelAuth.TabIndex = 16;
            this.lblNetworkLevelAuth.Text = "Uwierzytelnianie sieci";
            // 
            // txtNetworkLevelAuth
            // 
            this.txtNetworkLevelAuth.Location = new System.Drawing.Point(179, 71);
            this.txtNetworkLevelAuth.Name = "txtNetworkLevelAuth";
            this.txtNetworkLevelAuth.ReadOnly = true;
            this.txtNetworkLevelAuth.Size = new System.Drawing.Size(100, 20);
            this.txtNetworkLevelAuth.TabIndex = 15;
            // 
            // lblRemoteDesktop
            // 
            this.lblRemoteDesktop.AutoSize = true;
            this.lblRemoteDesktop.Location = new System.Drawing.Point(6, 48);
            this.lblRemoteDesktop.Name = "lblRemoteDesktop";
            this.lblRemoteDesktop.Size = new System.Drawing.Size(66, 13);
            this.lblRemoteDesktop.TabIndex = 18;
            this.lblRemoteDesktop.Text = "Pulpit zdalny";
            // 
            // txtRemoteDesktop
            // 
            this.txtRemoteDesktop.Location = new System.Drawing.Point(179, 45);
            this.txtRemoteDesktop.Name = "txtRemoteDesktop";
            this.txtRemoteDesktop.ReadOnly = true;
            this.txtRemoteDesktop.Size = new System.Drawing.Size(100, 20);
            this.txtRemoteDesktop.TabIndex = 17;
            // 
            // grbRemote
            // 
            this.grbRemote.Controls.Add(this.txtRemoteAssistance);
            this.grbRemote.Controls.Add(this.lblRemoteDesktop);
            this.grbRemote.Controls.Add(this.lblRemoteAssistance);
            this.grbRemote.Controls.Add(this.txtRemoteDesktop);
            this.grbRemote.Controls.Add(this.txtNetworkLevelAuth);
            this.grbRemote.Controls.Add(this.lblNetworkLevelAuth);
            this.grbRemote.Location = new System.Drawing.Point(12, 12);
            this.grbRemote.Name = "grbRemote";
            this.grbRemote.Size = new System.Drawing.Size(316, 102);
            this.grbRemote.TabIndex = 19;
            this.grbRemote.TabStop = false;
            this.grbRemote.Text = "Zdalny";
            // 
            // grbServices
            // 
            this.grbServices.Controls.Add(this.txtCheckServiceStatus);
            this.grbServices.Controls.Add(this.lblCheckServiceStatus);
            this.grbServices.Location = new System.Drawing.Point(12, 120);
            this.grbServices.Name = "grbServices";
            this.grbServices.Size = new System.Drawing.Size(316, 59);
            this.grbServices.TabIndex = 20;
            this.grbServices.TabStop = false;
            this.grbServices.Text = "Usługi";
            // 
            // grbDeviceSpecification
            // 
            this.grbDeviceSpecification.Controls.Add(this.lblProcessorArchitecture);
            this.grbDeviceSpecification.Controls.Add(this.lblProcessor);
            this.grbDeviceSpecification.Controls.Add(this.lblMemory);
            this.grbDeviceSpecification.Location = new System.Drawing.Point(12, 185);
            this.grbDeviceSpecification.Name = "grbDeviceSpecification";
            this.grbDeviceSpecification.Size = new System.Drawing.Size(316, 104);
            this.grbDeviceSpecification.TabIndex = 21;
            this.grbDeviceSpecification.TabStop = false;
            this.grbDeviceSpecification.Text = "Specyfikacja urządzenia";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(6, 104);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(47, 13);
            this.lblDomain.TabIndex = 23;
            this.lblDomain.Text = "Domena";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(179, 101);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(100, 20);
            this.txtDomain.TabIndex = 22;
            // 
            // grbSystemInfo
            // 
            this.grbSystemInfo.Controls.Add(this.lblAddressIP);
            this.grbSystemInfo.Controls.Add(this.lblDomain);
            this.grbSystemInfo.Controls.Add(this.txtAddressIP);
            this.grbSystemInfo.Controls.Add(this.txtDomain);
            this.grbSystemInfo.Controls.Add(this.txtHostname);
            this.grbSystemInfo.Controls.Add(this.lblHostname);
            this.grbSystemInfo.Controls.Add(this.txtPasswordExpiration);
            this.grbSystemInfo.Controls.Add(this.lblPasswordExpired);
            this.grbSystemInfo.Location = new System.Drawing.Point(12, 295);
            this.grbSystemInfo.Name = "grbSystemInfo";
            this.grbSystemInfo.Size = new System.Drawing.Size(316, 132);
            this.grbSystemInfo.TabIndex = 24;
            this.grbSystemInfo.TabStop = false;
            this.grbSystemInfo.Text = "Informacje o komputerze";
            // 
            // lblSystemActivated
            // 
            this.lblSystemActivated.AutoSize = true;
            this.lblSystemActivated.Location = new System.Drawing.Point(14, 45);
            this.lblSystemActivated.Name = "lblSystemActivated";
            this.lblSystemActivated.Size = new System.Drawing.Size(103, 13);
            this.lblSystemActivated.TabIndex = 25;
            this.lblSystemActivated.Text = "System aktywowany";
            // 
            // txtSystemActivated
            // 
            this.txtSystemActivated.Location = new System.Drawing.Point(187, 42);
            this.txtSystemActivated.Name = "txtSystemActivated";
            this.txtSystemActivated.ReadOnly = true;
            this.txtSystemActivated.Size = new System.Drawing.Size(100, 20);
            this.txtSystemActivated.TabIndex = 24;
            // 
            // grbSystem
            // 
            this.grbSystem.Controls.Add(this.lblWindowsVersion);
            this.grbSystem.Controls.Add(this.lblSystemActivated);
            this.grbSystem.Controls.Add(this.txtSystemActivated);
            this.grbSystem.Location = new System.Drawing.Point(344, 12);
            this.grbSystem.Name = "grbSystem";
            this.grbSystem.Size = new System.Drawing.Size(324, 102);
            this.grbSystem.TabIndex = 25;
            this.grbSystem.TabStop = false;
            this.grbSystem.Text = "System";
            // 
            // grbAccounts
            // 
            this.grbAccounts.Controls.Add(this.txtIsChangePassEnabled);
            this.grbAccounts.Controls.Add(this.label4);
            this.grbAccounts.Controls.Add(this.label3);
            this.grbAccounts.Controls.Add(this.label2);
            this.grbAccounts.Controls.Add(this.label1);
            this.grbAccounts.Location = new System.Drawing.Point(344, 120);
            this.grbAccounts.Name = "grbAccounts";
            this.grbAccounts.Size = new System.Drawing.Size(324, 169);
            this.grbAccounts.TabIndex = 26;
            this.grbAccounts.TabStop = false;
            this.grbAccounts.Text = "Konta użytkowników";
            // 
            // txtIsChangePassEnabled
            // 
            this.txtIsChangePassEnabled.Location = new System.Drawing.Point(140, 60);
            this.txtIsChangePassEnabled.Name = "txtIsChangePassEnabled";
            this.txtIsChangePassEnabled.ReadOnly = true;
            this.txtIsChangePassEnabled.Size = new System.Drawing.Size(163, 20);
            this.txtIsChangePassEnabled.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wspol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wykladowca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administrator";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(680, 496);
            this.Controls.Add(this.grbAccounts);
            this.Controls.Add(this.grbSystem);
            this.Controls.Add(this.grbSystemInfo);
            this.Controls.Add(this.grbDeviceSpecification);
            this.Controls.Add(this.grbServices);
            this.Controls.Add(this.grbRemote);
            this.Name = "Status";
            this.Text = "Status";
            this.grbRemote.ResumeLayout(false);
            this.grbRemote.PerformLayout();
            this.grbServices.ResumeLayout(false);
            this.grbServices.PerformLayout();
            this.grbDeviceSpecification.ResumeLayout(false);
            this.grbDeviceSpecification.PerformLayout();
            this.grbSystemInfo.ResumeLayout(false);
            this.grbSystemInfo.PerformLayout();
            this.grbSystem.ResumeLayout(false);
            this.grbSystem.PerformLayout();
            this.grbAccounts.ResumeLayout(false);
            this.grbAccounts.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblPasswordExpired;
        private System.Windows.Forms.TextBox txtPasswordExpiration;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblRemoteAssistance;
        private System.Windows.Forms.TextBox txtRemoteAssistance;
        private System.Windows.Forms.Label lblNetworkLevelAuth;
        private System.Windows.Forms.TextBox txtNetworkLevelAuth;
        private System.Windows.Forms.Label lblRemoteDesktop;
        private System.Windows.Forms.TextBox txtRemoteDesktop;
        private System.Windows.Forms.GroupBox grbRemote;
        private System.Windows.Forms.GroupBox grbServices;
        private System.Windows.Forms.GroupBox grbDeviceSpecification;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.GroupBox grbSystemInfo;
        private System.Windows.Forms.Label lblSystemActivated;
        private System.Windows.Forms.TextBox txtSystemActivated;
        private System.Windows.Forms.GroupBox grbSystem;
        private System.Windows.Forms.GroupBox grbAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsChangePassEnabled;
    }
}