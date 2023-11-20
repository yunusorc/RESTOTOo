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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {
            string getir = "Select * From PersonelTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            PersonelDataGridView.DataSource = dt;
            baglan.Close();

        }
        private void PersonelHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        private void PersonelListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
            PersonelIdTBox.Clear();
            PersonelAdiTBox.Clear();
            PersonelTelNoTBox.Clear();
            PersonelMaasiTBox.Clear();
            PersonelPozisyonuTBox.Clear();
        }




        private void PersonelKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kaydet = "INSERT INTO PersonelTb (PersonelAdiSoyadi, PersonelTeli, PersonelMaasi, PersonelPosziyonu, PersonelGirisTarihi) " +
                                    "VALUES (@personeladisoyadi, @personeltei, @personelmaasi, @personelpozisyonu, @personelgiristarihi)";
                    SqlCommand komut = new SqlCommand(kaydet, baglan);
                    komut.Parameters.AddWithValue("@personeladisoyadi", PersonelAdiTBox.Text);
                    komut.Parameters.AddWithValue("@personeltei", PersonelTelNoTBox.Text);
                    komut.Parameters.AddWithValue("@personelmaasi", PersonelMaasiTBox.Text);
                    komut.Parameters.AddWithValue("@personelpozisyonu", PersonelPozisyonuTBox.Text);
                    komut.Parameters.Add("@personelgiristarihi", PersoneldateTimePicker.Value);
                    komut.ExecuteNonQuery();
                    PersonelAdiTBox.Clear();
                    PersonelTelNoTBox.Clear();
                    PersonelMaasiTBox.Clear();
                    PersonelPozisyonuTBox.Clear();
                    MessageBox.Show("Personel Kaydedildi");
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }







        private void PersonelSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM PersonelTb WHERE PersonelId = @personelid";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@personelid", PersonelIdTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Personel Silindi");
                        PersonelIdTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Personel Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void PersonelGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string guncelle = "UPDATE PersonelTb SET ";

                    if (!string.IsNullOrEmpty(PersonelAdiTBox.Text))
                        guncelle += "PersonelAdiSoyadi = @personeladisoyadi, ";

                    if (!string.IsNullOrEmpty(PersonelTelNoTBox.Text))
                        guncelle += "PersonelTeli = @personelteli, ";

                    if (!string.IsNullOrEmpty(PersonelMaasiTBox.Text))
                        guncelle += "PersonelMaasi = @personelmaasi, ";

                    if (!string.IsNullOrEmpty(PersonelPozisyonuTBox.Text))
                        guncelle += "PersonelPosziyonu = @personelpozisyonu, ";

                    if (!string.IsNullOrEmpty(PersoneldateTimePicker.Text))
                        guncelle += "PersonelGirisTarihi = @personelgiristarihi, ";

                    guncelle = guncelle.TrimEnd(',', ' ');

                    guncelle += " WHERE PersonelId = @personelid";

                    SqlCommand komut = new SqlCommand(guncelle, baglan);
                    komut.Parameters.AddWithValue("@personelid", PersonelIdTBox.Text);
                    komut.Parameters.AddWithValue("@personeladisoyadi", PersonelAdiTBox.Text);
                    komut.Parameters.AddWithValue("@personelteli", PersonelTelNoTBox.Text);
                    komut.Parameters.AddWithValue("@personelmaasi", PersonelMaasiTBox.Text);
                    komut.Parameters.AddWithValue("@personelpozisyonu", PersonelPozisyonuTBox.Text);
                    komut.Parameters.AddWithValue("@personelgiristarihi", PersoneldateTimePicker.Value);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Personel Güncellendi");
                        kayitgetir();

                        PersonelIdTBox.Clear();
                        PersonelAdiTBox.Clear();
                        PersonelTelNoTBox.Clear();
                        PersonelMaasiTBox.Clear();
                        PersonelPozisyonuTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Personel Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }







        private void PersonelAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string ara = "SELECT * FROM PersonelTb WHERE PersonelAdiSoyadi LIKE '%' + @aranacakKelime + '%'";
                    SqlCommand komut = new SqlCommand(ara, baglan);
                    komut.Parameters.AddWithValue("@aranacakKelime", PersonelAdiTBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        PersonelDataGridView.DataSource = dt;
                    }
                    else
                    {
                        PersonelDataGridView.DataSource = null;
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
