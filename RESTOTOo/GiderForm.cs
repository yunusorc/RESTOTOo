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
    public partial class GiderForm : Form
    {
        public GiderForm()
        {
            InitializeComponent();
        }

        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {
            string getir = "Select * From GiderTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GiderDataGridView.DataSource = dt;
            baglan.Close();

        }
        private void GiderHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        private void GiderListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
            GiderIdTBox.Clear();
            GiderMiktarTBox.Clear();
            GiderAciklamaTBox.Clear();
        }




        private void GiderKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kaydet = "INSERT INTO GiderTb (GiderMiktari, GiderTarihi, GiderAciklamasi) " +
                                    "VALUES (@gidermiktari, @gidertarihi, @gideraciklamasi)";
                    SqlCommand komut = new SqlCommand(kaydet, baglan);
                    komut.Parameters.AddWithValue("@gidermiktari", GiderMiktarTBox.Text);
                    komut.Parameters.AddWithValue("@gidertarihi", GiderdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@gideraciklamasi", GiderAciklamaTBox.Text);
                    komut.ExecuteNonQuery();
                    GiderMiktarTBox.Clear();
                    GiderIdTBox.Clear();
                    GiderAciklamaTBox.Clear();
                    MessageBox.Show("Gider Kaydedildi");
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void GiderSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM GiderTb WHERE GiderId = @giderid";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@giderid", GiderIdTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Gider Silindi");
                        GiderIdTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gider Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void GiderGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string guncelle = "UPDATE GiderTb SET ";

                    if (!string.IsNullOrEmpty(GiderMiktarTBox.Text))
                        guncelle += "GiderMiktari = @gidermiktari, ";

                    if (!string.IsNullOrEmpty(GiderdateTimePicker.Text))
                        guncelle += "GiderTarihi = @gidertarihi, ";

                    if (!string.IsNullOrEmpty(GiderAciklamaTBox.Text))
                        guncelle += "GiderAciklamasi = @gideraciklamasi, ";

                    guncelle = guncelle.TrimEnd(',', ' ');

                    guncelle += " WHERE GiderId = @giderid";

                    SqlCommand komut = new SqlCommand(guncelle, baglan);
                    komut.Parameters.AddWithValue("@giderid", GiderIdTBox.Text);
                    komut.Parameters.AddWithValue("@gidermiktari", GiderMiktarTBox.Text);
                    komut.Parameters.AddWithValue("@gidertarihi", GiderdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@gideraciklamasi", GiderAciklamaTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Gider Güncellendi");
                        kayitgetir();

                        GiderIdTBox.Clear();
                        GiderMiktarTBox.Clear();
                        GiderAciklamaTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gider Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void GiderAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string ara = "SELECT * FROM GiderTb WHERE GiderMiktari LIKE '%' + @aranacakKelime + '%'";
                    SqlCommand komut = new SqlCommand(ara, baglan);
                    komut.Parameters.AddWithValue("@aranacakKelime", GiderMiktarTBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GiderDataGridView.DataSource = dt;
                    }
                    else
                    {
                        GiderDataGridView.DataSource = null;
                        MessageBox.Show("Gider Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }

        private void GiderHesaplaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    // Gelirlerin toplamını hesapla
                    string gelirSorgusu = "SELECT SUM(GelirMiktari) FROM GelirTb";
                    SqlCommand gelirKomut = new SqlCommand(gelirSorgusu, baglan);
                    decimal toplamGelir = (decimal)gelirKomut.ExecuteScalar();

                    // Giderlerin toplamını hesapla
                    string giderSorgusu = "SELECT SUM(GiderMiktari) FROM GiderTb";
                    SqlCommand giderKomut = new SqlCommand(giderSorgusu, baglan);
                    decimal toplamGider = (decimal)giderKomut.ExecuteScalar();

                    // Hesapla ve sonucu metin kutusuna yaz
                    decimal netGelir = toplamGelir - toplamGider;
                    GiderHesaplaTBox.Text = netGelir.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }
    }
}
