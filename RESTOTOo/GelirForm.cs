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
    public partial class GelirForm : Form
    {
        public GelirForm()
        {
            InitializeComponent();
        }

        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {
            string getir = "Select * From GelirTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            GelirDataGridView.DataSource = dt;
            baglan.Close();
        }


        private void GiderHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        private void GelirListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
            GelirIdTBox.Clear();
            GelirMiktarTBox.Clear();
            GelirAciklamaTBox.Clear();
        }




        private void GelirKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kaydet = "INSERT INTO GelirTb (GelirMiktari, GelirTarihi, GelirAciklamasi) " +
                                    "VALUES (@gelirmiktari, @gelirtarihi, @geliraciklamasi)";
                    SqlCommand komut = new SqlCommand(kaydet, baglan);
                    komut.Parameters.AddWithValue("@gelirmiktari", GelirMiktarTBox.Text);
                    komut.Parameters.AddWithValue("@gelirtarihi", GelirdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@geliraciklamasi", GelirAciklamaTBox.Text);
                    komut.ExecuteNonQuery();
                    GelirMiktarTBox.Clear();
                    GelirAciklamaTBox.Clear();
                    GelirIdTBox.Clear();
                    MessageBox.Show("Gelir Kaydedildi");
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }





        private void GelirSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM GelirTb WHERE GelirId = @gelirid";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@gelirid", GelirIdTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Gelir Silindi");
                        GelirIdTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gelir Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }




        private void GelirGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string guncelle = "UPDATE GelirTb SET ";

                    if (!string.IsNullOrEmpty(GelirMiktarTBox.Text))
                        guncelle += "GelirMiktari = @gelirmiktari, ";

                    if (!string.IsNullOrEmpty(GelirdateTimePicker.Text))
                        guncelle += "GelirTarihi = @gelirtarihi, ";

                    if (!string.IsNullOrEmpty(GelirAciklamaTBox.Text))
                        guncelle += "GelirAciklamasi = @geliraciklamasi, ";

                    guncelle = guncelle.TrimEnd(',', ' ');

                    guncelle += " WHERE GelirId = @gelirid";

                    SqlCommand komut = new SqlCommand(guncelle, baglan);
                    komut.Parameters.AddWithValue("@gelirid", GelirIdTBox.Text);
                    komut.Parameters.AddWithValue("@gelirmiktari", GelirMiktarTBox.Text);
                    komut.Parameters.AddWithValue("@gelirtarihi", GelirdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@geliraciklamasi", GelirAciklamaTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Gelir Güncellendi");
                        kayitgetir();

                        GelirIdTBox.Clear();
                        GelirMiktarTBox.Clear();
                        GelirAciklamaTBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gelir Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }





        private void GelirAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string ara = "SELECT * FROM GelirTb WHERE GelirMiktari LIKE '%' + @aranacakKelime + '%'";
                    SqlCommand komut = new SqlCommand(ara, baglan);
                    komut.Parameters.AddWithValue("@aranacakKelime", GelirMiktarTBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GelirDataGridView.DataSource = dt;
                    }
                    else
                    {
                        GelirDataGridView.DataSource = null;
                        MessageBox.Show("Gelir Bulunamadı");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }

        private void GelirHesaplaBtn_Click(object sender, EventArgs e)
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
                    GelirHesaplaTBox.Text = netGelir.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }


        }

       
    }
}
