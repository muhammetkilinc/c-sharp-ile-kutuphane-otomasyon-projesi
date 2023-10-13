namespace ekos
{
    partial class ControlHizliNotlar
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
            this.NotBaslik = new System.Windows.Forms.Label();
            this.NotIcerik = new System.Windows.Forms.Label();
            this.NotTarih = new System.Windows.Forms.Label();
            this.BtnDetay = new System.Windows.Forms.Button();
            this.NotId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IslemYapildi = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // NotBaslik
            // 
            this.NotBaslik.AutoEllipsis = true;
            this.NotBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotBaslik.Location = new System.Drawing.Point(53, 20);
            this.NotBaslik.Name = "NotBaslik";
            this.NotBaslik.Size = new System.Drawing.Size(456, 32);
            this.NotBaslik.TabIndex = 1;
            this.NotBaslik.Text = "Başlık";
            // 
            // NotIcerik
            // 
            this.NotIcerik.AutoEllipsis = true;
            this.NotIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotIcerik.Location = new System.Drawing.Point(57, 52);
            this.NotIcerik.Name = "NotIcerik";
            this.NotIcerik.Size = new System.Drawing.Size(452, 28);
            this.NotIcerik.TabIndex = 1;
            this.NotIcerik.Text = "İçerik";
            // 
            // NotTarih
            // 
            this.NotTarih.AutoEllipsis = true;
            this.NotTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NotTarih.Location = new System.Drawing.Point(56, 80);
            this.NotTarih.Name = "NotTarih";
            this.NotTarih.Size = new System.Drawing.Size(454, 20);
            this.NotTarih.TabIndex = 1;
            this.NotTarih.Text = "12/05/2022 15.54";
            // 
            // BtnDetay
            // 
            this.BtnDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetay.FlatAppearance.BorderSize = 0;
            this.BtnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetay.ForeColor = System.Drawing.Color.White;
            this.BtnDetay.Location = new System.Drawing.Point(600, 30);
            this.BtnDetay.Name = "BtnDetay";
            this.BtnDetay.Size = new System.Drawing.Size(177, 60);
            this.BtnDetay.TabIndex = 3;
            this.BtnDetay.Text = "Detaylı Gör";
            this.BtnDetay.UseVisualStyleBackColor = false;
            this.BtnDetay.Click += new System.EventHandler(this.BtnDetay_Click);
            // 
            // NotId
            // 
            this.NotId.AutoSize = true;
            this.NotId.Location = new System.Drawing.Point(600, 4);
            this.NotId.Name = "NotId";
            this.NotId.Size = new System.Drawing.Size(18, 16);
            this.NotId.TabIndex = 4;
            this.NotId.Text = "id";
            this.NotId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(-9, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 25);
            this.panel1.TabIndex = 5;
            // 
            // IslemYapildi
            // 
            this.IslemYapildi.BackColor = System.Drawing.Color.Lime;
            this.IslemYapildi.Location = new System.Drawing.Point(23, 26);
            this.IslemYapildi.Name = "IslemYapildi";
            this.IslemYapildi.Size = new System.Drawing.Size(20, 20);
            this.IslemYapildi.TabIndex = 6;
            // 
            // ControlHizliNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.IslemYapildi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NotId);
            this.Controls.Add(this.BtnDetay);
            this.Controls.Add(this.NotTarih);
            this.Controls.Add(this.NotIcerik);
            this.Controls.Add(this.NotBaslik);
            this.Name = "ControlHizliNotlar";
            this.Size = new System.Drawing.Size(800, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NotBaslik;
        private System.Windows.Forms.Label NotIcerik;
        private System.Windows.Forms.Label NotTarih;
        private System.Windows.Forms.Button BtnDetay;
        private System.Windows.Forms.Label NotId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel IslemYapildi;
    }
}
