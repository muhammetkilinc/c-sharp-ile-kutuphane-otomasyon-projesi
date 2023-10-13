namespace ekos
{
    partial class FrmAyarlarProfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PersonelProfil = new System.Windows.Forms.PictureBox();
            this.TxtVarsayilan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.VeriAdSoyad = new System.Windows.Forms.Label();
            this.VeriEposta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.VeriTelNo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtGorsel = new System.Windows.Forms.TextBox();
            this.p3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.p4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.p5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.p6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelProfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVarsayilan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Görsel URL";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.Cyan;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.FlatAppearance.BorderSize = 0;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(14, 543);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(521, 57);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "GÜNCELLE";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // PersonelProfil
            // 
            this.PersonelProfil.BackColor = System.Drawing.Color.Transparent;
            this.PersonelProfil.ErrorImage = global::ekos.Properties.Resources.wifiControl;
            this.PersonelProfil.Image = global::ekos.Properties.Resources.noProfil;
            this.PersonelProfil.Location = new System.Drawing.Point(28, 15);
            this.PersonelProfil.Name = "PersonelProfil";
            this.PersonelProfil.Size = new System.Drawing.Size(261, 175);
            this.PersonelProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonelProfil.TabIndex = 6;
            this.PersonelProfil.TabStop = false;
            this.toolTip1.SetToolTip(this.PersonelProfil, "URL\'yi görmek için tıklayın.");
            this.PersonelProfil.Click += new System.EventHandler(this.PersonelProfil_Click);
            // 
            // TxtVarsayilan
            // 
            this.TxtVarsayilan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.TxtVarsayilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtVarsayilan.ForeColor = System.Drawing.Color.White;
            this.TxtVarsayilan.Location = new System.Drawing.Point(115, 24);
            this.TxtVarsayilan.Name = "TxtVarsayilan";
            this.TxtVarsayilan.Size = new System.Drawing.Size(82, 26);
            this.TxtVarsayilan.TabIndex = 5;
            this.TxtVarsayilan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtVarsayilan.ValueChanged += new System.EventHandler(this.TxtAd_TextChanged);
            this.TxtVarsayilan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "gün içinde teslim etsin. (Varsayılan)";
            // 
            // VeriAdSoyad
            // 
            this.VeriAdSoyad.AutoEllipsis = true;
            this.VeriAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.VeriAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriAdSoyad.ForeColor = System.Drawing.Color.White;
            this.VeriAdSoyad.Location = new System.Drawing.Point(28, 221);
            this.VeriAdSoyad.Name = "VeriAdSoyad";
            this.VeriAdSoyad.Size = new System.Drawing.Size(261, 32);
            this.VeriAdSoyad.TabIndex = 7;
            this.VeriAdSoyad.Text = "Personel ADI";
            this.VeriAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VeriEposta
            // 
            this.VeriEposta.AutoEllipsis = true;
            this.VeriEposta.BackColor = System.Drawing.Color.Transparent;
            this.VeriEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VeriEposta.Location = new System.Drawing.Point(28, 255);
            this.VeriEposta.Name = "VeriEposta";
            this.VeriEposta.Size = new System.Drawing.Size(261, 23);
            this.VeriEposta.TabIndex = 7;
            this.VeriEposta.Text = "E-Posta";
            this.VeriEposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.panel1.BackgroundImage = global::ekos.Properties.Resources.anasayfaMenu;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.VeriTelNo);
            this.panel1.Controls.Add(this.VeriEposta);
            this.panel1.Controls.Add(this.PersonelProfil);
            this.panel1.Controls.Add(this.VeriAdSoyad);
            this.panel1.Location = new System.Drawing.Point(64, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 405);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesabını Devre Dışı Bırak";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VeriTelNo
            // 
            this.VeriTelNo.AutoEllipsis = true;
            this.VeriTelNo.BackColor = System.Drawing.Color.Transparent;
            this.VeriTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriTelNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.VeriTelNo.Location = new System.Drawing.Point(28, 282);
            this.VeriTelNo.Name = "VeriTelNo";
            this.VeriTelNo.Size = new System.Drawing.Size(261, 23);
            this.VeriTelNo.TabIndex = 7;
            this.VeriTelNo.Text = "Tel";
            this.VeriTelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TxtGorsel);
            this.panel5.Controls.Add(this.p3);
            this.panel5.Location = new System.Drawing.Point(14, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 67);
            this.panel5.TabIndex = 9;
            // 
            // TxtGorsel
            // 
            this.TxtGorsel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtGorsel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGorsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGorsel.ForeColor = System.Drawing.Color.White;
            this.TxtGorsel.Location = new System.Drawing.Point(0, 26);
            this.TxtGorsel.Name = "TxtGorsel";
            this.TxtGorsel.Size = new System.Drawing.Size(521, 25);
            this.TxtGorsel.TabIndex = 10;
            this.TxtGorsel.Text = "-";
            this.TxtGorsel.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p3.Location = new System.Drawing.Point(0, 63);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(521, 4);
            this.p3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TxtTel);
            this.panel2.Controls.Add(this.p4);
            this.panel2.Location = new System.Drawing.Point(14, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 67);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tel No  *";
            // 
            // TxtTel
            // 
            this.TxtTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTel.ForeColor = System.Drawing.Color.White;
            this.TxtTel.Location = new System.Drawing.Point(0, 26);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(521, 25);
            this.TxtTel.TabIndex = 10;
            this.TxtTel.Text = "5XXXXXXXXX";
            this.TxtTel.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            this.TxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p4.Location = new System.Drawing.Point(0, 63);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(521, 4);
            this.p4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TxtEposta);
            this.panel3.Controls.Add(this.p5);
            this.panel3.Location = new System.Drawing.Point(14, 367);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 67);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Posta";
            // 
            // TxtEposta
            // 
            this.TxtEposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtEposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEposta.ForeColor = System.Drawing.Color.White;
            this.TxtEposta.Location = new System.Drawing.Point(0, 26);
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(521, 25);
            this.TxtEposta.TabIndex = 10;
            this.TxtEposta.Text = "-";
            this.TxtEposta.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p5.Location = new System.Drawing.Point(0, 63);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(521, 4);
            this.p5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.p6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TxtVarsayilan);
            this.panel4.Location = new System.Drawing.Point(14, 455);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 67);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap *";
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p6.Location = new System.Drawing.Point(0, 63);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(521, 4);
            this.p6.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Öğrenci, kitabı";
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.BtnKaydet);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel16);
            this.panel10.Location = new System.Drawing.Point(413, 24);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(589, 405);
            this.panel10.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(14, 606);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 21);
            this.panel6.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label7);
            this.panel13.Controls.Add(this.TxtAd);
            this.panel13.Controls.Add(this.p1);
            this.panel13.Location = new System.Drawing.Point(14, 15);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(521, 67);
            this.panel13.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adınız *";
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.ForeColor = System.Drawing.Color.White;
            this.TxtAd.Location = new System.Drawing.Point(0, 26);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(521, 25);
            this.TxtAd.TabIndex = 10;
            this.TxtAd.Text = "-";
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            this.TxtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAd_KeyPress);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p1.Location = new System.Drawing.Point(0, 63);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(521, 4);
            this.p1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.TxtSoyad);
            this.panel11.Controls.Add(this.p2);
            this.panel11.Location = new System.Drawing.Point(14, 103);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(521, 67);
            this.panel11.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyadınız *";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.TxtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.ForeColor = System.Drawing.Color.White;
            this.TxtSoyad.Location = new System.Drawing.Point(0, 26);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(521, 25);
            this.TxtSoyad.TabIndex = 10;
            this.TxtSoyad.Text = "-";
            this.TxtSoyad.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            this.TxtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAd_KeyPress);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.p2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p2.Location = new System.Drawing.Point(0, 63);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(521, 4);
            this.p2.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(73)))), ((int)(((byte)(112)))));
            this.panel16.Controls.Add(this.label8);
            this.panel16.Location = new System.Drawing.Point(14, 543);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(521, 57);
            this.panel16.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(18, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(490, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "* Zorunlu alanları doldurun!!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAyarlarProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1082, 451);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAyarlarProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelProfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVarsayilan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TxtVarsayilan;
        private System.Windows.Forms.PictureBox PersonelProfil;
        private System.Windows.Forms.Label VeriAdSoyad;
        private System.Windows.Forms.Label VeriEposta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VeriTelNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtGorsel;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEposta;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
    }
}