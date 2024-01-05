namespace PCManager.Forms
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAddedTime = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.tbAddedTime = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(11, 29);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(34, 20);
            this.tbID.TabIndex = 0;
            this.tbID.Text = "1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblAddedTime
            // 
            this.lblAddedTime.AutoSize = true;
            this.lblAddedTime.Location = new System.Drawing.Point(58, 13);
            this.lblAddedTime.Name = "lblAddedTime";
            this.lblAddedTime.Size = new System.Drawing.Size(64, 13);
            this.lblAddedTime.TabIndex = 3;
            this.lblAddedTime.Text = "Added Time";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(11, 101);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(695, 141);
            this.rtbContent.TabIndex = 4;
            this.rtbContent.Text = "";
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.Items.AddRange(new object[] {
            "Jasper",
            "Luźne"});
            this.lbCategory.Location = new System.Drawing.Point(156, 29);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(120, 43);
            this.lbCategory.TabIndex = 5;
            // 
            // tbAddedTime
            // 
            this.tbAddedTime.Location = new System.Drawing.Point(61, 29);
            this.tbAddedTime.Name = "tbAddedTime";
            this.tbAddedTime.Size = new System.Drawing.Size(78, 20);
            this.tbAddedTime.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(153, 13);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(14, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.Image")));
            this.btnLoadData.Location = new System.Drawing.Point(61, 55);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(38, 40);
            this.btnLoadData.TabIndex = 18;
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(11, 248);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.Size = new System.Drawing.Size(695, 150);
            this.dgvNotes.TabIndex = 19;
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbAddedTime);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.lblAddedTime);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "Notes";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddedTime;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.TextBox tbAddedTime;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvNotes;
    }
}