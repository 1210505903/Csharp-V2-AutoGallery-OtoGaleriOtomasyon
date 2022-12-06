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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tuvturk.com.tr/gecikme-bedeli.aspx");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://intvd.gib.gov.tr/internetvd/template.jsp?page=IVD_MTV_SORGU");
            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://intvd.gib.gov.tr/internetvd/template.jsp?page=IVD_MTV_SORGU");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hgsmusteri.ptt.gov.tr/hgs.jsf#violation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://kacakgecis.kgm.gov.tr/ihlal/Sayfalar/ihlal.aspx");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form1 Yeni = new Form1();
            Yeni.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
