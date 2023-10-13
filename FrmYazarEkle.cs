using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmYazarEkle : Form
    {
        public FrmYazarEkle()
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
        public int KtpTercuman = 0;
        public int ktpGelen = 0;

        public int allDesignYazar = 0;


        public void Paneller()
        {
            p1.BackColor = Color.Gray;
            p2.BackColor = Color.Gray;
            p3.BackColor = Color.Gray;
            p4.BackColor = Color.Gray;
        }
        public void temizle()
        {
            TxtYazarAd.Clear();
            TxtYazarSoyad.Clear();
            TxtYazarEposta.Clear();
            TxtYazarHakkinda.Clear();
            YazarListele.ClearSelection();
        }


        private void FrmYazarEkle_Load(object sender, EventArgs e)
        {
            p1.BackColor= Color.FromArgb(0, 204, 255);
            YazarListele.DataSource = "";

            if (allDesignYazar == 0)
            {
                var liste = from y in db.Yazarlar
                            orderby y.YazarAd
                            select new
                            {
                                y.Id,
                                y.YazarAd,
                                y.YazarSoyad,
                                y.YazarEposta
                            };

                YazarListele.DataSource = liste.ToList();
                YazarListele.ClearSelection();
            }

            else if (allDesignYazar == 1)
            {
                var liste = from kt in db.KitapAlanOgrenci
                            join k in db.Kitaplar
                            on kt.KitapId equals k.Id
                            join y in db.Yazarlar
                            on k.YazarId equals y.Id
                            orderby y.YazarAd
                            group kt by (kt.Kitaplar.Yazarlar.YazarAd + " " + kt.Kitaplar.Yazarlar.YazarSoyad) into grp
                            where grp.Count() >= 50
                            select new
                            {
                                YazarAd = grp.Key,
                                ToplamOkuma = grp.Count() + " kişi"
                            };

                YazarListele.DataSource = liste.ToList();
                YazarListele.ClearSelection();
            }

            else if (allDesignYazar == 2)
            {
                var Sonuc = db.Kitaplar.GroupBy(x => x.Yazarlar.Id).Select(x => x.FirstOrDefault()).ToList();
                var liste = from y in Sonuc
                            select new
                            {
                                y.Yazarlar.Id,
                                y.Yazarlar.YazarAd,
                                y.Yazarlar.YazarSoyad,
                                y.Yazarlar.YazarEposta
                            };

                YazarListele.DataSource = liste.ToList();
                YazarListele.ClearSelection();
            }
        }

        private void TxtYazarSoyad_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p2.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void TxtYazarAd_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p1.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void TxtYazarEposta_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p3.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void TxtYazarHakkinda_TextChanged(object sender, EventArgs e)
        {
            Paneller();
            p4.BackColor = Color.FromArgb(0, 204, 255);
        }

        private void TxtYazarAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void YazarListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (allDesignYazar == 0 || allDesignYazar == 2)
            {
                int YazarId = int.Parse(YazarListele.CurrentRow.Cells[0].Value.ToString());
                var YazarBul = db.Yazarlar.Find(YazarId);


                TxtYazarAd.Text = YazarBul.YazarAd;
                TxtYazarSoyad.Text = YazarBul.YazarSoyad;
                TxtYazarEposta.Text = YazarBul.YazarEposta;
                TxtYazarHakkinda.Text = YazarBul.YazarHakkinda;

                BtnEkle.Text = "GÜNCELLE";

                Paneller();
                p1.BackColor = Color.FromArgb(0, 204, 255);
                p1.Focus();
            }

            else
            {
                string YazarId = YazarListele.CurrentRow.Cells[0].Value.ToString();
                var YazarBul = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad).Contains(YazarId));

                TxtYazarAd.Text = YazarBul.YazarAd;
                TxtYazarSoyad.Text = YazarBul.YazarSoyad;
                TxtYazarEposta.Text = YazarBul.YazarEposta;
                TxtYazarHakkinda.Text = YazarBul.YazarHakkinda;

                BtnEkle.Text = "GÜNCELLE";

                Paneller();
                p1.BackColor = Color.FromArgb(0, 204, 255);
                p1.Focus();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtYazarEposta.Text == "" || this.TxtYazarEposta.Text.Contains('@') && this.TxtYazarEposta.Text.Contains('.'))
            {


                if (BtnEkle.Text == "EKLE")
                {
                    var kontrol = db.Yazarlar.ToList();
                    int kontrolSay = 0;
                    foreach (var item in kontrol)
                    {
                        if (item.YazarAd.ToLower() == TxtYazarAd.Text.ToLower() && item.YazarSoyad.ToLower() == TxtYazarSoyad.Text.ToLower())
                        {
                            MessageBox.Show("Bu yazar zaten mevcut!");
                            kontrolSay = 1;
                            break;
                        }
                    }

                    if (kontrolSay == 0)
                    {
                        var yazarEkle = new Yazarlar();
                        yazarEkle.YazarAd = TxtYazarAd.Text;
                        yazarEkle.YazarSoyad = TxtYazarSoyad.Text;
                        yazarEkle.YazarEposta = TxtYazarEposta.Text;
                        yazarEkle.YazarHakkinda = TxtYazarHakkinda.Text;
                        yazarEkle.KayitTarih = DateTime.Now;
                        db.Yazarlar.Add(yazarEkle);
                        db.SaveChanges();
                        MessageBox.Show(TxtYazarAd.Text + " " + TxtYazarSoyad.Text + " isimli yazar kaydedildi.");

                        if (ktpEkle == 1)
                        {
                            var data = TxtYazarAd.Text + " " + TxtYazarSoyad.Text;
                            var yazarId = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad).Contains(data));
                            var kitapEkle = new FrmKitapEkle();
                            kitapEkle.TxtIsbn.Text = isbn;
                            kitapEkle.TxtSn.Text = sn;
                            kitapEkle.TxtFoto.Text = foto;
                            kitapEkle.TxtKitapAd.Text = kitaAd;
                            kitapEkle.gelenKategori = gelenKategori;

                            if (KtpTercuman == 0)
                            {
                                kitapEkle.yazar = yazarId.Id;
                                kitapEkle.tercuman = tercuman;
                            }

                            else
                            {
                                kitapEkle.yazar = yazar;
                                kitapEkle.tercuman = yazarId.Id;
                            }



                            kitapEkle.sayfaNo = sayfaNo;
                            kitapEkle.yayinevi = yayinevi;
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
                    var YazarBul = db.Yazarlar.Find(YazarId);

                    if (TxtYazarAd.Text == YazarBul.YazarAd && TxtYazarSoyad.Text == YazarBul.YazarSoyad)
                    {
                        YazarBul.YazarEposta = TxtYazarEposta.Text;
                        YazarBul.YazarHakkinda = TxtYazarHakkinda.Text;
                        YazarBul.KayitTarih = DateTime.Now;
                        db.SaveChanges();
                        MessageBox.Show(TxtYazarAd.Text + " " + TxtYazarSoyad.Text + " isimli yazar güncellendi.");


                        if (ktpEkle == 1)
                        {
                            var kitapEkle = new FrmKitapEkle();
                            kitapEkle.TxtIsbn.Text = isbn;
                            kitapEkle.TxtSn.Text = sn;
                            kitapEkle.TxtFoto.Text = foto;
                            kitapEkle.TxtKitapAd.Text = kitaAd;
                            kitapEkle.gelenKategori = gelenKategori;

                            if (KtpTercuman == 0)
                            {
                                kitapEkle.yazar = YazarBul.Id;
                                kitapEkle.tercuman = tercuman;
                            }

                            else
                            {
                                kitapEkle.yazar = yazar;
                                kitapEkle.tercuman = YazarBul.Id;
                            }



                            kitapEkle.sayfaNo = sayfaNo;
                            kitapEkle.yayinevi = yayinevi;
                            this.Hide();
                            kitapEkle.ShowDialog();
                        }

                        temizle();
                        Paneller();
                        BtnEkle.Text = "EKLE";
                    }
                    else
                    {
                        var kontrol = db.Yazarlar.ToList();
                        int kontrolSay = 0;
                        foreach (var item in kontrol)
                        {
                            if (item.YazarAd.ToLower() == TxtYazarAd.Text.ToLower() && item.YazarSoyad.ToLower() == TxtYazarSoyad.Text.ToLower())
                            {
                                MessageBox.Show("Bu yazar zaten mevcut!");
                                kontrolSay = 1;
                                break;
                            }
                        }

                        if (kontrolSay == 0)
                        {
                            YazarBul.YazarAd = TxtYazarAd.Text;
                            YazarBul.YazarSoyad = TxtYazarSoyad.Text;
                            YazarBul.YazarEposta = TxtYazarEposta.Text;
                            YazarBul.YazarHakkinda = TxtYazarHakkinda.Text;
                            YazarBul.KayitTarih = DateTime.Now;
                            db.SaveChanges();
                            MessageBox.Show(TxtYazarAd.Text + " " + TxtYazarSoyad.Text + " isimli yazar güncellendi.");


                            temizle();
                            Paneller();
                        }

                    }
                }

                YazarListele.DataSource = "";
                var liste = from y in db.Yazarlar
                            orderby y.YazarAd
                            select new
                            {
                                y.Id,
                                y.YazarAd,
                                y.YazarSoyad,
                                y.YazarEposta
                            };

                YazarListele.DataSource = liste.ToList();

            }
            else if (TxtYazarEposta.Text != "" && !this.TxtYazarEposta.Text.Contains('@') || !this.TxtYazarEposta.Text.Contains('.'))
            {
                MessageBox.Show("Lütfen Mail adresini kontrol edin!", "Email Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void TxtYazarAra_Click(object sender, EventArgs e)
        {
            TxtYazarAra.Text = "";
        }

        private void TxtYazarAra_TextChanged(object sender, EventArgs e)
        {
            YazarListele.DataSource = "";
            allDesignYazar = 0;
            if (TxtYazarAra.Text != "")
            {
                var query = from y in db.Yazarlar
                            orderby y.YazarAd
                            where (y.YazarAd + " " + y.YazarSoyad).Contains(TxtYazarAra.Text)
                            orderby y.YazarAd
                            select new
                            {
                                y.Id,
                                y.YazarAd,
                                y.YazarSoyad,
                                y.YazarEposta
                            };

                YazarListele.DataSource = query.ToList();
            }

            else
            {
                var liste = from y in db.Yazarlar
                            orderby y.YazarAd
                            select new
                            {
                                y.Id,
                                y.YazarAd,
                                y.YazarSoyad,
                                y.YazarEposta
                            };

                YazarListele.DataSource = liste.ToList();
            }
        }

        private void YazarListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (allDesignYazar == 0 || allDesignYazar == 2)
            {
                var data = YazarListele.CurrentRow.Cells[0].Value;
                var yazarId = db.Yazarlar.Find(data);
                var kitapEkle = new FrmKitapEkle();
                kitapEkle.TxtIsbn.Text = isbn;
                kitapEkle.TxtSn.Text = sn;
                kitapEkle.TxtFoto.Text = foto;
                kitapEkle.TxtKitapAd.Text = kitaAd;
                kitapEkle.gelenKategori = gelenKategori;

                if (KtpTercuman == 0)
                {
                    kitapEkle.yazar = yazarId.Id;
                    kitapEkle.tercuman = tercuman;
                }

                else
                {
                    kitapEkle.yazar = yazar;
                    kitapEkle.tercuman = yazarId.Id;
                }



                kitapEkle.sayfaNo = sayfaNo;
                kitapEkle.yayinevi = yayinevi;
                this.Hide();
                kitapEkle.ShowDialog();
            }

            else
            {
                string data = YazarListele.CurrentRow.Cells[0].Value.ToString();
                var yazarId = db.Yazarlar.FirstOrDefault(x => (x.YazarAd + " " + x.YazarSoyad).Contains(data));
                var kitapEkle = new FrmKitapEkle();
                kitapEkle.TxtIsbn.Text = isbn;
                kitapEkle.TxtSn.Text = sn;
                kitapEkle.TxtFoto.Text = foto;
                kitapEkle.TxtKitapAd.Text = kitaAd;
                kitapEkle.gelenKategori = gelenKategori;

                if (KtpTercuman == 0)
                {
                    kitapEkle.yazar = yazarId.Id;
                    kitapEkle.tercuman = tercuman;
                }

                else
                {
                    kitapEkle.yazar = yazar;
                    kitapEkle.tercuman = yazarId.Id;
                }



                kitapEkle.sayfaNo = sayfaNo;
                kitapEkle.yayinevi = yayinevi;
                this.Hide();
                kitapEkle.ShowDialog();
            }

        }

        private void FrmYazarEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ktpGelen != 0)
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
