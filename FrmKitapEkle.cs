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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ekos
{
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }

        ekosEntities db = new ekosEntities();
        public int gelenKategori = 0;
        public int yazar = 0;
        public int yayinevi = 0;
        public int tercuman = 0;
        public int sayfaNo = 0;

        private void TxtFoto_TextChanged(object sender, EventArgs e)
        {
                KitapGorsel.ImageLocation = TxtFoto.Text;
            
        }

        public void kontrol()
        {

            

            var yazarlar = db.Yazarlar.OrderBy(x => x.YazarAd).ToList();
            int deger = db.Yazarlar.Select(x => x.Id).Count();
            string[] yazarString = new string[deger];
            int say = 0;
            foreach (var item in yazarlar)
            {
                yazarString[say] = item.YazarAd + " " + item.YazarSoyad;
                say++;
            }

            foreach (var item in yazarString)
            {
                ComboYazar.Items.Add(item);
            }
            foreach (var item in yazarString)
            {
                ComboTercuman.Items.Add(item);
            }

            ComboYazar.AutoCompleteCustomSource.AddRange(yazarString);
            ComboTercuman.AutoCompleteCustomSource.AddRange(yazarString);




            var kategori = db.KitapKategori.OrderBy(x => x.KategoriAd).ToList();
            int deger2 = db.KitapKategori.Select(x => x.Id).Count();
            string[] KategoriString = new string[deger2];
            int say2 = 0;
            foreach (var item in kategori)
            {
                KategoriString[say2] = item.KategoriAd;
                say2++;
            }

            foreach (var item in KategoriString)
            {
                comboKitapTuru.Items.Add(item);
            }

            comboKitapTuru.AutoCompleteCustomSource.AddRange(KategoriString);




            var yayinevi = db.Yayinevi.ToList();
            int deger3 = db.Yayinevi.Select(x => x.Id).Count();
            string[] yayineviString = new string[deger3];
            int say3 = 0;
            foreach (var item in yayinevi)
            {
                yayineviString[say3] = item.YayineviAd;
                say3++;
            }

            foreach (var item in yayineviString)
            {
                ComboYayinevi.Items.Add(item);
            }

            ComboYayinevi.AutoCompleteCustomSource.AddRange(yayineviString);

        }

        private void TxtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSayfaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
            kontrol();
            TxtIsbn.MaxLength = 13;
            TxtSn.MaxLength = 4;
            TxtSayfaSayisi.MaxLength = 4;

            if (gelenKategori != 0)
            {
                var kt = db.KitapKategori.Find(gelenKategori);
                comboKitapTuru.Text = kt.KategoriAd;
            }

            if (yazar != 0)
            {
                var yazarlar = db.Yazarlar.Find(yazar);
                ComboYazar.Text = yazarlar.YazarAd + " " + yazarlar.YazarSoyad;
            }

            if (yayinevi != 0)
            {
                var yayinevleri = db.Yayinevi.Find(yayinevi);
                ComboYayinevi.Text = yayinevleri.YayineviAd;
            }

            if (tercuman != 0)
            {
                var tercumanlar = db.Yazarlar.Find(tercuman);
                ComboTercuman.Text = tercumanlar.YazarAd + " " + tercumanlar.YazarSoyad;
            }

            if (tercuman == 0)
            {
                ComboTercuman.SelectedIndex = 0;
            }
            

            if (sayfaNo != 0)
            {
                
                TxtSayfaSayisi.Text = sayfaNo.ToString();
            }


            ComboYazar.Items.Remove("Belirtilmedi");


            if (ComboYazar.Text == ComboTercuman.Text)
            {
                ComboTercuman.Text = "";
                ComboTercuman.Items.Remove(ComboYazar.Text);
                MessageBox.Show("Yazar ve tercüman aynı kişi olamaz!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxtIsbn_TextChanged(object sender, EventArgs e)
        {
            VeriIsbn.Text = TxtIsbn.Text;
        }

        private void TxtSn_TextChanged(object sender, EventArgs e)
        {
            VeriSn.Text = TxtSn.Text;
        }

        private void TxtKitapAd_TextChanged(object sender, EventArgs e)
        {
            VeriKitapAd.Text = TxtKitapAd.Text;
        }

        private void TxtSayfaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (TxtSayfaSayisi.Text != "")
            {
                sayfaNo = int.Parse(TxtSayfaSayisi.Text);
                VeriSayfa.Text = TxtSayfaSayisi.Text;
            }
        }

        string adSoyadYazar = "Belirtilmedi";
        private void ComboYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            if (ComboYazar.Text != "Belirtilmedi")
            {
                var y = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad) == ComboYazar.Text);
                yazar = y.Id;
                VeriYazar.Text = y.YazarAd + " " + y.YazarSoyad;

                if (adSoyadYazar != "")
                {
                    if (adSoyadYazar != (y.YazarAd + " " + y.YazarSoyad))
                    {
                        if (adSoyadYazar != "Belirtilmedi")
                        {
                            ComboTercuman.Items.Add(adSoyadYazar);
                            ComboTercuman.AutoCompleteCustomSource.Add(adSoyadYazar);

                        }
                        ComboTercuman.Items.Remove(y.YazarAd + " " + y.YazarSoyad);
                        ComboTercuman.AutoCompleteCustomSource.Remove(y.YazarAd + " " + y.YazarSoyad);
                        adSoyadYazar = y.YazarAd + " " + y.YazarSoyad;
                    }
                }
            }
            else
            {
                ComboYazar.Text = "";
                ComboYazar.Items.Remove("Belirtilmedi");
            }

        }
        
        string adSoyadTercuman = "Belirtilmedi";
        private void ComboTercuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTercuman.Text != "Belirtilmedi")
            {
                var y = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad) == ComboTercuman.Text);
                tercuman = y.Id;
                VeriTercuman.Text = y.YazarAd + " " + y.YazarSoyad;


                if (adSoyadTercuman != "")
                {
                    if (adSoyadTercuman != (y.YazarAd + " " + y.YazarSoyad))
                    {
                        if (adSoyadTercuman != "Belirtilmedi")
                        {
                            ComboYazar.Items.Add(adSoyadTercuman);
                            ComboYazar.AutoCompleteCustomSource.Add(adSoyadTercuman);
                            ComboYazar.Items.Remove("Belirtilmedi");

                        }
                        ComboYazar.Items.Remove("Belirtilmedi");
                        ComboYazar.Items.Remove(y.YazarAd + " " + y.YazarSoyad);
                        ComboYazar.AutoCompleteCustomSource.Remove(y.YazarAd + " " + y.YazarSoyad);
                        adSoyadTercuman = y.YazarAd + " " + y.YazarSoyad;
                    }
                }
            }

            else
            {
                tercuman = 0;
                VeriTercuman.Text = "Belirtilmedi";
                ComboYazar.Items.Add(adSoyadTercuman);
                adSoyadTercuman = "Belirtilmedi";
                ComboYazar.Items.Remove("Belirtilmedi");
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (VeriIsbn.Text != "" && VeriSn.Text != "" && VeriKitapAd.Text != "" && VeriYazar.Text != "" && VeriSayfa.Text != "" && VeriTur.Text != "" && VeriYayinevi.Text != "")
            {
                var kitapEkle = new Kitaplar();
                var yazarId = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad).Contains(VeriYazar.Text));
                var kategoriId = db.KitapKategori.FirstOrDefault(x => x.KategoriAd.Contains(VeriTur.Text));
                var yayineviId = db.Yayinevi.FirstOrDefault(x => x.YayineviAd.Contains(VeriYayinevi.Text));

                kitapEkle.Isbn = VeriIsbn.Text;
                kitapEkle.SnNumarasi = VeriSn.Text;
                kitapEkle.KitapAdi = VeriKitapAd.Text;
                kitapEkle.YazarId = yazarId.Id;
                kitapEkle.KategoriId = kategoriId.Id;
                kitapEkle.YayineviId = yayineviId.Id;
                kitapEkle.SayfaSayisi = int.Parse(VeriSayfa.Text);
                kitapEkle.KitapRafta = true;
                kitapEkle.KitapArsivde = false;
                kitapEkle.KayitTarih = DateTime.Now;

                if (KitapGorsel.Image != null)
                {
                    kitapEkle.FotoURL = TxtFoto.Text;
                }

                if (tercuman != 0)
                {
                    var tercumanId = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad).Contains(VeriTercuman.Text));
                    
                    kitapEkle.TercumanId = tercumanId.Id;
                }


                db.Kitaplar.Add(kitapEkle);
                db.SaveChanges();
                MessageBox.Show("Kitap başarılı bir şekilde kaydedildi.");

                TxtIsbn.Clear();
                TxtSn.Clear();
                TxtFoto.Clear();
                TxtKitapAd.Clear();
                TxtSayfaSayisi.Clear();
                comboKitapTuru.Text = "";
                ComboYazar.Text = "";
                ComboYayinevi.Text = "";
                ComboTercuman.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun! *", "Kitap Ekleme - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboKitapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kt = db.KitapKategori.FirstOrDefault(x => x.KategoriAd == comboKitapTuru.Text);
            gelenKategori = kt.Id;
            VeriTur.Text = kt.KategoriAd;
        }

        private void ComboYayinevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var y = db.Yayinevi.FirstOrDefault(x => x.YayineviAd == ComboYayinevi.Text);
            yayinevi = y.Id;
            VeriYayinevi.Text = y.YayineviAd;
        }
        private void BtnYenikategori_Click(object sender, EventArgs e)
        {
            this.Hide();
            var kategori = new FrmKitapKategorisiEkle();
            kategori.isbn = VeriIsbn.Text;
            kategori.sn = VeriSn.Text;
            kategori.foto = TxtFoto.Text;
            kategori.kitaAd = VeriKitapAd.Text;
            kategori.gelenKategori = gelenKategori;
            kategori.yazar = yazar;
            kategori.yayinevi = yayinevi;
            kategori.sayfaNo = sayfaNo;
            kategori.tercuman = tercuman;
            kategori.ktpGelen = 1;
            kategori.ShowDialog();
        }

        private void BtnYeniYazar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var y = new FrmYazarEkle();
            y.isbn = VeriIsbn.Text;
            y.sn = VeriSn.Text;
            y.foto = TxtFoto.Text;
            y.kitaAd = VeriKitapAd.Text;
            y.gelenKategori = gelenKategori;
            y.yazar = yazar;
            y.yayinevi = yayinevi;
            y.sayfaNo = sayfaNo;
            y.tercuman = tercuman;
            y.ktpEkle = 1;
            y.KtpTercuman = 0;
            y.ktpGelen = 1;
            y.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmQRCode QrCode = new FrmQRCode();
            QrCode.gelenDeger.Text = 1.ToString();
            QrCode.deger = 1;
            this.Hide();
            QrCode.ShowDialog();
        }

        private void BtnYeniYayinevi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var y = new FrmYayineviEkle();
            y.isbn = VeriIsbn.Text;
            y.sn = VeriSn.Text;
            y.foto = TxtFoto.Text;
            y.kitaAd = VeriKitapAd.Text;
            y.gelenKategori = gelenKategori;
            y.yazar = yazar;
            y.yayinevi = yayinevi;
            y.sayfaNo = sayfaNo;
            y.tercuman = tercuman;
            y.ktpEkle = 1;
            y.ktpGelen = 1;
            y.ShowDialog();
        }

        private void BtnYeniTercuman_Click(object sender, EventArgs e)
        {
            this.Hide();
            var y = new FrmYazarEkle();
            y.isbn = VeriIsbn.Text;
            y.sn = VeriSn.Text;
            y.foto = TxtFoto.Text;
            y.kitaAd = VeriKitapAd.Text;
            y.gelenKategori = gelenKategori;
            y.yazar = yazar;
            y.yayinevi = yayinevi;
            y.sayfaNo = sayfaNo;
            y.tercuman = tercuman;
            y.ktpEkle = 1;
            y.KtpTercuman = 1;
            y.ktpGelen = 1;
            y.ShowDialog();
        }
    }
}
