using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bt_tinh_Click(object sender, EventArgs e)
        {
            
            try
            {
                double r = double.Parse(txt_bk.Text);
                if (r <= 0)
                {
                    MessageBox.Show("Loi", "Thong bao!");
                }
                else 
                {
                    double cv = Math.Round(2 * Math.PI * r, 5);
                    double dt = Math.Round(Math.PI * Math.Pow(r, 2), 5);
                    txt_cv.Text = cv.ToString();
                    txt_dt.Text = dt.ToString();
                }
            }catch(Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }
        private void bt_tt_Click(object sender, EventArgs e)
        {
            txt_bk.Clear();
            txt_cv.Clear();
            txt_dt.Clear();
            txt_bk.Focus();
        }
    }
}
