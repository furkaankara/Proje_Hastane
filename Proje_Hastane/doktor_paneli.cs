using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class doktor_paneli : Form
    {
        public doktor_paneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();


        private void doktor_paneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from doc_tbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branşları getirme
            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into doc_tbl (DocAd,DocSoyad,DocBrans,DocTc,DocSifre) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4",mskTc.Text);
            cmd.Parameters.AddWithValue("@p5",txtSifre.Text);
            
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor Bilgileri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("delete from doc_tbl where doctc=@p1 ",bgl.baglanti());
            komut6.Parameters.AddWithValue("@p1", mskTc.Text);
            komut6.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update doc_tbl set docad=@p1,docsoyad=@p2,docbrans=@p3,docsifre=@p5 where doctc=@p4 ",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBrans.Text);
            cmd.Parameters.AddWithValue("@p4", mskTc.Text);
            cmd.Parameters.AddWithValue("@p5", txtSifre.Text);

            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information );

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
