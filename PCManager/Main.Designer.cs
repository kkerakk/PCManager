namespace PCManager
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.btnWebsites = new System.Windows.Forms.Button();
            this.btnShutdownComputer = new System.Windows.Forms.Button();
            this.btnManagePC = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelBottomMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelLeftMenu.SuspendLayout();
            this.panelBottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.panelLeftMenu.Controls.Add(this.btnWebsites);
            this.panelLeftMenu.Controls.Add(this.btnShutdownComputer);
            this.panelLeftMenu.Controls.Add(this.btnManagePC);
            this.panelLeftMenu.Controls.Add(this.btnStatus);
            this.panelLeftMenu.Controls.Add(this.panelLogo);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(150, 491);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // btnWebsites
            // 
            this.btnWebsites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWebsites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWebsites.FlatAppearance.BorderSize = 0;
            this.btnWebsites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWebsites.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWebsites.Image = ((System.Drawing.Image)(resources.GetObject("btnWebsites.Image")));
            this.btnWebsites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsites.Location = new System.Drawing.Point(0, 170);
            this.btnWebsites.Name = "btnWebsites";
            this.btnWebsites.Size = new System.Drawing.Size(150, 40);
            this.btnWebsites.TabIndex = 4;
            this.btnWebsites.Text = "  Websites";
            this.btnWebsites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWebsites.UseVisualStyleBackColor = true;
            this.btnWebsites.Click += new System.EventHandler(this.btnWebsites_Click);
            // 
            // btnShutdownComputer
            // 
            this.btnShutdownComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShutdownComputer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdownComputer.FlatAppearance.BorderSize = 0;
            this.btnShutdownComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdownComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdownComputer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShutdownComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnShutdownComputer.Image")));
            this.btnShutdownComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdownComputer.Location = new System.Drawing.Point(0, 130);
            this.btnShutdownComputer.Name = "btnShutdownComputer";
            this.btnShutdownComputer.Size = new System.Drawing.Size(150, 40);
            this.btnShutdownComputer.TabIndex = 3;
            this.btnShutdownComputer.Text = "  Shutdown PC";
            this.btnShutdownComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdownComputer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShutdownComputer.UseVisualStyleBackColor = true;
            this.btnShutdownComputer.Click += new System.EventHandler(this.btnShutdownComputer_Click);
            // 
            // btnManagePC
            // 
            this.btnManagePC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManagePC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePC.FlatAppearance.BorderSize = 0;
            this.btnManagePC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnManagePC.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManagePC.Image = ((System.Drawing.Image)(resources.GetObject("btnManagePC.Image")));
            this.btnManagePC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePC.Location = new System.Drawing.Point(0, 90);
            this.btnManagePC.Name = "btnManagePC";
            this.btnManagePC.Size = new System.Drawing.Size(150, 40);
            this.btnManagePC.TabIndex = 2;
            this.btnManagePC.Text = "  Manage PC";
            this.btnManagePC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagePC.UseVisualStyleBackColor = true;
            this.btnManagePC.Click += new System.EventHandler(this.btnManagePC_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 50);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(150, 40);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "  Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 50);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(150, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(714, 460);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelBottomMenu
            // 
            this.panelBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(8)))), ((int)(((byte)(69)))));
            this.panelBottomMenu.Controls.Add(this.btnSettings);
            this.panelBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomMenu.Location = new System.Drawing.Point(150, 460);
            this.panelBottomMenu.Name = "panelBottomMenu";
            this.panelBottomMenu.Size = new System.Drawing.Size(714, 31);
            this.panelBottomMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.Location = new System.Drawing.Point(639, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 31);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBottomMenu);
            this.Controls.Add(this.panelLeftMenu);
            this.MinimumSize = new System.Drawing.Size(880, 512);
            this.Name = "Main";
            this.Text = "PCManager";
            this.panelLeftMenu.ResumeLayout(false);
            this.panelBottomMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelBottomMenu;
        private System.Windows.Forms.Button btnManagePC;
        private System.Windows.Forms.Button btnShutdownComputer;
        private System.Windows.Forms.Button btnWebsites;
        private System.Windows.Forms.Button btnSettings;
    }
}

