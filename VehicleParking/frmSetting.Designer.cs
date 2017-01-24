namespace VehicleParking
{
    partial class frmSetting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogo = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVehicle);
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 661);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setting";
            // 
            // btnVehicle
            // 
            this.btnVehicle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicle.Location = new System.Drawing.Point(39, 133);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(186, 47);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            // 
            // btnLogo
            // 
            this.btnLogo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.Location = new System.Drawing.Point(39, 80);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(186, 47);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "Logo";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 661);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogo);
            this.tabControl1.Controls.Add(this.tabVehicle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogo
            // 
            this.tabLogo.Location = new System.Drawing.Point(4, 22);
            this.tabLogo.Name = "tabLogo";
            this.tabLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogo.Size = new System.Drawing.Size(981, 635);
            this.tabLogo.TabIndex = 0;
            this.tabLogo.Text = "Logo";
            this.tabLogo.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Location = new System.Drawing.Point(4, 22);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicle.Size = new System.Drawing.Size(981, 635);
            this.tabVehicle.TabIndex = 1;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VehicleParking.Properties.Resources.Settings_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogo;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}