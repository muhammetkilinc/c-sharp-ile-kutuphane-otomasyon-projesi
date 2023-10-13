namespace ekos
{
    partial class FrmYayineviEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYayineviEkle));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtYazarAra = new System.Windows.Forms.TextBox();
            this.YazarListele = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYazarAd = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazarListele)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(812, 3);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtYazarAra);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(367, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 45);
            this.panel3.TabIndex = 16;
            // 
            // TxtYazarAra
            // 
            this.TxtYazarAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtYazarAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYazarAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtYazarAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarAra.ForeColor = System.Drawing.Color.White;
            this.TxtYazarAra.Location = new System.Drawing.Point(0, 0);
            this.TxtYazarAra.Name = "TxtYazarAra";
            this.TxtYazarAra.Size = new System.Drawing.Size(812, 29);
            this.TxtYazarAra.TabIndex = 1;
            this.TxtYazarAra.Click += new System.EventHandler(this.TxtYazarAra_Click);
            this.TxtYazarAra.TextChanged += new System.EventHandler(this.TxtYazarAra_TextChanged);
            // 
            // YazarListele
            // 
            this.YazarListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YazarListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.YazarListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YazarListele.Location = new System.Drawing.Point(367, 96);
            this.YazarListele.Name = "YazarListele";
            this.YazarListele.RowHeadersWidth = 51;
            this.YazarListele.RowTemplate.Height = 24;
            this.YazarListele.Size = new System.Drawing.Size(812, 466);
            this.YazarListele.TabIndex = 15;
            this.YazarListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YazarListele_CellClick);
            this.YazarListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YazarListele_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Doldurulması zorunlu alanlar.";
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Cyan;
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.FlatAppearance.BorderSize = 0;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnEkle.Location = new System.Drawing.Point(40, 344);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(284, 58);
            this.BtnEkle.TabIndex = 13;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres (İsteğe Bağlı)";
            // 
            // TxtAdres
            // 
            this.TxtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdres.ForeColor = System.Drawing.Color.White;
            this.TxtAdres.Location = new System.Drawing.Point(0, 25);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(284, 182);
            this.TxtAdres.TabIndex = 2;
            this.TxtAdres.TextChanged += new System.EventHandler(this.TxtYazarSoyad_TextChanged);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Gray;
            this.p2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p2.Location = new System.Drawing.Point(0, 213);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(284, 3);
            this.p2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtAdres);
            this.panel2.Controls.Add(this.p2);
            this.panel2.Location = new System.Drawing.Point(40, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 216);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yayınevi Adı *";
            // 
            // TxtYazarAd
            // 
            this.TxtYazarAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtYazarAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYazarAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarAd.ForeColor = System.Drawing.Color.White;
            this.TxtYazarAd.Location = new System.Drawing.Point(0, 24);
            this.TxtYazarAd.Name = "TxtYazarAd";
            this.TxtYazarAd.Size = new System.Drawing.Size(284, 27);
            this.TxtYazarAd.TabIndex = 1;
            this.TxtYazarAd.TextChanged += new System.EventHandler(this.TxtYazarAd_TextChanged);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Gray;
            this.p1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p1.Location = new System.Drawing.Point(0, 58);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(284, 3);
            this.p1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtYazarAd);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Location = new System.Drawing.Point(40, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 61);
            this.panel1.TabIndex = 9;
            // 
            // FrmYayineviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1218, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.YazarListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYayineviEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayınevi Ekle - EKOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmYayineviEkle_FormClosed);
            this.Load += new System.EventHandler(this.FrmYayineviEkle_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazarListele)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtYazarAra;
        private System.Windows.Forms.DataGridView YazarListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYazarAd;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel1;
    }
}