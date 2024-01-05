namespace PCManager.Forms
{
    partial class FileRename
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileRename));
            this.lvFileRename = new System.Windows.Forms.ListView();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnSyllabusClearPath = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnLoadNames = new System.Windows.Forms.Button();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.cbRemoveFirstToSpace = new System.Windows.Forms.CheckBox();
            this.btnRestoreNames = new System.Windows.Forms.Button();
            this.btnRenameNames = new System.Windows.Forms.Button();
            this.cbChangePolishLetters = new System.Windows.Forms.CheckBox();
            this.cbRemoveSpace = new System.Windows.Forms.CheckBox();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFileRename
            // 
            this.lvFileRename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFileRename.HideSelection = false;
            this.lvFileRename.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvFileRename.Location = new System.Drawing.Point(0, 199);
            this.lvFileRename.Name = "lvFileRename";
            this.lvFileRename.Size = new System.Drawing.Size(698, 251);
            this.lvFileRename.TabIndex = 0;
            this.lvFileRename.UseCompatibleStateImageBehavior = false;
            this.lvFileRename.View = System.Windows.Forms.View.List;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectoryPath.Location = new System.Drawing.Point(3, 0);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(83, 15);
            this.lblDirectoryPath.TabIndex = 19;
            this.lblDirectoryPath.Text = "Directory Path";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(5, 20);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(614, 26);
            this.txtDirectoryPath.TabIndex = 17;
            // 
            // btnSyllabusClearPath
            // 
            this.btnSyllabusClearPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusClearPath.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClearPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusClearPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClearPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClearPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSyllabusClearPath.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusClearPath.Image")));
            this.btnSyllabusClearPath.Location = new System.Drawing.Point(657, 20);
            this.btnSyllabusClearPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSyllabusClearPath.Name = "btnSyllabusClearPath";
            this.btnSyllabusClearPath.Size = new System.Drawing.Size(23, 26);
            this.btnSyllabusClearPath.TabIndex = 18;
            this.btnSyllabusClearPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSyllabusClearPath.UseVisualStyleBackColor = false;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpenFileDialog.FlatAppearance.BorderSize = 0;
            this.btnOpenFileDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOpenFileDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFileDialog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenFileDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFileDialog.Image")));
            this.btnOpenFileDialog.Location = new System.Drawing.Point(624, 20);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(23, 26);
            this.btnOpenFileDialog.TabIndex = 20;
            this.btnOpenFileDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenFileDialog.UseVisualStyleBackColor = false;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnLoadNames
            // 
            this.btnLoadNames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadNames.FlatAppearance.BorderSize = 0;
            this.btnLoadNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadNames.ForeColor = System.Drawing.Color.White;
            this.btnLoadNames.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadNames.Image")));
            this.btnLoadNames.Location = new System.Drawing.Point(6, 153);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(36, 40);
            this.btnLoadNames.TabIndex = 21;
            this.btnLoadNames.UseVisualStyleBackColor = false;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.cbRemoveFirstToSpace);
            this.PanelTop.Controls.Add(this.btnRestoreNames);
            this.PanelTop.Controls.Add(this.btnRenameNames);
            this.PanelTop.Controls.Add(this.cbChangePolishLetters);
            this.PanelTop.Controls.Add(this.cbRemoveSpace);
            this.PanelTop.Controls.Add(this.lblDirectoryPath);
            this.PanelTop.Controls.Add(this.btnLoadNames);
            this.PanelTop.Controls.Add(this.txtDirectoryPath);
            this.PanelTop.Controls.Add(this.btnOpenFileDialog);
            this.PanelTop.Controls.Add(this.btnSyllabusClearPath);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(698, 199);
            this.PanelTop.TabIndex = 22;
            // 
            // cbRemoveFirstToSpace
            // 
            this.cbRemoveFirstToSpace.AutoSize = true;
            this.cbRemoveFirstToSpace.Location = new System.Drawing.Point(6, 111);
            this.cbRemoveFirstToSpace.Name = "cbRemoveFirstToSpace";
            this.cbRemoveFirstToSpace.Size = new System.Drawing.Size(124, 17);
            this.cbRemoveFirstToSpace.TabIndex = 26;
            this.cbRemoveFirstToSpace.Text = "Change polish letters";
            this.cbRemoveFirstToSpace.UseVisualStyleBackColor = true;
            // 
            // btnRestoreNames
            // 
            this.btnRestoreNames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRestoreNames.FlatAppearance.BorderSize = 0;
            this.btnRestoreNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRestoreNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRestoreNames.ForeColor = System.Drawing.Color.White;
            this.btnRestoreNames.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreNames.Image")));
            this.btnRestoreNames.Location = new System.Drawing.Point(90, 153);
            this.btnRestoreNames.Name = "btnRestoreNames";
            this.btnRestoreNames.Size = new System.Drawing.Size(36, 40);
            this.btnRestoreNames.TabIndex = 25;
            this.btnRestoreNames.UseVisualStyleBackColor = false;
            this.btnRestoreNames.Click += new System.EventHandler(this.btnRestoreNames_Click);
            // 
            // btnRenameNames
            // 
            this.btnRenameNames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenameNames.FlatAppearance.BorderSize = 0;
            this.btnRenameNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRenameNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenameNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRenameNames.ForeColor = System.Drawing.Color.White;
            this.btnRenameNames.Image = ((System.Drawing.Image)(resources.GetObject("btnRenameNames.Image")));
            this.btnRenameNames.Location = new System.Drawing.Point(48, 153);
            this.btnRenameNames.Name = "btnRenameNames";
            this.btnRenameNames.Size = new System.Drawing.Size(36, 40);
            this.btnRenameNames.TabIndex = 24;
            this.btnRenameNames.UseVisualStyleBackColor = false;
            this.btnRenameNames.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // cbChangePolishLetters
            // 
            this.cbChangePolishLetters.AutoSize = true;
            this.cbChangePolishLetters.Location = new System.Drawing.Point(6, 88);
            this.cbChangePolishLetters.Name = "cbChangePolishLetters";
            this.cbChangePolishLetters.Size = new System.Drawing.Size(124, 17);
            this.cbChangePolishLetters.TabIndex = 23;
            this.cbChangePolishLetters.Text = "Change polish letters";
            this.cbChangePolishLetters.UseVisualStyleBackColor = true;
            // 
            // cbRemoveSpace
            // 
            this.cbRemoveSpace.AutoSize = true;
            this.cbRemoveSpace.Location = new System.Drawing.Point(6, 65);
            this.cbRemoveSpace.Name = "cbRemoveSpace";
            this.cbRemoveSpace.Size = new System.Drawing.Size(98, 17);
            this.cbRemoveSpace.TabIndex = 22;
            this.cbRemoveSpace.Text = "Remove space";
            this.cbRemoveSpace.UseVisualStyleBackColor = true;
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.lvFileRename);
            this.Name = "FileRename";
            this.Text = "FileRename";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFileRename;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Button btnSyllabusClearPath;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnLoadNames;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.CheckBox cbChangePolishLetters;
        private System.Windows.Forms.CheckBox cbRemoveSpace;
        private System.Windows.Forms.Button btnRestoreNames;
        private System.Windows.Forms.Button btnRenameNames;
        private System.Windows.Forms.CheckBox cbRemoveFirstToSpace;
    }
}