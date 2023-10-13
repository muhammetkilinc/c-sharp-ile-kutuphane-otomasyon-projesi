using ekos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmKitapAlanOgr : Form
    {
        public FrmKitapAlanOgr()
        {
            InitializeComponent();
        }
        public string okulNo = "0";
        public int OgrDetayDeger = 0;
        public int gecikenKitap = 0;
        ekosEntities db = new ekosEntities();

        public void temizle()
        {
            BtnUyari.Visible = false;
            TxtClear.Visible = false;
            OgrTxtAra.Clear();
            OgrTxtAra.Focus();
            BtnIslem.Visible = false;
            kitapAlanOgrListele.ClearSelection();
        }

        public void BtnTikla(Button btn)
        {
            void btnEtki(Button etki)
            {
                etki.BackColor = Color.White;
                etki.ForeColor = Color.Black;
            }
            btnEtki(BtnTumKayit);
            btnEtki(BtnTeslimEden);
            btnEtki(BtnTeslimEtmeyen);
            btnEtki(BtnGeciktiren);

            btn.BackColor = Color.FromArgb(0, 15, 27);
            btn.ForeColor = Color.White;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmKitapAlanOgr_Load(object sender, EventArgs e)
        {
            int say = db.KitapAlanOgrenci.Select(x => x.Id).Count();
            ToplamKayit.Text = "Toplam Kayıt : " + say.ToString();

            temizle();
            OgrTxtAra.Focus();

            int kayit = int.Parse(IlkKayit.Text);
            if (okulNo == "0" && gecikenKitap == 0)
            {
                BtnTikla(BtnTumKayit);

                var query = from ktOgr in db.KitapAlanOgrenci
                            join Ogrenci in db.Ogrenciler
                            on ktOgr.OgrId equals Ogrenci.Id
                            join Kitap in db.Kitaplar
                            on ktOgr.KitapId equals Kitap.Id
                            join yazar in db.Yazarlar
                            on Kitap.YazarId equals yazar.Id
                            where ktOgr.Id <= kayit
                            orderby ktOgr.Id descending
                            select new
                            {
                                ktOgr.Id,
                                Ogrenci.OgrNo,
                                Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                Kitap.KitapAdi,
                                Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                ktOgr.AlisTarihi,
                                ktOgr.TeslimTarihi,
                                TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                            };
                kitapAlanOgrListele.DataSource = query.ToList();

                
                temizle();
            }

            else if (gecikenKitap == 1)
            {
                BtnTikla(BtnGeciktiren);
                var query = from ktOgr in db.KitapAlanOgrenci
                            join Ogrenci in db.Ogrenciler
                            on ktOgr.OgrId equals Ogrenci.Id
                            join Kitap in db.Kitaplar
                            on ktOgr.KitapId equals Kitap.Id
                            join yazar in db.Yazarlar
                            on Kitap.YazarId equals yazar.Id
                            where (ktOgr.GecenGunSayisi - ktOgr.geciktirmeGunSayisi) > 0
                            orderby ktOgr.Id descending
                            select new
                            {
                                ktOgr.Id,
                                Ogrenci.OgrNo,
                                Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                Kitap.KitapAdi,
                                Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                ktOgr.AlisTarihi,
                                ktOgr.TeslimTarihi,
                                TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                            };
                kitapAlanOgrListele.DataSource = query.ToList();
            }

            else if (gecikenKitap == 2)
            {
                BtnTikla(BtnGeciktiren);
                var query = from ktOgr in db.KitapAlanOgrenci
                            join Ogrenci in db.Ogrenciler
                            on ktOgr.OgrId equals Ogrenci.Id
                            join Kitap in db.Kitaplar
                            on ktOgr.KitapId equals Kitap.Id
                            join yazar in db.Yazarlar
                            on Kitap.YazarId equals yazar.Id
                            where (ktOgr.GecenGunSayisi - ktOgr.geciktirmeGunSayisi) > 0 && ktOgr.TeslimTarihi == null
                            orderby ktOgr.Id descending
                            select new
                            {
                                ktOgr.Id,
                                Ogrenci.OgrNo,
                                Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                Kitap.KitapAdi,
                                Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                ktOgr.AlisTarihi,
                                ktOgr.TeslimTarihi,
                                TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                            };
                kitapAlanOgrListele.DataSource = query.ToList();
            }

            else
            {
                if (OgrDetayDeger == 0)
                {
                    BtnTikla(BtnTumKayit);
                    BtnTumKayit.BackColor = Color.White;
                    BtnTumKayit.ForeColor = Color.Black;

                    var query = from ktOgr in db.KitapAlanOgrenci
                                join Ogrenci in db.Ogrenciler
                                on ktOgr.OgrId equals Ogrenci.Id
                                join Kitap in db.Kitaplar
                                on ktOgr.KitapId equals Kitap.Id
                                join yazar in db.Yazarlar
                                on Kitap.YazarId equals yazar.Id
                                where Ogrenci.OgrNo == okulNo
                                orderby ktOgr.Id descending
                                select new
                                {
                                    ktOgr.Id,
                                    Ogrenci.OgrNo,
                                    Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                    Kitap.KitapAdi,
                                    Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                    ktOgr.AlisTarihi,
                                    ktOgr.TeslimTarihi,
                                    TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                                };
                    kitapAlanOgrListele.DataSource = query.ToList();
                }

                else if (OgrDetayDeger == 1)
                {
                    BtnTikla(BtnTeslimEtmeyen);
                    var query = from ktOgr in db.KitapAlanOgrenci
                                join Ogrenci in db.Ogrenciler
                                on ktOgr.OgrId equals Ogrenci.Id
                                join Kitap in db.Kitaplar
                                on ktOgr.KitapId equals Kitap.Id
                                join yazar in db.Yazarlar
                                on Kitap.YazarId equals yazar.Id
                                where Ogrenci.OgrNo == okulNo && ktOgr.TeslimTarihi == null
                                orderby ktOgr.Id descending
                                select new
                                {
                                    ktOgr.Id,
                                    Ogrenci.OgrNo,
                                    Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                    Kitap.KitapAdi,
                                    Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                    ktOgr.AlisTarihi,
                                    ktOgr.TeslimTarihi,
                                    TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                                };
                    kitapAlanOgrListele.DataSource = query.ToList();
                }

                else if (OgrDetayDeger == 2)
                {
                    BtnTikla(BtnGeciktiren);
                    kitapAlanOgrListele.DataSource = "";
                    var query = from ktOgr in db.KitapAlanOgrenci
                                join Ogrenci in db.Ogrenciler
                                on ktOgr.OgrId equals Ogrenci.Id
                                join Kitap in db.Kitaplar
                                on ktOgr.KitapId equals Kitap.Id
                                join yazar in db.Yazarlar
                                on Kitap.YazarId equals yazar.Id
                                where Ogrenci.OgrNo == okulNo && (ktOgr.GecenGunSayisi - ktOgr.geciktirmeGunSayisi) > 0
                                orderby ktOgr.Id descending
                                select new
                                {
                                    ktOgr.Id,
                                    Ogrenci.OgrNo,
                                    Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                    Kitap.KitapAdi,
                                    Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                    ktOgr.AlisTarihi,
                                    ktOgr.TeslimTarihi,
                                    TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                                };
                    kitapAlanOgrListele.DataSource = query.ToList();
                }
            }

        }

        private void OgrTxtAra_TextChanged(object sender, EventArgs e)
        {
            if (OgrTxtAra.Text.Length >= 3)
            {
                BtnUyari.Visible = false;

                BtnTikla(BtnTumKayit);
                BtnTumKayit.BackColor = Color.White;
                BtnTumKayit.ForeColor = Color.Black;

                if (OgrTxtAra.Text != "")
                {
                        var veri = db.KitapAlanOgrenci.Where(x =>
                       (x.Ogrenciler.OgrNo + " " + x.Ogrenciler.OgrAd + " " + x.Ogrenciler.OgrSoyad +
                       x.Ogrenciler.OgrTel + x.Ogrenciler.Bolumler.BolumAd +
                       x.Kitaplar.KitapAdi + x.Kitaplar.Isbn + x.Kitaplar.SnNumarasi + x.Kitaplar.Yazarlar.YazarAd + x.Kitaplar.Yazarlar.YazarSoyad
                       ).Contains(OgrTxtAra.Text)).ToList();

                    var kitapAlan = veri;

                    var query = from ktOgr in kitapAlan
                                join Ogrenci in db.Ogrenciler
                                on ktOgr.OgrId equals Ogrenci.Id
                                join Kitap in db.Kitaplar
                                on ktOgr.KitapId equals Kitap.Id
                                join yazar in db.Yazarlar
                                on Kitap.YazarId equals yazar.Id
                                orderby ktOgr.Id descending
                                select new
                                {
                                    ktOgr.Id,
                                    Ogrenci.OgrNo,
                                    Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                    Kitap.KitapAdi,
                                    Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                    ktOgr.AlisTarihi,
                                    ktOgr.TeslimTarihi,
                                    TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                                };
                    kitapAlanOgrListele.DataSource = query.ToList();
                }
            }

            else if (OgrTxtAra.Text.Length < 3)
            {
                kitapAlanOgrListele.DataSource = "";
                BtnUyari.Visible = true;
                BtnTikla(BtnTumKayit);
                BtnTumKayit.BackColor = Color.White;
                BtnTumKayit.ForeColor = Color.Black;
            }

            if (OgrTxtAra.Text != "")
            {
                TxtClear.Visible = true;
            }

            if (OgrTxtAra.Text == "")
            {
                BtnUyari.Visible = false;
                TxtClear.Visible = false;
                int kayit = int.Parse(IlkKayit.Text);
                var query = from ktOgr in db.KitapAlanOgrenci
                            join Ogrenci in db.Ogrenciler
                            on ktOgr.OgrId equals Ogrenci.Id
                            join Kitap in db.Kitaplar
                            on ktOgr.KitapId equals Kitap.Id
                            join yazar in db.Yazarlar
                            on Kitap.YazarId equals yazar.Id
                            where ktOgr.Id <= kayit
                            orderby ktOgr.Id descending
                            select new
                            {
                                ktOgr.Id,
                                Ogrenci.OgrNo,
                                Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                                Kitap.KitapAdi,
                                Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                                ktOgr.AlisTarihi,
                                ktOgr.TeslimTarihi,
                                TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                            };
                kitapAlanOgrListele.DataSource = query.ToList();
            }

            BtnIslem.Visible = false;
            kitapAlanOgrListele.ClearSelection();
        }

        private void TxtClear_Click(object sender, EventArgs e)
        {
            OgrTxtAra.Clear();
            kitapAlanOgrListele.DataSource = "";
            TxtClear.Visible = false;
            temizle();
        }

        private void kitapAlanOgrListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kitapAlanId = int.Parse(kitapAlanOgrListele.CurrentRow.Cells[0].Value.ToString());
            var kontrolID = db.KitapAlanOgrenci.Find(kitapAlanId);
            if (kontrolID.TeslimTarihi == null)
            {
                var teslimAl = new FrmKitapVer();
                teslimAl.kitapAlanId = int.Parse(kitapAlanOgrListele.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                teslimAl.ShowDialog();
            }
            else
            {
                var detay = new FrmKitapAlanDetay();
                detay.kitapAlan = kitapAlanId;
                detay.ShowDialog();
            }

            
        }

        private void BtnTumKayit_Click(object sender, EventArgs e)
        {
            BtnTikla(BtnTumKayit);

            kitapAlanOgrListele.DataSource = "";
            var query = from ktOgr in db.KitapAlanOgrenci
                        join Ogrenci in db.Ogrenciler
                        on ktOgr.OgrId equals Ogrenci.Id
                        join Kitap in db.Kitaplar
                        on ktOgr.KitapId equals Kitap.Id
                        join yazar in db.Yazarlar
                        on Kitap.YazarId equals yazar.Id
                        orderby ktOgr.Id descending
                        select new
                        {
                            ktOgr.Id,
                            Ogrenci.OgrNo,
                            Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                            Kitap.KitapAdi,
                            Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                            ktOgr.AlisTarihi,
                            ktOgr.TeslimTarihi,
                            TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                        };
            kitapAlanOgrListele.DataSource = query.ToList();
            temizle();
        }

        private void BtnTeslimEden_Click(object sender, EventArgs e)
        {
            BtnTikla(BtnTeslimEden);
            kitapAlanOgrListele.DataSource = "";
            var query = from ktOgr in db.KitapAlanOgrenci
                        join Ogrenci in db.Ogrenciler
                        on ktOgr.OgrId equals Ogrenci.Id
                        join Kitap in db.Kitaplar
                        on ktOgr.KitapId equals Kitap.Id
                        join yazar in db.Yazarlar
                        on Kitap.YazarId equals yazar.Id
                        where ktOgr.TeslimTarihi != null
                        orderby ktOgr.Id descending
                        select new
                        {
                            ktOgr.Id,
                            Ogrenci.OgrNo,
                            Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                            Kitap.KitapAdi,
                            Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                            ktOgr.AlisTarihi,
                            ktOgr.TeslimTarihi,
                            TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                        };
            kitapAlanOgrListele.DataSource = query.ToList();
            temizle();
        }

        private void BtnTeslimEtmeyen_Click(object sender, EventArgs e)
        {
            BtnTikla(BtnTeslimEtmeyen);
            kitapAlanOgrListele.DataSource = "";
            var query = from ktOgr in db.KitapAlanOgrenci
                        join Ogrenci in db.Ogrenciler
                        on ktOgr.OgrId equals Ogrenci.Id
                        join Kitap in db.Kitaplar
                        on ktOgr.KitapId equals Kitap.Id
                        join yazar in db.Yazarlar
                        on Kitap.YazarId equals yazar.Id
                        where ktOgr.TeslimTarihi == null
                        orderby ktOgr.Id descending
                        select new
                        {
                            ktOgr.Id,
                            Ogrenci.OgrNo,
                            Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                            Kitap.KitapAdi,
                            Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                            ktOgr.AlisTarihi,
                            ktOgr.TeslimTarihi,
                            TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                        };
            kitapAlanOgrListele.DataSource = query.ToList();
            temizle();
        }

        private void BtnGeciktiren_Click(object sender, EventArgs e)
        {
            BtnTikla(BtnGeciktiren);
            kitapAlanOgrListele.DataSource = "";
            var query = from ktOgr in db.KitapAlanOgrenci
                        join Ogrenci in db.Ogrenciler
                        on ktOgr.OgrId equals Ogrenci.Id
                        join Kitap in db.Kitaplar
                        on ktOgr.KitapId equals Kitap.Id
                        join yazar in db.Yazarlar
                        on Kitap.YazarId equals yazar.Id
                        where (ktOgr.GecenGunSayisi - ktOgr.geciktirmeGunSayisi) > 0
                        orderby ktOgr.Id descending
                        select new
                        {
                            ktOgr.Id,
                            Ogrenci.OgrNo,
                            Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                            Kitap.KitapAdi,
                            Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                            ktOgr.AlisTarihi,
                            ktOgr.TeslimTarihi,
                            TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                        };
            kitapAlanOgrListele.DataSource = query.ToList();
            temizle();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kayit = int.Parse(IlkKayit.Text);
            kitapAlanOgrListele.DataSource = "";
            var query = from ktOgr in db.KitapAlanOgrenci
                        join Ogrenci in db.Ogrenciler
                        on ktOgr.OgrId equals Ogrenci.Id
                        join Kitap in db.Kitaplar
                        on ktOgr.KitapId equals Kitap.Id
                        join yazar in db.Yazarlar
                        on Kitap.YazarId equals yazar.Id
                        where ktOgr.Id <= kayit
                        orderby ktOgr.Id descending
                        select new
                        {
                            ktOgr.Id,
                            Ogrenci.OgrNo,
                            Ogrenci = Ogrenci.OgrAd + " " + Ogrenci.OgrSoyad,
                            Kitap.KitapAdi,
                            Yazar = yazar.YazarAd + " " + yazar.YazarSoyad,
                            ktOgr.AlisTarihi,
                            ktOgr.TeslimTarihi,
                            TeslimEdildi = ktOgr.TeslimTarihi == null ? "Hayır" : "Evet"
                        };
            kitapAlanOgrListele.DataSource = query.ToList();
            temizle();
        }

        private void kitapAlanOgrListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(kitapAlanOgrListele.CurrentRow.Cells[0].Value.ToString());
            var kayit = db.KitapAlanOgrenci.Find(id);

            BtnIslem.Visible = true;
            if (kayit.TeslimTarihi == null)
            {
                BtnIslem.Text = "TESLİM AL";
            }
            else if (kayit.TeslimTarihi != null)
            {
                BtnIslem.Text = "DETAYLI BİLGİ";
            }

        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(kitapAlanOgrListele.CurrentRow.Cells[0].Value.ToString());
            var kayit = db.KitapAlanOgrenci.Find(id);

            if (BtnIslem.Text == "TESLİM AL")
            {
                var teslimAl = new FrmKitapVer();
                teslimAl.kitapAlanId = int.Parse(kitapAlanOgrListele.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                teslimAl.ShowDialog();
            }
            else if (BtnIslem.Text == "DETAYLI BİLGİ")
            {
                var detay = new FrmKitapAlanDetay();
                detay.kitapAlan = kayit.Id;
                detay.ShowDialog();
            }
        }
    }
}
