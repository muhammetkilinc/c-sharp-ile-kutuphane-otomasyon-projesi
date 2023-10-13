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
    public partial class FrmAyarlarProfilFoto : Form
    {
        public FrmAyarlarProfilFoto()
        {
            InitializeComponent();
        }

        ekosEntities db = new ekosEntities();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAyarlarProfilFoto_Load(object sender, EventArgs e)
        {
            var personel = db.Personel.Find(personelGiris.pId);
            profil.ImageLocation = personel.GorselUrl;
            url.Text = personel.GorselUrl;
        }
    }
}
