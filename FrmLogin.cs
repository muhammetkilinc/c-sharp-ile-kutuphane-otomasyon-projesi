using ekos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmLogin : Form
    {
        ekosEntities ekos = new ekosEntities();
        public FrmLogin()
        {
            InitializeComponent();
        }
        int deger = 0;
        bool beniHatirla = false;
        public void Efekt()
        {
            panelKullanici.BackColor = Color.FromArgb(82, 135, 175);
            panelSifre.BackColor = Color.FromArgb(82, 135, 175);
        }

        public void HataliGiris()
        {
            var personelId = ekos.PersonelSifre.FirstOrDefault(x => x.KullaniciAdi.Contains(txtKullanici.Text));
            var hataId = ekos.PersonelHataliGiris.FirstOrDefault(x => x.PersonelId == personelId.Id);
            string PcName = Environment.MachineName;


            if (hataId.Id == 0 || hataId.Id == null)
            {
                var hata = new PersonelHataliGiris();
                hata.PersonelId = personelId.Id;
                hata.BilgisayarAdi = PcName;
                hata.GirisTespitTarih = DateTime.Now;
                hata.aktif = true;
                ekos.PersonelHataliGiris.Add(hata);
                ekos.SaveChanges();
            }
            else if (hataId.Id != 0)
            {
                var hata = ekos.PersonelHataliGiris.Find(hataId.Id);
                hata.PersonelId = personelId.Id;
                hata.BilgisayarAdi = PcName;
                hata.GirisTespitTarih = DateTime.Now;
                hata.aktif = true;
                ekos.SaveChanges();
            }
            else
            {
                var hata = new PersonelHataliGiris();
                hata.PersonelId = personelId.Id;
                hata.BilgisayarAdi = PcName;
                hata.GirisTespitTarih = DateTime.Now;
                hata.aktif = true;
                ekos.PersonelHataliGiris.Add(hata);
                ekos.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Efekt();
            Application.Exit();
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {



            try
            {
                Efekt();
                panelKullanici.BackColor = Color.Cyan;
                if (txtSifre.Text != "" && txtKullanici.Text != "")
                {
                    btnGiris.Visible = Visible;
                }

                else
                {
                    btnGiris.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 100000", "Hata: 100000");
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Efekt();
                panelSifre.BackColor = Color.Cyan;
                if (txtSifre.Text != "" && txtKullanici.Text != "")
                {
                    btnGiris.Visible = Visible;
                }

                else
                {
                    btnGiris.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 100010", "Hata: 100010");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int logId = 0;


            Efekt();
            try
            {
                if (txtKullanici.Text != "" && txtSifre.Text != "")
                {
                    try
                    {
                        string kullanici = txtKullanici.Text;
                        string sifre = txtSifre.Text;
                        var personel = ekos.PersonelSifre.FirstOrDefault(a => a.KullaniciAdi == kullanici && a.Sifre == sifre);
                        
                        try
                        {


                            var log = new PersonelLogKaydi();
                            log.PersonelId = personel.Personel.Id;
                            log.GirisTarihi = DateTime.Now;
                            log.ProgramAdi = "Masaüstü Uygulaması";

                            ekos.PersonelLogKaydi.Add(log);
                            ekos.SaveChanges();

                            var pHatirla = ekos.PersonelBeniHatirla.Find(1);
                            if (beniHatirla == true)
                            {
                                pHatirla.PersonelId = personel.Personel.Id;
                                pHatirla.aktif = true;
                                pHatirla.KayitTarih = DateTime.Now;
                                ekos.SaveChanges();
                            }

                            var logForeach = ekos.PersonelLogKaydi.ToList();
                            foreach (var item in logForeach)
                            {
                                logId = item.Id;
                            }


                            if (txtKullanici.Text == personel.KullaniciAdi && txtSifre.Text == personel.Sifre)
                            {
                                //txtKullanici.Text = personelId.pId.ToString();
                                personelGiris.pId = personel.Personel.Id;
                                personelGiris.LogId = logId;

                                var hataId = ekos.PersonelHataliGiris.FirstOrDefault(x => x.PersonelId == personelGiris.pId);

                                personelGiris.HataId = hataId.Id;

                                AllDesign anasayfa = new AllDesign();
                                    anasayfa.Show();
                                    this.Hide(); 
                                if (hataId.aktif == true)
                                {
                                    var hata = new FrmLoginHataliGiris();
                                    hata.ShowDialog();
                                }


                            }
                            else
                            {
                                HataliGiris();
                                MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre girin!", "Giriş İşlemleri - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {

                            HataliGiris();
                            MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre girin!", "Giriş İşlemleri - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        
                    }
                    catch (Exception)
                    {
                        HataliGiris();
                        MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre girin!", "Giriş İşlemleri - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    HataliGiris();
                    MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre girin!", "Giriş İşlemleri - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 100020", "Hata: 100020", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            Efekt();
            try
            {
                FrmHakkinda hakkinda = new FrmHakkinda();
                hakkinda.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 100030", "Hata: 100030", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 64)
            {
                e.Handled = true;
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            Efekt();
            panelSifre.BackColor = Color.Cyan;
        }

        private void txtKullanici_Click(object sender, EventArgs e)
        {
            Efekt();
            panelKullanici.BackColor = Color.Cyan;
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Efekt();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            if (txtKullanici.Text != "" && txtSifre.Text != "")
            {
                btnGiris.Visible = true;
            }
        }

        private void EyeIcon_MouseMove(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '\0';
            EyeIcon.Image = Resources.eyeClose;
        }

        private void EyeIcon_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            EyeIcon.Image = Resources.eyeOpen;
        }

        bool mouseDown;
        private Point offset;
        private void PanelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void PanelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void PanelLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
                
            }
            Opacity += .2;
        }

        
        private void CheckPanel_Click(object sender, EventArgs e)
        {
            if (deger == 0)
            {
                Check.Image = Resources.CheckOn;
                CheckText.ForeColor = Color.Lime;
                beniHatirla = true;
                deger = 1;
            }
            else if (deger == 1)
            {
                Check.Image = Resources.CheckOff;
                CheckText.ForeColor = Color.White;
                beniHatirla = false;
                deger = 0;
            }
        }
    }
}
