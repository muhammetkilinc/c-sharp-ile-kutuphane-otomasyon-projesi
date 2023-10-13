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
    public partial class ControlKitaplar : UserControl
    {
        public ControlKitaplar()
        {
            InitializeComponent();
        }

        #region Properties

        private string _kitapAd;
        private string _kitapYazar;
        private string _kitapYayinevi;
        private Image _gorsel;
        private string _raftaMi;
        private Color _rafRenk;

        [Category("Custom Props")]
        public string VeriKitapAd
        {
            get { return _kitapAd; }
            set { _kitapAd = value; KitapAd.Text = value; }
        }



        [Category("Custom Props")]
        public string VeriKitapYazar
        {
            get { return _kitapYazar; }
            set { _kitapYazar = value; KitapYazar.Text = value; }
        }



        [Category("Custom Props")]
        public string VeriKitapYayinevi
        {
            get { return _kitapYayinevi; }
            set { _kitapYayinevi = value; KitapYayinevi.Text = value; }
        }



        [Category("Custom Props")]
        public Image VeriGorsel
        {
            get { return _gorsel; }
            set { _gorsel = value; Gorsel.Image = value; }
        }



        [Category("Custom Props")]
        public string VeriRaf
        {
            get { return _raftaMi; }
            set { _raftaMi = value; KitapRaf.Text = value; }
        }


        [Category("Custom Props")]
        public Color VeriRafRenk
        {
            get { return _rafRenk; }
            set { _rafRenk = value; KitapRaf.BackColor = value; }
        }







        #endregion

        private void BtnKitapAktar_Click(object sender, EventArgs e)
        {
            FrmKitapVer kitap = new FrmKitapVer();
            kitap.BtnKitapSec.Visible = false;
            kitap.VerilerKitap.Visible = Visible;
            kitap.VeriKitapId.Text = KitapId.Text;
            kitap.VeriKitapAd.Text = KitapAd.Text;
            kitap.VeriYazarad.Text = KitapYazar.Text;
            kitap.veriOgrId.Text = OgrId.Text;
            kitap.VeriOgrAd.Text = OgrAd.Text;
            kitap.VeriOgrNo.Text = OgrNo.Text;
            if (OgrId.Text != "0" && OgrAd.Text != "0" && OgrNo.Text != "0")
            {
                kitap.btnOgrSec.Visible = false;
                kitap.VerilerOgr.Visible = Visible;
            }
            kitap.ShowDialog();
        }
    }
}
