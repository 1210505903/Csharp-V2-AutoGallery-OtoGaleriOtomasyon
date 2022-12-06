using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projem;

namespace projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 arac = new Form8();
            arac.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 duzenle = new Form4();
            duzenle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 duzenle = new Form3();
            duzenle.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 hesap = new Form5();
            hesap.Show();
            this.Hide();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 fom = new projem.Form9();
            fom.Show();
            this.Hide();
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 fon = new Form10();
            fon.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 aa = new Form7();
            aa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 bb = new Form6();
            bb.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://reservation.tuvturk.com.tr/web.ui/Index.aspx");
        }
    }
}
