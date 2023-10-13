using ekos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        ekosEntities db = new ekosEntities();
        public int kitapId = 0;
        public int deger = 0;
        public int AllDesignDeger = 0;




        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
            if (AllDesignDeger == 1)
            {
                var query = from ogr in db.Ogrenciler
                            join bolum in db.Bolumler
                            on ogr.BolumId equals bolum.Id
                            join kt in db.KitapAlanOgrenci
                            on ogr.Id equals kt.OgrId
                            orderby kt.AlisTarihi descending
                            select new
                            {
                                ogr.Id,
                                ogr.OgrNo,
                                ogrenciAd = ogr.OgrAd + " " + ogr.OgrSoyad,
                                Tel = ogr.OgrTel.Substring(0, 4) + " " + ogr.OgrTel.Substring(4, 3) + " " + ogr.OgrTel.Substring(7, 2) + " " + ogr.OgrTel.Substring(9, 2),
                                ogr.OgrEposta,
                                bolum.BolumAd
                            };
                ogrenciListele.DataSource = query.ToList();
                MessageBox.Show("a");
            }
            else if (AllDesignDeger == 2)
            {

                var say2 = db.KitapAlanOgrenci.OrderBy(Ogrenci => Ogrenci.AlisTarihi)
                         .GroupBy(Ogrenci => Ogrenci.OgrId)
                         .Select(Sinif => new { Sinif = Sinif.Key, OgrenciSayisi = Sinif.Count() });

                MessageBox.Show(say2.ToString());
            }
            else if (AllDesignDeger == 3)
            {
                var query = from ogr in db.Ogrenciler
                            join bolum in db.Bolumler
                            on ogr.BolumId equals bolum.Id
                            join kt in db.KitapAlanOgrenci
                            on ogr.Id equals kt.OgrId
                            orderby kt.AlisTarihi descending
                            select new
                            {
                                ogr.Id,
                                ogr.OgrNo,
                                ogrenciAd = ogr.OgrAd + " " + ogr.OgrSoyad,
                                Tel = ogr.OgrTel.Substring(0, 4) + " " + ogr.OgrTel.Substring(4, 3) + " " + ogr.OgrTel.Substring(7, 2) + " " + ogr.OgrTel.Substring(9, 2),
                                ogr.OgrEposta,
                                bolum.BolumAd
                            };
                ogrenciListele.DataSource = query.ToList();
            }
            else if (AllDesignDeger == 4)
            {
                var query = from ogr in db.Ogrenciler
                            join bolum in db.Bolumler
                            on ogr.BolumId equals bolum.Id
                            join kt in db.KitapAlanOgrenci
                            on ogr.Id equals kt.OgrId
                            orderby kt.AlisTarihi descending
                            select new
                            {
                                ogr.Id,
                                ogr.OgrNo,
                                ogrenciAd = ogr.OgrAd + " " + ogr.OgrSoyad,
                                Tel = ogr.OgrTel.Substring(0, 4) + " " + ogr.OgrTel.Substring(4, 3) + " " + ogr.OgrTel.Substring(7, 2) + " " + ogr.OgrTel.Substring(9, 2),
                                ogr.OgrEposta,
                                bolum.BolumAd
                            };
                ogrenciListele.DataSource = query.ToList();
            }
            else if (AllDesignDeger == 5)
            {
                var query = from ogr in db.Ogrenciler
                            join bolum in db.Bolumler
                            on ogr.BolumId equals bolum.Id
                            join kt in db.KitapAlanOgrenci
                            on ogr.Id equals kt.OgrId
                            orderby kt.AlisTarihi descending
                            select new
                            {
                                ogr.Id,
                                ogr.OgrNo,
                                ogrenciAd = ogr.OgrAd + " " + ogr.OgrSoyad,
                                Tel = ogr.OgrTel.Substring(0, 4) + " " + ogr.OgrTel.Substring(4, 3) + " " + ogr.OgrTel.Substring(7, 2) + " " + ogr.OgrTel.Substring(9, 2),
                                ogr.OgrEposta,
                                bolum.BolumAd
                            };
                ogrenciListele.DataSource = query.ToList();
            }
        }

        private void OgrTxtAra_TextChanged(object sender, EventArgs e)
        {
            if (OgrTxtAra.Text.Length >= 3)
            {
                if (OgrTxtAra.Text != "")
                {

                    var veri = db.Ogrenciler.Where(x => (
                    x.OgrNo + " " + x.OgrAd + " " + x.OgrSoyad + " " + x.OgrTel + " " + x.Bolumler.BolumAd
                    + " " + x.OgrEposta

                    ).Contains(OgrTxtAra.Text)).ToList();

                    var ogrListesi = veri;

                        var query = from ogr in ogrListesi
                                    join bolum in db.Bolumler
                                    on ogr.BolumId equals bolum.Id
                                    select new
                                    {
                                        ogr.Id,
                                        ogr.OgrNo,
                                        ogrenciAd = ogr.OgrAd + " " + ogr.OgrSoyad,
                                        Tel = ogr.OgrTel.Substring(0, 4) + " " + ogr.OgrTel.Substring(4, 3) + " " + ogr.OgrTel.Substring(7, 2) + " " + ogr.OgrTel.Substring(9, 2),
                                        ogr.OgrEposta,
                                        bolum.BolumAd
                                    };
                        ogrenciListele.DataSource = query.ToList();
                }
            }

            if (OgrTxtAra.Text != "")
            {
                TxtClear.Visible = true;
            }

            if (OgrTxtAra.Text == "")
            {
                TxtClear.Visible = false;
                ogrenciListele.DataSource = "";
            }



        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        


        private void TxtClear_Click(object sender, EventArgs e)
        {
            OgrTxtAra.Clear();
            ogrenciListele.DataSource = "";
            TxtClear.Visible = false;
        }

        private void ogrenciListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deger == 0)
            {
                var ogrDetay = new FrmOgrenciDetayliGor();
                ogrDetay.ogrId = int.Parse(ogrenciListele.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                ogrDetay.ShowDialog();
            }
            else
            {
                int ogrenciID = int.Parse(ogrenciListele.CurrentRow.Cells[0].Value.ToString());
                var kontrolId = db.Ogrenciler.Find(ogrenciID);
                if (kontrolId.KutuphaneBlok == true)
                {
                    MessageBox.Show("Bu kişi 1 veya daha fazla kitabın yasal süresini geçti!");
                }
                else if (kontrolId.MezunMu == true)
                {
                    MessageBox.Show("Mezun olanlar kitap alamaz!");
                }
                else if (kontrolId.DisiplinCezali == true)
                {
                    MessageBox.Show(kontrolId.OgrAd + " " + kontrolId.OgrSoyad + " Disiplin Cezalı!");
                }
                else if (kontrolId.KitapAlmaSayisi == 2)
                {
                    MessageBox.Show(kontrolId.OgrAd + " " + kontrolId.OgrSoyad + " en fazla 2 kitap alabilir!");
                }
                else
                {
                    var kitapVer = new FrmKitapVer();
                    kitapVer.kitapId = kitapId;
                    kitapVer.ogrId = int.Parse(ogrenciListele.CurrentRow.Cells[0].Value.ToString());
                    this.Hide();
                    kitapVer.ShowDialog();
                }
                
            }
        }

    }
}
