namespace CarRace
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBut
            // 
            this.StartBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartBut.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartBut.Location = new System.Drawing.Point(722, 281);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(75, 77);
            this.StartBut.TabIndex = 0;
            this.StartBut.Text = "Start";
            this.StartBut.UseVisualStyleBackColor = false;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBut.BackColor = System.Drawing.Color.Maroon;
            this.exitBut.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBut.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.exitBut.Location = new System.Drawing.Point(722, 392);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(75, 74);
            this.exitBut.TabIndex = 1;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = false;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Graphics_pro.Properties.Resources.startlogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 478);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.StartBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBut;
        private System.Windows.Forms.Button exitBut;
    }
}