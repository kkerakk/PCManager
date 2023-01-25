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
            this.FLPSyllabus = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtSyllabus = new System.Windows.Forms.RichTextBox();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.lblDirectoryPath = new System.Windows.Forms.LinkLabel();
            this.PanelTopSyllabus = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.LBYear = new System.Windows.Forms.ListBox();
            this.btnSyllabusGenerate = new System.Windows.Forms.Button();
            this.lblSemester = new System.Windows.Forms.Label();
            this.LBSemester = new System.Windows.Forms.ListBox();
            this.lblFieldOfStudy = new System.Windows.Forms.Label();
            this.LBFieldOfStudy = new System.Windows.Forms.ListBox();
            this.lblLevelOfStudy = new System.Windows.Forms.Label();
            this.LBLevelOfStudy = new System.Windows.Forms.ListBox();
            this.btnSyllabusAddPath = new System.Windows.Forms.Button();
            this.btnSyllabusClear = new System.Windows.Forms.Button();
            this.btnSyllabusLoad = new System.Windows.Forms.Button();
            this.btnSyllabusSave = new System.Windows.Forms.Button();
            this.FLPSyllabus.SuspendLayout();
            this.PanelTopSyllabus.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLPSyllabus
            // 
            this.FLPSyllabus.AutoScroll = true;
            this.FLPSyllabus.AutoSize = true;
            this.FLPSyllabus.Controls.Add(this.rtxtSyllabus);
            this.FLPSyllabus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLPSyllabus.Location = new System.Drawing.Point(0, 157);
            this.FLPSyllabus.Name = "FLPSyllabus";
            this.FLPSyllabus.Size = new System.Drawing.Size(715, 304);
            this.FLPSyllabus.TabIndex = 1;
            // 
            // rtxtSyllabus
            // 
            this.rtxtSyllabus.Location = new System.Drawing.Point(3, 3);
            this.rtxtSyllabus.Name = "rtxtSyllabus";
            this.rtxtSyllabus.Size = new System.Drawing.Size(705, 298);
            this.rtxtSyllabus.TabIndex = 0;
            this.rtxtSyllabus.Text = "";
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(5, 21);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(645, 20);
            this.txtDirectoryPath.TabIndex = 0;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.LinkColor = System.Drawing.Color.Black;
            this.lblDirectoryPath.Location = new System.Drawing.Point(5, 5);
            this.lblDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(74, 13);
            this.lblDirectoryPath.TabIndex = 1;
            this.lblDirectoryPath.TabStop = true;
            this.lblDirectoryPath.Text = "Directory Path";
            this.lblDirectoryPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDirectoryPath_LinkClicked);
            // 
            // PanelTopSyllabus
            // 
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
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusAddPath);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClear);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusLoad);
            this.PanelTopSyllabus.Controls.Add(this.txtDirectoryPath);
            this.PanelTopSyllabus.Controls.Add(this.lblDirectoryPath);
            this.PanelTopSyllabus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopSyllabus.Location = new System.Drawing.Point(0, 0);
            this.PanelTopSyllabus.Name = "PanelTopSyllabus";
            this.PanelTopSyllabus.Size = new System.Drawing.Size(715, 155);
            this.PanelTopSyllabus.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(5, 92);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 13);
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
            this.LBYear.Location = new System.Drawing.Point(5, 108);
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
            this.btnSyllabusGenerate.Location = new System.Drawing.Point(197, 49);
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
            this.lblSemester.Location = new System.Drawing.Point(383, 92);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
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
            this.LBSemester.Location = new System.Drawing.Point(383, 108);
            this.LBSemester.Name = "LBSemester";
            this.LBSemester.Size = new System.Drawing.Size(120, 34);
            this.LBSemester.TabIndex = 9;
            // 
            // lblFieldOfStudy
            // 
            this.lblFieldOfStudy.AutoSize = true;
            this.lblFieldOfStudy.Location = new System.Drawing.Point(131, 92);
            this.lblFieldOfStudy.Name = "lblFieldOfStudy";
            this.lblFieldOfStudy.Size = new System.Drawing.Size(69, 13);
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
            this.LBFieldOfStudy.Location = new System.Drawing.Point(131, 108);
            this.LBFieldOfStudy.Name = "LBFieldOfStudy";
            this.LBFieldOfStudy.Size = new System.Drawing.Size(120, 34);
            this.LBFieldOfStudy.TabIndex = 7;
            // 
            // lblLevelOfStudy
            // 
            this.lblLevelOfStudy.AutoSize = true;
            this.lblLevelOfStudy.Location = new System.Drawing.Point(257, 92);
            this.lblLevelOfStudy.Name = "lblLevelOfStudy";
            this.lblLevelOfStudy.Size = new System.Drawing.Size(73, 13);
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
            this.LBLevelOfStudy.Location = new System.Drawing.Point(257, 108);
            this.LBLevelOfStudy.Name = "LBLevelOfStudy";
            this.LBLevelOfStudy.Size = new System.Drawing.Size(120, 34);
            this.LBLevelOfStudy.TabIndex = 5;
            // 
            // btnSyllabusAddPath
            // 
            this.btnSyllabusAddPath.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusAddPath.FlatAppearance.BorderSize = 0;
            this.btnSyllabusAddPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusAddPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusAddPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSyllabusAddPath.Location = new System.Drawing.Point(653, 21);
            this.btnSyllabusAddPath.Name = "btnSyllabusAddPath";
            this.btnSyllabusAddPath.Size = new System.Drawing.Size(23, 20);
            this.btnSyllabusAddPath.TabIndex = 4;
            this.btnSyllabusAddPath.Text = "+";
            this.btnSyllabusAddPath.UseVisualStyleBackColor = false;
            this.btnSyllabusAddPath.Click += new System.EventHandler(this.btnSyllabusAddPath_Click);
            // 
            // btnSyllabusClear
            // 
            this.btnSyllabusClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusClear.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClear.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusClear.Location = new System.Drawing.Point(101, 49);
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
            this.btnSyllabusLoad.Location = new System.Drawing.Point(5, 49);
            this.btnSyllabusLoad.Name = "btnSyllabusLoad";
            this.btnSyllabusLoad.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusLoad.TabIndex = 2;
            this.btnSyllabusLoad.Text = "Load";
            this.btnSyllabusLoad.UseVisualStyleBackColor = false;
            this.btnSyllabusLoad.Click += new System.EventHandler(this.btnSyllabusLoad_Click);
            // 
            // btnSyllabusSave
            // 
            this.btnSyllabusSave.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSyllabusSave.FlatAppearance.BorderSize = 0;
            this.btnSyllabusSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusSave.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusSave.Location = new System.Drawing.Point(293, 49);
            this.btnSyllabusSave.Name = "btnSyllabusSave";
            this.btnSyllabusSave.Size = new System.Drawing.Size(90, 40);
            this.btnSyllabusSave.TabIndex = 14;
            this.btnSyllabusSave.Text = "Save";
            this.btnSyllabusSave.UseVisualStyleBackColor = false;
            this.btnSyllabusSave.Click += new System.EventHandler(this.btnSyllabusSave_Click);
            // 
            // Syllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 461);
            this.Controls.Add(this.PanelTopSyllabus);
            this.Controls.Add(this.FLPSyllabus);
            this.Name = "Syllabus";
            this.Text = "Syllabus";
            this.FLPSyllabus.ResumeLayout(false);
            this.PanelTopSyllabus.ResumeLayout(false);
            this.PanelTopSyllabus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPSyllabus;
        private System.Windows.Forms.LinkLabel lblDirectoryPath;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Panel PanelTopSyllabus;
        private System.Windows.Forms.Button btnSyllabusLoad;
        private System.Windows.Forms.RichTextBox rtxtSyllabus;
        private System.Windows.Forms.Button btnSyllabusClear;
        private System.Windows.Forms.Button btnSyllabusAddPath;
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
    }
}