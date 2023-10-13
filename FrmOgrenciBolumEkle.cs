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
    public partial class FrmOgrenciBolumEkle : Form
    {
        public FrmOgrenciBolumEkle()
        {
            InitializeComponent();
        }
        public int OgrGelen = 0;
        public int GelenBolumId = 0;
        public string OgrNo = "";
        public string OgrAd = "";
        public string OgrSoyad = "";
        public string OgrTel = "";
        public string OgrEposta = "";
        public bool checkDisiplin = false;

        ekosEntities db = new ekosEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKategori.Text != "")
            {
                var kategori = new Bolumler();
                var kontrol = db.Bolumler.ToList();
                int kontrolSay = 0;
                foreach (var item in kontrol)
                {
                    if (item.BolumAd.ToLower() == TxtKategori.Text.ToLower())
                    {
                        MessageBox.Show("Bu bölüm zaten mevcut!");
                        kontrolSay = 1;
                        break;
                    }
                }

                if (kontrolSay == 0)
                {
                    kategori.BolumAd = TxtKategori.Text;
                    db.Bolumler.Add(kategori);
                    db.SaveChanges();
                    this.Hide();
                    MessageBox.Show("\"" + TxtKategori.Text + "\" isimli bölüm eklendi.");

                    var kt = db.Bolumler.FirstOrDefault(x => x.BolumAd == TxtKategori.Text);
                    if (OgrGelen == 1)
                    {
                        var ogrEkle = new FrmOgrenciDetayliGor();
                        ogrEkle.TxtOkulNo.Text = OgrNo;
                        ogrEkle.TxtAd.Text = OgrAd;
                        ogrEkle.TxtSoyad.Text = OgrSoyad;
                        ogrEkle.TxtTel.Text = OgrTel;
                        ogrEkle.TxtEposta.Text = OgrEposta;
                        ogrEkle.CheckDisiplin.Checked = checkDisiplin;
                        ogrEkle.gelenBolumId = kt.Id;
                        this.Hide();
                        ogrEkle.ShowDialog();
                    }



                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bölüm adı giriniz!", "Bölüm Bilgisi - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOgrenciBolumEkle_Load(object sender, EventArgs e)
        {
            TxtKategori.Focus();
        }

        private void FrmOgrenciBolumEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OgrGelen == 1)
            {
                var ogrEkle = new FrmOgrenciDetayliGor();
                ogrEkle.TxtOkulNo.Text = OgrNo;
                ogrEkle.TxtAd.Text = OgrAd;
                ogrEkle.TxtSoyad.Text = OgrSoyad;
                ogrEkle.TxtTel.Text = OgrTel;
                ogrEkle.TxtEposta.Text = OgrEposta;
                ogrEkle.gelenBolumId = GelenBolumId;
                ogrEkle.CheckDisiplin.Checked = checkDisiplin;
                this.Hide();
                ogrEkle.ShowDialog();
            }
        }
    }
}
