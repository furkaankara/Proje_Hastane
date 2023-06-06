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
    public partial class frm_sekreter_detay : Form
    {
        public frm_sekreter_detay()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frm_sekreter_detay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            //ad soyad çekme

            SqlCommand komut= new SqlCommand("select sekreteradsoyad from tbl_sekreter where sekretertc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //branş data gride aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            ///

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from doc_tbl", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            //branş getirme

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar ",bgl.baglanti());
            SqlDataReader dr2 =komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti() .Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular(randevuıd,randevutarih,randevusaat,randevubrans,randevudoktor) values(@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", txtId.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p3", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p5",cmbDoktor.Text);  

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Oluşturuldu");



                }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("select docad, docsoyad from doc_tbl where docbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader(); 
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into tbl_duyuru (duyuru) values(@p1)",bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1",rchDuyuru.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           doktor_paneli dp= new doktor_paneli();
            dp.Show();  

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Brans frm = new frm_Brans();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_RandevuLİSTESİ fr=new frm_RandevuLİSTESİ();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_duyurular fr=new frm_duyurular();   
           fr.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void rchDuyuru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
