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
    public partial class FrmAllDesignOgrenciler : Form
    {
        public FrmAllDesignOgrenciler()
        {
            InitializeComponent();
        }

        private void BtnTumOgr_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 0;
            ogr.ShowDialog();
        }

        private void BtnKtpAlan_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 1;
            ogr.ShowDialog();
        }

        private void BtnCokKitapOkuyan_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 3;
            ogr.ShowDialog();
        }

        private void BtnCokKypOkunanBolum_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 4;
            ogr.ShowDialog();
        }

        private void BtnDisiplin_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 5;
            ogr.ShowDialog();
        }

        private void BtnKtpGeciktiren_Click(object sender, EventArgs e)
        {
            FrmOgrenciler ogr = new FrmOgrenciler();
            ogr.AllDesignDeger = 6;
            ogr.ShowDialog();
        }
    }
}
