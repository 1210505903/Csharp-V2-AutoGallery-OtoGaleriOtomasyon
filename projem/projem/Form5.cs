﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Double sonucB;
        Double sonuc;
        String depo;
        Double islem(Double x, Double y)
        {
            if (depo == "x")
            {
                sonuc = x * y;
            }
            else if (depo == "-")
            {
                sonuc = x - y;
            }
            else if (depo == "+")
            {
                sonuc = x + y;
            }

            return sonuc;

        }
        Double islem2(Double x, Double y)
        {
            if (depo == "/")
            {
                sonucB = x / y;
            }
            else if (depo == "%")
            {
                sonucB = x * y / 100;
            }

            return sonucB;

        }
              
        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn5.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn1.Text;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn6.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn2.Text;
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn4.Text;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn7.Text;
        }

        private void btnBolu_Click(object sender, EventArgs e)
        {
            depo = btnBolu.Text;
            if (txtKucukYazi.Text == "" && txtBuyukYazi.Text != "")
            {
                txtKucukYazi.Text = txtBuyukYazi.Text;
                txtBuyukYazi.Text = "";
            }
            else
            {
                if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
                {
                    txtKucukYazi.Text = (islem2(Convert.ToDouble(txtKucukYazi.Text), Convert.ToDouble(txtBuyukYazi.Text))).ToString();

                    txtBuyukYazi.Text = "";
                }
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn8.Text;
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn9.Text;
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn0.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBuyukYazi.Text += btn3.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 Yeni = new Form1();
            Yeni.Show();
            this.Hide();
        }

        private void BtnCarpi_Click_1(object sender, EventArgs e)
        {
            depo = BtnCarpi.Text;
            if (txtKucukYazi.Text == "" && txtBuyukYazi.Text != "")
            {
                txtKucukYazi.Text = txtBuyukYazi.Text;
                txtBuyukYazi.Text = "";
            }
            else
            {
                if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
                {
                    txtKucukYazi.Text = (islem(Convert.ToDouble(txtKucukYazi.Text), Convert.ToDouble(txtBuyukYazi.Text))).ToString();

                    txtBuyukYazi.Text = "";
                }
            }
        }

        private void btnEksi_Click_1(object sender, EventArgs e)
        {
            depo = btnEksi.Text;
            if (txtKucukYazi.Text == "" && txtBuyukYazi.Text != "")
            {
                txtKucukYazi.Text = txtBuyukYazi.Text;
                txtBuyukYazi.Text = "";
            }
            else
            {
                if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
                {
                    txtKucukYazi.Text = (islem(Convert.ToDouble(txtKucukYazi.Text), Convert.ToDouble(txtBuyukYazi.Text))).ToString();

                    txtBuyukYazi.Text = "";
                }
            }
        }

        private void btnArti_Click_1(object sender, EventArgs e)
        {
            depo = btnArti.Text;
            if (txtKucukYazi.Text == "" && txtBuyukYazi.Text != "")
            {
                txtKucukYazi.Text = txtBuyukYazi.Text;
                txtBuyukYazi.Text = "";
            }
            else
            {
                if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
                {
                    txtKucukYazi.Text = (islem(Convert.ToDouble(txtKucukYazi.Text), Convert.ToDouble(txtBuyukYazi.Text))).ToString();

                    txtBuyukYazi.Text = "";
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            depo = btnBolu.Text;
            if (txtKucukYazi.Text == "" && txtBuyukYazi.Text != "")
            {
                txtKucukYazi.Text = txtBuyukYazi.Text;
                txtBuyukYazi.Text = "";
            }
            else
            {
                if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
                {
                    txtKucukYazi.Text = (islem2(Convert.ToDouble(txtKucukYazi.Text), Convert.ToDouble(txtBuyukYazi.Text))).ToString();

                    txtBuyukYazi.Text = "";
                }
            }
        }

        private void btnNokta_Click_1(object sender, EventArgs e)
        {
            bool Nokta = txtBuyukYazi.Text.Contains(",");
            if (Nokta == false)
            {
                txtBuyukYazi.Text += btnNokta.Text;
            }
        }

        private void btnEsittir_Click_1(object sender, EventArgs e)
        {
            if (txtBuyukYazi.Text == "" && txtKucukYazi.Text != "")
            {
                txtBuyukYazi.Text = txtKucukYazi.Text;
                txtKucukYazi.Text = "";
            }
            else if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
            {
                if (depo == "/")
                {
                    txtBuyukYazi.Text = (Convert.ToDouble(txtKucukYazi.Text) / Convert.ToDouble(txtBuyukYazi.Text)).ToString();
                    txtKucukYazi.Text = "";
                }
                else if (depo == "x")
                {
                    txtBuyukYazi.Text = (Convert.ToDouble(txtKucukYazi.Text) * Convert.ToDouble(txtBuyukYazi.Text)).ToString();
                    txtKucukYazi.Text = "";
                }
                else if (depo == "+")
                {
                    txtBuyukYazi.Text = (Convert.ToDouble(txtKucukYazi.Text) + Convert.ToDouble(txtBuyukYazi.Text)).ToString();
                    txtKucukYazi.Text = "";
                }
                else if (depo == "-")
                {
                    txtBuyukYazi.Text = (Convert.ToDouble(txtKucukYazi.Text) - Convert.ToDouble(txtBuyukYazi.Text)).ToString();
                    txtKucukYazi.Text = "";
                }
            }
        }

        private void btnTekSil_Click_1(object sender, EventArgs e)
        {
            if (txtBuyukYazi.Text != "")
            {
                int Sayim = txtBuyukYazi.Text.Length;
                txtBuyukYazi.Text = txtBuyukYazi.Text.Remove(Sayim - 1, 1);
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (txtBuyukYazi.Text != "" && txtKucukYazi.Text != "")
            {
                txtBuyukYazi.Text = txtKucukYazi.Text;
                txtKucukYazi.Text = "";
            }
            else if (txtBuyukYazi.Text != "" && txtKucukYazi.Text == "")
            {
                txtBuyukYazi.Text = "";

            }
            else if (txtBuyukYazi.Text == "" && txtKucukYazi.Text != "")
            {
                txtBuyukYazi.Text = txtKucukYazi.Text;
                txtKucukYazi.Text = "";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
