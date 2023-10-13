namespace ekos
{
    partial class FrmKitaplar
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
            this.KitapListesi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KitapBtnSearch = new System.Windows.Forms.Button();
            this.KitapPltSrch = new System.Windows.Forms.Panel();
            this.KitapTxtAra = new System.Windows.Forms.TextBox();
            this.OgrId = new System.Windows.Forms.Label();
            this.OgrAd = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deger = new System.Windows.Forms.Label();
            this.KitapPltSrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // KitapListesi
            // 
            this.KitapListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KitapListesi.AutoScroll = true;
            this.KitapListesi.Location = new System.Drawing.Point(9, 128);
            this.KitapListesi.Name = "KitapListesi";
            this.KitapListesi.Size = new System.Drawing.Size(783, 459);
            this.KitapListesi.TabIndex = 6;
            this.KitapListesi.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KitapListesi_Scroll);
            this.KitapListesi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KitapListesi_MouseMove);
            this.KitapListesi.Move += new System.EventHandler(this.KitapListesi_Move);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(751, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 10);
            this.panel1.TabIndex = 32;
            this.panel1.Visible = false;
            // 
            // KitapBtnSearch
            // 
            this.KitapBtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.KitapBtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KitapBtnSearch.FlatAppearance.BorderSize = 0;
            this.KitapBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitapBtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapBtnSearch.ForeColor = System.Drawing.Color.White;
            this.KitapBtnSearch.Location = new System.Drawing.Point(591, 76);
            this.KitapBtnSearch.Name = "KitapBtnSearch";
            this.KitapBtnSearch.Size = new System.Drawing.Size(75, 37);
            this.KitapBtnSearch.TabIndex = 31;
            this.KitapBtnSearch.Text = "Ara";
            this.KitapBtnSearch.UseVisualStyleBackColor = false;
            this.KitapBtnSearch.Click += new System.EventHandler(this.KitapBtnSearch_Click);
            // 
            // KitapPltSrch
            // 
            this.KitapPltSrch.BackColor = System.Drawing.Color.White;
            this.KitapPltSrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KitapPltSrch.Controls.Add(this.KitapTxtAra);
            this.KitapPltSrch.Location = new System.Drawing.Point(47, 76);
            this.KitapPltSrch.Name = "KitapPltSrch";
            this.KitapPltSrch.Size = new System.Drawing.Size(546, 37);
            this.KitapPltSrch.TabIndex = 30;
            // 
            // KitapTxtAra
            // 
            this.KitapTxtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KitapTxtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapTxtAra.Location = new System.Drawing.Point(13, 5);
            this.KitapTxtAra.Name = "KitapTxtAra";
            this.KitapTxtAra.Size = new System.Drawing.Size(524, 23);
            this.KitapTxtAra.TabIndex = 1;
            this.KitapTxtAra.TextChanged += new System.EventHandler(this.KitapTxtAra_TextChanged);
            this.KitapTxtAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KitapTxtAra_KeyPress);
            // 
            // OgrId
            // 
            this.OgrId.AutoSize = true;
            this.OgrId.Location = new System.Drawing.Point(56, 10);
            this.OgrId.Name = "OgrId";
            this.OgrId.Size = new System.Drawing.Size(14, 16);
            this.OgrId.TabIndex = 35;
            this.OgrId.Text = "0";
            this.OgrId.Visible = false;
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Location = new System.Drawing.Point(103, 10);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(14, 16);
            this.OgrAd.TabIndex = 36;
            this.OgrAd.Text = "0";
            this.OgrAd.Visible = false;
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSize = true;
            this.OgrNo.Location = new System.Drawing.Point(154, 10);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(14, 16);
            this.OgrNo.TabIndex = 37;
            this.OgrNo.Text = "0";
            this.OgrNo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ekos.Properties.Resources.qrCode;
            this.pictureBox1.Location = new System.Drawing.Point(671, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ekos.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(12, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(26, 26);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 34;
            this.logo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ada Göre";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(157, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "Barkoda Göre";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(297, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 37);
            this.button3.TabIndex = 40;
            this.button3.Text = "Yazara Göre";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(437, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 37);
            this.button4.TabIndex = 40;
            this.button4.Text = "Yayınevine Göre";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(589, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 37);
            this.button5.TabIndex = 40;
            this.button5.Text = "Sayfaya Göre";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deger
            // 
            this.deger.AutoSize = true;
            this.deger.Location = new System.Drawing.Point(186, 10);
            this.deger.Name = "deger";
            this.deger.Size = new System.Drawing.Size(14, 16);
            this.deger.TabIndex = 41;
            this.deger.Text = "0";
            this.deger.Visible = false;
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 600);
            this.Controls.Add(this.deger);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrAd);
            this.Controls.Add(this.OgrId);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KitapBtnSearch);
            this.Controls.Add(this.KitapPltSrch);
            this.Controls.Add(this.KitapListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitaplar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            this.KitapPltSrch.ResumeLayout(false);
            this.KitapPltSrch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel KitapListesi;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KitapBtnSearch;
        private System.Windows.Forms.Panel KitapPltSrch;
        public System.Windows.Forms.TextBox KitapTxtAra;
        public System.Windows.Forms.Label OgrId;
        public System.Windows.Forms.Label OgrAd;
        public System.Windows.Forms.Label OgrNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label deger;
    }
}