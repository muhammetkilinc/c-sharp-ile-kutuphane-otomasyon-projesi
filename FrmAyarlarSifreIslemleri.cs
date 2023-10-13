using ekos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmAyarlarSifreIslemleri : Form
    {
        public FrmAyarlarSifreIslemleri()
        {
            InitializeComponent();
        }
        string kullaniciEski = "";
        string sifreEski = "";
        public void Efekt()
        {
            panelKullanici.BackColor = Color.FromArgb(82, 135, 175);
            panelSifre.BackColor = Color.FromArgb(82, 135, 175);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '\0';
            pictureBox1.Image = Resources.eyeClose;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            pictureBox1.Image = Resources.eyeOpen;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            Efekt();
            panelSifre.BackColor = Color.Cyan;

        }
        private void FrmAyarlarSifreIslemleri_Load(object sender, EventArgs e)
        {
            var personel = db.PersonelSifre.Find(personelGiris.pId);
            txtKullanici.Text = personel.KullaniciAdi;
            txtSifre.Text = personel.Sifre;

            kullaniciEski = personel.KullaniciAdi;
            sifreEski = personel.Sifre;


            BtnGuncelle.Visible = false;

            txtKullanici.Focus();
            Efekt();
            panelKullanici.BackColor = Color.Cyan;
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

            Efekt();
            panelKullanici.BackColor = Color.Cyan;

            if (txtSifre.Text != "" && txtKullanici.Text != "" && txtKullanici.Text != kullaniciEski || txtSifre.Text != sifreEski)
            {
                BtnGuncelle.Visible = Visible;
            }

            else
            {
                BtnGuncelle.Visible = false;
            }
        }

        private void txtKullanici_Click(object sender, EventArgs e)
        {
            Efekt();
            panelKullanici.BackColor = Color.Cyan;
        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 64)
            {
                e.Handled = true;
            }
        }

        private void BtnGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGuncelle.BackColor = Color.Cyan;
            BtnGuncelle.ForeColor = Color.Black;
        }

        private void BtnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BtnGuncelle.BackColor = Color.FromArgb(51, 95, 124);
            BtnGuncelle.ForeColor = Color.White;
        }
        ekosEntities db = new ekosEntities();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var personel = db.PersonelSifre.Find(personelGiris.pId);
                personel.KullaniciAdi = txtKullanici.Text;
                personel.Sifre = txtSifre.Text;
                personel.KayitTarih = DateTime.Now;
                db.SaveChanges();
                BtnGuncelle.Visible = false;


                MessageBox.Show("Kullanıcı adınız ve şifreniz güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Veri kaydedilirken bir hata oluştu!", "Veri Güncelleme - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtSifre_TextChanged_1(object sender, EventArgs e)
        {
            Efekt();
            panelSifre.BackColor = Color.Cyan;

            if (txtSifre.Text != "" && txtKullanici.Text != "" && txtKullanici.Text != kullaniciEski || txtSifre.Text != sifreEski)
            {
                BtnGuncelle.Visible = Visible;
            }

            else
            {
                BtnGuncelle.Visible = false;
            }
        }
    }
}
