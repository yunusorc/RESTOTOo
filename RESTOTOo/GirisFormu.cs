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


namespace RESTOTOo
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
            GirisParolaTbox.UseSystemPasswordChar = true;
        }

       
        private void GirisFormu_Load(object sender, EventArgs e)
        {
            GirisKullaniciAdiTBox.Select();

        }


        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        // Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Integrated Security=True;Connect ;
        SqlConnection baglan = new SqlConnection(constring);

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = GirisKullaniciAdiTBox.Text;
            string parola = GirisParolaTbox.Text;


            if (KullaniciDogrula(kullaniciAdi, parola))
            {
                 this.Hide();
                AnaForm anaForm = new AnaForm();
                anaForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış");
                GirisKullaniciAdiTBox.Clear();
                GirisParolaTbox.Clear();
            }
        }


  


        private bool KullaniciDogrula(string kullaniciAdi, string parola)
        {
            using (SqlConnection baglan = new SqlConnection(constring))
            {
                try
                {
                    baglan.Open();
                    string sorgu = "SELECT COUNT(*) FROM KullaniciTb WHERE KullaniciAdi = @kullaniciadi AND KullaniciParola = @kullaniciparola";
                    SqlCommand komut = new SqlCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@kullaniciadi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@kullaniciparola", parola);
                    int kullaniciSayisi = (int)komut.ExecuteScalar();

                    return kullaniciSayisi > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Oluştu: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
