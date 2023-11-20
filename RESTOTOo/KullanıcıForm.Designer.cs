
namespace RESTOTOo
{
    partial class KullanıcıForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıForm));
            this.KullaniciKullaniciAdiLbl = new System.Windows.Forms.Label();
            this.KullaniciParolaLbl = new System.Windows.Forms.Label();
            this.KullaniciKullaniciAdiTBox = new System.Windows.Forms.TextBox();
            this.KullaniciParolaTBox = new System.Windows.Forms.TextBox();
            this.KullaniciDataGridView = new System.Windows.Forms.DataGridView();
            this.KullaniciKaydetBtn = new System.Windows.Forms.Button();
            this.KullaniciSilBtn = new System.Windows.Forms.Button();
            this.KullaniciListeleBtn = new System.Windows.Forms.Button();
            this.UrunHomeBtn = new System.Windows.Forms.Button();
            this.ımageListStok = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciKullaniciAdiLbl
            // 
            this.KullaniciKullaniciAdiLbl.AutoSize = true;
            this.KullaniciKullaniciAdiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.KullaniciKullaniciAdiLbl.ForeColor = System.Drawing.Color.White;
            this.KullaniciKullaniciAdiLbl.Location = new System.Drawing.Point(23, 37);
            this.KullaniciKullaniciAdiLbl.Name = "KullaniciKullaniciAdiLbl";
            this.KullaniciKullaniciAdiLbl.Size = new System.Drawing.Size(110, 19);
            this.KullaniciKullaniciAdiLbl.TabIndex = 22;
            this.KullaniciKullaniciAdiLbl.Text = "Kullanıcı Adı:";
            // 
            // KullaniciParolaLbl
            // 
            this.KullaniciParolaLbl.AutoSize = true;
            this.KullaniciParolaLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.KullaniciParolaLbl.ForeColor = System.Drawing.Color.White;
            this.KullaniciParolaLbl.Location = new System.Drawing.Point(68, 80);
            this.KullaniciParolaLbl.Name = "KullaniciParolaLbl";
            this.KullaniciParolaLbl.Size = new System.Drawing.Size(65, 19);
            this.KullaniciParolaLbl.TabIndex = 23;
            this.KullaniciParolaLbl.Text = "Parola:";
            // 
            // KullaniciKullaniciAdiTBox
            // 
            this.KullaniciKullaniciAdiTBox.Location = new System.Drawing.Point(153, 36);
            this.KullaniciKullaniciAdiTBox.Name = "KullaniciKullaniciAdiTBox";
            this.KullaniciKullaniciAdiTBox.Size = new System.Drawing.Size(288, 22);
            this.KullaniciKullaniciAdiTBox.TabIndex = 24;
            // 
            // KullaniciParolaTBox
            // 
            this.KullaniciParolaTBox.Location = new System.Drawing.Point(153, 77);
            this.KullaniciParolaTBox.Name = "KullaniciParolaTBox";
            this.KullaniciParolaTBox.Size = new System.Drawing.Size(288, 22);
            this.KullaniciParolaTBox.TabIndex = 25;
            // 
            // KullaniciDataGridView
            // 
            this.KullaniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KullaniciDataGridView.Location = new System.Drawing.Point(27, 195);
            this.KullaniciDataGridView.Name = "KullaniciDataGridView";
            this.KullaniciDataGridView.RowHeadersWidth = 51;
            this.KullaniciDataGridView.RowTemplate.Height = 24;
            this.KullaniciDataGridView.Size = new System.Drawing.Size(522, 222);
            this.KullaniciDataGridView.TabIndex = 32;
            // 
            // KullaniciKaydetBtn
            // 
            this.KullaniciKaydetBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.KullaniciKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciKaydetBtn.Image")));
            this.KullaniciKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KullaniciKaydetBtn.Location = new System.Drawing.Point(27, 116);
            this.KullaniciKaydetBtn.Name = "KullaniciKaydetBtn";
            this.KullaniciKaydetBtn.Size = new System.Drawing.Size(170, 60);
            this.KullaniciKaydetBtn.TabIndex = 37;
            this.KullaniciKaydetBtn.Text = "KAYDET";
            this.KullaniciKaydetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KullaniciKaydetBtn.UseVisualStyleBackColor = true;
            this.KullaniciKaydetBtn.Click += new System.EventHandler(this.KullaniciKaydetBtn_Click);
            // 
            // KullaniciSilBtn
            // 
            this.KullaniciSilBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.KullaniciSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciSilBtn.Image")));
            this.KullaniciSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KullaniciSilBtn.Location = new System.Drawing.Point(203, 116);
            this.KullaniciSilBtn.Name = "KullaniciSilBtn";
            this.KullaniciSilBtn.Size = new System.Drawing.Size(173, 60);
            this.KullaniciSilBtn.TabIndex = 38;
            this.KullaniciSilBtn.Text = "    SİL";
            this.KullaniciSilBtn.UseVisualStyleBackColor = true;
            this.KullaniciSilBtn.Click += new System.EventHandler(this.KullaniciSilBtn_Click);
            // 
            // KullaniciListeleBtn
            // 
            this.KullaniciListeleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.KullaniciListeleBtn.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciListeleBtn.Image")));
            this.KullaniciListeleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KullaniciListeleBtn.Location = new System.Drawing.Point(382, 116);
            this.KullaniciListeleBtn.Name = "KullaniciListeleBtn";
            this.KullaniciListeleBtn.Size = new System.Drawing.Size(170, 60);
            this.KullaniciListeleBtn.TabIndex = 41;
            this.KullaniciListeleBtn.Text = "LİSTELE";
            this.KullaniciListeleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KullaniciListeleBtn.UseVisualStyleBackColor = true;
            this.KullaniciListeleBtn.Click += new System.EventHandler(this.KullaniciListeleBtn_Click);
            // 
            // UrunHomeBtn
            // 
            this.UrunHomeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrunHomeBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunHomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UrunHomeBtn.ImageIndex = 0;
            this.UrunHomeBtn.ImageList = this.ımageListStok;
            this.UrunHomeBtn.Location = new System.Drawing.Point(452, 12);
            this.UrunHomeBtn.Name = "UrunHomeBtn";
            this.UrunHomeBtn.Size = new System.Drawing.Size(100, 90);
            this.UrunHomeBtn.TabIndex = 42;
            this.UrunHomeBtn.Text = "ANA SAYFA";
            this.UrunHomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UrunHomeBtn.UseVisualStyleBackColor = false;
            this.UrunHomeBtn.Click += new System.EventHandler(this.UrunHomeBtn_Click);
            // 
            // ımageListStok
            // 
            this.ımageListStok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListStok.ImageStream")));
            this.ımageListStok.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListStok.Images.SetKeyName(0, "home.png");
            // 
            // KullanıcıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(594, 487);
            this.ControlBox = false;
            this.Controls.Add(this.UrunHomeBtn);
            this.Controls.Add(this.KullaniciListeleBtn);
            this.Controls.Add(this.KullaniciSilBtn);
            this.Controls.Add(this.KullaniciKaydetBtn);
            this.Controls.Add(this.KullaniciDataGridView);
            this.Controls.Add(this.KullaniciParolaTBox);
            this.Controls.Add(this.KullaniciKullaniciAdiTBox);
            this.Controls.Add(this.KullaniciParolaLbl);
            this.Controls.Add(this.KullaniciKullaniciAdiLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KullanıcıForm";
            this.Text = "KULLANICI";
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KullaniciKullaniciAdiLbl;
        private System.Windows.Forms.Label KullaniciParolaLbl;
        private System.Windows.Forms.TextBox KullaniciKullaniciAdiTBox;
        private System.Windows.Forms.TextBox KullaniciParolaTBox;
        private System.Windows.Forms.DataGridView KullaniciDataGridView;
        private System.Windows.Forms.Button KullaniciKaydetBtn;
        private System.Windows.Forms.Button KullaniciSilBtn;
        private System.Windows.Forms.Button KullaniciListeleBtn;
        private System.Windows.Forms.Button UrunHomeBtn;
        private System.Windows.Forms.ImageList ımageListStok;
    }
}