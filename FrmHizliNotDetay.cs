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
    public partial class FrmHizliNotDetay : Form
    {
        public FrmHizliNotDetay()
        {
            InitializeComponent();
        }
        public int id = 0;
        ekosEntities db = new ekosEntities();
        
        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Hide();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBaslik.Text != "" && TxtNot.Text != "")
            {
                if (personelGiris.pId != 0)
                {
                    var hizliNot = new hizliNotSistemi();
                    hizliNot.personelId = personelGiris.pId;
                    hizliNot.notBaslik = TxtBaslik.Text;
                    hizliNot.notIcerik = TxtNot.Text;

                    if (Kontrol.Checked == true)
                    {
                        hizliNot.yerineGetirildiMi = true;
                    }
                    else
                    {
                        hizliNot.yerineGetirildiMi = false;
                    }

                    hizliNot.KayitTarih = DateTime.Now;
                    db.hizliNotSistemi.Add(hizliNot);
                    db.SaveChanges();
                    this.Hide();
                    //MessageBox.Show("Notunuz kaydedildi.", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İzinsiz Kullanıcı Girişi!", "Personel Girişi - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen her iki alanı da doldurun!", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*if (TxtBaslik.Text != "" && TxtNot.Text != "")
            {
                
                //MessageBox.Show(DateTime.Now.ToString());
                if (NotId.Text != "id")
                {
                    int id = int.Parse(NotId.Text);
                    var hizliNot = db.HizliNotSistemi.Find(id);
                    hizliNot.notBaslik = TxtBaslik.Text;
                    hizliNot.KayitTarih = DateTime.Now;
                    db.SaveChanges();
                }
                else if (NotId.Text == "id")
                {
                    HizliNotSistemi hizliNot = new HizliNotSistemi();
                    hizliNot.notBaslik = TxtBaslik.Text;
                    hizliNot.KayitTarih = DateTime.Now;
                    MessageBox.Show(TxtBaslik.Text + " - " + DateTime.Now.ToString());
                    db.HizliNotSistemi.Add(hizliNot);
                    db.SaveChanges();
                }
                
                this.Hide();
                if (BtnKaydet.Text == "KAYDET")
                {
                    MessageBox.Show("Notunuz Kaydedildi.");
                }
                else if (BtnKaydet.Text == "GÜNCELLE")
                {
                    MessageBox.Show("Notunuz Güncellendi.");
                }
            }

            else
            {
                MessageBox.Show("Lütfen İçeriği doldurun!");
            }*/
        }

        private void FrmHizliNotDetay_Load(object sender, EventArgs e)
        {


            if (id != 0)
            {
                TxtTarih.Visible = true;
                PanelRenk.Visible = true;
                PanelText.Visible = true;
                BtnGuncelle.Visible = true;
                BtnSil.Visible = true;
                BtnKaydet.Visible = false;

                var hizliNot = db.hizliNotSistemi.Find(id);
                TxtTarih.Text = hizliNot.KayitTarih.ToString();
                TxtBaslik.Text = hizliNot.notBaslik;
                TxtNot.Text = hizliNot.notIcerik;

                if (hizliNot.yerineGetirildiMi == true)
                {
                    PanelRenk.BackColor = Color.Lime;
                    PanelText.Text = "Not yerine getirildi.";
                    Kontrol.Checked = true;
                }

                else if (hizliNot.yerineGetirildiMi == false)
                {
                    PanelRenk.BackColor = Color.Red;
                    PanelText.Text = "Not yerine getirilmedi.";
                    Kontrol.Checked = false;
                }
            }

            else if (id == 0)
            {

                TxtTarih.Visible = false;
                PanelRenk.Visible = false;
                PanelText.Visible = false;
                BtnGuncelle.Visible = false;
                BtnSil.Visible = false;
                BtnKaydet.Visible = true;
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var hizliNot = db.hizliNotSistemi.Find(id);
                hizliNot.notBaslik = TxtBaslik.Text;
                hizliNot.notIcerik = TxtNot.Text;

                if (Kontrol.Checked == true)
                {
                    hizliNot.yerineGetirildiMi = true;
                }

                else
                {
                    hizliNot.yerineGetirildiMi = false;
                }
                db.SaveChanges();
                this.Hide();
                //MessageBox.Show("Notunuz güncellendi.", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu nota ait ID değeri bulunamadı!", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var hizliNot = db.hizliNotSistemi.Find(id);
                db.hizliNotSistemi.Remove(hizliNot);
                db.SaveChanges();
                this.Hide();
                //MessageBox.Show("Notunuz silindi.", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu nota ait ID değeri bulunamadı!", "Notlar - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
