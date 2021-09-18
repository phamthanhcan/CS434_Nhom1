using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {

            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa + sob;
                lblkq.Text = soa + " + " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {

                lblkq.Text = "Nhập sai dữ liệu";
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa - sob;
                lblkq.Text = soa + " - " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {

                lblkq.Text = "Nhập sai dữ liệu";
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa * sob;
                lblkq.Text = soa + " * " + sob + " = " + kq.ToString();
            }
            catch (Exception)
            {

                lblkq.Text = "Nhập sai dữ liệu";
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = Convert.ToInt32(txta.Text);
                double sob = Convert.ToInt32(txtb.Text);
                double kq = soa / sob;
                lblkq.Text = soa + " / " + sob + " = " + kq.ToString();
                if (sob == 0) {
                    lblkq.Text = "Không thể chia cho 0";
                }
                else {
                    lblkq.Text = soa + " / " + sob + " = " + kq.ToString();

                }
            }
            catch (Exception)
            {
                lblkq.Text = "Nhập sai dữ liệu";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txta1.Text);
            int b = Convert.ToInt32(txtb1.Text);
            string kq;

            if (a == 0)
            {
                if (b == 0)
                    MessageBox.Show("phuong trinh vo so nghiem");
                else
                    MessageBox.Show("phuong trinh vo nghiem");
            }
            else
            {
                int x = (-b / a);
                txtkq1.Text = x.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int chieuDai = Convert.ToInt32(txtdai.Text);
            int chieuRong = Convert.ToInt32(txtrong.Text);

            int kq = 2 * (chieuDai + chieuRong);
            txtkq2.Text ="Chu vi = "  + kq.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int chieuDai = Convert.ToInt32(txtdai.Text);
            int chieuRong = Convert.ToInt32(txtrong.Text);

            int kq = chieuDai*chieuRong;
            txtkq2.Text ="Diện tích =" + kq.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            lblkq.Text = "";
        }

        private void btn_nl_Click(object sender, EventArgs e)
        {
            txta1.Text = "";
            txtb1.Text = "";
            txtkq1.Text = "";
        }

        private void btn_nhaplai2_Click(object sender, EventArgs e)
        {
            txtdai.Text = "";
            txtrong.Text = "";
            txtkq2.Text = "";
        }
    }
}
