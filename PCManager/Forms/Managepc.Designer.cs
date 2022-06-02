namespace PCManager.Forms
{
    partial class Managepc
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
            this.btnSetWiredAutoconfig = new System.Windows.Forms.Button();
            this.btnPowerSupply = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnPowershell = new System.Windows.Forms.Button();
            this.btnCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetWiredAutoconfig
            // 
            this.btnSetWiredAutoconfig.BackColor = System.Drawing.Color.IndianRed;
            this.btnSetWiredAutoconfig.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetWiredAutoconfig.Location = new System.Drawing.Point(28, 211);
            this.btnSetWiredAutoconfig.Name = "btnSetWiredAutoconfig";
            this.btnSetWiredAutoconfig.Size = new System.Drawing.Size(132, 40);
            this.btnSetWiredAutoconfig.TabIndex = 25;
            this.btnSetWiredAutoconfig.Text = "Uwierzytelnianie";
            this.btnSetWiredAutoconfig.UseVisualStyleBackColor = false;
            this.btnSetWiredAutoconfig.Click += new System.EventHandler(this.btnSetWiredAutoconfig_Click);
            // 
            // btnPowerSupply
            // 
            this.btnPowerSupply.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPowerSupply.Location = new System.Drawing.Point(28, 165);
            this.btnPowerSupply.Name = "btnPowerSupply";
            this.btnPowerSupply.Size = new System.Drawing.Size(132, 40);
            this.btnPowerSupply.TabIndex = 24;
            this.btnPowerSupply.Text = "Opcje Zasilania";
            this.btnPowerSupply.UseVisualStyleBackColor = true;
            this.btnPowerSupply.Click += new System.EventHandler(this.btnPowerSupply_Click);
            // 
            // btnServices
            // 
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnServices.Location = new System.Drawing.Point(28, 119);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(132, 40);
            this.btnServices.TabIndex = 23;
            this.btnServices.Text = "Usługi";
            this.btnServices.UseVisualStyleBackColor = true;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnPowershell
            // 
            this.btnPowershell.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPowershell.Location = new System.Drawing.Point(28, 73);
            this.btnPowershell.Name = "btnPowershell";
            this.btnPowershell.Size = new System.Drawing.Size(132, 40);
            this.btnPowershell.TabIndex = 22;
            this.btnPowershell.Text = "Włącz Powershell";
            this.btnPowershell.UseVisualStyleBackColor = true;
            this.btnPowershell.Click += new System.EventHandler(this.btnPowershell_Click);
            // 
            // btnCmd
            // 
            this.btnCmd.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCmd.Location = new System.Drawing.Point(28, 27);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(132, 40);
            this.btnCmd.TabIndex = 21;
            this.btnCmd.Text = "Włącz wiersz poleceń";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // Managepc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetWiredAutoconfig);
            this.Controls.Add(this.btnPowerSupply);
            this.Controls.Add(this.btnServices);
            this.Controls.Add(this.btnPowershell);
            this.Controls.Add(this.btnCmd);
            this.Name = "Managepc";
            this.Text = "Managepc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetWiredAutoconfig;
        private System.Windows.Forms.Button btnPowerSupply;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnPowershell;
        private System.Windows.Forms.Button btnCmd;
    }
}