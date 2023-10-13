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
    public partial class FrmKitapKategorisiEkle : Form
    {
        public FrmKitapKategorisiEkle()
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
        public int ktpGelen = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKategori.Text != "")
            {
                var kategori = new KitapKategori();
                var kontrol = db.KitapKategori.ToList();
                int kontrolSay = 0;
                foreach (var item in kontrol)
                {
                    if (item.KategoriAd.ToLower() == TxtKategori.Text.ToLower())
                    {
                        MessageBox.Show("Bu tür zaten mevcut");
                        kontrolSay = 1;
                        break;
                    }
                }

                if (kontrolSay == 0)
                {
                    kategori.KategoriAd = TxtKategori.Text;
                    db.KitapKategori.Add(kategori);
                    db.SaveChanges();
                    this.Hide();
                    MessageBox.Show("\"" + TxtKategori.Text + "\" isimli kitap türü eklendi.");

                        var kt = db.KitapKategori.FirstOrDefault(x => x.KategoriAd == TxtKategori.Text);
                    if (ktpGelen == 1)
                    {
                        var kitapEkle = new FrmKitapEkle();
                        kitapEkle.TxtIsbn.Text = isbn;
                        kitapEkle.TxtSn.Text = sn;
                        kitapEkle.TxtFoto.Text = foto;
                        kitapEkle.TxtKitapAd.Text = kitaAd;
                        kitapEkle.gelenKategori = kt.Id;
                        kitapEkle.yazar = yazar;
                        kitapEkle.yayinevi = yayinevi;
                        kitapEkle.sayfaNo = sayfaNo;
                        kitapEkle.tercuman = tercuman;
                        kitapEkle.ShowDialog();
                    }
                        
                    

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori adı giriniz!", "Kitap Kategorisi - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKitapKategorisiEkle_Load(object sender, EventArgs e)
        {
            TxtKategori.Focus();
        }

        private void TxtKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmKitapKategorisiEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ktpGelen == 1)
            {
                var kitapEkle = new FrmKitapEkle();
                kitapEkle.TxtIsbn.Text = isbn;
                kitapEkle.TxtSn.Text = sn;
                kitapEkle.TxtFoto.Text = foto;
                kitapEkle.TxtKitapAd.Text = kitaAd;
                if (gelenKategori != 0)
                {
                    kitapEkle.gelenKategori = gelenKategori;
                }
                kitapEkle.yazar = yazar;
                kitapEkle.yayinevi = yayinevi;
                kitapEkle.sayfaNo = sayfaNo;
                kitapEkle.tercuman = tercuman;
                kitapEkle.ShowDialog();
            }
            

        }
    }
}
