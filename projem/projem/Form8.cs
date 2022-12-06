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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\otogaleri.accdb");
        //OleDbDataReader dr;
        OleDbCommand komut;
        private void Form8_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tbl_kasa ORDER BY k_ID ASC", baglanti);
            da.Fill(dt);
            combo_kasa.ValueMember = "k_ID";
            combo_kasa.DisplayMember = "kasa_tipi";
            combo_kasa.DataSource = dt;
            baglanti.Close();
            //////////////////////////////////////////////////////////////
            baglanti.Open();
            DataTable dtrenk = new DataTable();
            OleDbDataAdapter darenk = new OleDbDataAdapter("select * from tbl_renk", baglanti);
            darenk.Fill(dtrenk);
            combo_renk.ValueMember = "r_ID";
            combo_renk.DisplayMember = "renk";
            combo_renk.DataSource = dtrenk;
            baglanti.Close();
        }

        private void combo_kasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_kasa.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from tbl_araclar where a_kasatip=" + combo_kasa.SelectedValue, baglanti);
                da.Fill(dt);
                combo_marka.ValueMember = "a_id";
                combo_marka.DisplayMember = "a_marka";
                combo_marka.DataSource = dt;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Parameters.AddWithValue("@marka", combo_marka.SelectedValue);
            komut.Parameters.AddWithValue("@seri", text_seri.Text);
            komut.Parameters.AddWithValue("@kasa", combo_kasa.SelectedValue);
            komut.Parameters.AddWithValue("@yıl", text_model.Text);
            komut.Parameters.AddWithValue("@km", text_km.Text);
            komut.Parameters.AddWithValue("@vites", text_vıtes.Text);
            komut.Parameters.AddWithValue("@renk", combo_renk.SelectedValue);
            komut.Parameters.AddWithValue("@fiyat", text_fıyat.Text);
            komut.Parameters.AddWithValue("@tarih", date_alıstarihi.Text);
            komut.Parameters.AddWithValue("@acıklama", text_acıklama.Text);
            komut.Parameters.AddWithValue("@plaka", text_plaka.Text);
            komut.CommandText = "insert into tbl_arac(a_marka,a_seri,a_kasa,a_yıl,a_km,a_vites,a_renk,a_fiyat,a_yüklemetarihi,a_acıklama,plaka) values(@marka,@seri,@kasa,@yıl,@km,@vites,@renk,@fiyat,@tarih,@acıklama,@plaka)";
            komut.Connection = baglanti;
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarı ile gerçekleşmiştir.");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Herhangi bir nedenle Kaydedilmedi. ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misin ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form1 aracc = new Form1();
                aracc.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 aracc = new Form1();
            aracc.Show();
            this.Hide();
        }

        private void araçDüzenleVeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 duzenle = new Form4();
            duzenle.Show();
            this.Hide();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
