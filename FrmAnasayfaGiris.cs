using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class FrmAnasayfaGiris : Form
    {
        public FrmAnasayfaGiris()
        {
            InitializeComponent();
        }
        public int pId = 0;
        private void BtnNotlar_Click(object sender, EventArgs e)
        {
            FrmHizliNotlar not = new FrmHizliNotlar();
            not.ShowDialog();
        }
    }
}
