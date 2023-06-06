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
    public partial class frm_doc_giris : Form
    {
        public frm_doc_giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select * from doc_tbl where doctc=@p1 and docsifre=@p2  ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr =komut.ExecuteReader();
            if (dr.Read())
            {
                frm_doc_detay fr= new frm_doc_detay();
                fr.tc = mskTc.Text;
                fr.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Hatalı T.C veya Şifre lütfen bilgilerinizi kontrol ediniz ","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
