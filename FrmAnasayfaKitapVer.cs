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
    public partial class FrmAnasayfaKitapVer : Form
    {
        public FrmAnasayfaKitapVer()
        {
            InitializeComponent();
        }

        public int pId = 0;

        private void BtnKitapVer_Click(object sender, EventArgs e)
        {
            FrmKitapVer kitap = new FrmKitapVer();
            kitap.ShowDialog();
        }

        private void BtnOgrKitapGor_Click(object sender, EventArgs e)
        {
            FrmKitapAlanOgr kitap = new FrmKitapAlanOgr();
            kitap.ShowDialog();
        }

        private void BtnKitapVer_MouseMove(object sender, MouseEventArgs e)
        {
            BtnKitapVer.BackColor = Color.Cyan;
            BtnKitapVer.ForeColor = Color.Black;
        }

        private void BtnKitapVer_MouseLeave(object sender, EventArgs e)
        {

            BtnKitapVer.BackColor = Color.FromArgb(51, 95, 124);
            BtnKitapVer.ForeColor = Color.White;
        }

        private void BtnOgrKitapGor_MouseMove(object sender, MouseEventArgs e)
        {
            BtnOgrKitapGor.BackColor = Color.Cyan;
            BtnOgrKitapGor.ForeColor = Color.Black;
        }

        private void BtnOgrKitapGor_MouseLeave(object sender, EventArgs e)
        {
            BtnOgrKitapGor.BackColor = Color.FromArgb(51, 95, 124);
            BtnOgrKitapGor.ForeColor = Color.White;
        }
    }
}
