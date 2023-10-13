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
    public partial class FrmHizliNotlar : Form
    {
        public FrmHizliNotlar()
        {
            InitializeComponent();
        }


        ekosEntities db = new ekosEntities();


        private void FrmHizliNotlar_Load(object sender, EventArgs e)
        {
            var query = from h in db.hizliNotSistemi
                        orderby h.KayitTarih descending
                        where h.personelId == personelGiris.pId
                        select new
                        {
                            h.Id,
                            NotBaslik = h.notBaslik.ToUpper(),
                            h.notIcerik,
                            yerineGetirildi = h.yerineGetirildiMi == true ? "Evet" : "Hayır",
                            h.KayitTarih
                        };

            hizliNotlar.DataSource = query.ToList();


            var notlar = db.hizliNotSistemi.OrderByDescending(x => x.KayitTarih).Where(x => x.personelId == personelGiris.pId).ToList();

            int deger = 0;
            foreach (var item in notlar)
            {
                if (item.yerineGetirildiMi == false)
                {
                    hizliNotlar.Rows[deger].Cells[3].Style.BackColor = Color.Red;
                    hizliNotlar.Rows[deger].Cells[3].Style.ForeColor = Color.White;
                }
                deger++;

            }
            

            /*var hizliNot = db.HizliNotSistemi.ToList();
            hizliNotlar.DataSource = hizliNot;*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Yenile.Visible = true;
            FrmHizliNotDetay detay = new FrmHizliNotDetay();
            detay.ShowDialog();
        }

        private void hizliNotlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var detay = new FrmHizliNotDetay();
            detay.id = int.Parse(hizliNotlar.CurrentRow.Cells[0].Value.ToString());
            //this.Hide();
            Yenile.Visible = true;
            detay.ShowDialog();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var h = new FrmHizliNotlar();
            h.ShowDialog();

        }
    }
}
