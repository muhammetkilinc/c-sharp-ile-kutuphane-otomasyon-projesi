using AForge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmKitapAlanDetay : Form
    {
        public FrmKitapAlanDetay()
        {
            InitializeComponent();
        }
        public int kitapAlan = 0;
        ekosEntities db = new ekosEntities();

        private void FrmKitapAlanDetay_Load(object sender, EventArgs e)
        {
            if (kitapAlan != 0)
            {
                var detay = db.KitapAlanOgrenci.Find(kitapAlan);
                OgrOkulNo.Text = detay.Ogrenciler.OgrNo;
                OgrAdSoyad.Text = detay.Ogrenciler.OgrAd + " " + detay.Ogrenciler.OgrSoyad;
                OgrBolum.Text = detay.Ogrenciler.Bolumler.BolumAd;
                OgrTelNo.Text = detay.Ogrenciler.OgrTel;
                OgrEposta.Text = detay.Ogrenciler.OgrEposta;

                KitapGorsel.ImageLocation = detay.Kitaplar.FotoURL;
                KitapIsbn.Text = detay.Kitaplar.Isbn;
                KitapSn.Text = detay.Kitaplar.SnNumarasi;
                KitapAd.Text = detay.Kitaplar.KitapAdi;
                KitapSayfaSayisi.Text = detay.Kitaplar.SayfaSayisi.ToString();
                KitapYazar.Text = detay.Kitaplar.Yazarlar.YazarAd + " " + detay.Kitaplar.Yazarlar.YazarSoyad;
                KitapYayinevi.Text = detay.Kitaplar.Yayinevi.YayineviAd;

                VeriAlis.Text = detay.AlisTarihi.ToString();
                VeriTeslim.Text = detay.TeslimTarihi.ToString();
                if (detay.TeslimTarihi != null)
                {
                    VeriOkuduguGunSayisi.Text = detay.GecenGunSayisi.ToString() + " gün içinde okundu.";
                    VeriYasalSure.Text = detay.geciktirmeGunSayisi.ToString();

                    if (detay.GecenGunSayisi == 0)
                    {
                        VeriOkuduguGunSayisi.Text = "Aynı gün içinde okundu.";
                    }

                    if (detay.HasarliTeslim == true)
                    {
                        VeriBilgi.Text = "Hasarlı Teslim Edildi.";
                        VeriBilgi.ForeColor = Color.Red;
                    }

                    if (detay.HasarliTeslim == false)
                    {
                        VeriBilgi.Text = "Hasarsız Teslim Edildi.";
                        VeriBilgi.ForeColor = Color.Green;
                    }




                    int gecenGun = int.Parse(detay.GecenGunSayisi.ToString());
                    int yasalSinir = int.Parse(detay.geciktirmeGunSayisi.ToString());
                    int hesaplama = gecenGun - yasalSinir;

                    if (hesaplama > 0)
                    {
                        VeriGeciktirme.Text = hesaplama + " gün geç teslim edildi.";
                        VeriGeciktirme.ForeColor = Color.Red;
                    }
                    else
                    {
                        VeriGeciktirme.Text = "Zamanında teslim edildi.";
                        VeriGeciktirme.ForeColor = Color.Green;
                    }
                }
                else
                {
                    LblKalanSure.Visible= true;
                    VeriKalanSure.Visible= true;
                    VeriBilgi.Text = "Okunuyor ...";
                    VeriOkuduguGunSayisi.Text = "Okunuyor ...";
                    VeriYasalSure.Text = detay.geciktirmeGunSayisi.ToString();
                    VeriGeciktirme.Text = "Teslim edilmedi!";
                    VeriGeciktirme.ForeColor = Color.Red;

                    int gecenGun = int.Parse(detay.GecenGunSayisi.ToString());
                    int yasalSinir = int.Parse(detay.geciktirmeGunSayisi.ToString());
                    int hesaplama = gecenGun - yasalSinir;

                    if (hesaplama <= 0)
                    {
                        VeriKalanSure.Text = Math.Abs(hesaplama) + " gün içinde teslim edilmelidir.";
                        VeriGeciktirme.ForeColor = Color.Red;
                    }

                    if (hesaplama > 0)
                    {
                        VeriKalanSure.Text = hesaplama + " gün geç teslim edildi sayılacak.";
                        VeriGeciktirme.ForeColor = Color.Red;
                    }
                }




                if (detay.Kitaplar.TercumanId != null)
                {
                    int tercumanId = int.Parse(detay.Kitaplar.TercumanId.ToString());
                    foreach (var item in db.Yazarlar)
                    {
                        if (item.Id == tercumanId)
                        {
                            KitapTercuman.Text = item.YazarAd + " " + item.YazarSoyad;
                        }
                    }
                }
                
                
            }
        }

        private void BtnGenelBilgi_Click(object sender, EventArgs e)
        {
            PanelGenelBilgi.Visible = true;
            PanelTeslim.Visible = false;
            BtnGenelBilgi.BackColor = Color.White;
            BtnGenelBilgi.ForeColor = Color.Black;

            BtnTeslim.BackColor = Color.FromArgb(0, 36, 60);
            BtnTeslim.ForeColor = Color.White;
        }

        private void BtnTeslim_Click(object sender, EventArgs e)
        {
            PanelTeslim.Visible = true;
            PanelGenelBilgi.Visible = false;
            BtnTeslim.BackColor = Color.White;
            BtnTeslim.ForeColor = Color.Black;

            BtnGenelBilgi.BackColor = Color.FromArgb(0, 36, 60);
            BtnGenelBilgi.ForeColor = Color.White;
        }
    }
}
