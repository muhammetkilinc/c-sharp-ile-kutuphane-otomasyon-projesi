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
    public partial class ControlKitapAlanOgr : UserControl
    {
        public ControlKitapAlanOgr()
        {
            InitializeComponent();
        }
        #region Properties

        private string _ogrId;
        private string _ogrAd;
        private string _ogrNo;
        private string _kitapAd;
        private string _tarih;
        private Image _ogrGorsel;
        private Image _kitapGorsel;


        private string _ktpKitapAd;
        private string _ktpYazarAd;
        private string _ktpYayinevi;
        private string _ktpSayfaSayisi;


        [Category("Custom Props")]
        public string VeriOgrAdSoyad
        {
            get { return _ogrAd; }
            set { _ogrAd = value; OgrAdSoyad.Text = value; }
        }


        [Category("Custom Props")]
        public string VeriOgrNo
        {
            get { return _ogrNo; }
            set { _ogrNo = value; OgrNo.Text = value; }
        }

        
        [Category("Custom Props")]
        public string VeriKitapAd
        {
            get { return _kitapAd; }
            set { _kitapAd = value; KitapAd.Text = value; }
        }


        [Category("Custom Props")]
        public string VeriAlisTarih
        {
            get { return _tarih; }
            set { _tarih = value; AlisTarih.Text = value; }
        }

        [Category("Custom Props")]
        public Image VeriOgrGorsel
        {
            get { return _ogrGorsel; }
            set { _ogrGorsel = value; OgrGorsel.Image = value; }
        }

        [Category("Custom Props")]
        public Image VeriKitapGorsel
        {
            get { return _kitapGorsel; }
            set { _kitapGorsel = value; KitapGorsel.Image = value; }
        }

        [Category("Custom Props")]
        public string VeriKtpKitapAd
        {
            get { return _ktpKitapAd; }
            set { _ktpKitapAd = value; KtpKitapAd.Text = value; }
        }

        [Category("Custom Props")]
        public string VeriKtpYazarAd
        {
            get { return _ktpYazarAd; }
            set { _ktpYazarAd = value; KtpYazarAd.Text = value; }
        }

        [Category("Custom Props")]
        public string VeriKtpYayinevi
        {
            get { return _ktpYayinevi; }
            set { _ktpYayinevi = value; KtpYayinevi.Text = value; }
        }

        [Category("Custom Props")]
        public string VeriKtpSayfaSayisi
        {
            get { return _ktpSayfaSayisi; }
            set { _ktpSayfaSayisi = value;  KtpSayfaSayisi.Text = value; }
        }

        [Category("Custom Props")]
        public string VeriOgrId
        {
            get { return _ogrId; }
            set { _ogrId = value; OgrId.Text = value; }
        }







        #endregion

    }
}
