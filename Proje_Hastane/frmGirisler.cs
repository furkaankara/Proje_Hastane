using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
        }

        private void btnHastaGiriş_Click(object sender, EventArgs e)
        {
            frm_hastagiris fr =new frm_hastagiris();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGiriş_Click(object sender, EventArgs e)
        {
            frm_doc_giris fr=new frm_doc_giris();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGiriş_Click(object sender, EventArgs e)
        {
            frm_Sekreter_giris fr= new frm_Sekreter_giris();
            fr.Show();
            this.Hide();
        }

        private void frmGirisler_Load(object sender, EventArgs e)
        {

        }
    }
}
