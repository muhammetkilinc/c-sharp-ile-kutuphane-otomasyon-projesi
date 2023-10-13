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
    public partial class FrmLoginHataliGiris : Form
    {
        public FrmLoginHataliGiris()
        {
            InitializeComponent();
        }
        ekosEntities db = new ekosEntities();
        private void FrmLoginHataliGiris_Load(object sender, EventArgs e)
        {
            var personel = db.PersonelHataliGiris.Where(x => x.PersonelId == personelGiris.pId && x.aktif == true).FirstOrDefault();
            DateTime dt = DateTime.Parse(personel.GirisTespitTarih.ToString());

            TxtName.Text = personel.BilgisayarAdi;
            if (int.Parse(dt.Day.ToString()) < 10)
            {
                TxtTarih.Text = "0" + dt.Day.ToString();
            }
            if (int.Parse(dt.Day.ToString()) >= 10)
            {
                TxtTarih.Text = dt.Day.ToString();
            }

            if (int.Parse(dt.Month.ToString()) < 10)
            {
                TxtTarih.Text += " / 0" + dt.Month.ToString();
            }

            if (int.Parse(dt.Month.ToString()) >= 10)
            {
                TxtTarih.Text += " / " + dt.Month.ToString();
            }
            
            TxtTarih.Text += " / " + dt.Year.ToString();



            if (int.Parse(dt.Hour.ToString()) < 10)
            {
                TxtZaman.Text = "0" + dt.Hour.ToString();
            }
            if (int.Parse(dt.Hour.ToString()) >= 10)
            {
                TxtZaman.Text = dt.Hour.ToString();
            }

            if (int.Parse(dt.Minute.ToString()) < 10)
            {
                TxtZaman.Text += ":0" + dt.Minute.ToString();
            }

            if (int.Parse(dt.Minute.ToString()) >= 10)
            {
                TxtZaman.Text += ":" + dt.Minute.ToString();
            }

            if (int.Parse(dt.Second.ToString()) < 10)
            {
                TxtZaman.Text += ":0" + dt.Second.ToString();
            }

            if (int.Parse(dt.Second.ToString()) >= 10)
            {
                TxtZaman.Text += ":" + dt.Second.ToString();
            }


        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            if (personelGiris.HataId != 0)
            {
                var hata = db.PersonelHataliGiris.Find(personelGiris.HataId);
                hata.aktif = false;
                db.SaveChanges();
            }
            this.Hide();
        }

        bool mouseDown;
        private Point offset;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
