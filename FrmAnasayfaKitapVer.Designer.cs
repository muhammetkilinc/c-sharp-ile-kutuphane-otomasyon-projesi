namespace ekos
{
    partial class FrmAnasayfaKitapVer
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
            this.BtnKitapVer = new System.Windows.Forms.Button();
            this.BtnOgrKitapGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKitapVer
            // 
            this.BtnKitapVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.BtnKitapVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKitapVer.FlatAppearance.BorderSize = 0;
            this.BtnKitapVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKitapVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKitapVer.ForeColor = System.Drawing.Color.White;
            this.BtnKitapVer.Location = new System.Drawing.Point(238, 111);
            this.BtnKitapVer.Name = "BtnKitapVer";
            this.BtnKitapVer.Size = new System.Drawing.Size(586, 77);
            this.BtnKitapVer.TabIndex = 1;
            this.BtnKitapVer.Text = "ÖĞRENCİYE KİTAP VER";
            this.BtnKitapVer.UseVisualStyleBackColor = false;
            this.BtnKitapVer.Click += new System.EventHandler(this.BtnKitapVer_Click);
            this.BtnKitapVer.MouseLeave += new System.EventHandler(this.BtnKitapVer_MouseLeave);
            this.BtnKitapVer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnKitapVer_MouseMove);
            // 
            // BtnOgrKitapGor
            // 
            this.BtnOgrKitapGor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(95)))), ((int)(((byte)(124)))));
            this.BtnOgrKitapGor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOgrKitapGor.FlatAppearance.BorderSize = 0;
            this.BtnOgrKitapGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrKitapGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrKitapGor.ForeColor = System.Drawing.Color.White;
            this.BtnOgrKitapGor.Location = new System.Drawing.Point(238, 227);
            this.BtnOgrKitapGor.Name = "BtnOgrKitapGor";
            this.BtnOgrKitapGor.Size = new System.Drawing.Size(586, 77);
            this.BtnOgrKitapGor.TabIndex = 1;
            this.BtnOgrKitapGor.Text = "ÖĞRENCİYE VERİLEN KİTAPLARI GÖRÜNTÜLE";
            this.BtnOgrKitapGor.UseVisualStyleBackColor = false;
            this.BtnOgrKitapGor.Click += new System.EventHandler(this.BtnOgrKitapGor_Click);
            this.BtnOgrKitapGor.MouseLeave += new System.EventHandler(this.BtnOgrKitapGor_MouseLeave);
            this.BtnOgrKitapGor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnOgrKitapGor_MouseMove);
            // 
            // FrmAnasayfaKitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1082, 451);
            this.Controls.Add(this.BtnOgrKitapGor);
            this.Controls.Add(this.BtnKitapVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnasayfaKitapVer";
            this.Text = "FrmAnasayfaKitapVer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKitapVer;
        private System.Windows.Forms.Button BtnOgrKitapGor;
    }
}