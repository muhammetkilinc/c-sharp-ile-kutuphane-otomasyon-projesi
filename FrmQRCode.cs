using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ekos
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        public int deger = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            int Deger = int.Parse(gelenDeger.Text);

            if (Deger == 1)
            {
                if (BtnBaslat.Text == "Durdur")
                {
                    timer1.Stop();
                    vcd.Stop();
                    pictureBox1.Image = null;
                    BtnBaslat.Text = "Başlat";
                }


                if (deger == 0)
                {
                    var kitap = new FrmKitaplar();
                    kitap.OgrId.Text = OgrId.Text;
                    kitap.OgrAd.Text = OgrAd.Text;
                    kitap.OgrNo.Text = OgrNo.Text;
                    kitap.KitapTxtAra.Text = "";
                    this.Hide();
                    kitap.ShowDialog();
                }

                else
                {
                    var kitapEkle = new FrmKitapEkle();
                    this.Hide();
                    kitapEkle.ShowDialog();
                }
            }
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnBaslat.Text == "Başlat")
                {
                    vcd = new VideoCaptureDevice(fico[ComboKamera.SelectedIndex].MonikerString);
                    vcd.NewFrame += Vcd_NewFrame;
                    vcd.Start();
                    timer1.Start();
                    BtnBaslat.Text = "Durdur";
                }

                else if (BtnBaslat.Text == "Durdur")
                {
                    timer1.Stop();
                    vcd.Stop();
                    pictureBox1.Image = null;
                    BtnBaslat.Text = "Başlat";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kamera Hatası!");
            }
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception)
            {

                MessageBox.Show("Görüntü tanımlanamadı!");
            }
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo f in fico)
            {
                ComboKamera.Items.Add(f.Name);
                ComboKamera.SelectedIndex = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);

                if (sonuc != null)
                {


                    timer1.Stop();
                    vcd.Stop();
                    pictureBox1.Image = null;

                    if (deger == 0)
                    {
                        var kitap = new FrmKitaplar();
                        kitap.OgrId.Text = OgrId.Text;
                        kitap.OgrAd.Text = OgrAd.Text;
                        kitap.OgrNo.Text = OgrNo.Text;
                        kitap.KitapTxtAra.Text = sonuc.ToString();
                        kitap.i = 1;
                        this.Hide();
                        kitap.ShowDialog();
                    }

                    else
                    {
                        var kitapEkle = new FrmKitapEkle();
                        kitapEkle.TxtIsbn.Text = sonuc.ToString();
                        this.Hide();
                        kitapEkle.ShowDialog();
                    }
                }
            }
        }
    }
}
