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
    public partial class FrmAllDesignKitapTeslimAl : Form
    {
        public FrmAllDesignKitapTeslimAl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TxtRenk.BackColor = Color.Cyan;
        }

        private void TxtOgrAra_MouseClick(object sender, MouseEventArgs e)
        {
            TxtRenk.BackColor = Color.Cyan;
        }

        private void FrmAllDesignKitapTeslimAl_Load(object sender, EventArgs e)
        {
            TxtOgrAra.MaxLength = 11;
            TxtOgrAra.Focus();
        }

        private void BtnOgrAra_Click(object sender, EventArgs e)
        {
            if (TxtOgrAra.Text != "")
            {
                TxtRenk.BackColor = Color.Gray;
                FrmKitapAlanOgr ktpAlan = new FrmKitapAlanOgr();
                ktpAlan.okulNo = TxtOgrAra.Text;
                ktpAlan.OgrDetayDeger = 1;
                TxtOgrAra.Text = "";
                ktpAlan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Öğrenci numarasını yazınız.");
            }
        }

        private void TxtOgrAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 64)
            {
                e.Handled = true;
            }
        }
    }
}
