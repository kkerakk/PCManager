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
            this.FLPQuickShutdown = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnShutdownInstant = new System.Windows.Forms.Button();
            this.btnShutdown5min = new System.Windows.Forms.Button();
            this.btnShutdown10min = new System.Windows.Forms.Button();
            this.btnShutdown15min = new System.Windows.Forms.Button();
            this.btnShutdown30min = new System.Windows.Forms.Button();
            this.btnShutdown60min = new System.Windows.Forms.Button();
            this.btnShutdown120min = new System.Windows.Forms.Button();
            this.btnShutdown180min = new System.Windows.Forms.Button();
            this.btnShutdown240min = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.rbHibernate = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.FLPQuickShutdown.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelShutdown
            // 
            this.btnCancelShutdown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelShutdown.Location = new System.Drawing.Point(271, 217);
            this.btnCancelShutdown.Name = "btnCancelShutdown";
            this.btnCancelShutdown.Size = new System.Drawing.Size(105, 40);
            this.btnCancelShutdown.TabIndex = 9;
            this.btnCancelShutdown.Text = "Cancel";
            this.btnCancelShutdown.UseVisualStyleBackColor = true;
            this.btnCancelShutdown.Click += new System.EventHandler(this.btnCancelShutdown_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Chartreuse;
            this.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown.Location = new System.Drawing.Point(147, 217);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(105, 40);
            this.btnShutdown.TabIndex = 10;
            this.btnShutdown.Text = "Start";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // txtShutdownTime
            // 
            this.txtShutdownTime.Location = new System.Drawing.Point(147, 182);
            this.txtShutdownTime.MaxLength = 4;
            this.txtShutdownTime.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtShutdownTime.Name = "txtShutdownTime";
            this.txtShutdownTime.Size = new System.Drawing.Size(229, 20);
            this.txtShutdownTime.TabIndex = 11;
            this.txtShutdownTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShutdownTime_KeyPress);
            // 
            // FLPQuickShutdown
            // 
            this.FLPQuickShutdown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FLPQuickShutdown.Controls.Add(this.panel1);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdownInstant);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown5min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown10min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown15min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown30min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown60min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown120min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown180min);
            this.FLPQuickShutdown.Controls.Add(this.btnShutdown240min);
            this.FLPQuickShutdown.Dock = System.Windows.Forms.DockStyle.Right;
            this.FLPQuickShutdown.Location = new System.Drawing.Point(533, 0);
            this.FLPQuickShutdown.Name = "FLPQuickShutdown";
            this.FLPQuickShutdown.Size = new System.Drawing.Size(150, 450);
            this.FLPQuickShutdown.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblActions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblActions
            // 
            this.lblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblActions.ForeColor = System.Drawing.Color.Black;
            this.lblActions.Location = new System.Drawing.Point(34, 9);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(81, 20);
            this.lblActions.TabIndex = 0;
            this.lblActions.Text = "Shutdown";
            // 
            // btnShutdownInstant
            // 
            this.btnShutdownInstant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdownInstant.FlatAppearance.BorderSize = 0;
            this.btnShutdownInstant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdownInstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdownInstant.ForeColor = System.Drawing.Color.Black;
            this.btnShutdownInstant.Location = new System.Drawing.Point(0, 35);
            this.btnShutdownInstant.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdownInstant.Name = "btnShutdownInstant";
            this.btnShutdownInstant.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdownInstant.Size = new System.Drawing.Size(150, 30);
            this.btnShutdownInstant.TabIndex = 1;
            this.btnShutdownInstant.Text = "Now";
            this.btnShutdownInstant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdownInstant.UseVisualStyleBackColor = true;
            this.btnShutdownInstant.Click += new System.EventHandler(this.btnShutdownInstant_Click);
            // 
            // btnShutdown5min
            // 
            this.btnShutdown5min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown5min.FlatAppearance.BorderSize = 0;
            this.btnShutdown5min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown5min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown5min.Location = new System.Drawing.Point(0, 65);
            this.btnShutdown5min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown5min.Name = "btnShutdown5min";
            this.btnShutdown5min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown5min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown5min.TabIndex = 2;
            this.btnShutdown5min.Text = "in 5 minutes";
            this.btnShutdown5min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown5min.UseVisualStyleBackColor = true;
            this.btnShutdown5min.Click += new System.EventHandler(this.btnShutdown5min_Click);
            // 
            // btnShutdown10min
            // 
            this.btnShutdown10min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown10min.FlatAppearance.BorderSize = 0;
            this.btnShutdown10min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown10min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown10min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown10min.Location = new System.Drawing.Point(0, 95);
            this.btnShutdown10min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown10min.Name = "btnShutdown10min";
            this.btnShutdown10min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown10min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown10min.TabIndex = 3;
            this.btnShutdown10min.Text = "in 10 minutes";
            this.btnShutdown10min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown10min.UseVisualStyleBackColor = true;
            this.btnShutdown10min.Click += new System.EventHandler(this.btnShutdown10min_Click);
            // 
            // btnShutdown15min
            // 
            this.btnShutdown15min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown15min.FlatAppearance.BorderSize = 0;
            this.btnShutdown15min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown15min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown15min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown15min.Location = new System.Drawing.Point(0, 125);
            this.btnShutdown15min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown15min.Name = "btnShutdown15min";
            this.btnShutdown15min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown15min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown15min.TabIndex = 4;
            this.btnShutdown15min.Text = "in 15 minutes";
            this.btnShutdown15min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown15min.UseVisualStyleBackColor = true;
            this.btnShutdown15min.Click += new System.EventHandler(this.btnShutdown15min_Click);
            // 
            // btnShutdown30min
            // 
            this.btnShutdown30min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown30min.FlatAppearance.BorderSize = 0;
            this.btnShutdown30min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown30min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown30min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown30min.Location = new System.Drawing.Point(0, 155);
            this.btnShutdown30min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown30min.Name = "btnShutdown30min";
            this.btnShutdown30min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown30min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown30min.TabIndex = 5;
            this.btnShutdown30min.Text = "in 30 minutes";
            this.btnShutdown30min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown30min.UseVisualStyleBackColor = true;
            this.btnShutdown30min.Click += new System.EventHandler(this.btnShutdown30min_Click);
            // 
            // btnShutdown60min
            // 
            this.btnShutdown60min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown60min.FlatAppearance.BorderSize = 0;
            this.btnShutdown60min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown60min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown60min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown60min.Location = new System.Drawing.Point(0, 185);
            this.btnShutdown60min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown60min.Name = "btnShutdown60min";
            this.btnShutdown60min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown60min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown60min.TabIndex = 6;
            this.btnShutdown60min.Text = "in 1 hour";
            this.btnShutdown60min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown60min.UseVisualStyleBackColor = true;
            this.btnShutdown60min.Click += new System.EventHandler(this.btnShutdown60min_Click);
            // 
            // btnShutdown120min
            // 
            this.btnShutdown120min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown120min.FlatAppearance.BorderSize = 0;
            this.btnShutdown120min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown120min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown120min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown120min.Location = new System.Drawing.Point(0, 215);
            this.btnShutdown120min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown120min.Name = "btnShutdown120min";
            this.btnShutdown120min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown120min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown120min.TabIndex = 7;
            this.btnShutdown120min.Text = "in 2 hour";
            this.btnShutdown120min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown120min.UseVisualStyleBackColor = true;
            this.btnShutdown120min.Click += new System.EventHandler(this.btnShutdown120min_Click);
            // 
            // btnShutdown180min
            // 
            this.btnShutdown180min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown180min.FlatAppearance.BorderSize = 0;
            this.btnShutdown180min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown180min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown180min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown180min.Location = new System.Drawing.Point(0, 245);
            this.btnShutdown180min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown180min.Name = "btnShutdown180min";
            this.btnShutdown180min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown180min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown180min.TabIndex = 8;
            this.btnShutdown180min.Text = "in 3 hour";
            this.btnShutdown180min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown180min.UseVisualStyleBackColor = true;
            this.btnShutdown180min.Click += new System.EventHandler(this.btnShutdown180min_Click);
            // 
            // btnShutdown240min
            // 
            this.btnShutdown240min.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShutdown240min.FlatAppearance.BorderSize = 0;
            this.btnShutdown240min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown240min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShutdown240min.ForeColor = System.Drawing.Color.Black;
            this.btnShutdown240min.Location = new System.Drawing.Point(0, 275);
            this.btnShutdown240min.Margin = new System.Windows.Forms.Padding(0);
            this.btnShutdown240min.Name = "btnShutdown240min";
            this.btnShutdown240min.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnShutdown240min.Size = new System.Drawing.Size(150, 30);
            this.btnShutdown240min.TabIndex = 9;
            this.btnShutdown240min.Text = "in 4 hour";
            this.btnShutdown240min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShutdown240min.UseVisualStyleBackColor = true;
            this.btnShutdown240min.Click += new System.EventHandler(this.btnShutdown240min_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.rbLogOff);
            this.groupBoxActions.Controls.Add(this.rbHibernate);
            this.groupBoxActions.Controls.Add(this.rbRestart);
            this.groupBoxActions.Controls.Add(this.rbShutdown);
            this.groupBoxActions.Location = new System.Drawing.Point(147, 35);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(229, 120);
            this.groupBoxActions.TabIndex = 13;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(7, 89);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(60, 17);
            this.rbLogOff.TabIndex = 3;
            this.rbLogOff.Text = "Log Off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            this.rbLogOff.CheckedChanged += new System.EventHandler(this.rbLogOff_CheckedChanged);
            // 
            // rbHibernate
            // 
            this.rbHibernate.AutoSize = true;
            this.rbHibernate.Location = new System.Drawing.Point(7, 66);
            this.rbHibernate.Name = "rbHibernate";
            this.rbHibernate.Size = new System.Drawing.Size(71, 17);
            this.rbHibernate.TabIndex = 2;
            this.rbHibernate.Text = "Hibernate";
            this.rbHibernate.UseVisualStyleBackColor = true;
            this.rbHibernate.CheckedChanged += new System.EventHandler(this.rbHibernate_CheckedChanged);
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(7, 43);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(59, 17);
            this.rbRestart.TabIndex = 1;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            this.rbRestart.CheckedChanged += new System.EventHandler(this.rbRestart_CheckedChanged);
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(7, 20);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(73, 17);
            this.rbShutdown.TabIndex = 0;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            this.rbShutdown.CheckedChanged += new System.EventHandler(this.rbShutdown_CheckedChanged);
            // 
            // ShutdownComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.FLPQuickShutdown);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.txtShutdownTime);
            this.Controls.Add(this.btnCancelShutdown);
            this.Name = "ShutdownComputer";
            this.Text = "ShutdownComputer";
            this.FLPQuickShutdown.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelShutdown;
        private System.Windows.Forms.Button btnShutdown;
        public System.Windows.Forms.TextBox txtShutdownTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShutdownInstant;
        private System.Windows.Forms.Button btnShutdown5min;
        private System.Windows.Forms.Button btnShutdown10min;
        private System.Windows.Forms.Button btnShutdown15min;
        private System.Windows.Forms.Button btnShutdown30min;
        private System.Windows.Forms.Button btnShutdown60min;
        private System.Windows.Forms.Button btnShutdown120min;
        private System.Windows.Forms.Button btnShutdown180min;
        private System.Windows.Forms.Button btnShutdown240min;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.RadioButton rbHibernate;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.FlowLayoutPanel FLPQuickShutdown;
    }
}