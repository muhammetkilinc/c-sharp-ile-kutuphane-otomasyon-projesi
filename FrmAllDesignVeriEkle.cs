using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmAllDesignVeriEkle : Form
    {
        public FrmAllDesignVeriEkle()
        {
            InitializeComponent();
        }
        public void BtnMove(Button btn)
        {
            btn.BackColor = Color.Cyan;
            btn.ForeColor = Color.Black;
        }
        public void BtnLeave(Button btn)
        {
            btn.BackColor = Color.FromArgb(51, 95, 124);
            btn.ForeColor = Color.White;
        }
        private void BtnKitapEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnKitapEkle);
        }

        private void BtnKitapEkle_MouseLeave(object sender, EventArgs e)
        {

            BtnLeave(BtnKitapEkle);
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle ekle = new FrmKitapEkle();
            ekle.ShowDialog();
        }

        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            var kategori = new FrmKitapKategorisiEkle();
            kategori.ShowDialog();
        }

        private void BtnYazarEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnYazarEkle);
        }

        private void BtnYayineviEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnYayineviEkle);
        }

        private void BtnOgrenciEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnOgrenciEkle);
        }

        private void BtnBolumEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnBolumEkle);
        }

        private void BtnKategoriEkle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMove(BtnKategoriEkle);
        }

        private void BtnYazarEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave(BtnYazarEkle);
        }

        private void BtnYayineviEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave(BtnYayineviEkle);
        }

        private void BtnOgrenciEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave(BtnOgrenciEkle);
        }

        private void BtnBolumEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave(BtnBolumEkle);
        }

        private void BtnKategoriEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnLeave(BtnKategoriEkle);
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            var yazar = new FrmYazarEkle();
            yazar.ShowDialog();
        }

        private void BtnYayineviEkle_Click(object sender, EventArgs e)
        {
            var yayinevi = new FrmYayineviEkle();
            yayinevi.ShowDialog();
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            var ogr = new FrmOgrenciDetayliGor();
            ogr.ShowDialog();
        }

        private void BtnBolumEkle_Click(object sender, EventArgs e)
        {
            var bolum = new FrmOgrenciBolumEkle();
            bolum.ShowDialog();
        }
    }
}
