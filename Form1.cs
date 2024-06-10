using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_chuvidientichhinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbchuvi_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            Double chuvi, bankinh;
            bankinh = Convert.ToDouble(txtbankinh.Text);
            chuvi = bankinh * 2 * Math.PI;
            txtKQ.Text = chuvi.ToString();

        }

        private void btndientich_Click(object sender, EventArgs e)
        {

            Double dientich, bankinh;
            bankinh = Convert.ToDouble(txtbankinh.Text);
            dientich = bankinh * bankinh * Math.PI;
            txtKQ.Text = dientich.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbankinh.Text = "5.2";
        }

        private void btntinhn1_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbdientich1.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                string thongbao = "- Diện tích " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbchuvi1.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                string thongbao = "- Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btntinhl2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (chkdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                thongbao = thongbao + "- Diện tích " + Convert.ToString(dientich) + Environment.NewLine;

            }
            if (chkcv.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                thongbao = thongbao + "- Chu vi" + Convert.ToString(chuvi) + Environment.NewLine;
            }

            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tính năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
