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
    public partial class frm_hastagiris : Form
    {
        public frm_hastagiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hasta_kayit fr=new frm_hasta_kayit();
            fr.Show();
            
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_hastalar where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr=komut.ExecuteReader();

            if (dr.Read())
            {
                frm_hastadetay fr = new frm_hastadetay();
                fr.tc = mskTc.Text; 
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Girişi Lütfen Bilgilerinizi Kontrol ediniz ");
            }
            bgl.baglanti().Close();
        
        }
    }
}
