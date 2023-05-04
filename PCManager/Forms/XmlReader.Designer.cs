namespace PCManager.Forms
{
    partial class XmlReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlReader));
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.btnClearPath = new System.Windows.Forms.Button();
            this.btnLoadNames = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.DGVXmlReader = new System.Windows.Forms.DataGridView();
            this.PanelTopXMLReader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.ListBox();
            this.btnGetPath = new System.Windows.Forms.Button();
            this.btnCheckUniqueValues = new System.Windows.Forms.Button();
            this.lbSubfoldersPath = new System.Windows.Forms.ListBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblCounterValue = new System.Windows.Forms.Label();
            this.rtUniqueValues = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVXmlReader)).BeginInit();
            this.PanelTopXMLReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDirectoryPath.Location = new System.Drawing.Point(5, 21);
            this.txtDirectoryPath.Margin = new System.Windows.Forms.Padding(5);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(645, 26);
            this.txtDirectoryPath.TabIndex = 2;
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDirectoryPath.Location = new System.Drawing.Point(5, 3);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(83, 15);
            this.lblDirectoryPath.TabIndex = 17;
            this.lblDirectoryPath.Text = "Directory Path";
            // 
            // btnClearPath
            // 
            this.btnClearPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearPath.FlatAppearance.BorderSize = 0;
            this.btnClearPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClearPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearPath.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPath.Image")));
            this.btnClearPath.Location = new System.Drawing.Point(655, 20);
            this.btnClearPath.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearPath.Name = "btnClearPath";
            this.btnClearPath.Size = new System.Drawing.Size(23, 26);
            this.btnClearPath.TabIndex = 18;
            this.btnClearPath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearPath.UseVisualStyleBackColor = false;
            this.btnClearPath.Click += new System.EventHandler(this.btnClearPath_Click);
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
            this.btnLoadNames.Location = new System.Drawing.Point(43, 51);
            this.btnLoadNames.Name = "btnLoadNames";
            this.btnLoadNames.Size = new System.Drawing.Size(37, 40);
            this.btnLoadNames.TabIndex = 19;
            this.btnLoadNames.UseVisualStyleBackColor = false;
            this.btnLoadNames.Click += new System.EventHandler(this.btnLoadNames_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(86, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAll.Image")));
            this.btnClearAll.Location = new System.Drawing.Point(131, 51);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(38, 40);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // DGVXmlReader
            // 
            this.DGVXmlReader.AllowUserToAddRows = false;
            this.DGVXmlReader.AllowUserToDeleteRows = false;
            this.DGVXmlReader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGVXmlReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVXmlReader.Location = new System.Drawing.Point(12, 189);
            this.DGVXmlReader.Name = "DGVXmlReader";
            this.DGVXmlReader.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVXmlReader.Size = new System.Drawing.Size(757, 517);
            this.DGVXmlReader.TabIndex = 23;
            // 
            // PanelTopXMLReader
            // 
            this.PanelTopXMLReader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTopXMLReader.Controls.Add(this.lbHeader);
            this.PanelTopXMLReader.Controls.Add(this.rtUniqueValues);
            this.PanelTopXMLReader.Controls.Add(this.btnGetPath);
            this.PanelTopXMLReader.Controls.Add(this.btnCheckUniqueValues);
            this.PanelTopXMLReader.Controls.Add(this.lblDirectoryPath);
            this.PanelTopXMLReader.Controls.Add(this.txtDirectoryPath);
            this.PanelTopXMLReader.Controls.Add(this.lbSubfoldersPath);
            this.PanelTopXMLReader.Controls.Add(this.btnClearPath);
            this.PanelTopXMLReader.Controls.Add(this.btnClearAll);
            this.PanelTopXMLReader.Controls.Add(this.btnLoadNames);
            this.PanelTopXMLReader.Controls.Add(this.btnClear);
            this.PanelTopXMLReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopXMLReader.Location = new System.Drawing.Point(0, 0);
            this.PanelTopXMLReader.Name = "PanelTopXMLReader";
            this.PanelTopXMLReader.Size = new System.Drawing.Size(992, 167);
            this.PanelTopXMLReader.TabIndex = 25;
            // 
            // lbHeader
            // 
            this.lbHeader.FormattingEnabled = true;
            this.lbHeader.Location = new System.Drawing.Point(775, 95);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(98, 69);
            this.lbHeader.TabIndex = 28;
            this.lbHeader.Click += new System.EventHandler(this.lbHeader_Click);
            // 
            // btnGetPath
            // 
            this.btnGetPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetPath.FlatAppearance.BorderSize = 0;
            this.btnGetPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetPath.ForeColor = System.Drawing.Color.White;
            this.btnGetPath.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPath.Image")));
            this.btnGetPath.Location = new System.Drawing.Point(3, 51);
            this.btnGetPath.Name = "btnGetPath";
            this.btnGetPath.Size = new System.Drawing.Size(38, 40);
            this.btnGetPath.TabIndex = 27;
            this.btnGetPath.UseVisualStyleBackColor = false;
            this.btnGetPath.Click += new System.EventHandler(this.btnGetPath_Click);
            // 
            // btnCheckUniqueValues
            // 
            this.btnCheckUniqueValues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckUniqueValues.FlatAppearance.BorderSize = 0;
            this.btnCheckUniqueValues.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckUniqueValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUniqueValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheckUniqueValues.ForeColor = System.Drawing.Color.White;
            this.btnCheckUniqueValues.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckUniqueValues.Image")));
            this.btnCheckUniqueValues.Location = new System.Drawing.Point(775, 51);
            this.btnCheckUniqueValues.Name = "btnCheckUniqueValues";
            this.btnCheckUniqueValues.Size = new System.Drawing.Size(38, 40);
            this.btnCheckUniqueValues.TabIndex = 23;
            this.btnCheckUniqueValues.UseVisualStyleBackColor = false;
            this.btnCheckUniqueValues.Click += new System.EventHandler(this.btnCheckUniqueValues_Click);
            // 
            // lbSubfoldersPath
            // 
            this.lbSubfoldersPath.FormattingEnabled = true;
            this.lbSubfoldersPath.Location = new System.Drawing.Point(5, 95);
            this.lbSubfoldersPath.Name = "lbSubfoldersPath";
            this.lbSubfoldersPath.Size = new System.Drawing.Size(764, 69);
            this.lbSubfoldersPath.TabIndex = 26;
            this.lbSubfoldersPath.Click += new System.EventHandler(this.lbSubfoldersPath_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(8, 172);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(38, 13);
            this.lblCounter.TabIndex = 27;
            this.lblCounter.Text = "Count:";
            // 
            // lblCounterValue
            // 
            this.lblCounterValue.AutoSize = true;
            this.lblCounterValue.Location = new System.Drawing.Point(45, 172);
            this.lblCounterValue.Name = "lblCounterValue";
            this.lblCounterValue.Size = new System.Drawing.Size(13, 13);
            this.lblCounterValue.TabIndex = 28;
            this.lblCounterValue.Text = "0";
            // 
            // rtUniqueValues
            // 
            this.rtUniqueValues.Location = new System.Drawing.Point(879, 95);
            this.rtUniqueValues.Name = "rtUniqueValues";
            this.rtUniqueValues.ReadOnly = true;
            this.rtUniqueValues.ShowSelectionMargin = true;
            this.rtUniqueValues.Size = new System.Drawing.Size(98, 69);
            this.rtUniqueValues.TabIndex = 29;
            this.rtUniqueValues.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // XmlReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 718);
            this.Controls.Add(this.lblCounterValue);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.DGVXmlReader);
            this.Controls.Add(this.PanelTopXMLReader);
            this.Name = "XmlReader";
            this.Text = "XmlReader";
            ((System.ComponentModel.ISupportInitialize)(this.DGVXmlReader)).EndInit();
            this.PanelTopXMLReader.ResumeLayout(false);
            this.PanelTopXMLReader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.Button btnClearPath;
        private System.Windows.Forms.Button btnLoadNames;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridView DGVXmlReader;
        private System.Windows.Forms.Panel PanelTopXMLReader;
        private System.Windows.Forms.Button btnCheckUniqueValues;
        private System.Windows.Forms.ListBox lbSubfoldersPath;
        private System.Windows.Forms.Button btnGetPath;
        private System.Windows.Forms.ListBox lbHeader;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblCounterValue;
        private System.Windows.Forms.RichTextBox rtUniqueValues;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}