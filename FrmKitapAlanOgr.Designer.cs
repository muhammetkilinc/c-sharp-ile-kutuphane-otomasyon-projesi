namespace ekos
{
    partial class FrmKitapAlanOgr
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapAlanOgr));
            this.btnExit = new System.Windows.Forms.Button();
            this.OgrPltSrch = new System.Windows.Forms.Panel();
            this.TxtClear = new System.Windows.Forms.Label();
            this.OgrTxtAra = new System.Windows.Forms.TextBox();
            this.kitapAlanOgrListele = new System.Windows.Forms.DataGridView();
            this.IlkKayit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTumKayit = new System.Windows.Forms.Button();
            this.BtnTeslimEden = new System.Windows.Forms.Button();
            this.BtnTeslimEtmeyen = new System.Windows.Forms.Button();
            this.BtnGeciktiren = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToplamKayit = new System.Windows.Forms.Label();
            this.BtnIslem = new System.Windows.Forms.Button();
            this.BtnUyari = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OgrPltSrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlanOgrListele)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1111, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // OgrPltSrch
            // 
            this.OgrPltSrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OgrPltSrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OgrPltSrch.Controls.Add(this.TxtClear);
            this.OgrPltSrch.Controls.Add(this.OgrTxtAra);
            this.OgrPltSrch.Location = new System.Drawing.Point(269, 47);
            this.OgrPltSrch.Name = "OgrPltSrch";
            this.OgrPltSrch.Size = new System.Drawing.Size(634, 37);
            this.OgrPltSrch.TabIndex = 35;
            // 
            // TxtClear
            // 
            this.TxtClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClear.AutoSize = true;
            this.TxtClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtClear.ForeColor = System.Drawing.Color.Red;
            this.TxtClear.Location = new System.Drawing.Point(596, 8);
            this.TxtClear.Name = "TxtClear";
            this.TxtClear.Size = new System.Drawing.Size(27, 18);
            this.TxtClear.TabIndex = 4;
            this.TxtClear.Text = "❌";
            this.TxtClear.Visible = false;
            this.TxtClear.Click += new System.EventHandler(this.TxtClear_Click);
            // 
            // OgrTxtAra
            // 
            this.OgrTxtAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.OgrTxtAra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.OgrTxtAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OgrTxtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OgrTxtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrTxtAra.ForeColor = System.Drawing.Color.Black;
            this.OgrTxtAra.Location = new System.Drawing.Point(13, 5);
            this.OgrTxtAra.Name = "OgrTxtAra";
            this.OgrTxtAra.Size = new System.Drawing.Size(577, 23);
            this.OgrTxtAra.TabIndex = 1;
            this.OgrTxtAra.TextChanged += new System.EventHandler(this.OgrTxtAra_TextChanged);
            // 
            // kitapAlanOgrListele
            // 
            this.kitapAlanOgrListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapAlanOgrListele.BackgroundColor = System.Drawing.Color.White;
            this.kitapAlanOgrListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapAlanOgrListele.Location = new System.Drawing.Point(12, 158);
            this.kitapAlanOgrListele.Name = "kitapAlanOgrListele";
            this.kitapAlanOgrListele.RowHeadersWidth = 51;
            this.kitapAlanOgrListele.RowTemplate.Height = 24;
            this.kitapAlanOgrListele.Size = new System.Drawing.Size(1134, 544);
            this.kitapAlanOgrListele.TabIndex = 41;
            this.kitapAlanOgrListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapAlanOgrListele_CellClick);
            this.kitapAlanOgrListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapAlanOgrListele_CellDoubleClick);
            // 
            // IlkKayit
            // 
            this.IlkKayit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IlkKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlkKayit.Location = new System.Drawing.Point(7, 8);
            this.IlkKayit.Name = "IlkKayit";
            this.IlkKayit.Size = new System.Drawing.Size(46, 19);
            this.IlkKayit.TabIndex = 42;
            this.IlkKayit.Text = "50";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.IlkKayit);
            this.panel1.Location = new System.Drawing.Point(58, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 38);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "İlk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "kaydı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(179, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 45;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTumKayit
            // 
            this.BtnTumKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTumKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTumKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumKayit.Location = new System.Drawing.Point(358, 109);
            this.BtnTumKayit.Name = "BtnTumKayit";
            this.BtnTumKayit.Size = new System.Drawing.Size(183, 41);
            this.BtnTumKayit.TabIndex = 46;
            this.BtnTumKayit.Text = "Tüm Kayıtlar";
            this.BtnTumKayit.UseVisualStyleBackColor = true;
            this.BtnTumKayit.Click += new System.EventHandler(this.BtnTumKayit_Click);
            // 
            // BtnTeslimEden
            // 
            this.BtnTeslimEden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeslimEden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeslimEden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTeslimEden.Location = new System.Drawing.Point(547, 109);
            this.BtnTeslimEden.Name = "BtnTeslimEden";
            this.BtnTeslimEden.Size = new System.Drawing.Size(175, 41);
            this.BtnTeslimEden.TabIndex = 46;
            this.BtnTeslimEden.Text = "Teslim Edilen";
            this.BtnTeslimEden.UseVisualStyleBackColor = true;
            this.BtnTeslimEden.Click += new System.EventHandler(this.BtnTeslimEden_Click);
            // 
            // BtnTeslimEtmeyen
            // 
            this.BtnTeslimEtmeyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTeslimEtmeyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTeslimEtmeyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTeslimEtmeyen.Location = new System.Drawing.Point(728, 109);
            this.BtnTeslimEtmeyen.Name = "BtnTeslimEtmeyen";
            this.BtnTeslimEtmeyen.Size = new System.Drawing.Size(202, 41);
            this.BtnTeslimEtmeyen.TabIndex = 46;
            this.BtnTeslimEtmeyen.Text = "Teslim Edilmeyen";
            this.BtnTeslimEtmeyen.UseVisualStyleBackColor = true;
            this.BtnTeslimEtmeyen.Click += new System.EventHandler(this.BtnTeslimEtmeyen_Click);
            // 
            // BtnGeciktiren
            // 
            this.BtnGeciktiren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeciktiren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeciktiren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeciktiren.Location = new System.Drawing.Point(936, 109);
            this.BtnGeciktiren.Name = "BtnGeciktiren";
            this.BtnGeciktiren.Size = new System.Drawing.Size(202, 41);
            this.BtnGeciktiren.TabIndex = 46;
            this.BtnGeciktiren.Text = "Geciktirenler";
            this.BtnGeciktiren.UseVisualStyleBackColor = true;
            this.BtnGeciktiren.Click += new System.EventHandler(this.BtnGeciktiren_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ekos.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(33, 33);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 34;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.ToplamKayit);
            this.panel2.Controls.Add(this.BtnIslem);
            this.panel2.Location = new System.Drawing.Point(12, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 60);
            this.panel2.TabIndex = 47;
            // 
            // ToplamKayit
            // 
            this.ToplamKayit.AutoSize = true;
            this.ToplamKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamKayit.ForeColor = System.Drawing.Color.White;
            this.ToplamKayit.Location = new System.Drawing.Point(904, 20);
            this.ToplamKayit.Name = "ToplamKayit";
            this.ToplamKayit.Size = new System.Drawing.Size(146, 20);
            this.ToplamKayit.TabIndex = 1;
            this.ToplamKayit.Text = "Toplam Kayıt : 0";
            this.ToplamKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnIslem
            // 
            this.BtnIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIslem.Location = new System.Drawing.Point(27, 13);
            this.BtnIslem.Name = "BtnIslem";
            this.BtnIslem.Size = new System.Drawing.Size(184, 36);
            this.BtnIslem.TabIndex = 0;
            this.BtnIslem.Text = "TESLİM AL";
            this.BtnIslem.UseVisualStyleBackColor = true;
            this.BtnIslem.Visible = false;
            this.BtnIslem.Click += new System.EventHandler(this.BtnIslem_Click);
            // 
            // BtnUyari
            // 
            this.BtnUyari.FlatAppearance.BorderSize = 2;
            this.BtnUyari.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnUyari.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnUyari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUyari.ForeColor = System.Drawing.Color.Red;
            this.BtnUyari.Location = new System.Drawing.Point(220, 47);
            this.BtnUyari.Name = "BtnUyari";
            this.BtnUyari.Size = new System.Drawing.Size(37, 37);
            this.BtnUyari.TabIndex = 48;
            this.BtnUyari.Text = "!";
            this.toolTip1.SetToolTip(this.BtnUyari, "Lütfen en az 3 harf giriniz!");
            this.BtnUyari.UseVisualStyleBackColor = true;
            this.BtnUyari.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmKitapAlanOgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 774);
            this.Controls.Add(this.BtnUyari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnGeciktiren);
            this.Controls.Add(this.BtnTeslimEtmeyen);
            this.Controls.Add(this.BtnTeslimEden);
            this.Controls.Add(this.BtnTumKayit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kitapAlanOgrListele);
            this.Controls.Add(this.OgrPltSrch);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKitapAlanOgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Alan Öğrenciler - EKOS";
            this.Load += new System.EventHandler(this.FrmKitapAlanOgr_Load);
            this.OgrPltSrch.ResumeLayout(false);
            this.OgrPltSrch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlanOgrListele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel OgrPltSrch;
        private System.Windows.Forms.Label TxtClear;
        public System.Windows.Forms.TextBox OgrTxtAra;
        private System.Windows.Forms.DataGridView kitapAlanOgrListele;
        private System.Windows.Forms.TextBox IlkKayit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTumKayit;
        private System.Windows.Forms.Button BtnTeslimEden;
        private System.Windows.Forms.Button BtnTeslimEtmeyen;
        private System.Windows.Forms.Button BtnGeciktiren;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ToplamKayit;
        private System.Windows.Forms.Button BtnIslem;
        private System.Windows.Forms.Button BtnUyari;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}