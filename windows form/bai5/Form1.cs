using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String s = DateTime.Today.ToString("dd/MM/yyyy");
            label_NgayThu.Text = s;
        }

        private void button_TinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                double csc = double.Parse(textBox_ChiSoCu.Text);
                double csm = double.Parse(textBox_ChiSoMoi.Text);
                double dg = double.Parse(textBox_DonGia.Text);
                if (csc < csm)
                {
                    double tien = (csm - csc) * dg;
                    textBox_ThanhTien.Text = tien.ToString();
                    label_ThongBao.Text = "";
                }
                else
                    label_ThongBao.Text = "* chỉ số mới phải lớn hơn chỉ số cũ";
            }
            catch(Exception loi)
            {
                MessageBox.Show(loi.Message);
            }
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_KhachHang.Clear();
            textBox_ChiSoCu.Clear();
            textBox_ChiSoMoi.Clear();
            textBox_DonGia.Clear();
            textBox_KhachHang.Focus();
        }
    }
}
