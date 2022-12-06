using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace projem
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\otogaleri.accdb");
        bool durum = false;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void buton_giris_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            OleDbCommand tablosecimi = new OleDbCommand("select * from tbl_kullanici", baglanti);
            OleDbDataReader okuyucu = tablosecimi.ExecuteReader();
            while (okuyucu.Read())
            {
                if ((okuyucu[1].ToString() == text_kuladi.Text) && (text_sifre.Text == okuyucu[2].ToString()))
                {
                    durum = true;
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                    break;
                }

            }
            if (durum == false)
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz Yanlış");


            okuyucu.Close();
            baglanti.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
