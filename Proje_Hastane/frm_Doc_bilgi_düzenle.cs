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
    public partial class frm_Doc_bilgi_düzenle : Form
    {
        public frm_Doc_bilgi_düzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tcno;

        private void frm_Doc_bilgi_düzenle_Load(object sender, EventArgs e)
        {
            msktcno.Text = tcno;


            SqlCommand sql = new SqlCommand("select * from doc_tbl where doctc=@p1", bgl.baglanti());
            sql.Parameters.AddWithValue("@p1", msktcno.Text);
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();   
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnbilgiüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update doc_tbl set docad=@p1, docsoyad=@p2,docbrans=@p3,docsifre=@p4 where doctc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktcno.Text);

            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz Güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
