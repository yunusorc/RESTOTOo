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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        static string constring = @"Data Source=LAPTOP-HVN2B3FS\SQLEXPRESS;Initial Catalog=RestOto;Trusted_Connection=True;";
        SqlConnection baglan = new SqlConnection(constring);

        public void kayitgetir()
        {
            string getir = "Select * From UrunTb";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            UrunDataGridView.DataSource = dt;
            baglan.Close();
        }


        private void UrunHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }


        private void UrunListeleBtn_Click(object sender, EventArgs e)
        {
            kayitgetir();
            UrunIdTBox.Clear();
            UrunAdiTBox.Clear();
            UrunMiktariTBox.Clear();
            UrunTedarikciTBox.Clear();
            UrunTeslimAlanPersonelTBox.Clear();
            UrunAciklamaTBox.Clear();
            UrunFiyatiTBox.Clear();
            UrunKategorisiTBox.Clear();
        }



        private void UrunKaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    // Önce girdiğiniz UrunAdi'na ait bir kaydın olup olmadığını kontrol edelim
                    string kontrolSorgusu = "SELECT COUNT(*) FROM UrunTb WHERE UrunAdi = @urunadi";
                    SqlCommand kontrolKomut = new SqlCommand(kontrolSorgusu, baglan);
                    kontrolKomut.Parameters.AddWithValue("@urunadi", UrunAdiTBox.Text);
                    int kayitSayisi = (int)kontrolKomut.ExecuteScalar();

                    if (kayitSayisi > 0)
                    {
                        // Eğer UrunAdi'na ait bir kayıt bulunuyorsa, miktarı güncelleyelim ve diğer verileri üzerine yazalım
                        string guncelle = "UPDATE UrunTb SET UrunMiktari = UrunMiktari + @urunmiktari, UrunAciklamasi = @urunaciklama, " +
                                          "UrunAlisFiyati = @urunfiyati, UrunKategorisi = @urunkategorisi, TedarikciId = @tedarikciid, " +
                                          "PersonelId = @personelid WHERE UrunAdi = @urunadi";
                        SqlCommand guncelleKomut = new SqlCommand(guncelle, baglan);
                        guncelleKomut.Parameters.AddWithValue("@urunadi", UrunAdiTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@urunmiktari", UrunMiktariTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@urunaciklama", UrunAciklamaTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@urunfiyati", UrunFiyatiTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@urunkategorisi", UrunKategorisiTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@tedarikciid", UrunTedarikciTBox.Text);
                        guncelleKomut.Parameters.AddWithValue("@personelid", UrunTeslimAlanPersonelTBox.Text);
                        guncelleKomut.ExecuteNonQuery();

                        MessageBox.Show("Ürün Güncellendi");
                    }
                    else
                    {
                        // Eğer UrunAdi'na ait bir kayıt bulunmuyorsa, yeni bir kayıt ekleyelim
                        string kaydet = "INSERT INTO UrunTb (UrunAdi, UrunMiktari, UrunAciklamasi, UrunAlisFiyati, UrunKategorisi, TedarikciId, PersonelId) " +
                                        "VALUES (@urunadi, @urunmiktari, @urunaciklama, @urunfiyati, @urunkategorisi, @tedarikciid, @personelid )";
                        SqlCommand kaydetKomut = new SqlCommand(kaydet, baglan);
                        kaydetKomut.Parameters.AddWithValue("@urunadi", UrunAdiTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@urunmiktari", UrunMiktariTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@urunaciklama", UrunAciklamaTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@urunfiyati", UrunFiyatiTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@urunkategorisi", UrunKategorisiTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@tedarikciid", UrunTedarikciTBox.Text);
                        kaydetKomut.Parameters.AddWithValue("@personelid", UrunTeslimAlanPersonelTBox.Text);
                        kaydetKomut.ExecuteNonQuery();

                        MessageBox.Show("Yeni Ürün Kaydedildi");
                    }

                    // Alanları temizle ve kayıtları güncelle
                    UrunAdiTBox.Clear();
                    UrunMiktariTBox.Clear();
                    UrunAciklamaTBox.Clear();
                    UrunFiyatiTBox.Clear();
                    UrunKategorisiTBox.Clear();
                    UrunTedarikciTBox.Clear();
                    UrunTeslimAlanPersonelTBox.Clear();
                    UrunIdTBox.Clear();
                    kayitgetir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var! " + hata.Message);
            }
        }






        private void UrunSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "DELETE FROM UrunTb WHERE UrunId = @urunid";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@urunid", UrunIdTBox.Text);
                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        kayitgetir();
                        MessageBox.Show("Ürün Silindi");
                        UrunIdTBox.Clear();
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




        private void UrunGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string guncelle = "UPDATE UrunTb SET ";

                    if (!string.IsNullOrEmpty(UrunAdiTBox.Text))
                        guncelle += "UrunAdi = @urunadi, ";

                    if (!string.IsNullOrEmpty(UrunMiktariTBox.Text))
                        guncelle += "UrunMiktari = @urunmiktari, ";

                    if (!string.IsNullOrEmpty(UrunFiyatiTBox.Text))
                        guncelle += "UrunAlisFiyati = @urunalisfiyati, ";

                    if (!string.IsNullOrEmpty(UrunAciklamaTBox.Text))
                        guncelle += "UrunAciklamasi = @urunaciklamasi, ";

                    if (!string.IsNullOrEmpty(UrunKategorisiTBox.Text))
                        guncelle += "UrunKategorisi = @urunkategorisi, ";

                    guncelle = guncelle.TrimEnd(',', ' ');

                    guncelle += " WHERE UrunId = @urunid";

                    SqlCommand komut = new SqlCommand(guncelle, baglan);
                    komut.Parameters.AddWithValue("@urunid", UrunIdTBox.Text);
                    komut.Parameters.AddWithValue("@urunadi", UrunAdiTBox.Text);
                    komut.Parameters.AddWithValue("@urunmiktari", UrunMiktariTBox.Text);
                    komut.Parameters.AddWithValue("@urunalisfiyati", UrunFiyatiTBox.Text);
                    komut.Parameters.AddWithValue("@urunaciklamasi", UrunAciklamaTBox.Text);
                    komut.Parameters.AddWithValue("@urunkategorisi", UrunKategorisiTBox.Text);

                    int etkilenenSatir = komut.ExecuteNonQuery();

                    if (etkilenenSatir > 0)
                    {
                        MessageBox.Show("Ürün Güncellendi");
                        kayitgetir();

                        UrunIdTBox.Clear();
                        UrunAdiTBox.Clear();
                        UrunMiktariTBox.Clear();
                        UrunTedarikciTBox.Clear();
                        UrunTeslimAlanPersonelTBox.Clear();
                        UrunAciklamaTBox.Clear();
                        UrunFiyatiTBox.Clear();
                        UrunKategorisiTBox.Clear();
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




        private void UrunAraBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string ara = "SELECT * FROM UrunTb WHERE UrunAdi LIKE '%' + @aranacakKelime + '%'";
                    SqlCommand komut = new SqlCommand(ara, baglan);
                    komut.Parameters.AddWithValue("@aranacakKelime", UrunAdiTBox.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        UrunDataGridView.DataSource = dt;
                    }
                    else
                    {
                        UrunDataGridView.DataSource = null;
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


