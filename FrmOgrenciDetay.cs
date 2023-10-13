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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ekos
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            OgrNo.MaxLength = 11;
            OgrTel.MaxLength = 11;
            OgrSinif.MaxLength = 1;
            if (id.Text != "id")
            {

                int gelenId = int.Parse(id.Text);
                ekosEntities db = new ekosEntities();
                var bolum = db.Bolumler.ToList();
                var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == gelenId);
                var kitapAlanOgr = db.KitapAlanOgrenci.Count(x => x.Ogrenciler.Id == gelenId);
                var getirmedigiKitap = db.KitapAlanOgrenci.Count(x => x.Ogrenciler.Id == gelenId && x.TeslimTarihi == null);
                var gecikenKitap = db.KitapAlanOgrenci.Where(x => x.Ogrenciler.Id == gelenId).ToList();

                OgrBolum.Items.Add(ogr.Bolumler.BolumAd);
                OgrNo.Text = ogr.OgrNo;
                OgrAd.Text = ogr.OgrAd;
                OgrSoyad.Text = ogr.OgrSoyad;
                OgrTel.Text = ogr.OgrTel;
                OgrEposta.Text = ogr.OgrEposta;
                OgrBolum.SelectedIndex = 0;
                OgrSinif.Text = ogr.SinifNo.ToString();


                if (ogr.KutuphaneBlok == true)
                {
                    KitapVer.Visible = false;
                    label5.Text = "Yasal süresi geçmiş kitabı bulunuyor.";
                }

                if (ogr.MezunMu == true)
                {
                    TxtMezun.Text = "Bu kişi Mezun";
                    TxtMezun.ForeColor = Color.Red;
                }

                if (ogr.DisiplinCezali == true)
                {
                    cezali.Checked = true;
                }

                if (ogr.MezunMu == true)
                {
                    KitapVer.Visible = false;
                    label5.Text = "Bu kişi Mezun";

                    if (kitapAlanOgr == 0)
                    {
                        label9.Visible = false;
                        label10.Visible = false;
                    }
                }

                else if (ogr.DisiplinCezali == true)
                {
                    KitapVer.Visible = false;
                    label5.Text = "Bu kişi Disiplin Cezalı";
                }

                else if (ogr.KitapAlmaSayisi >= 2)
                {
                    KitapVer.Visible = false;
                }

                foreach (var b in bolum)
                {
                    if (ogr.Bolumler.BolumAd != b.BolumAd)
                    {
                        OgrBolum.Items.Add(b.BolumAd);
                    }

                }

                if (getirmedigiKitap > 0)
                {
                    getirmedigiKitaplar.Visible = true;
                }

                if (kitapAlanOgr > 0)
                {
                    KitapGoruntule.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                }

                foreach (var item in gecikenKitap)
                {
                    int gecenGun = int.Parse(item.GecenGunSayisi.ToString());
                    int yasalSinir = int.Parse(item.geciktirmeGunSayisi.ToString());
                    int hesaplama = gecenGun - yasalSinir;

                    if (hesaplama > 0)
                    {
                        gecikenKitaplar.Visible = true;
                        label10.Visible = false;
                    }


                }



            }



            


        }

        private void FrmOgrenciDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OgrEposta.Text == "" || this.OgrEposta.Text.Contains('@') && this.OgrEposta.Text.Contains('.'))
            {
                if (OgrNo.Text != "" && OgrAd.Text != "" && OgrSoyad.Text != "" && OgrTel.Text != "" && OgrEposta.Text != "" && OgrBolum.Text != "" && OgrSinif.Text != "")
                {
                    ekosEntities db = new ekosEntities();
                    var bolumler = db.Bolumler.ToList();
                    int bolumId = 0;
                    foreach (var b in bolumler)
                    {
                        if (OgrBolum.Text == b.BolumAd)
                        {
                            bolumId = b.Id;
                        }
                    }


                    int ogrId = int.Parse(id.Text);
                    var ogrGuncelle = db.Ogrenciler.Find(ogrId);
                    ogrGuncelle.OgrNo = OgrNo.Text;
                    ogrGuncelle.OgrAd = OgrAd.Text;
                    ogrGuncelle.OgrSoyad = OgrSoyad.Text;
                    ogrGuncelle.OgrTel = OgrTel.Text;
                    ogrGuncelle.OgrEposta = OgrEposta.Text;
                    ogrGuncelle.BolumId = bolumId;
                    ogrGuncelle.SinifNo = int.Parse(OgrSinif.Text);


                    if (cezali.Checked == true)
                    {
                        ogrGuncelle.DisiplinCezali = true;
                    }
                    else if (cezali.Checked != true)
                    {
                        ogrGuncelle.DisiplinCezali = false;
                    }

                    db.SaveChanges();
                    this.Hide();
                    MessageBox.Show(ogrGuncelle.OgrAd + " " + ogrGuncelle.OgrSoyad + " isimli öğrenci verisi güncellendi.");

                }

                else
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Eksik veri gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (OgrEposta.Text != "" && !this.OgrEposta.Text.Contains('@') || !this.OgrEposta.Text.Contains('.'))
            {
                MessageBox.Show("Lütfen Mail adresini kontrol edin!", "Email Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void TxtClear1_Click(object sender, EventArgs e)
        {
            OgrNo.Clear();
            TxtClear1.Visible = false;
            OgrNo.Focus();
        }

        private void OgrNo_TextChanged(object sender, EventArgs e)
        {
            if (OgrNo.Text == "")
            {
                TxtClear1.Visible = false;
            }
            else
            {
                TxtClear1.Visible = true;
            }
        }

        private void TxtClear2_Click(object sender, EventArgs e)
        {
            OgrAd.Clear();
            TxtClear2.Visible = false;
            OgrAd.Focus();
        }

        private void OgrAd_TextChanged(object sender, EventArgs e)
        {
            if (OgrAd.Text == "")
            {
                TxtClear2.Visible = false;
            }
            else
            {
                TxtClear2.Visible = true;
            }
        }

        private void TxtClear3_Click(object sender, EventArgs e)
        {
            OgrSoyad.Clear();
            TxtClear3.Visible = false;
            OgrSoyad.Focus();
        }

        private void OgrSoyad_TextChanged(object sender, EventArgs e)
        {
            if (OgrSoyad.Text == "")
            {
                TxtClear3.Visible = false;
            }
            else
            {
                TxtClear3.Visible = true;
            }
        }

        private void TxtClear4_Click(object sender, EventArgs e)
        {
            OgrTel.Clear();
            TxtClear4.Visible = false;
            OgrTel.Focus();

        }

        private void OgrTel_TextChanged(object sender, EventArgs e)
        {
            if (OgrTel.Text == "")
            {
                TxtClear4.Visible = false;
            }
            else
            {
                TxtClear4.Visible = true;
            }
        }

        private void TxtClear5_Click(object sender, EventArgs e)
        {
            OgrEposta.Clear();
            TxtClear5.Visible = false;
            OgrEposta.Focus();
        }

        private void OgrEposta_TextChanged(object sender, EventArgs e)
        {
            if (OgrEposta.Text == "")
            {
                TxtClear5.Visible = false;
            }
            else
            {
                TxtClear5.Visible = true;
            }
        }

        private void OgrSinif_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void KitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenId = int.Parse(id.Text);
                ekosEntities db = new ekosEntities();
                var bolum = db.Bolumler.ToList();
                var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == gelenId);

                FrmKitapVer ktp = new FrmKitapVer();
                ktp.ogrId = ogr.Id;
                this.Hide();
                ktp.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Bu öğrenciye ait ID bilgisi bulunamadı!", "Öğrenci Bilgi - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OgrAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OgrEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void KitapGoruntule_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = OgrNo.Text;
            this.Hide();
            ktpAlan.ShowDialog();
        }

        private void getirmedigiKitaplar_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = OgrNo.Text;
            ktpAlan.OgrDetayDeger = 1;
            this.Hide();
            ktpAlan.ShowDialog();
        }

        private void gecikenKitaplar_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = OgrNo.Text;
            ktpAlan.OgrDetayDeger = 2;
            this.Hide();
            ktpAlan.ShowDialog();
        }
    }
}
