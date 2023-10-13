using AForge;
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
    public partial class FrmKitapVer : Form
    {
        public FrmKitapVer()
        {
            InitializeComponent();
        }
        ekosEntities db = new ekosEntities();
        public int ogrId = 0;
        public int kitapId = 1;
        public int kitapAlanId = 0;

        
        public void btnKitap()
        {
            
        }
        private void btnOgrSec_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.kitapId = kitapId;
            ogr.deger = 1;
            this.Hide();
            ogr.ShowDialog();
        }

        private void FrmKitapVer_Load(object sender, EventArgs e)
        {
            int pId = personelGiris.pId;
            if (pId != 0)
            {
                var personel = db.Personel.Find(pId);
                TxtGeciktirme.Text = personel.VarsayilanKitapGeciktirme.ToString();
            }


            if (kitapAlanId != 0)
            {
                BtnEkle.Text = "TESLİM AL";
                btnOgrSec.Visible = false;
                BtnKitapSec.Visible = false;
                PanelGeciktirme.Visible = false;
                BtnOgrDegistir.Visible = false;
                BtnKitapDegistir.Visible = false;
                BtnYeniOgr.Visible = false;
                BtnYeniKitap.Visible = false;

                VerilerOgr.Visible = true;
                PanelTeslim.Visible = true;
                VerilerKitap.Visible = true;
                BtnEkle.Visible = true;

                var ktOgr = db.KitapAlanOgrenci.Find(kitapAlanId);
                veriOgrId.Text = ktOgr.Ogrenciler.Id.ToString();
                VeriOgrAd.Text = ktOgr.Ogrenciler.OgrAd + " " + ktOgr.Ogrenciler.OgrSoyad;
                VeriOgrNo.Text = ktOgr.Ogrenciler.OgrNo;
                VeriKitapId.Text = ktOgr.Kitaplar.Id.ToString();
                VeriKitapAd.Text = ktOgr.Kitaplar.KitapAdi;
                VeriYazarad.Text = ktOgr.Kitaplar.Yazarlar.YazarAd + " " + ktOgr.Kitaplar.Yazarlar.YazarSoyad;
                KitapGorsel.ImageLocation = ktOgr.Kitaplar.FotoURL;

                ogrId = ktOgr.Ogrenciler.Id;
                kitapId = ktOgr.Kitaplar.Id;


            }
            if (kitapId != 0 || ogrId != 0)
            {
                if (ogrId != 0)
                {
                    btnOgrSec.Visible = false;
                    VerilerOgr.Visible = true;
                    var ogrenci = db.Ogrenciler.Find(ogrId);
                    veriOgrId.Text = ogrenci.Id.ToString();
                    VeriOgrAd.Text = ogrenci.OgrAd + " " + ogrenci.OgrSoyad;
                    VeriOgrNo.Text = ogrenci.OgrNo;
                }
                if (kitapId != 0)
                {
                    BtnKitapSec.Visible = false;
                    VerilerKitap.Visible = true;
                    var kitap = db.Kitaplar.Find(kitapId);
                    VeriKitapId.Text = kitap.Id.ToString();
                    VeriKitapAd.Text = kitap.KitapAdi;
                    VeriYazarad.Text = kitap.Yazarlar.YazarAd + " " + kitap.Yazarlar.YazarSoyad;
                    KitapGorsel.ImageLocation = kitap.FotoURL;
                }

                if (kitapId != 0 && ogrId != 0)
                {
                    BtnEkle.Visible = true;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnDegistir_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.kitapId = kitapId;
            ogr.deger = 1;
            this.Hide();
            ogr.ShowDialog();
        }

        private void BtnKitapSec_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnKitapDegistir_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            

            if (kitapAlanId != 0)
            {
                var kitapAlan = db.KitapAlanOgrenci.Find(kitapAlanId);
                kitapAlan.TeslimTarihi = DateTime.Now;
                kitapAlan.Ogrenciler.KitapAlmaSayisi -= 1;

                if (KontrolHasarsiz.Checked == true)
                {
                    kitapAlan.HasarliTeslim = false;
                }
                else if (KontrolHasarli.Checked == true)
                {
                    kitapAlan.HasarliTeslim = true;
                }

               


                kitapAlan.Kitaplar.KitapRafta = true;


                //

                    var gecenGun = db.KitapAlanOgrenci.OrderBy(x => x.GecenGunSayisi).ToList();
                    int sayac = 0;

                foreach (var item in gecenGun)
                {
                    string alisTarihi = item.AlisTarihi.ToString();


                    DateTime AlisTarih = DateTime.Parse(alisTarihi);
                    DateTime alis = new DateTime(AlisTarih.Year, AlisTarih.Month, AlisTarih.Day);
                    DateTime bugunTarihi = DateTime.Now;
                    TimeSpan gecenZaman = bugunTarihi - alis;
                    int tsInt = int.Parse(gecenZaman.Days.ToString());

                    item.GecenGunSayisi = tsInt;

                    if ((tsInt - item.geciktirmeGunSayisi) > 0 && item.TeslimTarihi == null)
                    {
                        item.Ogrenciler.KutuphaneBlok = true;
                        sayac = item.Ogrenciler.Id;
                    }

                    else
                    {
                        item.Ogrenciler.KutuphaneBlok = false;
                    }

                }


                    //

                db.SaveChanges();
                MessageBox.Show("Başarılı bir şekilde teslim alındı.");
            }
            else
            {
                if (ogrId != 0 && kitapId != 0)
                {
                    var kaydet = new KitapAlanOgrenci();
                    kaydet.OgrId = ogrId;
                    kaydet.KitapId = kitapId;
                    kaydet.AlisTarihi = DateTime.Now;
                    kaydet.geciktirmeGunSayisi = int.Parse(TxtGeciktirme.Text);
                    kaydet.HasarliTeslim = false;
                    kaydet.GecenGunSayisi = 0;
                    kaydet.KayitTarih = DateTime.Now;

                    db.KitapAlanOgrenci.Add(kaydet);
                    db.SaveChanges();



                    var OgrGuncelle = db.Ogrenciler.Find(ogrId);
                    OgrGuncelle.KitapAlmaSayisi += 1;
                    db.SaveChanges();

                    var KitapGuncelle = db.Kitaplar.Find(kitapId);
                    KitapGuncelle.KitapRafta = false;
                    db.SaveChanges();

                    MessageBox.Show("Başarılı bir şekilde kaydedildi.");
                }
            }

                

            



            this.Hide();
            
        }

        private void BtnYeniOgr_Click(object sender, EventArgs e)
        {
            var ekle = new FrmOgrenciDetayliGor();
            ekle.ogrEkleGelen= 1;
            ekle.kitapEkleGelenId = 1;
            this.Hide();
            ekle.ShowDialog();
        }
    }
}
