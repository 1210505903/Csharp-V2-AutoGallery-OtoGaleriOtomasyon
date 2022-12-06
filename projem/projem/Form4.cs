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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=" + Application.StartupPath + "\\otogaleri.accdb");

        private void Form4_Load(object sender, EventArgs e)
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
            griddoldur();
        }
        private void griddoldur()
        {
            OleDbDataAdapter da;
            DataSet ds;
            DataTable dt;
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT tbl_arac.a_fiyat, tbl_arac.plaka, tbl_araclar.a_marka, tbl_arac.a_seri, tbl_kasa.kasa_tipi, tbl_arac.a_yıl, tbl_arac.a_km, tbl_arac.a_vites, tbl_renk.renk, tbl_arac.a_yüklemetarihi, tbl_arac.a_acıklama,tbl_arac.a_ID FROM tbl_arac,tbl_araclar,tbl_kasa,tbl_renk where tbl_arac.a_kasa=tbl_kasa.k_ID and tbl_araclar.a_id=tbl_arac.a_marka and tbl_arac.a_renk=tbl_renk.r_ID", baglanti);

            ds = new DataSet();
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(combo_marka.SelectedValue.ToString());
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            combo_kasa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text_seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text_plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text_model.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            text_km.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            text_vıtes.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            combo_renk.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            date_alıstarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            text_fıyat.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text_acıklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            text_ID.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update tbl_arac set a_marka='" + combo_marka.SelectedValue + "',a_seri='" + text_seri.Text + "',a_kasa='" + combo_kasa.SelectedValue + "',a_yıl='" + text_model.Text + "',a_km='" + text_km.Text + "',a_vites='" + text_vıtes.Text + "',a_renk='" + combo_renk.SelectedValue + "',a_fiyat='" + text_fıyat.Text + "',a_yüklemetarihi='" + date_alıstarihi.Text + "',a_acıklama='" + text_acıklama.Text + "',plaka='" + text_plaka.Text + "' where a_ID=" + Convert.ToInt16(text_ID.Text) + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 arac = new Form8();
            arac.Show();
            this.Hide();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 arac4 = new Form5();
            arac4.Show();
            this.Hide();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form9 arac2 = new Form9();
            arac2.Show();
            this.Hide();
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 ara3c = new Form10();
            ara3c.Show();
            this.Hide();
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
    }
}
