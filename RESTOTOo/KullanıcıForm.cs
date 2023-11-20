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
    public partial class KullanıcıForm : Form
    {
        public KullanıcıForm()
        {
            InitializeComponent();
        }
        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);


        public void kayitgetir()
        {
            string getir = "Select * From KullaniciTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            KullaniciDataGridView.DataSource = dt;
            baglan.Close();
        }

        private void UrunHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        private void KullaniciListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }



        private void KullaniciKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kaydet = "INSERT INTO KullaniciTb (KullaniciAdi, KullaniciParola) " +
                "VALUES (@kullaniciadi, @kullaniciparola)";

                    SqlCommand komut = new SqlCommand(kaydet, baglan);
                    komut.Parameters.AddWithValue("@kullaniciadi", KullaniciKullaniciAdiTBox.Text);
                    komut.Parameters.AddWithValue("@kullaniciparola", KullaniciParolaTBox.Text);
                    komut.ExecuteNonQuery();
                    KullaniciKullaniciAdiTBox.Clear();
                    KullaniciParolaTBox.Clear();
                    MessageBox.Show("Kullanıcı Kaydedildi");
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }






        private void KullaniciSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM KullaniciTb WHERE KullaniciAdi = @kullaniciadi";

                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@kullaniciadi", KullaniciKullaniciAdiTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Ürün Silindi");
                        KullaniciKullaniciAdiTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ürün Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




    }
}
