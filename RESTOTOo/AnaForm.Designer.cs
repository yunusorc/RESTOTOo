namespace RESTOTOo
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.GelirBtn = new System.Windows.Forms.Button();
            this.ımageListAnaSayfa = new System.Windows.Forms.ImageList(this.components);
            this.GiderBtn = new System.Windows.Forms.Button();
            this.PersonelBtn = new System.Windows.Forms.Button();
            this.TedarikciBtn = new System.Windows.Forms.Button();
            this.UrunBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.KullaniciBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GirisRestOtoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GelirBtn
            // 
            this.GelirBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GelirBtn.ImageIndex = 0;
            this.GelirBtn.ImageList = this.ımageListAnaSayfa;
            this.GelirBtn.Location = new System.Drawing.Point(36, 173);
            this.GelirBtn.Name = "GelirBtn";
            this.GelirBtn.Size = new System.Drawing.Size(200, 200);
            this.GelirBtn.TabIndex = 0;
            this.GelirBtn.Text = "GELİR";
            this.GelirBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GelirBtn.UseVisualStyleBackColor = true;
            this.GelirBtn.Click += new System.EventHandler(this.GelirBtn_Click);
            // 
            // ımageListAnaSayfa
            // 
            this.ımageListAnaSayfa.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListAnaSayfa.ImageStream")));
            this.ımageListAnaSayfa.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListAnaSayfa.Images.SetKeyName(0, "gelir.png");
            this.ımageListAnaSayfa.Images.SetKeyName(1, "gider.png");
            this.ımageListAnaSayfa.Images.SetKeyName(2, "personel.png");
            this.ımageListAnaSayfa.Images.SetKeyName(3, "stok.png");
            this.ımageListAnaSayfa.Images.SetKeyName(4, "tedarikci.png");
            this.ımageListAnaSayfa.Images.SetKeyName(5, "power.png");
            this.ımageListAnaSayfa.Images.SetKeyName(6, "users.png");
            this.ımageListAnaSayfa.Images.SetKeyName(7, "ayarlar.png");
            // 
            // GiderBtn
            // 
            this.GiderBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GiderBtn.ImageIndex = 1;
            this.GiderBtn.ImageList = this.ımageListAnaSayfa;
            this.GiderBtn.Location = new System.Drawing.Point(252, 173);
            this.GiderBtn.Name = "GiderBtn";
            this.GiderBtn.Size = new System.Drawing.Size(200, 200);
            this.GiderBtn.TabIndex = 1;
            this.GiderBtn.Text = "GİDER";
            this.GiderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GiderBtn.UseVisualStyleBackColor = true;
            this.GiderBtn.Click += new System.EventHandler(this.GiderBtn_Click);
            // 
            // PersonelBtn
            // 
            this.PersonelBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PersonelBtn.ImageIndex = 2;
            this.PersonelBtn.ImageList = this.ımageListAnaSayfa;
            this.PersonelBtn.Location = new System.Drawing.Point(252, 392);
            this.PersonelBtn.Name = "PersonelBtn";
            this.PersonelBtn.Size = new System.Drawing.Size(200, 200);
            this.PersonelBtn.TabIndex = 2;
            this.PersonelBtn.Text = "PERSONEL";
            this.PersonelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PersonelBtn.UseVisualStyleBackColor = true;
            this.PersonelBtn.Click += new System.EventHandler(this.PersonelBtn_Click);
            // 
            // TedarikciBtn
            // 
            this.TedarikciBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.TedarikciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TedarikciBtn.ImageIndex = 4;
            this.TedarikciBtn.ImageList = this.ımageListAnaSayfa;
            this.TedarikciBtn.Location = new System.Drawing.Point(36, 392);
            this.TedarikciBtn.Name = "TedarikciBtn";
            this.TedarikciBtn.Size = new System.Drawing.Size(200, 200);
            this.TedarikciBtn.TabIndex = 3;
            this.TedarikciBtn.Text = "TEDARİKCİ";
            this.TedarikciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TedarikciBtn.UseVisualStyleBackColor = true;
            this.TedarikciBtn.Click += new System.EventHandler(this.TedarikciBtn_Click);
            // 
            // UrunBtn
            // 
            this.UrunBtn.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UrunBtn.ImageIndex = 3;
            this.UrunBtn.ImageList = this.ımageListAnaSayfa;
            this.UrunBtn.Location = new System.Drawing.Point(472, 173);
            this.UrunBtn.Name = "UrunBtn";
            this.UrunBtn.Size = new System.Drawing.Size(200, 200);
            this.UrunBtn.TabIndex = 4;
            this.UrunBtn.Text = "ÜRÜN/STOK";
            this.UrunBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UrunBtn.UseVisualStyleBackColor = true;
            this.UrunBtn.Click += new System.EventHandler(this.UrunBtn_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold);
            this.CikisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CikisBtn.ImageIndex = 5;
            this.CikisBtn.ImageList = this.ımageListAnaSayfa;
            this.CikisBtn.Location = new System.Drawing.Point(252, 610);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(200, 200);
            this.CikisBtn.TabIndex = 5;
            this.CikisBtn.Text = "ÇIKIŞ";
            this.CikisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CikisBtn.UseVisualStyleBackColor = true;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // KullaniciBtn
            // 
            this.KullaniciBtn.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KullaniciBtn.ImageIndex = 6;
            this.KullaniciBtn.ImageList = this.ımageListAnaSayfa;
            this.KullaniciBtn.Location = new System.Drawing.Point(472, 392);
            this.KullaniciBtn.Name = "KullaniciBtn";
            this.KullaniciBtn.Size = new System.Drawing.Size(200, 200);
            this.KullaniciBtn.TabIndex = 6;
            this.KullaniciBtn.Text = "KULLANICI";
            this.KullaniciBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KullaniciBtn.UseVisualStyleBackColor = true;
            this.KullaniciBtn.Click += new System.EventHandler(this.KullaniciBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 53;
            this.label1.Text = "İŞLETME SİSTEMİ";
            // 
            // GirisRestOtoLbl
            // 
            this.GirisRestOtoLbl.AutoSize = true;
            this.GirisRestOtoLbl.Font = new System.Drawing.Font("Arial", 93F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisRestOtoLbl.ForeColor = System.Drawing.Color.White;
            this.GirisRestOtoLbl.Location = new System.Drawing.Point(-4, -23);
            this.GirisRestOtoLbl.Name = "GirisRestOtoLbl";
            this.GirisRestOtoLbl.Size = new System.Drawing.Size(679, 177);
            this.GirisRestOtoLbl.TabIndex = 52;
            this.GirisRestOtoLbl.Text = "RestOto";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(719, 867);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisRestOtoLbl);
            this.Controls.Add(this.KullaniciBtn);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.UrunBtn);
            this.Controls.Add(this.TedarikciBtn);
            this.Controls.Add(this.PersonelBtn);
            this.Controls.Add(this.GiderBtn);
            this.Controls.Add(this.GelirBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "RestOto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GelirBtn;
        private System.Windows.Forms.ImageList ımageListAnaSayfa;
        private System.Windows.Forms.Button GiderBtn;
        private System.Windows.Forms.Button PersonelBtn;
        private System.Windows.Forms.Button TedarikciBtn;
        private System.Windows.Forms.Button UrunBtn;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Button KullaniciBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GirisRestOtoLbl;
    }
}

