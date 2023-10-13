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
    public partial class FrmOgrenciDetayliGor : Form
    {
        public FrmOgrenciDetayliGor()
        {
            InitializeComponent();
        }
        public int gelenBolumId = 0;
        ekosEntities db = new ekosEntities();

        public int ogrId = 0;
        public int ogrEkleGelen = 0;
        public int kitapEkleGelenId = 0;
        int deger = 0;
        bool beniHatirla = false;

        public void yenile()
        {
            var kontrolEt = db.Ogrenciler.Find(ogrId);

            if (kontrolEt.MezunMu == false)
            {
                this.Text = kontrolEt.OgrAd + " " + kontrolEt.OgrSoyad + " - EKOS";
            }

            if (kontrolEt.MezunMu == true)
            {
                this.Text = kontrolEt.OgrAd + " " + kontrolEt.OgrSoyad + " (Mezun Öğrenci) - EKOS";
            }

            LblSinif.Text = kontrolEt.SinifNo + ". Sınıf";
            if (kontrolEt.MezunMu == true)
            {
                LblSinif.Text += " / Mezun öğrenci";
            }
        }


        public void BtnTikla(Button btn)
        {
            void BtnNormal(Button normal)
            {
                normal.BackColor = Color.FromArgb(0, 36, 60);
                normal.ForeColor = Color.White;
            }
            BtnNormal(BtnYeniOgr);
            BtnNormal(BtnOgrBilgi);
            BtnNormal(BtnKitapBilgi);
            BtnNormal(BtnEngeller);
            BtnNormal(BtnAldigiKitap);

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }


        private void FrmOgrenciDetayliGor_Load(object sender, EventArgs e)
        {
            TxtOkulNo.MaxLength = 11;
            TxtTel.MaxLength = 11;
            try
            {
                var gecenGun = db.KitapAlanOgrenci.OrderBy(x => x.GecenGunSayisi).ToList();
                int sayac = 0;

                foreach (var item in gecenGun)
                {
                    string alisTarihi = item.AlisTarihi.ToString();
                    DateTime AlisTarih = DateTime.Parse(alisTarihi);
                    DateTime alis = new DateTime(AlisTarih.Year, AlisTarih.Month, AlisTarih.Day);

                    if (item.TeslimTarihi != null && item.GecenGunSayisi == null)
                    {
                        DateTime bugunTarihi = item.TeslimTarihi.Value;
                        TimeSpan gecenZaman = bugunTarihi - alis;
                        int tsInt = int.Parse(gecenZaman.Days.ToString());

                        item.GecenGunSayisi = tsInt;
                    }

                    if (item.TeslimTarihi == null)
                    {
                        DateTime bugunTarihi = DateTime.Now;
                        TimeSpan gecenZaman = bugunTarihi - alis;
                        int tsInt = int.Parse(gecenZaman.Days.ToString());

                        item.GecenGunSayisi = tsInt;

                        if ((tsInt - item.geciktirmeGunSayisi) > 0)
                        {
                            item.Ogrenciler.KutuphaneBlok = true;
                            sayac = item.Ogrenciler.Id;
                        }

                        else
                        {
                            item.Ogrenciler.KutuphaneBlok = false;
                        }
                    }



                }


                db.SaveChanges();
            }
            catch (Exception)
            {

                
            }



            TxtOkulNo.MaxLength = 11;
            TxtTel.MaxLength = 11;
            TxtAd.MaxLength = 50;
            TxtSoyad.MaxLength = 50;
            TxtEposta.MaxLength = 100;
            var bolumler = db.Bolumler.OrderBy(x => x.BolumAd).ToList();
            foreach (var item in bolumler)
            {
                TxtBolum.Items.Add(item.BolumAd);
            }

            if (ogrId != 0)
            {
                BtnEkle.Text = "GÜNCELLE";
                var ogr = db.Ogrenciler.Find(ogrId);

                BtnOgrBilgi.Visible = true;
                BtnKitapBilgi.Visible = true;
                BtnEngeller.Visible = true;
                BtnAldigiKitap.Visible = true;
                PanelYeniOgr.Visible = true;
                ButtonBilgi.Text = "Öğrenci Bilgileri";


                TxtOkulNo.Text = ogr.OgrNo;
                TxtAd.Text = ogr.OgrAd;
                TxtSoyad.Text = ogr.OgrSoyad;
                TxtTel.Text = ogr.OgrTel;
                TxtEposta.Text = ogr.OgrEposta;
                TxtBolum.Text = ogr.Bolumler.BolumAd;
                LblSinif.Text = ogr.SinifNo + ". Sınıf";
                if (ogr.MezunMu == true)
                {
                    LblSinif.Text += " / Mezun öğrenci";
                }

                if (ogr.DisiplinCezali == false)
                {
                    Check.Image = Resources.CheckOff2;
                    CheckText.ForeColor = Color.Black;
                    beniHatirla = false;
                    CheckDisiplin.Checked = false;
                    deger = 0;
                }

                if (ogr.DisiplinCezali == true)
                {
                    Check.Image = Resources.CheckOn2;
                    CheckText.ForeColor = Color.Red;
                    beniHatirla = true;
                    CheckDisiplin.Checked = true;
                    deger = 1;
                }

                if (ogr.MezunMu == false)
                {
                    this.Text = ogr.OgrAd + " " + ogr.OgrSoyad + " - EKOS";
                }

                if (ogr.MezunMu == true)
                {
                    this.Text = ogr.OgrAd + " " + ogr.OgrSoyad + " (Mezun Öğrenci) - EKOS";
                }


                BtnTikla(BtnOgrBilgi);
            }
            else if (ogrId == 0)
            {
                this.Text = "Yeni Öğrenci Ekle - EKOS";
                PanelYeniOgr.Visible = true;
                button1.Visible = true;

                if (CheckDisiplin.Checked == true)
                {
                    Check.Image = Resources.CheckOn2;
                    CheckText.ForeColor = Color.Red;
                    beniHatirla = true;
                    CheckDisiplin.Checked = true;
                    deger = 1;
                }

            }


            if (gelenBolumId != 0)
            {
                var bolum = db.Bolumler.Find(gelenBolumId);
                TxtBolum.Text = bolum.BolumAd;
            }
            if (gelenBolumId == 0)
            {
                TxtBolum.SelectedIndex = 0;
            }
            

            TxtOkulNo.Focus();


        }
        private void CheckPanel_Click(object sender, EventArgs e)
        {
            if (deger == 0)
            {
                Check.Image = Resources.CheckOn2;
                CheckText.ForeColor = Color.Red;
                beniHatirla = true;
                CheckDisiplin.Checked = true;
                deger = 1;
            }
            else if (deger == 1)
            {
                Check.Image = Resources.CheckOff2;
                CheckText.ForeColor = Color.Black;
                beniHatirla = false;
                CheckDisiplin.Checked = false;
                deger = 0;
            }
        }

        private void TxtOkulNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtOkulNo.Text != "")
            {
                TxtClear1.Visible = true;
            }
            else
            {
                TxtClear1.Visible = false;
            }
        }

        private void TxtClear1_Click(object sender, EventArgs e)
        {
            TxtOkulNo.Clear();
            TxtClear1.Visible = false;
            TxtOkulNo.Focus();
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            
            if (TxtAd.Text != "")
            {
                this.Text = TxtAd.Text + " " + TxtSoyad.Text + " - EKOS";
                TxtClear2.Visible = true;
            }
            else
            {
                if (TxtSoyad.Text != "")
                {
                    this.Text = TxtSoyad.Text + " - EKOS";
                }
                else if (TxtSoyad.Text == "")
                {
                    this.Text = "Yeni Öğrenci Ekle - EKOS";
                }

                TxtClear2.Visible = false;
            }
        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {
            
            if (TxtSoyad.Text != "")
            {
                this.Text = TxtAd.Text + " " + TxtSoyad.Text + " - EKOS";
                TxtClear3.Visible = true;
            }
            else
            {
                if (TxtAd.Text != "")
                {
                    this.Text = TxtAd.Text + " - EKOS";
                }
                else if (TxtAd.Text == "")
                {
                    this.Text = "Yeni Öğrenci Ekle - EKOS";
                }
                TxtClear3.Visible = false;
            }
        }

        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            if (TxtTel.Text != "")
            {
                TxtClear4.Visible = true;
            }
            else
            {
                TxtClear4.Visible = false;
            }
        }

        private void TxtEposta_TextChanged(object sender, EventArgs e)
        {
            if (TxtEposta.Text != "")
            {
                TxtClear5.Visible = true;
            }
            else
            {
                TxtClear5.Visible = false;
            }
        }

        private void TxtClear2_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtClear2.Visible = false;
            TxtAd.Focus();
        }

        private void TxtClear3_Click(object sender, EventArgs e)
        {
            TxtSoyad.Clear();
            TxtClear3.Visible = false;
            TxtSoyad.Focus();
        }

        private void TxtClear4_Click(object sender, EventArgs e)
        {
            TxtTel.Clear();
            TxtClear4.Visible = false;
            TxtTel.Focus();
        }

        private void TxtClear5_Click(object sender, EventArgs e)
        {
            TxtEposta.Clear();
            TxtClear5.Visible = false;
            TxtEposta.Focus();
        }

        private void TxtOkulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtOkulNo.Text != "" && TxtOkulNo.Text.Length >= 11 && TxtAd.Text != "" && TxtSoyad.Text != "" && TxtTel.Text != "" && TxtTel.Text.Length >= 11 && TxtBolum.Text != "")
            {
                if (TxtEposta.Text == "" || this.TxtEposta.Text.Contains('@') && this.TxtEposta.Text.Contains('.'))
                {

                    var bolumler = db.Bolumler.ToList();
                    int bolumId = 0;
                    foreach (var b in bolumler)
                    {
                        if (TxtBolum.Text == b.BolumAd)
                        {
                            bolumId = b.Id;
                        }
                    }




                    if (BtnEkle.Text == "GÜNCELLE")
                    {
                        var ogr = db.Ogrenciler.Find(ogrId);

                        var ogrKontrol = db.Ogrenciler.Where(x => x.OgrNo != ogr.OgrNo).ToList();
                        int kontrolSay = 0;
                        foreach (var item in ogrKontrol)
                        {
                            if (item.OgrNo == TxtOkulNo.Text)
                            {
                                MessageBox.Show("Bu okul numarası başka bir öğrenciye ait! \n(Öğrenci Adı: " + item.OgrAd.ToUpper() + " " + item.OgrSoyad.ToUpper() + ")");
                                kontrolSay = 1;
                                break;
                            }
                        }

                        if (kontrolSay == 0)
                        {
                            ogr.OgrNo = TxtOkulNo.Text;
                            ogr.OgrAd = TxtAd.Text;
                            ogr.OgrSoyad = TxtSoyad.Text;
                            ogr.OgrTel = TxtTel.Text;

                            if (TxtEposta.Text != "")
                            {
                                ogr.OgrEposta = TxtEposta.Text;
                            }

                            ogr.BolumId = bolumId;
                            ogr.SinifNo = 1;

                            if (CheckDisiplin.Checked == false)
                            {
                                ogr.DisiplinCezali = false;
                            }

                            if (CheckDisiplin.Checked == true)
                            {
                                ogr.DisiplinCezali = true;
                            }

                            ogr.KayitTarih = DateTime.Now;

                            db.SaveChanges();
                            MessageBox.Show(ogr.OgrAd + " " + ogr.OgrSoyad + " isimli öğrenci güncellendi.");

                            
                            try
                            {
                                var ogrenci = db.Ogrenciler.ToList();

                                foreach (var ogrF in ogrenci)
                                {
                                    int kontrol = int.Parse(ogrF.OgrNo.ToString().Substring(0, 4));

                                    if (DateTime.Now.Month >= 7)
                                    {
                                        if (kontrol == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = false;
                                            ogrF.SinifNo = 1;
                                        }

                                        else if ((kontrol + 1) == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = false;
                                            ogrF.SinifNo = 2;
                                        }

                                        else if ((kontrol + 2) == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = true;
                                            ogrF.SinifNo = 2;
                                        }

                                        else
                                        {
                                            ogrF.MezunMu = true;
                                            ogrF.SinifNo = 2;
                                        }
                                    }

                                    db.SaveChanges();
                                }


                                yenile();
                            }
                            catch (Exception)
                            {


                            }



                        }
                    }



                    if (BtnEkle.Text == "EKLE")
                    {
                        var ogr = new Ogrenciler();

                        var ogrKontrol = db.Ogrenciler.ToList();
                        int kontrolSay = 0;
                        foreach (var item in ogrKontrol)
                        {
                            if (item.OgrNo == TxtOkulNo.Text)
                            {
                                MessageBox.Show("Bu okul numarası başka bir öğrenciye ait! \n(Öğrenci Adı: " + item.OgrAd.ToUpper() + " " + item.OgrSoyad.ToUpper() + ")");
                                kontrolSay = 1;
                                break;
                            }
                        }

                        if (kontrolSay == 0)
                        {
                            ogr.OgrNo = TxtOkulNo.Text;
                            ogr.OgrAd = TxtAd.Text;
                            ogr.OgrSoyad = TxtSoyad.Text;
                            ogr.OgrTel = TxtTel.Text;
                            ogr.KitapAlmaSayisi = 0;
                            ogr.KutuphaneBlok = false;

                            if (TxtEposta.Text != "")
                            {
                                ogr.OgrEposta = TxtEposta.Text;
                            }

                            ogr.BolumId = bolumId;
                            ogr.SinifNo = 1;

                            if (CheckDisiplin.Checked == false)
                            {
                                ogr.DisiplinCezali = false;
                            }

                            if (CheckDisiplin.Checked == true)
                            {
                                ogr.DisiplinCezali = true;
                            }

                            ogr.KayitTarih = DateTime.Now;

                            db.Ogrenciler.Add(ogr);
                            db.SaveChanges();
                            MessageBox.Show(ogr.OgrAd + " " + ogr.OgrSoyad + " isimli öğrenci eklendi.");


                            try
                            {
                                var ogrenci = db.Ogrenciler.ToList();

                                foreach (var ogrF in ogrenci)
                                {
                                    int kontrol = int.Parse(ogrF.OgrNo.ToString().Substring(0, 4));

                                    if (DateTime.Now.Month >= 7)
                                    {
                                        if (kontrol == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = false;
                                            ogrF.SinifNo = 1;
                                        }

                                        else if ((kontrol + 1) == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = false;
                                            ogrF.SinifNo = 2;
                                        }

                                        else if ((kontrol + 2) == DateTime.Now.Year)
                                        {
                                            ogrF.MezunMu = true;
                                            ogrF.SinifNo = 2;
                                        }

                                        else
                                        {
                                            ogrF.MezunMu = true;
                                            ogrF.SinifNo = 2;
                                        }
                                    }

                                    db.SaveChanges();
                                }

                            }
                            catch (Exception)
                            {

                                
                            }


                            ogrId = ogr.Id;
                            var ogrKaydedilen = db.Ogrenciler.Find(ogrId);
                            this.Text = ogrKaydedilen.OgrAd + ogrKaydedilen.OgrSoyad + " - EKOS";

                            if (ogrEkleGelen == 1 && ogrKaydedilen.DisiplinCezali == false && ogrKaydedilen.MezunMu == false && ogrKaydedilen.KutuphaneBlok == false)
                            {
                                var ekle = new FrmKitapVer();
                                ekle.ogrId = ogrKaydedilen.Id;
                                ekle.kitapId = kitapEkleGelenId;
                                this.Hide();
                                ekle.ShowDialog();
                            }
                            if (ogrKaydedilen.DisiplinCezali == true || ogrKaydedilen.MezunMu == true || ogrKaydedilen.KutuphaneBlok == true)
                            {
                                MessageBox.Show("Bu öğrenci kitap alma şartlarını taşımıyor!");
                                
                                BtnOgrBilgi.Visible = true;
                                BtnKitapBilgi.Visible = true;
                                BtnEngeller.Visible = true;
                                BtnAldigiKitap.Visible = true;
                                PanelYeniOgr.Visible = true;
                                button1.Visible = false;

                                BtnTikla(BtnOgrBilgi);
                                ButtonBilgi.Text = "Öğrenci Bilgileri";
                                PanelYeniOgr.Visible = true;
                                PanelKitap.Visible = false;
                                PanelEngeller.Visible = false;
                                PanelAlinanKitap.Visible = false;
                                BtnEkle.Text = "GÜNCELLE";

                                yenile();
                            }
                            else
                            {

                                BtnOgrBilgi.Visible = true;
                                BtnKitapBilgi.Visible = true;
                                BtnEngeller.Visible = true;
                                BtnAldigiKitap.Visible = true;
                                PanelYeniOgr.Visible = true;

                                BtnTikla(BtnOgrBilgi);
                                ButtonBilgi.Text = "Öğrenci Bilgileri";
                                PanelYeniOgr.Visible = true;
                                PanelKitap.Visible = false;
                                PanelEngeller.Visible = false;
                                PanelAlinanKitap.Visible = false;
                                BtnEkle.Text = "GÜNCELLE";

                                yenile();
                            }
                        }
                    }

                }
                else if (TxtEposta.Text != "" && !this.TxtEposta.Text.Contains('@') || !this.TxtEposta.Text.Contains('.'))
                {
                    MessageBox.Show("Lütfen Mail adresini kontrol edin!", "Email Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun!", "Eksik veri gönderimi - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnYeniOgr_Click(object sender, EventArgs e)
        {
            BtnTikla(BtnYeniOgr);
            PanelYeniOgr.Visible = true;
            ButtonBilgi.Text = "Yeni Öğrenci Ekle";
            LblSinif.Text = "Sınıfı, sistem tarafından hesaplanacaktır.";
            BtnEkle.Text = "EKLE";
            TxtOkulNo.Clear();
            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtTel.Clear();
            TxtEposta.Clear();
            TxtBolum.SelectedIndex = 0;
            PanelYeniOgr.Visible = true;
            PanelKitap.Visible = false;
            PanelAlinanKitap.Visible = false;
            PanelEngeller.Visible = false;
            button1.Visible = true;

            Check.Image = Resources.CheckOff2;
            CheckText.ForeColor = Color.Black;
            beniHatirla = false;
            CheckDisiplin.Checked = false;
            deger = 0;

        }

        private void BtnOgrBilgi_Click(object sender, EventArgs e)
        {
            if (ogrId != 0)
            {

                button1.Visible = false;
                BtnTikla(BtnOgrBilgi);
                ButtonBilgi.Text = "Öğrenci Bilgileri";
                PanelYeniOgr.Visible = true;
                PanelKitap.Visible = false;
                PanelEngeller.Visible = false;
                PanelAlinanKitap.Visible = false;

                BtnEkle.Text = "GÜNCELLE";
                var ogr = db.Ogrenciler.Find(ogrId);

                BtnOgrBilgi.Visible = true;
                BtnKitapBilgi.Visible = true;
                BtnEngeller.Visible = true;
                BtnAldigiKitap.Visible = true;
                PanelYeniOgr.Visible = true;
                ButtonBilgi.Text = "Öğrenci Bilgileri";


                TxtOkulNo.Text = ogr.OgrNo;
                TxtAd.Text = ogr.OgrAd;
                TxtSoyad.Text = ogr.OgrSoyad;
                TxtTel.Text = ogr.OgrTel;
                TxtEposta.Text = ogr.OgrEposta;
                TxtBolum.Text = ogr.Bolumler.BolumAd;

                if (ogr.DisiplinCezali == false)
                {
                    Check.Image = Resources.CheckOff2;
                    CheckText.ForeColor = Color.Black;
                    beniHatirla = false;
                    CheckDisiplin.Checked = false;
                    deger = 0;
                }

                if (ogr.DisiplinCezali == true)
                {
                    Check.Image = Resources.CheckOn2;
                    CheckText.ForeColor = Color.Red;
                    beniHatirla = true;
                    CheckDisiplin.Checked = true;
                    deger = 1;
                }



                yenile();

                BtnTikla(BtnOgrBilgi);
            }
        }

        private void BtnKitapBilgi_Click(object sender, EventArgs e)
        {
            if (ogrId != 0)
            {
                button1.Visible = false;
                yenile();
                BtnTikla(BtnKitapBilgi);
                ButtonBilgi.Text = "Kitap İşlemleri";
                PanelYeniOgr.Visible = false;
                PanelEngeller.Visible = false;
                PanelAlinanKitap.Visible = false;
                PanelKitap.Visible = true;




                var bolum = db.Bolumler.ToList();
                var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == ogrId);
                var kitapAlanOgr = db.KitapAlanOgrenci.Count(x => x.Ogrenciler.Id == ogrId);
                var getirmedigiKitap = db.KitapAlanOgrenci.Count(x => x.Ogrenciler.Id == ogrId && x.TeslimTarihi == null);
                var gecikenKitap = db.KitapAlanOgrenci.Where(x => (x.GecenGunSayisi - x.geciktirmeGunSayisi) > 0 && x.OgrId == ogrId).ToList();


                GrpKitapVer.Text = "Mevcut " + ogr.KitapAlmaSayisi + " kitap alındı.";
                GrpVerilenKitap.Text = "Toplam " + kitapAlanOgr + " kitap alındı.";
                GrpGetirmedigiKitap.Text = getirmedigiKitap + " kitap teslim edilmedi.";


                if (ogr.KutuphaneBlok == true)
                {
                    BtnKitapVer.Visible = false;
                    LblKitapVer.Text = "Yasal süresi geçmiş kitabı bulunuyor.";
                }

                if (ogr.MezunMu == true)
                {
                    BtnKitapVer.Visible = false;
                    LblKitapVer.Text = "Bu kişi Mezun";
                }

                if (ogr.MezunMu == false)
                {


                    if (ogr.DisiplinCezali == true)
                    {
                        if (ogr.DisiplinCezali == true)
                        {
                            BtnKitapVer.Visible = false;
                            LblKitapVer.Text = "Bu kişi Disiplin Cezalı";
                        }
                    }
                    else
                    {

                        if (ogr.KitapAlmaSayisi >= 2)
                        {
                            BtnKitapVer.Visible = false;
                            LblKitapVer.Text = "Bu kişi 2'den fazla kitap aldı.";
                        }
                        else
                        {

                            if (ogr.KutuphaneBlok == true)
                            {
                                BtnKitapVer.Visible = false;
                                LblKitapVer.Text = "Yasal süresi geçmiş kitabı bulunuyor.";
                            }
                            else
                            {
                                BtnKitapVer.Visible = true;
                            }
                            
                        }
                    }
                }


                if (getirmedigiKitap > 0)
                {
                    BtnGetirmedigiKitap.Visible = true;
                }

                if (kitapAlanOgr > 0)
                {
                    BtnVerilenKitap.Visible = true;
                }

                if (LblVerilenKitap.Text == "Bu kişi hiç kitap almadı." && BtnVerilenKitap.Visible == false)
                {
                    LblGetirmedigiKitap.Text = "Hiç kitap alınmadı.";
                }


                int say = 0;
                foreach (var item in gecikenKitap)
                {
                    say += 1;
                    GrpGeciktirdigiKitap.Text = "Toplam " + say + " kitap geç verildi.";
                    BtnGeciktirdigiKitap.Visible = true;
                }






            }
        }

        private void BtnEngeller_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            yenile();
            BtnTikla(BtnEngeller);
            ButtonBilgi.Text = "Mevcut Engeller";
            PanelYeniOgr.Visible = false;
            PanelKitap.Visible = false;
            PanelAlinanKitap.Visible = false;
            PanelEngeller.Visible = true;

            LstEngeller.Items.Clear();
            int count = 0;
            var bolum = db.Bolumler.ToList();
            var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == ogrId);
            var kitapAlanOgr = db.KitapAlanOgrenci.Count(x => x.Ogrenciler.Id == ogrId);
            var gecikenKitap = db.KitapAlanOgrenci.Where(x => (x.GecenGunSayisi - x.geciktirmeGunSayisi) > 0 && x.OgrId == ogrId && x.TeslimTarihi == null).ToList();


            if (ogr.KutuphaneBlok == true)
            {
                count++;
                LstEngeller.Items.Add(count + "- Sistem tarafından bloke edildi.");
            }

            if (ogr.MezunMu == true)
            {
                count++;
                LstEngeller.Items.Add(count + "- Mezun oldu");
            }

            if (ogr.DisiplinCezali == true)
            {
                count++;
                LstEngeller.Items.Add(count + "- Disiplin cezası aldı.");
            }

            if (ogr.KitapAlmaSayisi >= 2)
            {
                count++;
                LstEngeller.Items.Add(count + "- Mevcut 2 kitap elinde bulunduruyor.");
            }

            if (gecikenKitap.Count() > 0)
            {
                count++;
                LstEngeller.Items.Add(count + "- Yasal süresi geçmiş kitabı teslim etmedi.");
            }



        }

        private void BtnAldigiKitap_Click(object sender, EventArgs e)
        {
            if (ogrId != 0)
            {
                button1.Visible = false;
                BtnTikla(BtnAldigiKitap);
                ButtonBilgi.Text = "Aldığı Tüm Kitaplar";
                PanelYeniOgr.Visible = false;
                PanelKitap.Visible = false;
                PanelEngeller.Visible = false;
                PanelAlinanKitap.Visible = true;

                var query = from ktOgr in db.KitapAlanOgrenci
                            join Ogrenci in db.Ogrenciler
                            on ktOgr.OgrId equals Ogrenci.Id
                            join Kitap in db.Kitaplar
                            on ktOgr.KitapId equals Kitap.Id
                            join yazar in db.Yazarlar
                            on Kitap.YazarId equals yazar.Id
                            where Ogrenci.Id == ogrId
                            orderby ktOgr.Id
                            select new
                            {
                                ktOgr.Id,
                                Kitap.KitapAdi,
                                Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                ktOgr.AlisTarihi,
                                ktOgr.TeslimTarihi,
                                ktOgr.GecenGunSayisi,
                                YasalSure = ktOgr.geciktirmeGunSayisi,
                                geciktiMi = (ktOgr.GecenGunSayisi - ktOgr.geciktirmeGunSayisi) > 0 ? "Evet" : "Hayır",
                                TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                            };
                DataAlinanKitap.DataSource = query.ToList();


            }
        }

        private void BtnKitapVer_Click(object sender, EventArgs e)
        {
            ekosEntities db = new ekosEntities();
            var bolum = db.Bolumler.ToList();
            var ogr = db.Ogrenciler.FirstOrDefault(x => x.Id == ogrId);

            FrmKitapVer ktp = new FrmKitapVer();
            ktp.ogrId = ogr.Id;
            ktp.kitapId = kitapEkleGelenId;
            this.Hide();
            ktp.ShowDialog();
        }

        private void BtnVerilenKitap_Click(object sender, EventArgs e)
        {
            var ogrNo = db.Ogrenciler.Find(ogrId);
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = ogrNo.OgrNo;
            this.Hide();
            ktpAlan.ShowDialog();
        }

        private void BtnGetirmedigiKitap_Click(object sender, EventArgs e)
        {
            var ogrNo = db.Ogrenciler.Find(ogrId);
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = ogrNo.OgrNo;
            ktpAlan.OgrDetayDeger = 1;
            this.Hide();
            ktpAlan.ShowDialog();
        }

        private void BtnGeciktirdigiKitap_Click(object sender, EventArgs e)
        {
            var ogrNo = db.Ogrenciler.Find(ogrId);
            FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
            ktpAlan.okulNo = ogrNo.OgrNo;
            ktpAlan.OgrDetayDeger = 2;
            this.Hide();
            ktpAlan.ShowDialog();
        }

        private void DataAlinanKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LblAlinanKitap.Visible= false;
            int id = int.Parse(DataAlinanKitap.CurrentRow.Cells[0].Value.ToString());
            var kitapAlan = db.KitapAlanOgrenci.Find(id);
            BtnDetay.Visible = true;

            if (kitapAlan.TeslimTarihi == null)
            {
                BtnTeslim.Visible = true;
            }

            else if (kitapAlan.TeslimTarihi != null)
            {
                BtnTeslim.Visible = false;
            }
        }

        private void BtnTeslim_Click(object sender, EventArgs e)
        {
            var teslimAl = new FrmKitapVer();
            teslimAl.kitapAlanId = int.Parse(DataAlinanKitap.CurrentRow.Cells[0].Value.ToString());
            this.Hide();
            teslimAl.ShowDialog();
        }

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DataAlinanKitap.CurrentRow.Cells[0].Value.ToString());
            var kayit = db.KitapAlanOgrenci.Find(id);

            var detay = new FrmKitapAlanDetay();
            detay.kitapAlan = kayit.Id;
            detay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bolum = new FrmOgrenciBolumEkle();
            bolum.OgrGelen = 1;
            bolum.OgrNo = TxtOkulNo.Text;
            bolum.OgrAd = TxtAd.Text;
            bolum.OgrSoyad = TxtSoyad.Text;
            bolum.OgrTel = TxtTel.Text;
            bolum.OgrEposta = TxtEposta.Text;
            bolum.checkDisiplin = CheckDisiplin.Checked;
            bolum.GelenBolumId = gelenBolumId;
            this.Hide();
            bolum.ShowDialog();
        }

        private void TxtBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtBolum.Text != "")
            {
                string bolumAd = TxtBolum.Text;
                var bolum = db.Bolumler.FirstOrDefault(x => x.BolumAd == bolumAd);
                gelenBolumId = bolum.Id;
            }
        }

        private void DataAlinanKitap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(DataAlinanKitap.CurrentRow.Cells[0].Value.ToString());
            var kayit = db.KitapAlanOgrenci.Find(id);

            var detay = new FrmKitapAlanDetay();
            detay.kitapAlan = kayit.Id;
            detay.ShowDialog();
        }
    }
}
