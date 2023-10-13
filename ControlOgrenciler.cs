using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekos
{
    public partial class ControlOgrenciler : UserControl
    {
        public ControlOgrenciler()
        {
            InitializeComponent();
        }

        #region Properties

        private string _ogrAdSoyad;
        private string _ogrNo;
        private string _ogrBolum;
        private string _ogrSinif;
        private string _ogrId;

        [Category("Custom Props")]
        public string VeriAdSoyad
        {
            get { return _ogrAdSoyad; }
            set { _ogrAdSoyad = value; OgrAdSoyad.Text = value; }
        }



        [Category("Custom Props")]
        public string VeriOgrNo
        {
            get { return _ogrNo; }
            set { _ogrNo = value; OgrNo.Text = value; }
        }



        [Category("Custom Props")]
        public string VeriOgrBolum
        {
            get { return _ogrBolum; }
            set { _ogrBolum = value; OgrBolum.Text = value; }
        }



        [Category("Custom Props")]
        public string VeriOgrSinif
        {
            get { return _ogrSinif; }
            set { _ogrSinif = value; OgrSinif.Text = value; }
        }




        [Category("Custom Props")]
        public string VeriOgrId
        {
            get { return _ogrId; }
            set { _ogrId = value; OgrId.Text = value; }
        }





        #endregion

        private void BtnAktar_Click(object sender, EventArgs e)
        {
            FrmKitapVer kitap = new FrmKitapVer();
            kitap.veriOgrId.Text = OgrId.Text;
            kitap.VeriOgrAd.Text = OgrAdSoyad.Text;
            kitap.VeriOgrNo.Text = OgrNo.Text;
            kitap.btnOgrSec.Visible = false;
            kitap.VerilerOgr.Visible = Visible;
            kitap.VeriKitapId.Text = KitapId.Text;
            kitap.VeriKitapAd.Text = KitapAd.Text;
            kitap.VeriYazarad.Text = YazarAd.Text;
            //if (KitapId.Text != "0" && KitapAd.Text != "0" && YazarAd.Text != "0")
            //{
                
            //    kitap.BtnKitapSec.Visible = false;
            //    kitap.VerilerKitap.Visible = Visible;
            //}
            kitap.ShowDialog();  
        }
    }
}
