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
    public partial class frm_hastadetay : Form
    {
        public frm_hastadetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl =new sqlbaglantisi();
        private void frm_hastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;    

            //AD SOYAD ÇEKME

            SqlCommand komut= new SqlCommand("Select HastaAd,HastaSoyad from tbl_hastalar where HastaTc=@p1 ",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", lbltc.Text);

            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //aktif randevu



            // Branşları çekme

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read()) {

                cmbbrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();


            // Doktor çekme


        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

           


            cmbdoc.Items.Clear();   
            SqlCommand komut3 = new SqlCommand("select docad,docsoyad from doc_tbl where docbrans=@p1",bgl.baglanti());

            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);

            SqlDataReader dr3= komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoc.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoc_SelectedIndexChanged(object sender, EventArgs e)
        {


            

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where RandevuBrans='"+cmbbrans.Text+"'"+"and RandevuDoktor='"+cmbdoc.Text+"' and RandevuDurum=0",bgl.baglanti());

            da.Fill(dt);
            dataGridView2.DataSource = dt; 
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_bilgidüzenle fr= new frm_bilgidüzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuıd=@p3",bgl.baglanti()); 
            komut.Parameters.Add("@p1",lbltc.Text);
            komut.Parameters.Add("@p2", richsikayet.Text);
            komut.Parameters.Add("@p3", txtİd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtİd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
