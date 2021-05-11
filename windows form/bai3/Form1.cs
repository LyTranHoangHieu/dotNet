using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            string s = "Toi ten la: " + textBox_HoTen.Text + "\nNgay sinh: " + textBox_NgaySinh.Text + "\nSo thich:\n";
            for (int i=0;i<textBox_SoThich.Lines.Length;i++)
            {
                s += "\t" + textBox_SoThich.Lines[i] + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
