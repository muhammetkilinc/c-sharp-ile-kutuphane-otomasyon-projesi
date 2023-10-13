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
    public partial class FrmYayineviEkle : Form
    {
        public FrmYayineviEkle()
        {
            InitializeComponent();
        }
        ekosEntities db = new ekosEntities();
        public string isbn = "";
        public string sn = "";
        public string foto = "";
        public string kitaAd = "";
        public int gelenKategori = 0;
        public int yazar = 0;
        public int yayinevi = 0;
        public int sayfaNo = 0;
        public int tercuman = 0;
        public int ktpEkle = 0;
        public int ktpGelen = 0;

        public void Paneller()
        {
            p1.BackColor = Color.Gray;
            p2.BackColor = Color.Gray;
        }
        public void temizle()
        {
            TxtYazarAd.Clear();
            TxtAdres.Clear();
            YazarListele.ClearSelection();
        }
        private void FrmYayineviEkle_Load(object sender, EventArgs e)
        {
            p1.BackColor = Color.FromArgb(0, 204, 255);


            var query = from y in db.Yayinevi
                        orderby y.YayineviAd
                        select new
                        {
                            y.Id,
                            y.YayineviAd,
                            y.Adres
                        };

            YazarListele.DataSource = query.ToList();
            YazarListele.ClearSelection();
        }

        private void TxtYazarAd_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p1.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void TxtYazarSoyad_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p2.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void YazarListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int YazarId = int.Parse(YazarListele.CurrentRow.Cells[0].Value.ToString());
            var YazarBul = db.Yayinevi.Find(YazarId);


            TxtYazarAd.Text = YazarBul.YayineviAd;
            TxtAdres.Text = YazarBul.Adres;

            BtnEkle.Text = "GÜNCELLE";

            Paneller();
            p1.BackColor = Color.FromArgb(0, 204, 255);
            p1.Focus();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
                if (BtnEkle.Text == "EKLE")
                {
                    var kontrol = db.Yayinevi.ToList();
                    int kontrolSay = 0;
                    foreach (var item in kontrol)
                    {
                        if (item.YayineviAd.ToLower() == TxtYazarAd.Text.ToLower())
                        {
                            MessageBox.Show("Bu yayınevi zaten mevcut!");
                            kontrolSay = 1;
                            break;
                        }
                    }

                    if (kontrolSay == 0)
                    {
                        var yazarEkle = new Yayinevi();
                        yazarEkle.YayineviAd = TxtYazarAd.Text;
                        yazarEkle.Adres = TxtAdres.Text;
                        yazarEkle.KayitTarih = DateTime.Now;
                        db.Yayinevi.Add(yazarEkle);
                        db.SaveChanges();
                        MessageBox.Show(TxtYazarAd.Text + " " + " isimli yayınevi kaydedildi.");

                        if (ktpEkle == 1)
                        {
                            var data = TxtYazarAd.Text;
                            var yazarId = db.Yayinevi.FirstOrDefault(x => x.YayineviAd.Contains(data));
                            var kitapEkle = new FrmKitapEkle();
                            kitapEkle.TxtIsbn.Text = isbn;
                            kitapEkle.TxtSn.Text = sn;
                            kitapEkle.TxtFoto.Text = foto;
                            kitapEkle.TxtKitapAd.Text = kitaAd;
                            kitapEkle.gelenKategori = gelenKategori;
                            kitapEkle.yazar = yazar;
                            kitapEkle.yayinevi = yazarId.Id;
                            kitapEkle.sayfaNo = sayfaNo;
                            kitapEkle.tercuman = tercuman;
                            this.Hide();
                            kitapEkle.ShowDialog();
                        }

                        temizle();
                        Paneller();
                    }
                }

                else if (BtnEkle.Text == "GÜNCELLE")
                {
                    int YazarId = int.Parse(YazarListele.CurrentRow.Cells[0].Value.ToString());
                    var YazarBul = db.Yayinevi.Find(YazarId);

                    if (TxtYazarAd.Text == YazarBul.YayineviAd)
                {
                    YazarBul.Adres = TxtAdres.Text;
                    YazarBul.KayitTarih = DateTime.Now;
                        db.SaveChanges();
                        MessageBox.Show(TxtYazarAd.Text + " " + " isimli yayınevi güncellendi.");


                        if (ktpEkle == 1)
                        {
                            var kitapEkle = new FrmKitapEkle();
                            kitapEkle.TxtIsbn.Text = isbn;
                            kitapEkle.TxtSn.Text = sn;
                            kitapEkle.TxtFoto.Text = foto;
                            kitapEkle.TxtKitapAd.Text = kitaAd;
                            kitapEkle.gelenKategori = gelenKategori;
                            kitapEkle.yazar = yazar;
                            kitapEkle.yayinevi = YazarBul.Id;
                            kitapEkle.sayfaNo = sayfaNo;
                            kitapEkle.tercuman = tercuman;
                            this.Hide();
                            kitapEkle.ShowDialog();
                        }

                        temizle();
                        Paneller();
                        BtnEkle.Text = "EKLE";
                    }
                    else
                    {
                        var kontrol = db.Yayinevi.ToList();
                        int kontrolSay = 0;
                        foreach (var item in kontrol)
                        {
                            if (item.YayineviAd.ToLower() == TxtYazarAd.Text.ToLower())
                            {
                                MessageBox.Show("Bu yayınevi zaten mevcut!");
                                kontrolSay = 1;
                                break;
                            }
                        }

                        if (kontrolSay == 0)
                        {
                            YazarBul.YayineviAd = TxtYazarAd.Text;
                            YazarBul.Adres = TxtAdres.Text;
                            YazarBul.KayitTarih = DateTime.Now;
                            db.SaveChanges();
                            MessageBox.Show(TxtYazarAd.Text + " " + TxtAdres.Text + " isimli yayınevi güncellendi.");


                            temizle();
                            Paneller();
                        }

                    }
                }

                YazarListele.DataSource = "";
                var liste = from y in db.Yayinevi
                            orderby y.YayineviAd
                            select new
                            {
                                y.Id,
                                y.YayineviAd,
                                y.Adres
                            };

                YazarListele.DataSource = liste.ToList();

            
        }

        private void TxtYazarAra_Click(object sender, EventArgs e)
        {
            TxtYazarAra.Text = "";
        }

        private void TxtYazarAra_TextChanged(object sender, EventArgs e)
        {
            var query = from y in db.Yayinevi
                        orderby y.YayineviAd
                        join k in db.Kitaplar
                        on y.Id equals k.Id
                        where (y.YayineviAd + y.Adres + k.KitapAdi).Contains(TxtYazarAra.Text)
                        orderby y.YayineviAd
                        select new
                        {
                            y.Id,
                            y.YayineviAd,
                            y.Adres
                        };

            YazarListele.DataSource = query.ToList();
        }

        private void YazarListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = YazarListele.CurrentRow.Cells[0].Value;
            var yayinId = db.Yayinevi.Find(data);
            var kitapEkle = new FrmKitapEkle();
            kitapEkle.TxtIsbn.Text = isbn;
            kitapEkle.TxtSn.Text = sn;
            kitapEkle.TxtFoto.Text = foto;
            kitapEkle.TxtKitapAd.Text = kitaAd;
            kitapEkle.gelenKategori = gelenKategori;
            kitapEkle.yazar = yazar;
            kitapEkle.yayinevi = yayinId.Id;
            kitapEkle.sayfaNo = sayfaNo;
            kitapEkle.tercuman = tercuman;
            this.Hide();
            kitapEkle.ShowDialog();
        }

        private void FrmYayineviEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ktpGelen == 1)
            {
                var kitapEkle = new FrmKitapEkle();
                kitapEkle.TxtIsbn.Text = isbn;
                kitapEkle.TxtSn.Text = sn;
                kitapEkle.TxtFoto.Text = foto;
                kitapEkle.TxtKitapAd.Text = kitaAd;
                kitapEkle.gelenKategori = gelenKategori;
                kitapEkle.yazar = yazar;
                kitapEkle.tercuman = tercuman;
                kitapEkle.sayfaNo = sayfaNo;
                kitapEkle.yayinevi = yayinevi;
                this.Hide();
                kitapEkle.ShowDialog();
            }
        }
    }
}
