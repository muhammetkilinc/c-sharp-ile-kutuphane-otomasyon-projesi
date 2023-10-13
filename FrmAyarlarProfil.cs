using ekos.Properties;
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
    public partial class FrmAyarlarProfil : Form
    {
        public FrmAyarlarProfil()
        {
            InitializeComponent();
        }

        ekosEntities db = new ekosEntities();
        public int pfYok = 0;
        private void TxtGorsel_TextChanged(object sender, EventArgs e)
        {
            if (TxtTel.Text != "" && TxtEposta.Text != "" && VeriAdSoyad.Text != "")
            {
                BtnKaydet.Visible = Visible;
                PersonelProfil.ImageLocation = TxtGorsel.Text;
            }
            else
            {
                BtnKaydet.Visible = false;
                
            }
        }




        private void FrmProfil_Load(object sender, EventArgs e)
        {
            TxtTel.MaxLength = 11;
            var personel = db.Personel.Find(personelGiris.pId);
            PersonelProfil.ImageLocation = personel.GorselUrl;
            TxtAd.Text = personel.Ad;
            TxtSoyad.Text = personel.Soyad;
            TxtGorsel.Text = personel.GorselUrl;
            TxtTel.Text = personel.TelNo;
            TxtEposta.Text = personel.EPosta;
            TxtVarsayilan.Text = personel.VarsayilanKitapGeciktirme.ToString();
            VeriAdSoyad.Text = personel.Ad + " " + personel.Soyad.ToUpper();
            VeriEposta.Text = personel.EPosta;
            VeriTelNo.Text = personel.TelNo;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && TxtSoyad.Text != "" && TxtTel.Text.Length == 11 && TxtVarsayilan.Value != 0)
            {
                try
                {
                    var Guncelle = db.Personel.Find(personelGiris.pId);
                    Guncelle.Ad = TxtAd.Text;
                    Guncelle.Soyad = TxtSoyad.Text;
                    Guncelle.TelNo = TxtTel.Text;
                    Guncelle.GorselUrl = TxtGorsel.Text;
                    Guncelle.EPosta = TxtEposta.Text;
                    Guncelle.VarsayilanKitapGeciktirme = int.Parse(TxtVarsayilan.Value.ToString());
                    db.SaveChanges();
                    MessageBox.Show("Bilgileriniz başarılı bir şekilde güncellendi.");
                }
                catch (Exception)
                {

                    MessageBox.Show("Veri kaydedilirken bir hata oluştu!", "Veri Güncelleme - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Lütfen zorunlu alanları eksiksiz doldurun!", "Veri Güncelleme - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void PersonelProfil_Click(object sender, EventArgs e)
        {
            if (pfYok == 0)
            {
                var profil = db.Personel.FirstOrDefault(x => x.Id == personelGiris.pId);
                var pf = new FrmAyarlarProfilFoto();
                pf.ShowDialog();
            }

            else
            {
                MessageBox.Show("Personel herhangi bir profil yüklemedi!");
            }
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            PersonelProfil.ImageLocation = TxtGorsel.Text;
            VeriAdSoyad.Text = TxtAd.Text + " " + TxtSoyad.Text.ToUpper();
            VeriEposta.Text = TxtEposta.Text;
            VeriTelNo.Text = TxtTel.Text;

            if (TxtAd.Text != "" && TxtSoyad.Text != "" && TxtTel.Text.Length == 11 && TxtVarsayilan.Value != 0)
            {
                BtnKaydet.Visible = Visible;
            }

            
            
            else if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtTel.Text.Length != 11 || TxtVarsayilan.Value == 0)
            {
                BtnKaydet.Visible = false;
            }


            if (TxtAd.Text != "")
            {
                p1.BackColor = Color.FromArgb(14, 73, 112);
            }

            if (TxtSoyad.Text != "")
            {
                p2.BackColor = Color.FromArgb(14, 73, 112);
            }

            if (TxtTel.Text.Length == 11)
            {
                p4.BackColor = Color.FromArgb(14, 73, 112);
            }

            if (TxtVarsayilan.Value != 0)
            {
                p6.BackColor = Color.FromArgb(14, 73, 112);
            }

            if (TxtAd.Text == "")
            {
                p1.BackColor = Color.Red;
            }
            if (TxtSoyad.Text == "")
            {
                p2.BackColor = Color.Red;
            }
            if (TxtTel.Text == "" || TxtTel.Text.Length < 11)
            {
                p4.BackColor = Color.Red;
            }
            if (TxtVarsayilan.Value == 0)
            {
                p6.BackColor = Color.Red;
            }


            
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
