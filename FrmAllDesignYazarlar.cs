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
    public partial class FrmAllDesignYazarlar : Form
    {
        public FrmAllDesignYazarlar()
        {
            InitializeComponent();
        }

        private void BtnKitapEkle_Click(object sender, EventArgs e)
        {
            var yazar = new FrmYazarEkle();
            yazar.ShowDialog();
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            var yazar = new FrmYazarEkle();
            yazar.allDesignYazar = 1;
            yazar.ShowDialog();
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            var yazar = new FrmYazarEkle();
            yazar.allDesignYazar = 2;
            yazar.ShowDialog();
        }
    }
}
