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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnFileRename = new System.Windows.Forms.Button();
            this.btnAddressBook = new System.Windows.Forms.Button();
            this.btnDataEncryption = new System.Windows.Forms.Button();
            this.btnXmlReader = new System.Windows.Forms.Button();
            this.btnSyllabus = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnWebsites = new System.Windows.Forms.Button();
            this.btnShutdownComputer = new System.Windows.Forms.Button();
            this.btnManagePC = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelBottomMenu = new System.Windows.Forms.Panel();
            this.btnRDP = new System.Windows.Forms.Button();
            this.panelLeftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.panelLeftMenu.Controls.Add(this.btnRDP);
            this.panelLeftMenu.Controls.Add(this.btnSettings);
            this.panelLeftMenu.Controls.Add(this.btnNotes);
            this.panelLeftMenu.Controls.Add(this.btnFileRename);
            this.panelLeftMenu.Controls.Add(this.btnAddressBook);
            this.panelLeftMenu.Controls.Add(this.btnDataEncryption);
            this.panelLeftMenu.Controls.Add(this.btnXmlReader);
            this.panelLeftMenu.Controls.Add(this.btnSyllabus);
            this.panelLeftMenu.Controls.Add(this.btnTimer);
            this.panelLeftMenu.Controls.Add(this.btnWebsites);
            this.panelLeftMenu.Controls.Add(this.btnShutdownComputer);
            this.panelLeftMenu.Controls.Add(this.btnManagePC);
            this.panelLeftMenu.Controls.Add(this.btnStatus);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 16);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(150, 529);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 440);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 40);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNotes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.Location = new System.Drawing.Point(0, 400);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(150, 40);
            this.btnNotes.TabIndex = 11;
            this.btnNotes.Text = "  Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnFileRename
            // 
            this.btnFileRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFileRename.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFileRename.FlatAppearance.BorderSize = 0;
            this.btnFileRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFileRename.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFileRename.Image = ((System.Drawing.Image)(resources.GetObject("btnFileRename.Image")));
            this.btnFileRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileRename.Location = new System.Drawing.Point(0, 360);
            this.btnFileRename.Name = "btnFileRename";
            this.btnFileRename.Size = new System.Drawing.Size(150, 40);
            this.btnFileRename.TabIndex = 10;
            this.btnFileRename.Text = "  File Rename";
            this.btnFileRename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFileRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFileRename.UseVisualStyleBackColor = true;
            this.btnFileRename.Click += new System.EventHandler(this.btnFileRename_Click);
            // 
            // btnAddressBook
            // 
            this.btnAddressBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddressBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddressBook.FlatAppearance.BorderSize = 0;
            this.btnAddressBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddressBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddressBook.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddressBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddressBook.Image")));
            this.btnAddressBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddressBook.Location = new System.Drawing.Point(0, 320);
            this.btnAddressBook.Name = "btnAddressBook";
            this.btnAddressBook.Size = new System.Drawing.Size(150, 40);
            this.btnAddressBook.TabIndex = 9;
            this.btnAddressBook.Text = "  Address Book";
            this.btnAddressBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddressBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddressBook.UseVisualStyleBackColor = true;
            this.btnAddressBook.Click += new System.EventHandler(this.btnAddressBook_Click);
            // 
            // btnDataEncryption
            // 
            this.btnDataEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDataEncryption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataEncryption.FlatAppearance.BorderSize = 0;
            this.btnDataEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDataEncryption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataEncryption.Image = ((System.Drawing.Image)(resources.GetObject("btnDataEncryption.Image")));
            this.btnDataEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataEncryption.Location = new System.Drawing.Point(0, 280);
            this.btnDataEncryption.Name = "btnDataEncryption";
            this.btnDataEncryption.Size = new System.Drawing.Size(150, 40);
            this.btnDataEncryption.TabIndex = 7;
            this.btnDataEncryption.Text = "  Data Encrypt";
            this.btnDataEncryption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataEncryption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataEncryption.UseVisualStyleBackColor = true;
            this.btnDataEncryption.Click += new System.EventHandler(this.btnDataEncryption_Click);
            // 
            // btnXmlReader
            // 
            this.btnXmlReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXmlReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXmlReader.FlatAppearance.BorderSize = 0;
            this.btnXmlReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXmlReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXmlReader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXmlReader.Image = ((System.Drawing.Image)(resources.GetObject("btnXmlReader.Image")));
            this.btnXmlReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXmlReader.Location = new System.Drawing.Point(0, 240);
            this.btnXmlReader.Name = "btnXmlReader";
            this.btnXmlReader.Size = new System.Drawing.Size(150, 40);
            this.btnXmlReader.TabIndex = 8;
            this.btnXmlReader.Text = "  XML Reader";
            this.btnXmlReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXmlReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXmlReader.UseVisualStyleBackColor = true;
            this.btnXmlReader.Click += new System.EventHandler(this.btnXmlReader_Click);
            // 
            // btnSyllabus
            // 
            this.btnSyllabus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSyllabus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSyllabus.FlatAppearance.BorderSize = 0;
            this.btnSyllabus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabus.Image = global::PCManager.Properties.Resources.document_2_24;
            this.btnSyllabus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyllabus.Location = new System.Drawing.Point(0, 200);
            this.btnSyllabus.Name = "btnSyllabus";
            this.btnSyllabus.Size = new System.Drawing.Size(150, 40);
            this.btnSyllabus.TabIndex = 6;
            this.btnSyllabus.Text = "  Syllabus";
            this.btnSyllabus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSyllabus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSyllabus.UseVisualStyleBackColor = true;
            this.btnSyllabus.Click += new System.EventHandler(this.btnSyllabus_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnTimer.Image")));
            this.btnTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimer.Location = new System.Drawing.Point(0, 160);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(150, 40);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "  Timer";
            this.btnTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
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
            this.btnWebsites.Location = new System.Drawing.Point(0, 120);
            this.btnWebsites.Name = "btnWebsites";
            this.btnWebsites.Size = new System.Drawing.Size(150, 40);
            this.btnWebsites.TabIndex = 4;
            this.btnWebsites.Text = "  Websites";
            this.btnWebsites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWebsites.UseVisualStyleBackColor = true;
            this.btnWebsites.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnWebsites_MouseDown);
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
            this.btnShutdownComputer.Location = new System.Drawing.Point(0, 80);
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
            this.btnManagePC.Location = new System.Drawing.Point(0, 40);
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
            this.btnStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.Location = new System.Drawing.Point(0, 0);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(150, 40);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "  Status";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(150, 16);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(740, 529);
            this.panelDesktop.TabIndex = 1;
            // 
            // panelBottomMenu
            // 
            this.panelBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.panelBottomMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBottomMenu.Location = new System.Drawing.Point(0, 0);
            this.panelBottomMenu.Name = "panelBottomMenu";
            this.panelBottomMenu.Size = new System.Drawing.Size(890, 16);
            this.panelBottomMenu.TabIndex = 1;
            // 
            // btnRDP
            // 
            this.btnRDP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRDP.FlatAppearance.BorderSize = 0;
            this.btnRDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRDP.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRDP.Image = ((System.Drawing.Image)(resources.GetObject("btnRDP.Image")));
            this.btnRDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRDP.Location = new System.Drawing.Point(0, 480);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(150, 40);
            this.btnRDP.TabIndex = 13;
            this.btnRDP.Text = "  RDP";
            this.btnRDP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRDP.UseVisualStyleBackColor = true;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 545);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelBottomMenu);
            this.MinimumSize = new System.Drawing.Size(890, 530);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCManager";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panelLeftMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelBottomMenu;
        private System.Windows.Forms.Button btnManagePC;
        private System.Windows.Forms.Button btnShutdownComputer;
        private System.Windows.Forms.Button btnWebsites;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnSyllabus;
        private System.Windows.Forms.Button btnDataEncryption;
        private System.Windows.Forms.Button btnXmlReader;
        private System.Windows.Forms.Button btnAddressBook;
        private System.Windows.Forms.Button btnFileRename;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnRDP;
    }
}

