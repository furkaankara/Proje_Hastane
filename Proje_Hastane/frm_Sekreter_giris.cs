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
    public partial class frm_Sekreter_giris : Form
    {
        public frm_Sekreter_giris()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtSifre.Text);
            
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                frm_sekreter_detay frs = new frm_sekreter_detay() ;
                frs.tc = mskTc.Text;
                frs.Show();
                this.Hide();    

            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalıdır Lütfen Bilgilerinizi Kontrol Ediniz ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frm_Sekreter_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
