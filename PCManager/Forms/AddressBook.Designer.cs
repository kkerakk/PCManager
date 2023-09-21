namespace PCManager.Forms
{
    partial class AddressBook
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
            this.dgvAddressBook = new System.Windows.Forms.DataGridView();
            this.NazwiskoImie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTel_kom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCopyButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddressBook
            // 
            this.dgvAddressBook.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAddressBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwiskoImie,
            this.NrTel,
            this.NrTel_kom,
            this.Email,
            this.EmailCopyButton});
            this.dgvAddressBook.Location = new System.Drawing.Point(12, 12);
            this.dgvAddressBook.Name = "dgvAddressBook";
            this.dgvAddressBook.Size = new System.Drawing.Size(673, 349);
            this.dgvAddressBook.TabIndex = 0;
            // 
            // NazwiskoImie
            // 
            this.NazwiskoImie.HeaderText = "NazwiskoImie";
            this.NazwiskoImie.Name = "NazwiskoImie";
            // 
            // NrTel
            // 
            this.NrTel.HeaderText = "NrTel";
            this.NrTel.Name = "NrTel";
            // 
            // NrTel_kom
            // 
            this.NrTel_kom.HeaderText = "NrTel_kom";
            this.NrTel_kom.Name = "NrTel_kom";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // EmailCopyButton
            // 
            this.EmailCopyButton.HeaderText = "Copy Email";
            this.EmailCopyButton.Name = "EmailCopyButton";
            this.EmailCopyButton.ReadOnly = true;
            this.EmailCopyButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmailCopyButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(538, 385);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(147, 56);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 385);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 56);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 553);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.dgvAddressBook);
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddressBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoImie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTel_kom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewButtonColumn EmailCopyButton;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoad;
    }
}