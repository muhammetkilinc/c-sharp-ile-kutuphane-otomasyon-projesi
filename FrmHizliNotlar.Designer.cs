namespace ekos
{
    partial class FrmHizliNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHizliNotlar));
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.hizliNotlar = new System.Windows.Forms.DataGridView();
            this.Yenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hızlı Not Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(855, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 33);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ekos.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(40, 33);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 31;
            this.logo.TabStop = false;
            // 
            // hizliNotlar
            // 
            this.hizliNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hizliNotlar.BackgroundColor = System.Drawing.Color.White;
            this.hizliNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizliNotlar.Location = new System.Drawing.Point(12, 122);
            this.hizliNotlar.Name = "hizliNotlar";
            this.hizliNotlar.RowHeadersWidth = 51;
            this.hizliNotlar.RowTemplate.Height = 24;
            this.hizliNotlar.Size = new System.Drawing.Size(878, 396);
            this.hizliNotlar.TabIndex = 32;
            this.hizliNotlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizliNotlar_CellDoubleClick);
            // 
            // Yenile
            // 
            this.Yenile.BackColor = System.Drawing.Color.White;
            this.Yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenile.ForeColor = System.Drawing.Color.Red;
            this.Yenile.Location = new System.Drawing.Point(12, 122);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(878, 396);
            this.Yenile.TabIndex = 1;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Visible = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            // 
            // FrmHizliNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 530);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.hizliNotlar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHizliNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hızlı Notlar - EKOS";
            this.Load += new System.EventHandler(this.FrmHizliNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hizliNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView hizliNotlar;
        private System.Windows.Forms.Button Yenile;
    }
}