using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ekos
{
    public partial class FrmAyarlarLogKayitlari : Form
    {
        public FrmAyarlarLogKayitlari()
        {
            InitializeComponent();
        }

        ekosEntities db = new ekosEntities();

        private void FrmAyarlarLogKayitlari_Load(object sender, EventArgs e)
        {

            if (personelGiris.pId != 0)
            {
                var personel = db.Personel.Find(personelGiris.pId);
                int say = int.Parse(personel.SistemeGirisSayisi.ToString());
                if (say > 0)
                {
                    SistemeGirisSayisi.Text = "Toplam " + say + " kere sisteme giriş yapıldı.";
                }
                if (say <= 0)
                {
                    SistemeGirisSayisi.Text = "Sisteme ilk defa girdiniz.";
                }
                int count = 0;
                var log = db.PersonelLogKaydi.Where(x => x.PersonelId == personelGiris.pId && x.CikisTarihi != null && x.ProgramAdi == "Masaüstü Uygulaması").OrderByDescending(x => x.GirisTarihi).Take(200);
                foreach (var item in log)
                {
                    count += 1;
                    DateTime giris = DateTime.Parse(item.GirisTarihi.ToString());
                    DateTime cikis = DateTime.Parse(item.CikisTarihi.ToString());
                    TimeSpan toplamGecenSure = cikis - giris;


                    Lstsay.Items.Add(count);
                    if (giris.Day == DateTime.Now.Day && giris.Month == DateTime.Now.Month && giris.Year == DateTime.Now.Year)
                    {
                        GirisKaydi.Items.Add("Bugün " + giris.ToString("HH:mm:ss"));
                        CikisKaydi.Items.Add("Bugün " + cikis.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        GirisKaydi.Items.Add(giris.ToString("dd MMMM yyyy dddd HH:mm:ss"));
                        CikisKaydi.Items.Add(cikis.ToString("dd MMMM yyyy dddd HH:mm:ss"));
                    }

                    string gecenGun = "";
                    int gunCarp = 0;

                    if (toplamGecenSure.Days != 0)
                    {
                        gunCarp = toplamGecenSure.Days * 24;
                    }

                    if (toplamGecenSure.Hours != 0)
                    {
                        gecenGun += (toplamGecenSure.Hours + gunCarp) + " s ";
                    }

                    if (toplamGecenSure.Minutes != 0)
                    {
                        gecenGun += toplamGecenSure.Minutes + " dk ";
                    }

                    if (toplamGecenSure.Seconds != 0)
                    {
                        gecenGun += toplamGecenSure.Seconds + " sn";
                    }

                    if (toplamGecenSure.Days == 0 && toplamGecenSure.Hours == 0 && toplamGecenSure.Minutes == 0 && toplamGecenSure.Seconds == 0)
                    {
                        gecenGun += "Hesaplanamadı!";
                    }

                    GecenSureKaydi.Items.Add(gecenGun);




                    /* 
                    GecenSureKaydi.DrawMode = DrawMode.OwnerDrawFixed;
                    GecenSureKaydi.DrawItem += new DrawItemEventHandler(GecenSureKaydi_RenkAyarla);

                    GecenSureKaydi.DrawItem += new DrawItemEventHandler(GecenSureKaydi_DrawItem);
                    
                    void GecenSureKaydi_DrawItem(object sender, DrawItemEventArgs e)
                    {
                        e.DrawBackground();
                        Brush myBrush = Brushes.Gray;
                        if (GecenSureKaydi.Items[e.Index].ToString().IndexOf("Hesaplanamadı!") >= 0)
                        {
                            myBrush = Brushes.Red;
                        }
                        else
                        {
                            myBrush = Brushes.White;
                        }

                        e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                            e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                        e.DrawFocusRectangle();
                    }
                    */

                }

            }
            
            else
            {
                MessageBox.Show(personelGiris.pId.ToString());
            }
        }
        int tekSeferGoster = 0;
        public void hata(int a)
        {
            if (tekSeferGoster == 0)
            {
                if (GecenSureKaydi.Items[a] == "Hesaplanamadı!")
                {
                    MessageBox.Show("Hata! Personelin Giriş ve çıkış tarihi birbirine eşit.");
                    tekSeferGoster = 1;
                }
            }

            else if (tekSeferGoster == 1)
            {
                if (GecenSureKaydi.Items[a] != "Hesaplanamadı!")
                {
                    tekSeferGoster = 0;
                }
            }
        }
        private void GirisKaydi_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int a = GirisKaydi.SelectedIndex;
                CikisKaydi.SelectedIndex = a;
                GecenSureKaydi.SelectedIndex = a;
                Lstsay.SelectedIndex = a;
                hata(a);
            }
            catch (Exception)
            {

                
            }
        }

        private void CikisKaydi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int a = CikisKaydi.SelectedIndex;
                GirisKaydi.SelectedIndex = a;
                GecenSureKaydi.SelectedIndex = a;
                Lstsay.SelectedIndex = a;
                hata(a);
            }
            catch (Exception)
            {


            }
        }

        private void GecenSureKaydi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int a = GecenSureKaydi.SelectedIndex;
                GirisKaydi.SelectedIndex = a;
                CikisKaydi.SelectedIndex = a;
                Lstsay.SelectedIndex = a;
                hata(a);
            }
            catch (Exception)
            {


            }
        }

        private void Lstsay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Lstsay.SelectedIndex;
                GirisKaydi.SelectedIndex = a;
                CikisKaydi.SelectedIndex = a;
                GecenSureKaydi.SelectedIndex = a;
                hata(a);
            }
            catch (Exception)
            {


            }
        }


    }
}
