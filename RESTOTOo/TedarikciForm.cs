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
    public partial class TedarikciForm : Form
    {
        public TedarikciForm()
        {
            InitializeComponent();
        }
        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {
            string getir = "Select * From TedarikciTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            TedarikciDataGridView.DataSource = dt;
            baglan.Close();

        }
        private void TedarikciHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        private void TedarikciListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
            TedarikciIdTBox.Clear();
            TedarikciAdiTBox.Clear();
            TedarikciTelTBox.Clear();
            TedarikciAdresTBox.Clear();
            TedarikciUrunKategorisiTBox.Clear();
        }




        private void TedarikciKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kaydet = "INSERT INTO TedarikciTb  (TedarikciAdiSoyadi, TedarikciTelefonu, TedarikciAdresi, UrunKategorisi) " +
                                    "VALUES (@tedarikciadisoyadi, @tedarikcitelefonu, @tedarikciadresi, @urunkategorisi)";
                    SqlCommand komut = new SqlCommand(kaydet, baglan);
                    komut.Parameters.AddWithValue("@tedarikciadisoyadi", TedarikciAdiTBox.Text);
                    komut.Parameters.AddWithValue("@tedarikcitelefonu", TedarikciTelTBox.Text);
                    komut.Parameters.AddWithValue("@tedarikciadresi", TedarikciAdresTBox.Text);
                    komut.Parameters.AddWithValue("@urunkategorisi", TedarikciUrunKategorisiTBox.Text);
                    komut.ExecuteNonQuery();
                    TedarikciAdiTBox.Clear();
                    TedarikciTelTBox.Clear();
                    TedarikciAdresTBox.Clear();
                    TedarikciUrunKategorisiTBox.Clear();
                    MessageBox.Show("Tedarikci Kaydedildi");
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void TedarikciSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM TedarikciTb WHERE TedarikciId = @tedarikciid";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@tedarikciid", TedarikciIdTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Tedarikci Silindi");
                        TedarikciIdTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tedarikci Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }






        private void TedarikciGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string guncelle = "UPDATE TedarikciTb SET ";

                    if (!string.IsNullOrEmpty(TedarikciAdiTBox.Text))
                        guncelle += "TedarikciAdiSoyadi = @tedarikciadisoyadi, ";

                    if (!string.IsNullOrEmpty(TedarikciTelTBox.Text))
                        guncelle += "TedarikciTelefonu = @tedarikcitelefonu, ";

                    if (!string.IsNullOrEmpty(TedarikciAdresTBox.Text))
                        guncelle += "TedarikciAdresi = @tedarikciadresi, ";

                    if (!string.IsNullOrEmpty(TedarikciUrunKategorisiTBox.Text))
                        guncelle += "UrunKategorisi = @urunkategorisi ";

                    guncelle = guncelle.TrimEnd(',', ' ');

                    guncelle += " WHERE TedarikciId = @tedarikciid";

                    SqlCommand komut = new SqlCommand(guncelle, baglan);
                    komut.Parameters.AddWithValue("@tedarikciid", TedarikciIdTBox.Text);
                    komut.Parameters.AddWithValue("@tedarikciadisoyadi", TedarikciAdiTBox.Text);
                    komut.Parameters.AddWithValue("@tedarikcitelefonu", TedarikciTelTBox.Text);
                    komut.Parameters.AddWithValue("@tedarikciadresi", TedarikciAdresTBox.Text);
                    komut.Parameters.AddWithValue("@urunkategorisi", TedarikciUrunKategorisiTBox.Text);

                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Tedarikçi Güncellendi");
                        kayitgetir();

                        TedarikciIdTBox.Clear();
                        TedarikciAdiTBox.Clear();
                        TedarikciTelTBox.Clear();
                        TedarikciAdresTBox.Clear();
                        TedarikciUrunKategorisiTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçi Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }





        private void TedarikciAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string ara = "SELECT * FROM TedarikciTb WHERE TedarikciAdiSoyadi LIKE '%' + @aranacakKelime + '%'";
                    SqlCommand komut = new SqlCommand(ara, baglan);
                    komut.Parameters.AddWithValue("@aranacakKelime", TedarikciAdiTBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        TedarikciDataGridView.DataSource = dt;
                    }
                    else
                    {
                        TedarikciDataGridView.DataSource = null;
                        MessageBox.Show("Personel Bulunamadı");
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
