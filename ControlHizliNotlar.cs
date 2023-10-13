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
    public partial class ControlHizliNotlar : UserControl
    {
        public ControlHizliNotlar()
        {
            InitializeComponent();
        }

        #region Properties

        private string _notBaslik;
        private string _notIcerik;
        private string _notTarih;
        private string _notId;
        private Color _islem;



        [Category("Custom Props")]
        public string VeriNotBaslik
        {
            get { return _notBaslik; }
            set { _notBaslik = value; NotBaslik.Text = value; }
        }


        [Category("Custom Props")]
        public string VeriNotIcerik
        {
            get { return _notIcerik; }
            set { _notIcerik = value; NotIcerik.Text = value; }
        }


        [Category("Custom Props")]
        public string VeriNotTarih
        {
            get { return _notTarih; }
            set { _notTarih = value; NotTarih.Text = value; }
        }


        [Category("Custom Props")]
        public string VeriNotId
        {
            get { return _notId; }
            set { _notId = value; NotId.Text = value; }
        }


        [Category("Custom Props")]
        public Color VeriNotIslem
        {
            get { return _islem; }
            set { _islem = value; IslemYapildi.BackColor = value; }
        }



        #endregion

        private void BtnDetay_Click(object sender, EventArgs e)
        {
            FrmHizliNotDetay not = new FrmHizliNotDetay();
            not.TxtBaslik.Text = NotBaslik.Text;
            not.TxtNot.Text = NotIcerik.Text;
            not.TxtTarih.Text = NotTarih.Text;
            not.BtnKaydet.Text = "GÜNCELLE";
            not.PanelRenk.BackColor = IslemYapildi.BackColor;
            not.TxtTarih.Visible = Visible;
            not.PanelRenk.Visible = Visible;
            not.PanelText.Visible = Visible;
            not.ShowDialog();
        }
    }
}
