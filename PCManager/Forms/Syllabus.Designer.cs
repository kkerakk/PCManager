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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Syllabus));
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.PanelTopSyllabus = new System.Windows.Forms.Panel();
            this.GBHeader = new System.Windows.Forms.GroupBox();
            this.cbHeaderLevelOfStudy = new System.Windows.Forms.CheckBox();
            this.cbHeaderFieldOfStudy = new System.Windows.Forms.CheckBox();
            this.btnSyllabusClearAll = new System.Windows.Forms.Button();
            this.btnSyllabusSaveAsHTML = new System.Windows.Forms.Button();
            this.btnSyllabusCheck = new System.Windows.Forms.Button();
            this.dtpYearOfStudy = new System.Windows.Forms.DateTimePicker();
            this.btnSyllabusCopy = new System.Windows.Forms.Button();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.btnSyllabusChangeNames = new System.Windows.Forms.Button();
            this.btnSyllabusSaveAsText = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSyllabusGenerate = new System.Windows.Forms.Button();
            this.lblSemester = new System.Windows.Forms.Label();
            this.LBSemester = new System.Windows.Forms.ListBox();
            this.lblFieldOfStudy = new System.Windows.Forms.Label();
            this.LBFieldOfStudy = new System.Windows.Forms.ListBox();
            this.lblLevelOfStudy = new System.Windows.Forms.Label();
            this.LBLevelOfStudy = new System.Windows.Forms.ListBox();
            this.btnSyllabusClearPath = new System.Windows.Forms.Button();
            this.btnSyllabusClear = new System.Windows.Forms.Button();
            this.btnSyllabusLoadNames = new System.Windows.Forms.Button();
            this.rtxtSyllabus = new System.Windows.Forms.RichTextBox();
            this.ttSyllabus = new System.Windows.Forms.ToolTip(this.components);
            this.PanelTopSyllabus.SuspendLayout();
            this.GBHeader.SuspendLayout();
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
            this.PanelTopSyllabus.Controls.Add(this.GBHeader);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClearAll);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusSaveAsHTML);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusCheck);
            this.PanelTopSyllabus.Controls.Add(this.dtpYearOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusCopy);
            this.PanelTopSyllabus.Controls.Add(this.lblDirectoryPath);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusChangeNames);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusSaveAsText);
            this.PanelTopSyllabus.Controls.Add(this.lblYear);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusGenerate);
            this.PanelTopSyllabus.Controls.Add(this.lblSemester);
            this.PanelTopSyllabus.Controls.Add(this.LBSemester);
            this.PanelTopSyllabus.Controls.Add(this.lblFieldOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.LBFieldOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.lblLevelOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.LBLevelOfStudy);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClearPath);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusClear);
            this.PanelTopSyllabus.Controls.Add(this.btnSyllabusLoadNames);
            this.PanelTopSyllabus.Controls.Add(this.txtDirectoryPath);
            this.PanelTopSyllabus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopSyllabus.Location = new System.Drawing.Point(0, 0);
            this.PanelTopSyllabus.Name = "PanelTopSyllabus";
            this.PanelTopSyllabus.Size = new System.Drawing.Size(694, 166);
            this.PanelTopSyllabus.TabIndex = 2;
            // 
            // GBHeader
            // 
            this.GBHeader.Controls.Add(this.cbHeaderLevelOfStudy);
            this.GBHeader.Controls.Add(this.cbHeaderFieldOfStudy);
            this.GBHeader.Location = new System.Drawing.Point(543, 55);
            this.GBHeader.Name = "GBHeader";
            this.GBHeader.Size = new System.Drawing.Size(107, 100);
            this.GBHeader.TabIndex = 24;
            this.GBHeader.TabStop = false;
            this.GBHeader.Text = "Headers";
            // 
            // cbHeaderLevelOfStudy
            // 
            this.cbHeaderLevelOfStudy.AutoSize = true;
            this.cbHeaderLevelOfStudy.Location = new System.Drawing.Point(6, 20);
            this.cbHeaderLevelOfStudy.Name = "cbHeaderLevelOfStudy";
            this.cbHeaderLevelOfStudy.Size = new System.Drawing.Size(92, 17);
            this.cbHeaderLevelOfStudy.TabIndex = 22;
            this.cbHeaderLevelOfStudy.Text = "Level of study";
            this.cbHeaderLevelOfStudy.UseVisualStyleBackColor = true;
            // 
            // cbHeaderFieldOfStudy
            // 
            this.cbHeaderFieldOfStudy.AutoSize = true;
            this.cbHeaderFieldOfStudy.Location = new System.Drawing.Point(6, 43);
            this.cbHeaderFieldOfStudy.Name = "cbHeaderFieldOfStudy";
            this.cbHeaderFieldOfStudy.Size = new System.Drawing.Size(88, 17);
            this.cbHeaderFieldOfStudy.TabIndex = 23;
            this.cbHeaderFieldOfStudy.Text = "Field of study";
            this.cbHeaderFieldOfStudy.UseVisualStyleBackColor = true;
            // 
            // btnSyllabusClearAll
            // 
            this.btnSyllabusClearAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusClearAll.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClearAll.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusClearAll.Image")));
            this.btnSyllabusClearAll.Location = new System.Drawing.Point(321, 116);
            this.btnSyllabusClearAll.Name = "btnSyllabusClearAll";
            this.btnSyllabusClearAll.Size = new System.Drawing.Size(38, 40);
            this.btnSyllabusClearAll.TabIndex = 21;
            this.btnSyllabusClearAll.UseVisualStyleBackColor = false;
            this.btnSyllabusClearAll.Click += new System.EventHandler(this.btnSyllabusClearAll_Click);
            this.btnSyllabusClearAll.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // btnSyllabusSaveAsHTML
            // 
            this.btnSyllabusSaveAsHTML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusSaveAsHTML.FlatAppearance.BorderSize = 0;
            this.btnSyllabusSaveAsHTML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusSaveAsHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusSaveAsHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusSaveAsHTML.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusSaveAsHTML.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusSaveAsHTML.Image")));
            this.btnSyllabusSaveAsHTML.Location = new System.Drawing.Point(181, 116);
            this.btnSyllabusSaveAsHTML.Name = "btnSyllabusSaveAsHTML";
            this.btnSyllabusSaveAsHTML.Size = new System.Drawing.Size(44, 40);
            this.btnSyllabusSaveAsHTML.TabIndex = 20;
            this.btnSyllabusSaveAsHTML.UseVisualStyleBackColor = false;
            this.btnSyllabusSaveAsHTML.Click += new System.EventHandler(this.btnSyllabusSaveAsHTML_Click);
            this.btnSyllabusSaveAsHTML.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // btnSyllabusCheck
            // 
            this.btnSyllabusCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusCheck.FlatAppearance.BorderSize = 0;
            this.btnSyllabusCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusCheck.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCheck.Image")));
            this.btnSyllabusCheck.Location = new System.Drawing.Point(458, 76);
            this.btnSyllabusCheck.Name = "btnSyllabusCheck";
            this.btnSyllabusCheck.Size = new System.Drawing.Size(36, 34);
            this.btnSyllabusCheck.TabIndex = 19;
            this.btnSyllabusCheck.UseVisualStyleBackColor = false;
            this.btnSyllabusCheck.Click += new System.EventHandler(this.btnSyllabusCheck_Click);
            this.btnSyllabusCheck.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // dtpYearOfStudy
            // 
            this.dtpYearOfStudy.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpYearOfStudy.CustomFormat = "yyyy";
            this.dtpYearOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpYearOfStudy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearOfStudy.Location = new System.Drawing.Point(5, 89);
            this.dtpYearOfStudy.Name = "dtpYearOfStudy";
            this.dtpYearOfStudy.ShowUpDown = true;
            this.dtpYearOfStudy.Size = new System.Drawing.Size(117, 24);
            this.dtpYearOfStudy.TabIndex = 18;
            // 
            // btnSyllabusCopy
            // 
            this.btnSyllabusCopy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusCopy.FlatAppearance.BorderSize = 0;
            this.btnSyllabusCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusCopy.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusCopy.Image")));
            this.btnSyllabusCopy.Location = new System.Drawing.Point(224, 116);
            this.btnSyllabusCopy.Name = "btnSyllabusCopy";
            this.btnSyllabusCopy.Size = new System.Drawing.Size(47, 40);
            this.btnSyllabusCopy.TabIndex = 17;
            this.btnSyllabusCopy.UseVisualStyleBackColor = false;
            this.btnSyllabusCopy.Click += new System.EventHandler(this.btnSyllabusCopy_Click);
            this.btnSyllabusCopy.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
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
            // btnSyllabusChangeNames
            // 
            this.btnSyllabusChangeNames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusChangeNames.FlatAppearance.BorderSize = 0;
            this.btnSyllabusChangeNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusChangeNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusChangeNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusChangeNames.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusChangeNames.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusChangeNames.Image")));
            this.btnSyllabusChangeNames.Location = new System.Drawing.Point(277, 116);
            this.btnSyllabusChangeNames.Name = "btnSyllabusChangeNames";
            this.btnSyllabusChangeNames.Size = new System.Drawing.Size(38, 40);
            this.btnSyllabusChangeNames.TabIndex = 15;
            this.btnSyllabusChangeNames.UseVisualStyleBackColor = false;
            this.btnSyllabusChangeNames.Click += new System.EventHandler(this.btnSyllabusChangeNames_Click);
            this.btnSyllabusChangeNames.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // btnSyllabusSaveAsText
            // 
            this.btnSyllabusSaveAsText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusSaveAsText.FlatAppearance.BorderSize = 0;
            this.btnSyllabusSaveAsText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusSaveAsText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusSaveAsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusSaveAsText.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusSaveAsText.Image")));
            this.btnSyllabusSaveAsText.Location = new System.Drawing.Point(131, 116);
            this.btnSyllabusSaveAsText.Name = "btnSyllabusSaveAsText";
            this.btnSyllabusSaveAsText.Size = new System.Drawing.Size(44, 40);
            this.btnSyllabusSaveAsText.TabIndex = 14;
            this.btnSyllabusSaveAsText.UseVisualStyleBackColor = false;
            this.btnSyllabusSaveAsText.Click += new System.EventHandler(this.btnSyllabusSaveAsText_Click);
            this.btnSyllabusSaveAsText.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
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
            // btnSyllabusGenerate
            // 
            this.btnSyllabusGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusGenerate.FlatAppearance.BorderSize = 0;
            this.btnSyllabusGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusGenerate.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusGenerate.Image")));
            this.btnSyllabusGenerate.Location = new System.Drawing.Point(93, 116);
            this.btnSyllabusGenerate.Name = "btnSyllabusGenerate";
            this.btnSyllabusGenerate.Size = new System.Drawing.Size(34, 40);
            this.btnSyllabusGenerate.TabIndex = 11;
            this.btnSyllabusGenerate.UseVisualStyleBackColor = false;
            this.btnSyllabusGenerate.Click += new System.EventHandler(this.btnSyllabusGenerate_Click);
            this.btnSyllabusGenerate.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSemester.Location = new System.Drawing.Point(354, 53);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(60, 15);
            this.lblSemester.TabIndex = 10;
            this.lblSemester.Text = "Semester";
            // 
            // LBSemester
            // 
            this.LBSemester.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBSemester.FormattingEnabled = true;
            this.LBSemester.ItemHeight = 18;
            this.LBSemester.Items.AddRange(new object[] {
            "letni",
            "zimowy"});
            this.LBSemester.Location = new System.Drawing.Point(354, 76);
            this.LBSemester.Name = "LBSemester";
            this.LBSemester.Size = new System.Drawing.Size(103, 36);
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
            this.LBFieldOfStudy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBFieldOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBFieldOfStudy.FormattingEnabled = true;
            this.LBFieldOfStudy.ItemHeight = 18;
            this.LBFieldOfStudy.Items.AddRange(new object[] {
            "BW",
            "INF",
            "KRYM",
            "NOP"});
            this.LBFieldOfStudy.Location = new System.Drawing.Point(131, 76);
            this.LBFieldOfStudy.Name = "LBFieldOfStudy";
            this.LBFieldOfStudy.Size = new System.Drawing.Size(103, 36);
            this.LBFieldOfStudy.TabIndex = 7;
            // 
            // lblLevelOfStudy
            // 
            this.lblLevelOfStudy.AutoSize = true;
            this.lblLevelOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLevelOfStudy.Location = new System.Drawing.Point(243, 53);
            this.lblLevelOfStudy.Name = "lblLevelOfStudy";
            this.lblLevelOfStudy.Size = new System.Drawing.Size(80, 15);
            this.lblLevelOfStudy.TabIndex = 6;
            this.lblLevelOfStudy.Text = "Level of study";
            // 
            // LBLevelOfStudy
            // 
            this.LBLevelOfStudy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBLevelOfStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLevelOfStudy.FormattingEnabled = true;
            this.LBLevelOfStudy.ItemHeight = 18;
            this.LBLevelOfStudy.Items.AddRange(new object[] {
            "I_stopien",
            "II_stopien"});
            this.LBLevelOfStudy.Location = new System.Drawing.Point(243, 76);
            this.LBLevelOfStudy.Name = "LBLevelOfStudy";
            this.LBLevelOfStudy.Size = new System.Drawing.Size(103, 36);
            this.LBLevelOfStudy.TabIndex = 5;
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
            this.btnSyllabusClearPath.Location = new System.Drawing.Point(653, 21);
            this.btnSyllabusClearPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSyllabusClearPath.Name = "btnSyllabusClearPath";
            this.btnSyllabusClearPath.Size = new System.Drawing.Size(23, 26);
            this.btnSyllabusClearPath.TabIndex = 4;
            this.btnSyllabusClearPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSyllabusClearPath.UseVisualStyleBackColor = false;
            this.btnSyllabusClearPath.Click += new System.EventHandler(this.btnSyllabusClearPath_Click);
            this.btnSyllabusClearPath.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // btnSyllabusClear
            // 
            this.btnSyllabusClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusClear.FlatAppearance.BorderSize = 0;
            this.btnSyllabusClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusClear.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusClear.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusClear.Image")));
            this.btnSyllabusClear.Location = new System.Drawing.Point(48, 116);
            this.btnSyllabusClear.Name = "btnSyllabusClear";
            this.btnSyllabusClear.Size = new System.Drawing.Size(39, 40);
            this.btnSyllabusClear.TabIndex = 3;
            this.btnSyllabusClear.UseVisualStyleBackColor = false;
            this.btnSyllabusClear.Click += new System.EventHandler(this.btnSyllabusClear_Click);
            this.btnSyllabusClear.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // btnSyllabusLoadNames
            // 
            this.btnSyllabusLoadNames.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSyllabusLoadNames.FlatAppearance.BorderSize = 0;
            this.btnSyllabusLoadNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSyllabusLoadNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyllabusLoadNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSyllabusLoadNames.ForeColor = System.Drawing.Color.White;
            this.btnSyllabusLoadNames.Image = ((System.Drawing.Image)(resources.GetObject("btnSyllabusLoadNames.Image")));
            this.btnSyllabusLoadNames.Location = new System.Drawing.Point(5, 116);
            this.btnSyllabusLoadNames.Name = "btnSyllabusLoadNames";
            this.btnSyllabusLoadNames.Size = new System.Drawing.Size(37, 40);
            this.btnSyllabusLoadNames.TabIndex = 2;
            this.btnSyllabusLoadNames.UseVisualStyleBackColor = false;
            this.btnSyllabusLoadNames.Click += new System.EventHandler(this.btnSyllabusLoadNames_Click);
            this.btnSyllabusLoadNames.MouseHover += new System.EventHandler(this.btnSyllabus_MouseHover);
            // 
            // rtxtSyllabus
            // 
            this.rtxtSyllabus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtSyllabus.Location = new System.Drawing.Point(0, 166);
            this.rtxtSyllabus.Name = "rtxtSyllabus";
            this.rtxtSyllabus.ReadOnly = true;
            this.rtxtSyllabus.Size = new System.Drawing.Size(694, 318);
            this.rtxtSyllabus.TabIndex = 3;
            this.rtxtSyllabus.Text = "";
            // 
            // Syllabus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 484);
            this.Controls.Add(this.rtxtSyllabus);
            this.Controls.Add(this.PanelTopSyllabus);
            this.Name = "Syllabus";
            this.Text = "Syllabus";
            this.PanelTopSyllabus.ResumeLayout(false);
            this.PanelTopSyllabus.PerformLayout();
            this.GBHeader.ResumeLayout(false);
            this.GBHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Panel PanelTopSyllabus;
        private System.Windows.Forms.Button btnSyllabusLoadNames;
        private System.Windows.Forms.Button btnSyllabusClear;
        private System.Windows.Forms.Button btnSyllabusClearPath;
        private System.Windows.Forms.Label lblLevelOfStudy;
        private System.Windows.Forms.ListBox LBLevelOfStudy;
        private System.Windows.Forms.Label lblFieldOfStudy;
        private System.Windows.Forms.ListBox LBFieldOfStudy;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSyllabusGenerate;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ListBox LBSemester;
        private System.Windows.Forms.Button btnSyllabusSaveAsText;
        private System.Windows.Forms.Button btnSyllabusChangeNames;
        private System.Windows.Forms.RichTextBox rtxtSyllabus;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Button btnSyllabusCopy;
        private System.Windows.Forms.DateTimePicker dtpYearOfStudy;
        private System.Windows.Forms.Button btnSyllabusCheck;
        private System.Windows.Forms.ToolTip ttSyllabus;
        private System.Windows.Forms.Button btnSyllabusSaveAsHTML;
        private System.Windows.Forms.Button btnSyllabusClearAll;
        private System.Windows.Forms.CheckBox cbHeaderLevelOfStudy;
        private System.Windows.Forms.GroupBox GBHeader;
        private System.Windows.Forms.CheckBox cbHeaderFieldOfStudy;
    }
}