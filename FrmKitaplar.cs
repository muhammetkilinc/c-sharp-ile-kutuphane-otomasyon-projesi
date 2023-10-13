using ekos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmKitaplar : Form
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }

        int AramaKriteri = 1;
        private void VeriListeleme()
        {
            int a = 1;
            int id = 1;
            ControlKitaplar[] kitaplar = new ControlKitaplar[10];
            KitapListesi.Controls.Clear();
            for (int ktp = 1; ktp < kitaplar.Length; ktp++)
            {
                kitaplar[ktp] = new ControlKitaplar();
                kitaplar[ktp].VeriKitapAd = "Tutunamayanlar";
                kitaplar[ktp].VeriKitapYazar = "Oğuz Atay";
                kitaplar[ktp].VeriKitapYayinevi = "İlhak Yayınları";
                kitaplar[ktp].VeriGorsel = Resources.ornekKitapGorsel;
                kitaplar[ktp].VeriRaf = "Rafta";
                kitaplar[ktp].VeriRafRenk = Color.Green;
                kitaplar[ktp].KitapId.Text = id.ToString();
                kitaplar[ktp].OgrId.Text = OgrId.Text;
                kitaplar[ktp].OgrAd.Text = OgrAd.Text;
                kitaplar[ktp].OgrNo.Text = OgrNo.Text;

                if (a == 1)
                {
                    //kitaplar[ktp].BtnKitapAktar.Visible = false;
                }

                KitapListesi.Controls.Add(kitaplar[ktp]);

                id++;
            }
        }


        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            int degerInt = int.Parse(deger.Text);
            if (degerInt == 0)
            {
                //timer1.Start();
            }
        }


        private void KitapTxtAra_TextChanged(object sender, EventArgs e)
        {
            panel1.Width = 650;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KitapTxtAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AramaKriteri == 1 || AramaKriteri == 3 || AramaKriteri == 4)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (AramaKriteri == 2 || AramaKriteri == 5)
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        public int i = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (i == 0)
            {
                KitapTxtAra.Text = "";
                i++;
            }

            panel1.Width -= 4;
            if (panel1.Width > 150)
            {
                panel1.BackColor = Color.FromArgb(0, 192, 0);
            }
            if (panel1.Width < 150)
            {
                panel1.BackColor = Color.Red;
            }
            if (panel1.Width < 5)
            {
                timer1.Stop();
                this.Hide();
            }
        }

        private void KitapListesi_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Width = 650;
        }

        private void KitapListesi_Move(object sender, EventArgs e)
        {
            panel1.Width = 650;
        }

        private void KitapListesi_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Width = 650;
        }

        private void KitapBtnSearch_Click(object sender, EventArgs e)
        {
            panel1.Width = 650;
            VeriListeleme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmQRCode QrCode = new FrmQRCode();
            QrCode.gelenDeger.Text = 1.ToString();
            QrCode.OgrId.Text = OgrId.Text;
            QrCode.OgrAd.Text = OgrAd.Text;
            QrCode.OgrNo.Text = OgrNo.Text;
            this.Hide();
            QrCode.ShowDialog();

        }

        private void KitapTxtAra_Enter(object sender, EventArgs e)
        {
            
        }
        public void BtnEffect()
        {
            void effect(Button btn)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            effect(button1);
            effect(button2);
            effect(button3);
            effect(button4);
            effect(button5);
        }
        public void BtnClickEffect(Button btn)
        {
            panel1.Width = 650;
            KitapTxtAra.Text = "";
            btn.BackColor = Color.FromArgb(0, 30, 54);
            btn.ForeColor = Color.White;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AramaKriteri = 1;
            BtnEffect();
            BtnClickEffect(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AramaKriteri = 2;
            BtnEffect();
            BtnClickEffect(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AramaKriteri = 3;
            BtnEffect();
            BtnClickEffect(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AramaKriteri = 4;
            BtnEffect();
            BtnClickEffect(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AramaKriteri = 5;
            BtnEffect();
            BtnClickEffect(button5);
        }
    }
}
