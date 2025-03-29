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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FrmCategories frmkategori;
        private void BtnKIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmkategori == null || frmkategori.IsDisposed)
            {
                frmkategori = new FrmCategories();
                frmkategori.MdiParent = this;
                frmkategori.Show();
            }
        }
        FrmBrands frmmarka;
        private void BtnMIslem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmmarka == null || frmmarka.IsDisposed)
            {
                frmmarka = new FrmBrands();
                frmmarka.MdiParent = this;
                frmmarka.Show();
            }

        }
    }
}
