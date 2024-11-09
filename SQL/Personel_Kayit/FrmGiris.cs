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

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ALGUS\\SQLEXPRESS;Initial Catalog=PersonelDeneme;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgiris = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAd=@p1 and Sifre=@p2",baglanti);
            komutgiris.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komutgiris.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader kmtgrs = komutgiris.ExecuteReader();
            if(kmtgrs.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı.");
            }
            baglanti.Close();
        }
    }
}
