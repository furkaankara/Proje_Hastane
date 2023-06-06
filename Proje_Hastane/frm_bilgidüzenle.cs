using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class frm_bilgidüzenle : Form
    {
        public frm_bilgidüzenle()
        {
            InitializeComponent();
        }


        public string tcno;

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frm_bilgidüzenle_Load(object sender, EventArgs e)
        {
            msktcno.Text = tcno;

            // ad çekme
            SqlCommand komut = new SqlCommand("select hastaAd from tbl_hastalar where hastaTc=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcno);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //soyad çekme

            SqlCommand komut2 = new SqlCommand("Select hastasoyad from tbl_hastalar where hastaTc=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", tcno);
            SqlDataReader dr2= komut2.ExecuteReader();
            while (dr2.Read())
            {
                txtSoyad.Text = dr2[0].ToString();  
            }
            bgl.baglanti().Close();

            //tel no çekme

            SqlCommand komut3 = new SqlCommand("select hastaTelefon from tbl_hastalar where HastAtC=@p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p3", tcno);
            SqlDataReader dr3= komut3.ExecuteReader();
            while (dr3.Read())
            {
                msktel.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();

            //şifre çekme

            SqlCommand komut4 = new SqlCommand("select hastasifre from tbl_hastalar where hastatc=@p4", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p4", tcno);
            SqlDataReader dr4=komut4.ExecuteReader();
            while (dr4.Read())
            {
                txtsifre.Text = dr4[0].ToString();  
            }   
            bgl.baglanti().Close();


            //cinsiyet çekme

            SqlCommand komut5 = new SqlCommand("select hastacinsiyet from tbl_hastalar where hastatc=@p5", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p5", tcno);
            SqlDataReader dr5= komut5.ExecuteReader();
            while (dr5.Read())
            {
                cmbxcinsiyet.Text = dr5[0].ToString();  
            }   
            bgl.baglanti().Close(); 



        }

        private void btnbilgiüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut6 = new SqlCommand("update tbl_hastalar set hastaad=@p1,hastasoyad=@p2,hastatelefon=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6",bgl.baglanti());

            komut6.Parameters.AddWithValue("@p1", txtAd.Text);
            komut6.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut6.Parameters.AddWithValue("@p3", msktel.Text);
            komut6.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut6.Parameters.AddWithValue("@p5", cmbxcinsiyet.Text);
            komut6.Parameters.AddWithValue("@p6", tcno);
            
            komut6.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

 

        }
    }
}
