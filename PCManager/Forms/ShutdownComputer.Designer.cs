namespace PCManager.Forms
{
    partial class ShutdownComputer
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
            this.btnCancelShutdown = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.txtShutdownTime = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelShutdown
            // 
            this.btnCancelShutdown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelShutdown.Location = new System.Drawing.Point(12, 12);
            this.btnCancelShutdown.Name = "btnCancelShutdown";
            this.btnCancelShutdown.Size = new System.Drawing.Size(132, 40);
            this.btnCancelShutdown.TabIndex = 9;
            this.btnCancelShutdown.Text = "Anuluj wyłączanie komputera";
            this.btnCancelShutdown.UseVisualStyleBackColor = true;
            this.btnCancelShutdown.Click += new System.EventHandler(this.btnCancelShutdown_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.White;
            this.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShutdown.Location = new System.Drawing.Point(381, 143);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(43, 40);
            this.btnShutdown.TabIndex = 10;
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // txtShutdownTime
            // 
            this.txtShutdownTime.Location = new System.Drawing.Point(381, 189);
            this.txtShutdownTime.MaxLength = 4;
            this.txtShutdownTime.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtShutdownTime.Name = "txtShutdownTime";
            this.txtShutdownTime.Size = new System.Drawing.Size(43, 20);
            this.txtShutdownTime.TabIndex = 11;
            this.txtShutdownTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShutdownTime_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(347, 287);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(347, 100);
            this.txtTest.MaxLength = 4;
            this.txtTest.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(137, 20);
            this.txtTest.TabIndex = 13;
            // 
            // ShutdownComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.txtShutdownTime);
            this.Controls.Add(this.btnCancelShutdown);
            this.Name = "ShutdownComputer";
            this.Text = "ShutdownComputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelShutdown;
        private System.Windows.Forms.Button btnShutdown;
        public System.Windows.Forms.TextBox txtShutdownTime;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox txtTest;
    }
}