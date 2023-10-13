namespace ekos
{
    partial class FrmOgrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciler));
            this.OgrPltSrch = new System.Windows.Forms.Panel();
            this.TxtClear = new System.Windows.Forms.Label();
            this.OgrTxtAra = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ogrenciListele = new System.Windows.Forms.DataGridView();
            this.OgrPltSrch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListele)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrPltSrch
            // 
            this.OgrPltSrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OgrPltSrch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OgrPltSrch.Controls.Add(this.TxtClear);
            this.OgrPltSrch.Controls.Add(this.OgrTxtAra);
            this.OgrPltSrch.Location = new System.Drawing.Point(184, 34);
            this.OgrPltSrch.Name = "OgrPltSrch";
            this.OgrPltSrch.Size = new System.Drawing.Size(634, 37);
            this.OgrPltSrch.TabIndex = 3;
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
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(983, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ekos.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(12, 10);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(26, 26);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 29;
            this.logo.TabStop = false;
            // 
            // ogrenciListele
            // 
            this.ogrenciListele.AllowUserToDeleteRows = false;
            this.ogrenciListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenciListele.BackgroundColor = System.Drawing.Color.White;
            this.ogrenciListele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ogrenciListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenciListele.GridColor = System.Drawing.Color.Silver;
            this.ogrenciListele.Location = new System.Drawing.Point(12, 77);
            this.ogrenciListele.Name = "ogrenciListele";
            this.ogrenciListele.ReadOnly = true;
            this.ogrenciListele.RowHeadersWidth = 51;
            this.ogrenciListele.RowTemplate.Height = 24;
            this.ogrenciListele.Size = new System.Drawing.Size(1006, 366);
            this.ogrenciListele.TabIndex = 32;
            this.ogrenciListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenciListele_CellClick);
            // 
            // FrmOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 465);
            this.Controls.Add(this.ogrenciListele);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.OgrPltSrch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOgrenciler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciler Listesi";
            this.Load += new System.EventHandler(this.FrmOgrenciler_Load);
            this.OgrPltSrch.ResumeLayout(false);
            this.OgrPltSrch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel OgrPltSrch;
        public System.Windows.Forms.TextBox OgrTxtAra;
        private System.Windows.Forms.DataGridView ogrenciListele;
        private System.Windows.Forms.Label TxtClear;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.PictureBox logo;
    }
}