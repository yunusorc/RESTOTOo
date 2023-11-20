using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTOTOo
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
     
        private void GelirBtn_Click(object sender, EventArgs e)
        {
            GelirForm gelirForm = new GelirForm();
            gelirForm.Show();
            this.Hide();
        }

        private void GiderBtn_Click(object sender, EventArgs e)
        {
            GiderForm GiderForm = new GiderForm();
            GiderForm.Show();
            this.Hide();
        }

        private void UrunBtn_Click(object sender, EventArgs e)
        {
            UrunForm urunForm = new UrunForm();
            urunForm.Show();
            this.Hide();
        }

        private void TedarikciBtn_Click(object sender, EventArgs e)
        {
            TedarikciForm tedarikciForm = new TedarikciForm();
            tedarikciForm.Show();
            this.Hide();
        }

        private void PersonelBtn_Click(object sender, EventArgs e)
        {
            PersonelForm PersonelForm = new PersonelForm();
            PersonelForm.Show();
            this.Hide();
        }

        private void KullaniciBtn_Click(object sender, EventArgs e)
        {
            KullanıcıForm kullaniciForm = new KullanıcıForm();
            kullaniciForm.Show();
            this.Hide();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sistemden çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }
}
