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
    public partial class FrmExit : Form
    {
        public FrmExit()
        {
            InitializeComponent();
        }

        ekosEntities db = new ekosEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var log = db.PersonelLogKaydi.Find(personelGiris.LogId);
                log.CikisTarihi = DateTime.Now;
                log.Personel.SistemeGirisSayisi += 1;
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Log kaydı hatası!", "Log Kayıtları - EKOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
