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
    public partial class frm_doc_detay : Form
    {
        public frm_doc_detay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            frm_duyurular fr= new frm_duyurular();
            fr.Show();
        }
        public string tc;
        sqlbaglantisi bgl= new sqlbaglantisi();

        
        private void frm_doc_detay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;    


            //ad soyad çekme

            SqlCommand komut= new SqlCommand("select docad, docsoyad from doc_tbl where doctc=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString()+" " + dr[1].ToString();
            }
            bgl.baglanti().Close();



            //randevular/
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevudoktor='"+lblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frm_Doc_bilgi_düzenle fr = new frm_Doc_bilgi_düzenle();
            fr.tcno=lblTc.Text;
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            
        }
    }
}
