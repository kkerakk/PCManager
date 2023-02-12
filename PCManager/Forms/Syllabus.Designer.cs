namespace PCManager.Forms
{
    partial class Syllabus
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
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.PanelTopSyllabus = new System.Windows.Forms.Panel();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.btnSyllabusChangeName = new System.Windows.Forms.Button();
            this.btnSyllabusSave = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.LBYear = new System.Windows.Forms.ListBox();
            this.btnSyllabusGenerate = new System.Windows.Forms.Button();
            this.lblSemester = new System.Windows.Forms.Label();
            this.LBSemester = new System.Windows.Forms.ListBox();
            this.lblFieldOfStudy = new System.Windows.Forms.Label();
            this.LBFieldOfStudy = new System.Windows.Forms.ListBox();
            this.lblLevelOfStudy = new System.Windows.Forms.Label();
            this.LBLevelOfStudy = new System.Windows.Forms.ListBox();
            this.btnSyllabusClearPath = new System.Windows.Forms.Button();
            this.btnSyllabusClear = new System.Windows.Forms.Button();
            this.btnSyllabusLoad = new System.Windows.Forms.Button();
            this.rtxtSyllabus = new System.Windows.Forms.RichTextBox();
            this.btnSyllabusCopy = new System.Windows.Forms.Button();
            this.PanelTopSyllabus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(5, 21);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(645, 26);
            this.txtDirectoryPath.TabIndex = 0;
            // 
            // PanelTopSyllabus
            // 
            this.PanelTopSyllabus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusCopy);
            this.PanelTopSyllabus.Controls.Add(this.lblDirectoryPath);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusChangeName);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusSave);
            this.PanelTopSyllabus.Controls.Add(this.lblYear);
            this.PanelTopSyllabus.Controls.Add(this.LBYear);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusGenerate);
            this.PanelTopSyllabus.Controls.Add(this.lblSemester);
            this.PanelTopSyllabus.Controls.Add(this.LBSemester);
            this.PanelTopSyllabus.Controls.Add(this.lblFieldOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.LBFieldOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.lblLevelOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.LBLevelOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClearPath);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClear);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusLoad);
            this.PanelTopSyllabus.Controls.Add(this.txtDirectoryPath);
            this.PanelTopSyllabus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopSyllabus.Location = new System.Drawing.Point(0, 0);
            this.PanelTopSyllabus.Name = "PanelTopSyllabus";
            this.PanelTopSyllabus.Size = new System.Drawing.Size(691, 166);
            this.PanelTopSyllabus.TabIndex = 2;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectoryPath.Location = new System.Drawing.Point(5, 3);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(83, 15);
            this.lblDirectoryPath.TabIndex = 16;
            this.lblDirectoryPath.Text = "Directory Path";
            // 
            // btnSyllabusChangeName
            // 
            this.btnSyllabusChangeName.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusChangeName.FlatAppearance.BorderSize = 0;
            this.btnSyllabusChangeName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusChangeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusChangeName.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusChangeName.Location = new System.Drawing.Point(485, 112);
            this.btnSyllabusChangeName.Name = "btnSyllabusChangeName";
            this.btnSyllabusChangeName.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusChangeName.TabIndex = 15;
            this.btnSyllabusChangeName.Text = "Change names";
            this.btnSyllabusChangeName.UseVisualStyleBackColor = false;
            this.btnSyllabusChangeName.Click += new System.EventHandler(this.btnSyllabusChangeName_Click);
            // 
            // btnSyllabusSave
            // 
            this.btnSyllabusSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusSave.FlatAppearance.BorderSize = 0;
            this.btnSyllabusSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusSave.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusSave.Location = new System.Drawing.Point(293, 112);
            this.btnSyllabusSave.Name = "btnSyllabusSave";
            this.btnSyllabusSave.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusSave.TabIndex = 14;
            this.btnSyllabusSave.Text = "Save";
            this.btnSyllabusSave.UseVisualStyleBackColor = false;
            this.btnSyllabusSave.Click += new System.EventHandler(this.btnSyllabusSave_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYear.Location = new System.Drawing.Point(5, 53);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(76, 15);
            this.lblYear.TabIndex = 13;
            this.lblYear.Text = "Year of study";
            // 
            // LBYear
            // 
            this.LBYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBYear.FormattingEnabled = true;
            this.LBYear.ItemHeight = 15;
            this.LBYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.LBYear.Location = new System.Drawing.Point(5, 69);
            this.LBYear.Name = "LBYear";
            this.LBYear.Size = new System.Drawing.Size(120, 34);
            this.LBYear.TabIndex = 12;
            // 
            // btnSyllabusGenerate
            // 
            this.btnSyllabusGenerate.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusGenerate.FlatAppearance.BorderSize = 0;
            this.btnSyllabusGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusGenerate.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusGenerate.Location = new System.Drawing.Point(197, 112);
            this.btnSyllabusGenerate.Name = "btnSyllabusGenerate";
            this.btnSyllabusGenerate.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusGenerate.TabIndex = 11;
            this.btnSyllabusGenerate.Text = "Generate";
            this.btnSyllabusGenerate.UseVisualStyleBackColor = false;
            this.btnSyllabusGenerate.Click += new System.EventHandler(this.btnSyllabusGenerate_Click);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemester.Location = new System.Drawing.Point(383, 53);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(60, 15);
            this.lblSemester.TabIndex = 10;
            this.lblSemester.Text = "Semester";
            // 
            // LBSemester
            // 
            this.LBSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBSemester.FormattingEnabled = true;
            this.LBSemester.ItemHeight = 15;
            this.LBSemester.Items.AddRange(new object[] {
            "letni",
            "zimowy"});
            this.LBSemester.Location = new System.Drawing.Point(383, 69);
            this.LBSemester.Name = "LBSemester";
            this.LBSemester.Size = new System.Drawing.Size(120, 34);
            this.LBSemester.TabIndex = 9;
            // 
            // lblFieldOfStudy
            // 
            this.lblFieldOfStudy.AutoSize = true;
            this.lblFieldOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFieldOfStudy.Location = new System.Drawing.Point(131, 53);
            this.lblFieldOfStudy.Name = "lblFieldOfStudy";
            this.lblFieldOfStudy.Size = new System.Drawing.Size(78, 15);
            this.lblFieldOfStudy.TabIndex = 8;
            this.lblFieldOfStudy.Text = "Field of study";
            // 
            // LBFieldOfStudy
            // 
            this.LBFieldOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBFieldOfStudy.FormattingEnabled = true;
            this.LBFieldOfStudy.ItemHeight = 15;
            this.LBFieldOfStudy.Items.AddRange(new object[] {
            "BW",
            "Informatyka",
            "KRYM",
            "NOP"});
            this.LBFieldOfStudy.Location = new System.Drawing.Point(131, 69);
            this.LBFieldOfStudy.Name = "LBFieldOfStudy";
            this.LBFieldOfStudy.Size = new System.Drawing.Size(120, 34);
            this.LBFieldOfStudy.TabIndex = 7;
            // 
            // lblLevelOfStudy
            // 
            this.lblLevelOfStudy.AutoSize = true;
            this.lblLevelOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLevelOfStudy.Location = new System.Drawing.Point(257, 53);
            this.lblLevelOfStudy.Name = "lblLevelOfStudy";
            this.lblLevelOfStudy.Size = new System.Drawing.Size(80, 15);
            this.lblLevelOfStudy.TabIndex = 6;
            this.lblLevelOfStudy.Text = "Level of study";
            // 
            // LBLevelOfStudy
            // 
            this.LBLevelOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLevelOfStudy.FormattingEnabled = true;
            this.LBLevelOfStudy.ItemHeight = 15;
            this.LBLevelOfStudy.Items.AddRange(new object[] {
            "I_stopien",
            "II_stopien"});
            this.LBLevelOfStudy.Location = new System.Drawing.Point(257, 69);
            this.LBLevelOfStudy.Name = "LBLevelOfStudy";
            this.LBLevelOfStudy.Size = new System.Drawing.Size(120, 34);
            this.LBLevelOfStudy.TabIndex = 5;
            // 
            // btnSyllabusClearPath
            // 
            this.btnSyllabusClearPath.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusClearPath.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClearPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClearPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClearPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSyllabusClearPath.Location = new System.Drawing.Point(653, 21);
            this.btnSyllabusClearPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSyllabusClearPath.Name = "btnSyllabusClearPath";
            this.btnSyllabusClearPath.Size = new System.Drawing.Size(23, 26);
            this.btnSyllabusClearPath.TabIndex = 4;
            this.btnSyllabusClearPath.Text = "C";
            this.btnSyllabusClearPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSyllabusClearPath.UseVisualStyleBackColor = false;
            this.btnSyllabusClearPath.Click += new System.EventHandler(this.btnSyllabusClearPath_Click);
            // 
            // btnSyllabusClear
            // 
            this.btnSyllabusClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusClear.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClear.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusClear.Location = new System.Drawing.Point(101, 112);
            this.btnSyllabusClear.Name = "btnSyllabusClear";
            this.btnSyllabusClear.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusClear.TabIndex = 3;
            this.btnSyllabusClear.Text = "Clear";
            this.btnSyllabusClear.UseVisualStyleBackColor = false;
            this.btnSyllabusClear.Click += new System.EventHandler(this.btnSyllabusClear_Click);
            // 
            // btnSyllabusLoad
            // 
            this.btnSyllabusLoad.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusLoad.FlatAppearance.BorderSize = 0;
            this.btnSyllabusLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusLoad.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusLoad.Location = new System.Drawing.Point(5, 112);
            this.btnSyllabusLoad.Name = "btnSyllabusLoad";
            this.btnSyllabusLoad.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusLoad.TabIndex = 2;
            this.btnSyllabusLoad.Text = "Load";
            this.btnSyllabusLoad.UseVisualStyleBackColor = false;
            this.btnSyllabusLoad.Click += new System.EventHandler(this.btnSyllabusLoad_Click);
            // 
            // rtxtSyllabus
            // 
            this.rtxtSyllabus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSyllabus.Location = new System.Drawing.Point(0, 166);
            this.rtxtSyllabus.Name = "rtxtSyllabus";
            this.rtxtSyllabus.ReadOnly = true;
            this.rtxtSyllabus.Size = new System.Drawing.Size(691, 318);
            this.rtxtSyllabus.TabIndex = 3;
            this.rtxtSyllabus.Text = "";
            // 
            // btnSyllabusCopy
            // 
            this.btnSyllabusCopy.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusCopy.FlatAppearance.BorderSize = 0;
            this.btnSyllabusCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusCopy.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusCopy.Location = new System.Drawing.Point(389, 112);
            this.btnSyllabusCopy.Name = "btnSyllabusCopy";
            this.btnSyllabusCopy.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusCopy.TabIndex = 17;
            this.btnSyllabusCopy.Text = "Copy";
            this.btnSyllabusCopy.UseVisualStyleBackColor = false;
            this.btnSyllabusCopy.Click += new System.EventHandler(this.btnSyllabusCopy_Click);
            // 
            // Syllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 484);
            this.Controls.Add(this.rtxtSyllabus);
            this.Controls.Add(this.PanelTopSyllabus);
            this.Name = "Syllabus";
            this.Text = "Syllabus";
            this.PanelTopSyllabus.ResumeLayout(false);
            this.PanelTopSyllabus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Panel PanelTopSyllabus;
        private System.Windows.Forms.Button btnSyllabusLoad;
        private System.Windows.Forms.Button btnSyllabusClear;
        private System.Windows.Forms.Button btnSyllabusClearPath;
        private System.Windows.Forms.Label lblLevelOfStudy;
        private System.Windows.Forms.ListBox LBLevelOfStudy;
        private System.Windows.Forms.Label lblFieldOfStudy;
        private System.Windows.Forms.ListBox LBFieldOfStudy;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ListBox LBYear;
        private System.Windows.Forms.Button btnSyllabusGenerate;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ListBox LBSemester;
        private System.Windows.Forms.Button btnSyllabusSave;
        private System.Windows.Forms.Button btnSyllabusChangeName;
        private System.Windows.Forms.RichTextBox rtxtSyllabus;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Button btnSyllabusCopy;
    }
}