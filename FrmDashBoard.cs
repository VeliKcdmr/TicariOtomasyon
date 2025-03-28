using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }
        FrmProductsAdd frmpadd;
        private void BtnMUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmpadd == null || frmpadd.IsDisposed)
            {
                frmpadd = new FrmProductsAdd();
                frmpadd.MdiParent = this;
                frmpadd.Show();
            }
        }
        FrmProductsList frmpl;
        private void BtnUrunList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmpl == null || frmpl.IsDisposed)
            {
                frmpl = new FrmProductsList();
                frmpl.MdiParent = this;
                frmpl.Show();
            }
        }
    }
}
