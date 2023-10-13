namespace ekos
{
    partial class FrmAyarlarSifreIslemleri
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSifre = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelKullanici = new System.Windows.Forms.Panel();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.panelSifre);
            this.panel7.Controls.Add(this.txtSifre);
            this.panel7.Location = new System.Drawing.Point(330, 182);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(407, 45);
            this.panel7.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ekos.Properties.Resources.eyeOpen;
            this.pictureBox1.Location = new System.Drawing.Point(367, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panelSifre
            // 
            this.panelSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(135)))), ((int)(((byte)(175)))));
            this.panelSifre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSifre.Location = new System.Drawing.Point(0, 42);
            this.panelSifre.Name = "panelSifre";
            this.panelSifre.Size = new System.Drawing.Size(407, 3);
            this.panelSifre.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(3, 13);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(353, 23);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(326, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şifreniz";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panelKullanici);
            this.panel5.Controls.Add(this.txtKullanici);
            this.panel5.Location = new System.Drawing.Point(330, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 45);
            this.panel5.TabIndex = 1;
            // 
            // panelKullanici
            // 
            this.panelKullanici.BackColor = System.Drawing.Color.Cyan;
            this.panelKullanici.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKullanici.Location = new System.Drawing.Point(0, 42);
            this.panelKullanici.Name = "panelKullanici";
            this.panelKullanici.Size = new System.Drawing.Size(407, 3);
            this.panelKullanici.TabIndex = 0;
            // 
            // txtKullanici
            // 
            this.txtKullanici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtKullanici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanici.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.ForeColor = System.Drawing.Color.White;
            this.txtKullanici.Location = new System.Drawing.Point(3, 11);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(381, 23);
            this.txtKullanici.TabIndex = 1;
            this.txtKullanici.Click += new System.EventHandler(this.txtKullanici_Click);
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtKullanici_TextChanged);
            this.txtKullanici.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullanici_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(326, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanıcı Adınız";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.Location = new System.Drawing.Point(330, 255);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(407, 73);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Visible = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            this.BtnGuncelle.MouseLeave += new System.EventHandler(this.BtnGuncelle_MouseLeave);
            this.BtnGuncelle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnGuncelle_MouseMove);
            // 
            // FrmAyarlarSifreIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1082, 451);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAyarlarSifreIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAyarlarSifreIslemleri";
            this.Load += new System.EventHandler(this.FrmAyarlarSifreIslemleri_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelKullanici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}