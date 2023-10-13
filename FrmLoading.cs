using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
        ekosEntities db = new ekosEntities();
        int logId = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            try
            {
                loading.Width += 7;
                if (loading.Width > 210)
                {
                    timer1.Stop();
                    

                    var BeniHatirla = db.PersonelBeniHatirla.Find(1);
                    if (BeniHatirla.aktif != false)
                    {
                        try
                        {


                            var log = new PersonelLogKaydi();
                            log.PersonelId = BeniHatirla.PersonelId;
                            log.GirisTarihi = DateTime.Now;
                            log.ProgramAdi = "Masaüstü Uygulaması";


                            ekos.PersonelLogKaydi.Add(log);
                            ekos.SaveChanges();

                            var logForeach = ekos.PersonelLogKaydi.ToList();
                            foreach (var item in logForeach)
                            {
                                logId = item.Id;
                            }

                                //txtKullanici.Text = personelId.pId.ToString();
                                personelGiris.pId = int.Parse(BeniHatirla.PersonelId.ToString());
                                personelGiris.LogId = logId;
                                AllDesign anasayfa = new AllDesign();
                                anasayfa.Show();
                                this.Hide();
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Beni Hatırla özelliği devre dışı!", "Giriş İşlemleri - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        FrmLogin login = new FrmLogin();
                        this.Hide();
                        login.Show();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: Z10000", "Hata: Z10000");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Stop();
                try
                {
                    try
                    {

                        var personel = ekos.Personel.OrderBy(x => x.Id).ToList();
                        var hata = ekos.PersonelHataliGiris.OrderBy(x => x.PersonelId).ToList();
                        List<int> PersonelListe = new List<int>();
                        List<int> HataListe = new List<int>();
                        List<int> ToplamListe = new List<int>();

                        foreach (var item in personel)
                        {
                            PersonelListe.Add(item.Id);
                        }

                        foreach (var item in hata)
                        {
                            HataListe.Add(int.Parse(item.PersonelId.Value.ToString()));
                        }

                        ToplamListe = HataListe.Concat(PersonelListe).ToList();

                        foreach (var item in hata)
                        {
                            if (item.PersonelId == ToplamListe[0])
                            {
                                ToplamListe.Remove(item.PersonelId.Value);
                            }
                        }

                        foreach (var item in hata)
                        {
                            if (item.PersonelId == ToplamListe[0])
                            {
                                ToplamListe.Remove(item.PersonelId.Value);
                            }
                        }

                        foreach (var item in ToplamListe)
                        {
                            var hataEkle = new PersonelHataliGiris();
                            hataEkle.PersonelId = item;
                            hataEkle.BilgisayarAdi = null;
                            hataEkle.GirisTespitTarih = DateTime.Now;
                            hataEkle.aktif = false;
                            ekos.PersonelHataliGiris.Add(hataEkle);
                            ekos.SaveChanges();
                        }



                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Hatalı giriş tespiti devre dışı!", "Otomotik veri düzenleme (OVD) hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //


                    try
                    {
                        var gecenGun = ekos.KitapAlanOgrenci.OrderBy(x => x.GecenGunSayisi).ToList();
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

                        ekos.SaveChanges();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Kitap Alan öğrencilerin bazılarında alış ve teslim tarihi arasında hata var!", "Otomotik veri düzenleme (OVD) hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        var ogrenci = ekos.Ogrenciler.ToList();

                        foreach (var ogr in ogrenci)
                        {
                            int kontrol = int.Parse(ogr.OgrNo.ToString().Substring(0, 4));

                            if (DateTime.Now.Month >= 7)
                            {
                                if (kontrol == DateTime.Now.Year)
                                {
                                    ogr.MezunMu = false;
                                    ogr.SinifNo = 1;
                                }

                                else if ((kontrol + 1) == DateTime.Now.Year)
                                {
                                    ogr.MezunMu = false;
                                    ogr.SinifNo = 2;
                                }

                                else if ((kontrol + 2) == DateTime.Now.Year)
                                {
                                    ogr.MezunMu = true;
                                    ogr.SinifNo = 2;
                                }

                                else
                                {
                                    ogr.MezunMu = true;
                                    ogr.SinifNo = 2;
                                }
                            }

                            ekos.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Bazı öğrencilerin kayıt tarihinde hata var!", "Otomotik veri düzenleme (OVD) hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Otomotik Veri düzenleme (OVD) sırasında hata oluştu!", "Otomotik veri düzenleme (OVD) hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Opacity += .4;
        }
        ekosEntities ekos = new ekosEntities();
        private void FrmLoading_Load(object sender, EventArgs e)
        {
            var personel = ekos.PersonelSifre.ToList();

            Opacity = 0;
            loading.Width = 0;
            timer2.Start();
        }
    }
}
