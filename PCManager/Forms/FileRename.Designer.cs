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
            this.SuspendLayout();
            // 
            // lvFileRename
            // 
            this.lvFileRename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvFileRename.HideSelection = false;
            this.lvFileRename.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvFileRename.Location = new System.Drawing.Point(0, 218);
            this.lvFileRename.Name = "lvFileRename";
            this.lvFileRename.Size = new System.Drawing.Size(800, 232);
            this.lvFileRename.TabIndex = 0;
            this.lvFileRename.UseCompatibleStateImageBehavior = false;
            this.lvFileRename.View = System.Windows.Forms.View.List;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectoryPath.Location = new System.Drawing.Point(12, 9);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(83, 15);
            this.lblDirectoryPath.TabIndex = 19;
            this.lblDirectoryPath.Text = "Directory Path";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(14, 29);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(645, 26);
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
            this.btnSyllabusClearPath.Location = new System.Drawing.Point(699, 30);
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
            this.btnOpenFileDialog.Location = new System.Drawing.Point(666, 30);
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
            this.btnLoadNames.Location = new System.Drawing.Point(14, 172);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(37, 40);
            this.btnLoadNames.TabIndex = 21;
            this.btnLoadNames.UseVisualStyleBackColor = false;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // FileRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadNames);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.lblDirectoryPath);
            this.Controls.Add(this.btnSyllabusClearPath);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.lvFileRename);
            this.Name = "FileRename";
            this.Text = "FileRename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFileRename;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Button btnSyllabusClearPath;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnLoadNames;
    }
}