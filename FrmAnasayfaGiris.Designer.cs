namespace ekos
{
    partial class FrmAnasayfaGiris
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
            this.BtnNotlar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.BackColor = System.Drawing.Color.Aqua;
            this.BtnNotlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNotlar.FlatAppearance.BorderSize = 0;
            this.BtnNotlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnNotlar.ForeColor = System.Drawing.Color.Black;
            this.BtnNotlar.Location = new System.Drawing.Point(412, 261);
            this.BtnNotlar.Name = "BtnNotlar";
            this.BtnNotlar.Size = new System.Drawing.Size(243, 63);
            this.BtnNotlar.TabIndex = 1;
            this.BtnNotlar.Text = "Hızlı Notlara Git";
            this.BtnNotlar.UseVisualStyleBackColor = false;
            this.BtnNotlar.Click += new System.EventHandler(this.BtnNotlar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ekos.Properties.Resources.anasayfa;
            this.pictureBox1.Location = new System.Drawing.Point(298, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAnasayfaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 451);
            this.Controls.Add(this.BtnNotlar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnasayfaGiris";
            this.Text = "FrmAnasayfaGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnNotlar;
    }
}