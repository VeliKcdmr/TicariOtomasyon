using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public class KontrolHelper
    {
        public static void Hatayazdir(Control kontrol, LabelControl lbl)
        {
            if (kontrol is TextEdit txt && string.IsNullOrWhiteSpace(txt.Text))
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = "* Bu alan boş bırakılamaz!";
                lbl.Visible = true;
            }
            else if (kontrol is ComboBoxEdit cmb && (cmb.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cmb.Text)))
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = "* Bir seçim yapmalısınız!";
                lbl.Visible = true;
            }
            else
            {
                lbl.Text = "";
                lbl.Visible = false;
            }
        }       

    }
}
