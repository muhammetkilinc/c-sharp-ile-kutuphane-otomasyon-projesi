using ekos.Properties;
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
    public partial class AllDesign : Form
    {
        public AllDesign()
        {
            InitializeComponent();

        }
        ekosEntities ekos = new ekosEntities();
        public int pfYok = 0;



        int IntAnasayfa = 1, IntVeriEkle = 1,
            //IntOgrenciler = 1, 
            //IntKitaplar = 1, 
            //IntYazarlar = 1, 
            IntAyarlar = 1;

        int deger = 1;

        // BTN START - Tüm menü butonların eriştiği yer
        public void BtnEffect(Button btn)
        {
            try
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
            catch (Exception)
            {

                MessageBox.Show("btnEffect değer hatası. Hata kodu: 200110", "Hata: 200110");
            }
        }
        public void BtnEffect2(Button btn)
        {
            try
            {
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.Black;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
            catch (Exception)
            {

                MessageBox.Show("btnEffect değer hatası. Hata kodu: 200110", "Hata: 200110");
            }
        }

        public void BtnEffectAll()
        {

            BtnEffect(menuAnasayfa);
            BtnEffect(menuVeriEkle);
            BtnEffect(menuGecikenKitap);
            BtnEffect(menuKitapAlVer);
            BtnEffect(menuOgr);
            BtnEffect(menuKitap);
            BtnEffect(menuYazar);
            BtnEffect(menuSonEklenen);
            BtnEffect(menuAyarlar);
            BtnEffect(menuKisayol);
            BtnEffect(menuHakkinda);
        }

        public void btnFormIciEffect(Button btn)
        {
            try
            {
                btn.BackColor = Color.FromArgb(0, 36, 60);
                btn.ForeColor = Color.White;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
            catch (Exception)
            {

                MessageBox.Show("btnFormIciEffect değer hatası. Hata kodu: 200110", "Hata: 200110");
            }
        }

        public void btnBold(Button btn)
        {
            BtnEffect2(btn);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        public void btnColor(Button btn, int deger)
        {
            try
            {
                btn.BackColor = Color.Cyan;
                btn.ForeColor = Color.Black;
                btn.Font = new Font(btn.Font, FontStyle.Bold);
                select.Location = new Point(0, deger);
            }
            catch (Exception)
            {

                MessageBox.Show("btnColor değer hatası. Hata kodu: 200120", "Hata: 200120");
            }
        }

        // BTN END


        // FRM START - İç içe formlar
        public void frmGetir(Form frm)
        {
            pnlBody.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnlBody.Controls.Add(frm);
            frm.Show();
        }

        public void PanelSurukleme()
        {
            int x, y;
            x = 210;
            y = 630;
            PanelAnasayfa.Location = new Point(x, y);
            PanelVeriEkle.Location = new Point(x, y);
            PanelOgrenci.Location  = new Point(x, y);
            PanelKitaplar.Location = new Point(x, y);
            PanelYazarlar.Location = new Point(x, y);
            PanelAyarlar.Location  = new Point(x, y);
        }

        public void hata404(string kod)
        {
            Frm404 hata = new Frm404();
            hata.HataKodu.Text = "Hata Kodu : " + kod;
            frmGetir(hata);
        }

        

        public void FrmKitapVerButtonlari()
        {
            deger = 2;
            try
            {
                PanelSurukleme();
                PanelAnasayfa.Location = new Point(226, 115);

                if (IntAnasayfa == 1)
                {
                    btnFormIciEffect(btnAnasayfaKitapTeslim);
                    btnFormIciEffect(btnAnasayfaGecikenKitap);
                    btnFormIciEffect(btnAnasayfaHizliNot);
                    btnBold(btnAnasayfaKitapVer);
                    FrmAnasayfaKitapVer KitapVer = new FrmAnasayfaKitapVer();
                    KitapVer.pId = personelGiris.pId;
                    frmGetir(KitapVer);
                }
                else if (IntAnasayfa == 2)
                {
                    btnFormIciEffect(btnAnasayfaKitapVer);
                    btnFormIciEffect(btnAnasayfaGecikenKitap);
                    btnFormIciEffect(btnAnasayfaHizliNot);
                    btnBold(btnAnasayfaKitapTeslim);
                    FrmAllDesignKitapTeslimAl TeslimAl = new FrmAllDesignKitapTeslimAl();
                    frmGetir(TeslimAl);
                }
                else if (IntAnasayfa == 3)
                {
                    btnFormIciEffect(btnAnasayfaKitapVer);
                    btnFormIciEffect(btnAnasayfaKitapTeslim);
                    btnFormIciEffect(btnAnasayfaHizliNot);
                    btnBold(btnAnasayfaGecikenKitap);
                    pnlBody.Controls.Clear();
                }
            }
            catch (Exception)
            {
                hata404("200062");
            }
        }
        public void frmAyarlarButtonlari()
        {
            var personel = ekos.PersonelSifre.FirstOrDefault(a => a.KullaniciAdi == lblKullanici.Text);
            deger = 9;
            try
            {
                PanelSurukleme();
                PanelAyarlar.Location = new Point(226, 115);
                BtnEffectAll();
                btnColor(menuAyarlar, 409);
                if (IntAyarlar == 1)
                {
                    btnFormIciEffect(BtnAyarSifre);
                    btnFormIciEffect(BtnAyarLog);
                    btnFormIciEffect(BtnAyarHizliNot);
                    btnBold(BtnAyarKisisel);
                    FrmAyarlarProfil profil = new FrmAyarlarProfil();
                    profil.pfYok = pfYok;
                    frmGetir(profil);
                }
                else if (IntAyarlar == 2)
                {
                    btnFormIciEffect(BtnAyarKisisel);
                    btnFormIciEffect(BtnAyarLog);
                    btnFormIciEffect(BtnAyarHizliNot);
                    btnBold(BtnAyarSifre);
                    FrmAyarlarSifreIslemleri sifre = new FrmAyarlarSifreIslemleri();
                    frmGetir(sifre);
                }
                else if (IntAyarlar == 3)
                {
                    btnFormIciEffect(BtnAyarKisisel);
                    btnFormIciEffect(BtnAyarSifre);
                    btnFormIciEffect(BtnAyarHizliNot);
                    btnBold(BtnAyarLog);
                    FrmAyarlarLogKayitlari log = new FrmAyarlarLogKayitlari();
                    frmGetir(log);
                }
            }
            catch (Exception)
            {
                hata404("200230");
            }
        }

        // FRM END



        public void MenuBtnHover(Button btn)
        {
            btn.BackColor = Color.FromArgb(1, 45, 79);
        }
        public void MenuBtnLeave(Button btn)
        {
            btn.BackColor = Color.Transparent;
        }






        public void kontrol()
        {
            string[] aramaTerimi = { "anasayfa", "ayarlar", "kısayollar", "hakkında" };
            txtAra.AutoCompleteCustomSource.AddRange(aramaTerimi);

        }
        private void anaSayfa_Load(object sender, EventArgs e)
        {
            var DbPersonel = ekos.Personel.Find(personelGiris.pId);
            var kullanici = ekos.PersonelSifre.Where(x => x.PersonelId == DbPersonel.Id).FirstOrDefault();
            lblKullanici.Text = kullanici.KullaniciAdi;
            Opacity = 0;
            kontrol();

            try
            {
                try
                {
                    if (DbPersonel.GorselUrl != null)
                    {
                        pcProfil.ImageLocation = DbPersonel.GorselUrl;
                    }
                    else
                    {
                        pfYok = 1;
                    }
                    
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Profil yüklenirken bir hata oluştu. Hata kodu:20001", "Hata:20001");
                }
                txtAra.Text = "";
                txtAra.ForeColor = Color.LightGray;
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu:20000", "Hata:20000");
            }

            try
            {
                PanelSurukleme();
                FrmAnasayfaGiris giris = new FrmAnasayfaGiris();
                giris.pId = personelGiris.pId;
                frmGetir(giris);
            }
            catch (Exception)
            {
                hata404("200061");
            }

        }

        private void txtAra_Enter(object sender, EventArgs e)
        {
            try
            {
                if (txtAra.Text == "Veri Ara ...")
                {
                    txtAra.Text = "";
                    txtAra.ForeColor = Color.LightGray;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Arama kutusunda bir hata oluştu. Hata kodu: 200010", "Hata: 200010");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var log = ekos.PersonelLogKaydi.Find(personelGiris.LogId);
                    log.CikisTarihi = DateTime.Now;
                    log.Personel.SistemeGirisSayisi += 1;

                    var pHatirla = ekos.PersonelBeniHatirla.Find(1);
                    pHatirla.PersonelId = null;
                    pHatirla.aktif = false;
                    pHatirla.KayitTarih = DateTime.Now;
                    ekos.SaveChanges();

                }
                catch (Exception)
                {


                }
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Çıkış yapılırken bir hata oluştu. Hata kodu: 200020", "Hata: 200020");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmExit exit = new FrmExit();
                exit.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Program kapatılırken bir hata oluştu. Hata kodu: 200030", "Hata: 200030");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtAra.Text = "Veri Ara ...";
            txtAra.ForeColor = Color.LightGray;
        }

        private void menuKitapAlVer_Click(object sender, EventArgs e)
        {
            deger = 2;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuKitapAlVer, 164);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200051", "Hata: 200051");
                }

                title.Text = "Kitap Alma/Verme";
                this.Text = "Kitap Alma/Verme - EKOS";
                FrmKitapVerButtonlari();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200050", "Hata: 200050");
            }
        }
        private void menuAnasayfa_Click(object sender, EventArgs e)
        {
            deger = 1;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuAnasayfa, 129);
                }
                catch (Exception)
                {
                    hata404("200061");
                }

                title.Text = "Ana Sayfa";
                this.Text = "Ana Sayfa - EKOS";

                PanelSurukleme();
                FrmAnasayfaGiris giris = new FrmAnasayfaGiris();
                giris.pId = personelGiris.pId;
                frmGetir(giris);


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200060", "Hata: 200060");
            }
        }

        private void menuVeriEkle_Click(object sender, EventArgs e)
        {
            deger = 3;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuVeriEkle, 199);
                }
                catch (Exception)
                {
                    hata404("200071");
                }

                title.Text = "Veri Ekle";
                this.Text = "Veri Ekle - EKOS";

                PanelSurukleme();
                //PanelVeriEkle.Location = new Point(226, 115);

                btnFormIciEffect(BtnVeriKitapEkle);
                btnFormIciEffect(BtnVeriOgrEkle);
                btnFormIciEffect(BtnVeriYazarEkle);
                btnFormIciEffect(BtnVeriBolumEkle);
                btnBold(BtnVeriKitapEkle);
                FrmAllDesignVeriEkle ekle = new FrmAllDesignVeriEkle();
                frmGetir(ekle);


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200070", "Hata: 200070");
            }
        }

        private void menuGecikenKitap_Click(object sender, EventArgs e)
        {
            //deger = 4;
            FrmKitapAlanOgr KtpOgr = new FrmKitapAlanOgr();
            KtpOgr.gecikenKitap = 2;
            KtpOgr.ShowDialog();

            /*try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuGecikenKitap, 234);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200081", "Hata: 200081");
                }

                title.Text = "Geciken Kitaplar";
                this.Text = "Geciken Kitaplar - EKOS";
                hata404("200080");

                PanelSurukleme();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200080", "Hata: 200080");
            }*/
        }

        private void menuOgr_Click(object sender, EventArgs e)
        {
            deger = 5;

                    BtnEffectAll();
                    btnColor(menuOgr, 270);
                    hata404("200071");




            title.Text = "Öğrenciler";
            this.Text = "Öğrenciler - EKOS";

            PanelSurukleme();
            FrmAllDesignOgrenciler ogr = new FrmAllDesignOgrenciler();
            frmGetir(ogr);
        }

        private void menuKitap_Click(object sender, EventArgs e)
        {
            deger = 6;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuKitap, 304);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200091", "Hata: 200091");
                }

                title.Text = "Kitaplar";
                this.Text = "Kitaplar - EKOS";
                hata404("200090");

                PanelSurukleme();
                PanelKitaplar.Location = new Point(226, 115);


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200090", "Hata: 200090");
            }
        }

        private void menuYazar_Click(object sender, EventArgs e)
        {
            deger = 7;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuYazar, 339);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200101", "Hata: 200101");
                }

                title.Text = "Yazarlar";
                this.Text = "Yazarlar - EKOS";
                hata404("200100");

                PanelSurukleme();
                var yazar = new FrmAllDesignYazarlar();
                frmGetir(yazar);


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200100", "Hata: 200100");
            }
        }

        private void menuSonEklenen_Click(object sender, EventArgs e)
        {
            deger = 8;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuSonEklenen, 374);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200131", "Hata: 200131");
                }

                title.Text = "Son Eklenen Kitaplar";
                this.Text = "Son Eklenen Kitaplar - EKOS";
                hata404("200130");

                PanelSurukleme();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200130", "Hata: 200130");
            }
        }

        private void menuAyarlar_Click(object sender, EventArgs e)
        {
            deger = 9;
            try
            {
                /*try
                {
                    BtnEffectAll();
                    btnColor(menuAyarlar, 409);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200141", "Hata: 200141");
                }*/

                title.Text = "Ayarlar > Kişisel Bilgiler";
                this.Text = "Ayarlar - EKOS";

                frmAyarlarButtonlari();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200140", "Hata: 200140");
            }
        }

        private void menuKisayol_Click(object sender, EventArgs e)
        {
            deger = 10;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuKisayol, 444);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200151", "Hata: 200151");
                }

                title.Text = "Kısayollar";
                this.Text = "Kısayollar - EKOS";
                FrmAllDesignKisayollar kisayol = new FrmAllDesignKisayollar();
                frmGetir(kisayol);

                PanelSurukleme();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200150", "Hata: 200150");
            }
        }

        private void menuHakkinda_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    FrmHakkinda hakkinda = new FrmHakkinda();
                    hakkinda.ShowDialog();
                }
                catch (Exception)
                {
                    hata404("200161");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200160", "Hata: 200160");
            }
        }

        private void menuYardim_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtAra_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtAra.Text == "")
                {
                    txtAra.Text = "Veri Ara ...";
                    txtAra.ForeColor = Color.LightGray;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200180", "Hata: 200180");
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pcLogo_Click(object sender, EventArgs e)
        {

            deger = 1;
            try
            {
                try
                {
                    BtnEffectAll();
                    btnColor(menuAnasayfa, 129);
                }
                catch (Exception)
                {

                    MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200201", "Hata: 200201");
                }

                title.Text = "Ana Sayfa";
                this.Text = "Ana Sayfa - EKOS";

                IntAnasayfa = 1;
                IntVeriEkle = 1;
                IntAyarlar = 1;
                PanelSurukleme();
                FrmAnasayfaGiris giris = new FrmAnasayfaGiris();
                giris.pId = personelGiris.pId;
                frmGetir(giris);

                txtAra.Clear();
                txtAra.Focus();


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200200", "Hata: 200200");
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    FrmHakkinda hakkinda = new FrmHakkinda();
                    hakkinda.ShowDialog();
                }
                catch (Exception)
                {
                    hata404("200211");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu. Hata kodu: 200210", "Hata: 200210");
            }
        }


        private void pcProfil_Click_1(object sender, EventArgs e)
        {

            title.Text = "Ayarlar > Kişisel Bilgiler";
            this.Text = "Ayarlar - EKOS";

            
            IntAyarlar = 1;
            frmAyarlarButtonlari();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            

        }

        private void pcProfil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnasayfaKitapTeslim_Click(object sender, EventArgs e)
        {
            

            title.Text = "Kitap Teslim Al";
            this.Text = "Kitap Teslim Al - EKOS";
            IntAnasayfa = 2;
            FrmKitapVerButtonlari();
        }

        private void btnAnasayfaKitapVer_Click(object sender, EventArgs e)
        {
            title.Text = "Kitap Ver";
            this.Text = "Kitap Ver - EKOS";
            IntAnasayfa = 1;
            FrmKitapVerButtonlari();
        }

        private void btnAnasayfaGecikenKitap_Click(object sender, EventArgs e)
        {
            /*title.Text = "Geciken Kitaplar";
            this.Text = "Geciken Kitaplar - EKOS";
            IntAnasayfa = 3;
            FrmKitapVerButtonlari();*/
            FrmKitapAlanOgr KtpOgr = new FrmKitapAlanOgr();
            KtpOgr.gecikenKitap = 1;
            KtpOgr.ShowDialog();
        }

        private void BtnAyarHizliNot_Click(object sender, EventArgs e)
        {
            FrmHizliNotlar not = new FrmHizliNotlar();
            not.ShowDialog();
        }

        private void BtnAyarKisisel_Click(object sender, EventArgs e)
        {
            IntAyarlar = 1;
            frmAyarlarButtonlari();
        }

        private void BtnAyarSifre_Click(object sender, EventArgs e)
        {
            IntAyarlar = 2;
            frmAyarlarButtonlari();
        }

        private void BtnAyarLog_Click(object sender, EventArgs e)
        {
            IntAyarlar = 3;
            frmAyarlarButtonlari();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            TxtClear.Visible = Visible;
            if (txtAra.Text == " ")
            {
                txtAra.Text = "";
                TxtClear.Visible = false;
            }

            if (txtAra.Text == "veri ara ...")
            {
                TxtClear.Visible = false;
            }

            if (txtAra.Text == "")
            {
                TxtClear.Visible = false;
            }
            txtAra.ForeColor = Color.Cyan;
            
        }

        private void menuAnasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 1)
            {
                MenuBtnHover(menuAnasayfa);
            }
            
        }

        private void menuKitapAlVer_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 2)
            {
                MenuBtnHover(menuKitapAlVer);
            }
        }

        private void menuVeriEkle_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 3)
            {
                MenuBtnHover(menuVeriEkle);
            }
        }

        private void menuGecikenKitap_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 4)
            {
                MenuBtnHover(menuGecikenKitap);
            }
        }

        private void menuOgr_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 5)
            {
                MenuBtnHover(menuOgr);
            }
        }

        private void menuKitap_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 6)
            {
                MenuBtnHover(menuKitap);
            }
        }

        private void menuYazar_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 7)
            {
                MenuBtnHover(menuYazar);
            }
        }

        private void menuSonEklenen_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 8)
            {
                MenuBtnHover(menuSonEklenen);
            }
        }

        private void menuAyarlar_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 9)
            {
                MenuBtnHover(menuAyarlar);
            }
        }

        private void menuKisayol_MouseMove(object sender, MouseEventArgs e)
        {
            if (deger != 10)
            {
                MenuBtnHover(menuKisayol);
            }
        }

        private void menuHakkinda_MouseMove(object sender, MouseEventArgs e)
        {
            MenuBtnHover(menuHakkinda);
        }


        private void menuAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 1)
            {
                MenuBtnLeave(menuAnasayfa);
            }
        }

        private void menuKitapAlVer_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 2)
            {
                MenuBtnLeave(menuKitapAlVer);
            }
        }

        private void menuVeriEkle_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 3)
            {
                MenuBtnLeave(menuVeriEkle);
            }
        }

        private void menuGecikenKitap_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 4)
            {
                MenuBtnLeave(menuGecikenKitap);
            }
        }

        private void menuOgr_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 5)
            {
                MenuBtnLeave(menuOgr);
            }
        }

        private void menuKitap_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 6)
            {
                MenuBtnLeave(menuKitap);
            }
        }

        private void menuYazar_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 7)
            {
                MenuBtnLeave(menuYazar);
            }
        }

        private void menuSonEklenen_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 8)
            {
                MenuBtnLeave(menuSonEklenen);
            }
        }

        private void menuAyarlar_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 9)
            {
                MenuBtnLeave(menuAyarlar);
            }
        }

        private void menuKisayol_MouseLeave(object sender, EventArgs e)
        {
            if (deger != 10)
            {
                MenuBtnLeave(menuKisayol);
            }
        }

        private void menuHakkinda_MouseLeave(object sender, EventArgs e)
        {
                MenuBtnLeave(menuHakkinda);
            
        }


        private void txtAra_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAra.Text == "veri ara ...")
            {
                txtAra.Text = "";
            }
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAra.Text == "asf" || txtAra.Text == "anasayfa")
                {
                    deger = 1;
                    try
                    {
                        BtnEffectAll();
                        btnColor(menuAnasayfa, 130);
                        PanelSurukleme();
                        FrmAnasayfaGiris giris = new FrmAnasayfaGiris();
                        giris.pId = personelGiris.pId;
                        frmGetir(giris);

                        title.Text = "Ana Sayfa";
                        this.Text = "Ana Sayfa - EKOS";
                    }
                    catch (Exception)
                    {
                        hata404("200191");
                    }

                }

                else if (txtAra.Text == "ayr" || txtAra.Text == "ayarlar")
                {
                    deger = 9;
                    try
                    {
                        IntAyarlar = 1;
                        frmAyarlarButtonlari();

                        title.Text = "Ayarlar";
                        this.Text = "Ayarlar - EKOS";
                    }
                    catch (Exception)
                    {
                        hata404("200192");
                    }

                }

                else if (txtAra.Text == "ks" || txtAra.Text == "kısayollar")
                {
                    deger = 10;
                        try
                        {
                            BtnEffectAll();
                            btnColor(menuKisayol, 444);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Biçimlendirmede bir hata oluştu. Hata kodu: 200151", "Hata: 200151");
                        }

                        title.Text = "Kısayollar";
                        this.Text = "Kısayollar - EKOS";
                        FrmAllDesignKisayollar kisayol = new FrmAllDesignKisayollar();
                        frmGetir(kisayol);

                        PanelSurukleme();

                }

                else if (txtAra.Text == "hk" || txtAra.Text == "hakkında")
                {
                    FrmHakkinda hakkinda = new FrmHakkinda();
                    hakkinda.ShowDialog();
                }

                else
                {
                    deger = 0;
                    BtnEffectAll();
                    PanelSurukleme();
                    select.Location = new Point(-50, 0);
                    hata404("200193");
                }
            }
        }

        private void BtnOgrKitapAlanOgr_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr KtpOgr = new FrmKitapAlanOgr();
            KtpOgr.ShowDialog();
        }

        private void BtnOgrCokKitapOkuyanSinif_Click(object sender, EventArgs e)
        {

        }

        private void BtnOgrKitapGeciktiren_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr KtpOgr = new FrmKitapAlanOgr();
            KtpOgr.ShowDialog();
        }

        private void BtnKtpGecikenKitap_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr KtpOgr = new FrmKitapAlanOgr();
            KtpOgr.ShowDialog();
        }

        private void BtnOgrTumOgr_Click(object sender, EventArgs e)
        {
            /*try
            {
                FrmOgrenciler tumOgrenciler = new FrmOgrenciler();
                tumOgrenciler.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Harici panel çöktü! (Panel Adı: FrmOgrenciler)");
            }*/

            title.Text = "Tüm Öğrenciler";
            this.Text = "Tüm Öğrenciler - EKOS";

            FrmOgrenciler ogr = new FrmOgrenciler();
            frmGetir(ogr);
        }

        private void BtnKtpTumKitap_Click(object sender, EventArgs e)
        {
            FrmKitaplar Kitap = new FrmKitaplar();
            Kitap.deger.Text = 1.ToString();
            Kitap.ShowDialog();
        }

        private void BtnVeriYazarEkle_Click(object sender, EventArgs e)
        {
            IntVeriEkle = 2;
        }

        private void BtnVeriOgrEkle_Click(object sender, EventArgs e)
        {
            IntVeriEkle = 3;
        }

        private void BtnVeriBolumEkle_Click(object sender, EventArgs e)
        {
            IntVeriEkle = 4;
        }

        bool mouseDown;
        private Point offset;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown==true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BtnBuyut_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnMinimazed_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMinimazed_MouseMove(object sender, MouseEventArgs e)
        {
            BtnMinimazed.BackColor = Color.FromArgb(51, 95, 124);
        }

        private void BtnMinimazed_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimazed.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();


                


            }
            Opacity += .4;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity -= .4;
            if (Opacity == 0)
            {
                timer1.Stop();
            }
        }

        private void TxtClear_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            TxtClear.Visible = false;
            txtAra.Focus();
        }

        private void AllDesign_FormClosed(object sender, FormClosedEventArgs e)
        {
            var log = ekos.PersonelLogKaydi.Find(personelGiris.LogId);
            log.CikisTarihi = DateTime.Now;
            ekos.SaveChanges();
        }

        private void AllDesign_FormClosing(object sender, FormClosingEventArgs e)
        {
            var log = ekos.PersonelLogKaydi.Find(personelGiris.LogId);
            log.CikisTarihi = DateTime.Now;
            ekos.SaveChanges();
        }

        private void AllDesign_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
        }

        private void BtnVeriKitapEkle_Click(object sender, EventArgs e)
        {
            IntVeriEkle = 1;
        }
    }
}
