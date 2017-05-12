namespace CarRace
{
    partial class SelectCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.car1RDBTN = new System.Windows.Forms.RadioButton();
            this.car2RDBTN = new System.Windows.Forms.RadioButton();
            this.car3RDBTN = new System.Windows.Forms.RadioButton();
            this.GoBTN = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Graphics_pro.Properties.Resources.car1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Graphics_pro.Properties.Resources.car2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(277, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 134);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Graphics_pro.Properties.Resources.car3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(558, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 134);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // car1RDBTN
            // 
            this.car1RDBTN.AutoSize = true;
            this.car1RDBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.car1RDBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car1RDBTN.ForeColor = System.Drawing.Color.Maroon;
            this.car1RDBTN.Location = new System.Drawing.Point(12, 176);
            this.car1RDBTN.Name = "car1RDBTN";
            this.car1RDBTN.Size = new System.Drawing.Size(91, 28);
            this.car1RDBTN.TabIndex = 3;
            this.car1RDBTN.TabStop = true;
            this.car1RDBTN.Text = "Car # 1";
            this.car1RDBTN.UseVisualStyleBackColor = false;
            this.car1RDBTN.CheckedChanged += new System.EventHandler(this.car1RDBTN_CheckedChanged);
            // 
            // car2RDBTN
            // 
            this.car2RDBTN.AutoSize = true;
            this.car2RDBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.car2RDBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car2RDBTN.ForeColor = System.Drawing.Color.Maroon;
            this.car2RDBTN.Location = new System.Drawing.Point(277, 176);
            this.car2RDBTN.Name = "car2RDBTN";
            this.car2RDBTN.Size = new System.Drawing.Size(95, 28);
            this.car2RDBTN.TabIndex = 4;
            this.car2RDBTN.TabStop = true;
            this.car2RDBTN.Text = "Car # 2";
            this.car2RDBTN.UseVisualStyleBackColor = false;
            this.car2RDBTN.CheckedChanged += new System.EventHandler(this.car2RDBTN_CheckedChanged);
            // 
            // car3RDBTN
            // 
            this.car3RDBTN.AutoSize = true;
            this.car3RDBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.car3RDBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car3RDBTN.ForeColor = System.Drawing.Color.Maroon;
            this.car3RDBTN.Location = new System.Drawing.Point(558, 176);
            this.car3RDBTN.Name = "car3RDBTN";
            this.car3RDBTN.Size = new System.Drawing.Size(93, 28);
            this.car3RDBTN.TabIndex = 5;
            this.car3RDBTN.TabStop = true;
            this.car3RDBTN.Text = "Car # 3";
            this.car3RDBTN.UseVisualStyleBackColor = false;
            this.car3RDBTN.CheckedChanged += new System.EventHandler(this.car3RDBTN_CheckedChanged);
            // 
            // GoBTN
            // 
            this.GoBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBTN.BackColor = System.Drawing.Color.Maroon;
            this.GoBTN.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBTN.ForeColor = System.Drawing.Color.LimeGreen;
            this.GoBTN.Location = new System.Drawing.Point(646, 396);
            this.GoBTN.Name = "GoBTN";
            this.GoBTN.Size = new System.Drawing.Size(165, 73);
            this.GoBTN.TabIndex = 6;
            this.GoBTN.Text = "Go";
            this.GoBTN.UseVisualStyleBackColor = false;
            this.GoBTN.Click += new System.EventHandler(this.GoBTN_Click);
            // 
            // exitBut
            // 
            this.exitBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBut.BackColor = System.Drawing.Color.Maroon;
            this.exitBut.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBut.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.exitBut.Location = new System.Drawing.Point(817, 396);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(75, 73);
            this.exitBut.TabIndex = 7;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // SelectCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graphics_pro.Properties.Resources.selectlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 496);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.GoBTN);
            this.Controls.Add(this.car3RDBTN);
            this.Controls.Add(this.car2RDBTN);
            this.Controls.Add(this.car1RDBTN);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton car1RDBTN;
        private System.Windows.Forms.RadioButton car2RDBTN;
        private System.Windows.Forms.RadioButton car3RDBTN;
        private System.Windows.Forms.Button GoBTN;
        private System.Windows.Forms.Button exitBut;
    }
}