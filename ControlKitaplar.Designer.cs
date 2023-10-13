namespace ekos
{
    partial class ControlKitaplar
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
            this.Gorsel = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KitapId = new System.Windows.Forms.Label();
            this.BtnKitapAktar = new System.Windows.Forms.Button();
            this.KitapRaf = new System.Windows.Forms.Label();
            this.KitapYayinevi = new System.Windows.Forms.Label();
            this.KitapYazar = new System.Windows.Forms.Label();
            this.KitapAd = new System.Windows.Forms.Label();
            this.OgrId = new System.Windows.Forms.Label();
            this.OgrAd = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // Gorsel
            // 
            this.Gorsel.BackColor = System.Drawing.Color.Gainsboro;
            this.Gorsel.Image = global::ekos.Properties.Resources.ornekKitapGorsel;
            this.Gorsel.Location = new System.Drawing.Point(22, 15);
            this.Gorsel.Name = "Gorsel";
            this.Gorsel.Size = new System.Drawing.Size(85, 96);
            this.Gorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gorsel.TabIndex = 0;
            this.Gorsel.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(-6, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 22);
            this.panel1.TabIndex = 6;
            // 
            // KitapId
            // 
            this.KitapId.AutoSize = true;
            this.KitapId.Location = new System.Drawing.Point(552, 96);
            this.KitapId.Name = "KitapId";
            this.KitapId.Size = new System.Drawing.Size(18, 16);
            this.KitapId.TabIndex = 12;
            this.KitapId.Text = "id";
            this.KitapId.Visible = false;
            // 
            // BtnKitapAktar
            // 
            this.BtnKitapAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnKitapAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapAktar.FlatAppearance.BorderSize = 0;
            this.BtnKitapAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKitapAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapAktar.ForeColor = System.Drawing.Color.White;
            this.BtnKitapAktar.Location = new System.Drawing.Point(555, 34);
            this.BtnKitapAktar.Name = "BtnKitapAktar";
            this.BtnKitapAktar.Size = new System.Drawing.Size(145, 52);
            this.BtnKitapAktar.TabIndex = 11;
            this.BtnKitapAktar.Text = "AKTAR";
            this.BtnKitapAktar.UseVisualStyleBackColor = false;
            this.BtnKitapAktar.Click += new System.EventHandler(this.BtnKitapAktar_Click);
            // 
            // KitapRaf
            // 
            this.KitapRaf.AutoSize = true;
            this.KitapRaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KitapRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapRaf.ForeColor = System.Drawing.Color.White;
            this.KitapRaf.Location = new System.Drawing.Point(136, 93);
            this.KitapRaf.Name = "KitapRaf";
            this.KitapRaf.Size = new System.Drawing.Size(72, 20);
            this.KitapRaf.TabIndex = 8;
            this.KitapRaf.Text = "Rafta Mı";
            // 
            // KitapYayinevi
            // 
            this.KitapYayinevi.AutoEllipsis = true;
            this.KitapYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapYayinevi.Location = new System.Drawing.Point(136, 68);
            this.KitapYayinevi.Name = "KitapYayinevi";
            this.KitapYayinevi.Size = new System.Drawing.Size(395, 25);
            this.KitapYayinevi.TabIndex = 9;
            this.KitapYayinevi.Text = "Yayınevi Adı";
            // 
            // KitapYazar
            // 
            this.KitapYazar.AutoEllipsis = true;
            this.KitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapYazar.Location = new System.Drawing.Point(136, 43);
            this.KitapYazar.Name = "KitapYazar";
            this.KitapYazar.Size = new System.Drawing.Size(395, 23);
            this.KitapYazar.TabIndex = 10;
            this.KitapYazar.Text = "Yazar Adı";
            // 
            // KitapAd
            // 
            this.KitapAd.AutoEllipsis = true;
            this.KitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapAd.Location = new System.Drawing.Point(134, 11);
            this.KitapAd.Name = "KitapAd";
            this.KitapAd.Size = new System.Drawing.Size(397, 32);
            this.KitapAd.TabIndex = 7;
            this.KitapAd.Text = "Kitap Adı";
            // 
            // OgrId
            // 
            this.OgrId.AutoSize = true;
            this.OgrId.Location = new System.Drawing.Point(491, 34);
            this.OgrId.Name = "OgrId";
            this.OgrId.Size = new System.Drawing.Size(40, 16);
            this.OgrId.TabIndex = 13;
            this.OgrId.Text = "OgrId";
            this.OgrId.Visible = false;
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Location = new System.Drawing.Point(491, 53);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(40, 16);
            this.OgrAd.TabIndex = 13;
            this.OgrAd.Text = "OgrId";
            this.OgrAd.Visible = false;
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSize = true;
            this.OgrNo.Location = new System.Drawing.Point(491, 69);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(40, 16);
            this.OgrNo.TabIndex = 13;
            this.OgrNo.Text = "OgrId";
            this.OgrNo.Visible = false;
            // 
            // ControlKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrAd);
            this.Controls.Add(this.OgrId);
            this.Controls.Add(this.KitapId);
            this.Controls.Add(this.BtnKitapAktar);
            this.Controls.Add(this.KitapRaf);
            this.Controls.Add(this.KitapYayinevi);
            this.Controls.Add(this.KitapYazar);
            this.Controls.Add(this.KitapAd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gorsel);
            this.Name = "ControlKitaplar";
            this.Size = new System.Drawing.Size(726, 127);
            ((System.ComponentModel.ISupportInitialize)(this.Gorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Gorsel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KitapRaf;
        private System.Windows.Forms.Label KitapYayinevi;
        private System.Windows.Forms.Label KitapYazar;
        private System.Windows.Forms.Label KitapAd;
        public System.Windows.Forms.Label OgrId;
        public System.Windows.Forms.Label OgrAd;
        public System.Windows.Forms.Label OgrNo;
        public System.Windows.Forms.Button BtnKitapAktar;
        public System.Windows.Forms.Label KitapId;
    }
}
