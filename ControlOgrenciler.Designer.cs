namespace ekos
{
    partial class ControlOgrenciler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OgrAdSoyad = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            this.OgrBolum = new System.Windows.Forms.Label();
            this.OgrSinif = new System.Windows.Forms.Label();
            this.BtnAktar = new System.Windows.Forms.Button();
            this.OgrId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.circularPicture1 = new ekos.circularPicture();
            this.KitapId = new System.Windows.Forms.Label();
            this.KitapAd = new System.Windows.Forms.Label();
            this.YazarAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrAdSoyad
            // 
            this.OgrAdSoyad.AutoEllipsis = true;
            this.OgrAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrAdSoyad.Location = new System.Drawing.Point(147, 13);
            this.OgrAdSoyad.Name = "OgrAdSoyad";
            this.OgrAdSoyad.Size = new System.Drawing.Size(397, 32);
            this.OgrAdSoyad.TabIndex = 1;
            this.OgrAdSoyad.Text = "Ad-Soyad";
            // 
            // OgrNo
            // 
            this.OgrNo.AutoEllipsis = true;
            this.OgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrNo.Location = new System.Drawing.Point(149, 45);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(395, 23);
            this.OgrNo.TabIndex = 2;
            this.OgrNo.Text = "Öğrenci No";
            // 
            // OgrBolum
            // 
            this.OgrBolum.AutoEllipsis = true;
            this.OgrBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrBolum.Location = new System.Drawing.Point(149, 70);
            this.OgrBolum.Name = "OgrBolum";
            this.OgrBolum.Size = new System.Drawing.Size(395, 25);
            this.OgrBolum.TabIndex = 2;
            this.OgrBolum.Text = "Bölümü";
            // 
            // OgrSinif
            // 
            this.OgrSinif.AutoEllipsis = true;
            this.OgrSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrSinif.Location = new System.Drawing.Point(149, 95);
            this.OgrSinif.Name = "OgrSinif";
            this.OgrSinif.Size = new System.Drawing.Size(395, 20);
            this.OgrSinif.TabIndex = 2;
            this.OgrSinif.Text = "Sınıf No";
            // 
            // BtnAktar
            // 
            this.BtnAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAktar.FlatAppearance.BorderSize = 0;
            this.BtnAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAktar.ForeColor = System.Drawing.Color.White;
            this.BtnAktar.Location = new System.Drawing.Point(560, 36);
            this.BtnAktar.Name = "BtnAktar";
            this.BtnAktar.Size = new System.Drawing.Size(145, 52);
            this.BtnAktar.TabIndex = 3;
            this.BtnAktar.Text = "AKTAR";
            this.BtnAktar.UseVisualStyleBackColor = false;
            this.BtnAktar.Click += new System.EventHandler(this.BtnAktar_Click);
            // 
            // OgrId
            // 
            this.OgrId.AutoSize = true;
            this.OgrId.Location = new System.Drawing.Point(557, 98);
            this.OgrId.Name = "OgrId";
            this.OgrId.Size = new System.Drawing.Size(18, 16);
            this.OgrId.TabIndex = 4;
            this.OgrId.Text = "id";
            this.OgrId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(-1, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 100);
            this.panel1.TabIndex = 5;
            // 
            // circularPicture1
            // 
            this.circularPicture1.Image = global::ekos.Properties.Resources.ornekOgrGorsel;
            this.circularPicture1.Location = new System.Drawing.Point(21, 13);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(105, 102);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circularPicture1.TabIndex = 6;
            this.circularPicture1.TabStop = false;
            // 
            // KitapId
            // 
            this.KitapId.AutoSize = true;
            this.KitapId.Location = new System.Drawing.Point(432, 28);
            this.KitapId.Name = "KitapId";
            this.KitapId.Size = new System.Drawing.Size(44, 16);
            this.KitapId.TabIndex = 7;
            this.KitapId.Text = "label1";
            this.KitapId.Visible = false;
            // 
            // KitapAd
            // 
            this.KitapAd.AutoSize = true;
            this.KitapAd.Location = new System.Drawing.Point(432, 48);
            this.KitapAd.Name = "KitapAd";
            this.KitapAd.Size = new System.Drawing.Size(44, 16);
            this.KitapAd.TabIndex = 7;
            this.KitapAd.Text = "label1";
            this.KitapAd.Visible = false;
            // 
            // YazarAd
            // 
            this.YazarAd.AutoSize = true;
            this.YazarAd.Location = new System.Drawing.Point(432, 68);
            this.YazarAd.Name = "YazarAd";
            this.YazarAd.Size = new System.Drawing.Size(44, 16);
            this.YazarAd.TabIndex = 7;
            this.YazarAd.Text = "label1";
            this.YazarAd.Visible = false;
            // 
            // ControlOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.YazarAd);
            this.Controls.Add(this.KitapAd);
            this.Controls.Add(this.KitapId);
            this.Controls.Add(this.circularPicture1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OgrId);
            this.Controls.Add(this.BtnAktar);
            this.Controls.Add(this.OgrSinif);
            this.Controls.Add(this.OgrBolum);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrAdSoyad);
            this.Name = "ControlOgrenciler";
            this.Size = new System.Drawing.Size(726, 127);
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OgrAdSoyad;
        private System.Windows.Forms.Label OgrNo;
        private System.Windows.Forms.Label OgrBolum;
        private System.Windows.Forms.Label OgrSinif;
        private System.Windows.Forms.Button BtnAktar;
        private System.Windows.Forms.Label OgrId;
        private System.Windows.Forms.Panel panel1;
        private circularPicture circularPicture1;
        public System.Windows.Forms.Label KitapId;
        public System.Windows.Forms.Label KitapAd;
        public System.Windows.Forms.Label YazarAd;
    }
}
