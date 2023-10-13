namespace ekos
{
    partial class FrmYazarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYazarEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYazarAd = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtYazarSoyad = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYazarEposta = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtYazarHakkinda = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.Panel();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.YazarListele = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtYazarAra = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazarListele)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtYazarAd);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Location = new System.Drawing.Point(43, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Adı *";
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
            this.TxtYazarAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYazarAd_KeyPress);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtYazarSoyad);
            this.panel2.Controls.Add(this.p2);
            this.panel2.Location = new System.Drawing.Point(43, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 61);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Soyadı *";
            // 
            // TxtYazarSoyad
            // 
            this.TxtYazarSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtYazarSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYazarSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarSoyad.ForeColor = System.Drawing.Color.White;
            this.TxtYazarSoyad.Location = new System.Drawing.Point(0, 25);
            this.TxtYazarSoyad.Name = "TxtYazarSoyad";
            this.TxtYazarSoyad.Size = new System.Drawing.Size(284, 27);
            this.TxtYazarSoyad.TabIndex = 2;
            this.TxtYazarSoyad.TextChanged += new System.EventHandler(this.TxtYazarSoyad_TextChanged);
            this.TxtYazarSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtYazarAd_KeyPress);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Gray;
            this.p2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p2.Location = new System.Drawing.Point(0, 58);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(284, 3);
            this.p2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TxtYazarEposta);
            this.panel4.Controls.Add(this.p3);
            this.panel4.Location = new System.Drawing.Point(43, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 61);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-Posta (İsteğe Bağlı)";
            // 
            // TxtYazarEposta
            // 
            this.TxtYazarEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtYazarEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYazarEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarEposta.ForeColor = System.Drawing.Color.White;
            this.TxtYazarEposta.Location = new System.Drawing.Point(0, 25);
            this.TxtYazarEposta.Name = "TxtYazarEposta";
            this.TxtYazarEposta.Size = new System.Drawing.Size(284, 27);
            this.TxtYazarEposta.TabIndex = 3;
            this.TxtYazarEposta.TextChanged += new System.EventHandler(this.TxtYazarEposta_TextChanged);
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Gray;
            this.p3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p3.Location = new System.Drawing.Point(0, 58);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(284, 3);
            this.p3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TxtYazarHakkinda);
            this.panel6.Controls.Add(this.p4);
            this.panel6.Location = new System.Drawing.Point(43, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(284, 189);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hakkında (İsteğe Bağlı)";
            // 
            // TxtYazarHakkinda
            // 
            this.TxtYazarHakkinda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtYazarHakkinda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtYazarHakkinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtYazarHakkinda.ForeColor = System.Drawing.Color.White;
            this.TxtYazarHakkinda.Location = new System.Drawing.Point(0, 31);
            this.TxtYazarHakkinda.Multiline = true;
            this.TxtYazarHakkinda.Name = "TxtYazarHakkinda";
            this.TxtYazarHakkinda.Size = new System.Drawing.Size(284, 145);
            this.TxtYazarHakkinda.TabIndex = 4;
            this.TxtYazarHakkinda.TextChanged += new System.EventHandler(this.TxtYazarHakkinda_TextChanged);
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Gray;
            this.p4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p4.Location = new System.Drawing.Point(0, 186);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(284, 3);
            this.p4.TabIndex = 0;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Cyan;
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.FlatAppearance.BorderSize = 0;
            this.BtnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnEkle.Location = new System.Drawing.Point(43, 498);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(284, 58);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 580);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "* Doldurulması zorunlu alanlar.";
            // 
            // YazarListele
            // 
            this.YazarListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YazarListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.YazarListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YazarListele.Location = new System.Drawing.Point(370, 92);
            this.YazarListele.Name = "YazarListele";
            this.YazarListele.RowHeadersWidth = 51;
            this.YazarListele.RowTemplate.Height = 24;
            this.YazarListele.Size = new System.Drawing.Size(812, 466);
            this.YazarListele.TabIndex = 7;
            this.YazarListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YazarListele_CellClick);
            this.YazarListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YazarListele_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtYazarAra);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(370, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(812, 45);
            this.panel3.TabIndex = 8;
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
            this.TxtYazarAra.Text = "Yazar Ekle ...";
            this.TxtYazarAra.Click += new System.EventHandler(this.TxtYazarAra_Click);
            this.TxtYazarAra.TextChanged += new System.EventHandler(this.TxtYazarAra_TextChanged);
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
            // FrmYazarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1218, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.YazarListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYazarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazarlar - EKOS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmYazarEkle_FormClosed);
            this.Load += new System.EventHandler(this.FrmYazarEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YazarListele)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtYazarAd;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtYazarSoyad;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYazarEposta;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtYazarHakkinda;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView YazarListele;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtYazarAra;
        private System.Windows.Forms.Panel panel5;
    }
}