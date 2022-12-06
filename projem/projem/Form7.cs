using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            panel_sms.Enabled = false;
            panel_internet.Enabled = false;
            panel1.Visible = false;
            panel_internet.Visible = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_internet.Enabled = true;
            panel_sms.Enabled = false;
            panel1.Visible = false;
            panel_internet.Visible = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            panel_sms.Enabled = true;
            panel_internet.Enabled = false;
            panel1.Visible = true;
            panel_internet.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.turkiye.gov.tr/emniyet-adima-tescilli-arac-sorgulama");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 arac = new Form1();
            arac.Show();
            this.Hide();
        }
    }
}
