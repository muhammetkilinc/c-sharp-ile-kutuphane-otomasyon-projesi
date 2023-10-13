namespace ekos
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.gelenDeger = new System.Windows.Forms.Label();
            this.OgrId = new System.Windows.Forms.Label();
            this.OgrAd = new System.Windows.Forms.Label();
            this.OgrNo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboKamera = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gelenDeger
            // 
            this.gelenDeger.AutoSize = true;
            this.gelenDeger.Location = new System.Drawing.Point(12, 425);
            this.gelenDeger.Name = "gelenDeger";
            this.gelenDeger.Size = new System.Drawing.Size(79, 16);
            this.gelenDeger.TabIndex = 0;
            this.gelenDeger.Text = "gelenDeger";
            this.gelenDeger.Visible = false;
            // 
            // OgrId
            // 
            this.OgrId.AutoSize = true;
            this.OgrId.Location = new System.Drawing.Point(97, 425);
            this.OgrId.Name = "OgrId";
            this.OgrId.Size = new System.Drawing.Size(40, 16);
            this.OgrId.TabIndex = 1;
            this.OgrId.Text = "OgrId";
            this.OgrId.Visible = false;
            // 
            // OgrAd
            // 
            this.OgrAd.AutoSize = true;
            this.OgrAd.Location = new System.Drawing.Point(143, 425);
            this.OgrAd.Name = "OgrAd";
            this.OgrAd.Size = new System.Drawing.Size(46, 16);
            this.OgrAd.TabIndex = 2;
            this.OgrAd.Text = "OgrAd";
            this.OgrAd.Visible = false;
            // 
            // OgrNo
            // 
            this.OgrNo.AutoSize = true;
            this.OgrNo.Location = new System.Drawing.Point(195, 425);
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.Size = new System.Drawing.Size(47, 16);
            this.OgrNo.TabIndex = 2;
            this.OgrNo.Text = "OgrNo";
            this.OgrNo.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = global::ekos.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(36, 33);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 36;
            this.logo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(753, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kamera Tercihi";
            // 
            // ComboKamera
            // 
            this.ComboKamera.BackColor = System.Drawing.Color.LightGray;
            this.ComboKamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboKamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboKamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboKamera.FormattingEnabled = true;
            this.ComboKamera.Location = new System.Drawing.Point(278, 32);
            this.ComboKamera.Name = "ComboKamera";
            this.ComboKamera.Size = new System.Drawing.Size(359, 28);
            this.ComboKamera.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(15, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBaslat.FlatAppearance.BorderSize = 0;
            this.BtnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.ForeColor = System.Drawing.Color.White;
            this.BtnBaslat.Location = new System.Drawing.Point(524, 69);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(113, 42);
            this.BtnBaslat.TabIndex = 40;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = false;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.OgrNo);
            this.Controls.Add(this.OgrAd);
            this.Controls.Add(this.OgrId);
            this.Controls.Add(this.gelenDeger);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboKamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code - EKOS";
            this.Load += new System.EventHandler(this.FrmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label gelenDeger;
        public System.Windows.Forms.Label OgrId;
        public System.Windows.Forms.Label OgrAd;
        public System.Windows.Forms.Label OgrNo;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboKamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer1;
    }
}