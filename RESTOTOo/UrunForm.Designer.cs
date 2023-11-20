
namespace RESTOTOo
{
    partial class UrunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunForm));
            this.ımageListStok = new System.Windows.Forms.ImageList(this.components);
            this.UrunHomeBtn = new System.Windows.Forms.Button();
            this.UrunKategorisiTBox = new System.Windows.Forms.TextBox();
            this.UrunFiyatiTBox = new System.Windows.Forms.TextBox();
            this.UrunAdiTBox = new System.Windows.Forms.TextBox();
            this.UrunMiktariLbl = new System.Windows.Forms.Label();
            this.UrunAdiLbl = new System.Windows.Forms.Label();
            this.UrunMiktariTBox = new System.Windows.Forms.TextBox();
            this.UrunAciklamaLbl = new System.Windows.Forms.Label();
            this.UrunDataGridView = new System.Windows.Forms.DataGridView();
            this.UrunListeleBtn = new System.Windows.Forms.Button();
            this.UrunAraBtn = new System.Windows.Forms.Button();
            this.UrunGuncelleBtn = new System.Windows.Forms.Button();
            this.UrunSilBtn = new System.Windows.Forms.Button();
            this.UrunKaydetBtn = new System.Windows.Forms.Button();
            this.UrunTedarikciTBox = new System.Windows.Forms.TextBox();
            this.UrunTeslimAlanPersonelTBox = new System.Windows.Forms.TextBox();
            this.UrunTedarikciLbl = new System.Windows.Forms.Label();
            this.UrunAlisFiyatiLbl = new System.Windows.Forms.Label();
            this.UrunKategorisiLbl = new System.Windows.Forms.Label();
            this.UrunAciklamaTBox = new System.Windows.Forms.TextBox();
            this.UrunTeslimAlanPersonelLbl = new System.Windows.Forms.Label();
            this.UrunIdLbl = new System.Windows.Forms.Label();
            this.UrunIdTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageListStok
            // 
            this.ımageListStok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListStok.ImageStream")));
            this.ımageListStok.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListStok.Images.SetKeyName(0, "home.png");
            // 
            // UrunHomeBtn
            // 
            this.UrunHomeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UrunHomeBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunHomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UrunHomeBtn.ImageIndex = 0;
            this.UrunHomeBtn.ImageList = this.ımageListStok;
            this.UrunHomeBtn.Location = new System.Drawing.Point(1000, 10);
            this.UrunHomeBtn.Name = "UrunHomeBtn";
            this.UrunHomeBtn.Size = new System.Drawing.Size(100, 90);
            this.UrunHomeBtn.TabIndex = 2;
            this.UrunHomeBtn.Text = "ANA SAYFA";
            this.UrunHomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UrunHomeBtn.UseVisualStyleBackColor = false;
            this.UrunHomeBtn.Click += new System.EventHandler(this.UrunHomeBtn_Click);
            // 
            // UrunKategorisiTBox
            // 
            this.UrunKategorisiTBox.Location = new System.Drawing.Point(645, 52);
            this.UrunKategorisiTBox.Name = "UrunKategorisiTBox";
            this.UrunKategorisiTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunKategorisiTBox.TabIndex = 27;
            // 
            // UrunFiyatiTBox
            // 
            this.UrunFiyatiTBox.Location = new System.Drawing.Point(645, 18);
            this.UrunFiyatiTBox.Name = "UrunFiyatiTBox";
            this.UrunFiyatiTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunFiyatiTBox.TabIndex = 24;
            // 
            // UrunAdiTBox
            // 
            this.UrunAdiTBox.Location = new System.Drawing.Point(148, 18);
            this.UrunAdiTBox.Name = "UrunAdiTBox";
            this.UrunAdiTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunAdiTBox.TabIndex = 23;
            // 
            // UrunMiktariLbl
            // 
            this.UrunMiktariLbl.AutoSize = true;
            this.UrunMiktariLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.UrunMiktariLbl.ForeColor = System.Drawing.Color.White;
            this.UrunMiktariLbl.Location = new System.Drawing.Point(16, 56);
            this.UrunMiktariLbl.Name = "UrunMiktariLbl";
            this.UrunMiktariLbl.Size = new System.Drawing.Size(111, 19);
            this.UrunMiktariLbl.TabIndex = 21;
            this.UrunMiktariLbl.Text = "Ürün Miktarı:";
            // 
            // UrunAdiLbl
            // 
            this.UrunAdiLbl.AutoSize = true;
            this.UrunAdiLbl.BackColor = System.Drawing.Color.Transparent;
            this.UrunAdiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunAdiLbl.ForeColor = System.Drawing.Color.White;
            this.UrunAdiLbl.Location = new System.Drawing.Point(44, 21);
            this.UrunAdiLbl.Name = "UrunAdiLbl";
            this.UrunAdiLbl.Size = new System.Drawing.Size(83, 19);
            this.UrunAdiLbl.TabIndex = 20;
            this.UrunAdiLbl.Text = "Ürün Adı:";
            // 
            // UrunMiktariTBox
            // 
            this.UrunMiktariTBox.Location = new System.Drawing.Point(148, 51);
            this.UrunMiktariTBox.Name = "UrunMiktariTBox";
            this.UrunMiktariTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunMiktariTBox.TabIndex = 28;
            // 
            // UrunAciklamaLbl
            // 
            this.UrunAciklamaLbl.AutoSize = true;
            this.UrunAciklamaLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.UrunAciklamaLbl.ForeColor = System.Drawing.Color.White;
            this.UrunAciklamaLbl.Location = new System.Drawing.Point(43, 89);
            this.UrunAciklamaLbl.Name = "UrunAciklamaLbl";
            this.UrunAciklamaLbl.Size = new System.Drawing.Size(84, 19);
            this.UrunAciklamaLbl.TabIndex = 29;
            this.UrunAciklamaLbl.Text = "Açıklama:";
            // 
            // UrunDataGridView
            // 
            this.UrunDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunDataGridView.Location = new System.Drawing.Point(12, 242);
            this.UrunDataGridView.Name = "UrunDataGridView";
            this.UrunDataGridView.RowHeadersWidth = 51;
            this.UrunDataGridView.RowTemplate.Height = 24;
            this.UrunDataGridView.Size = new System.Drawing.Size(1088, 299);
            this.UrunDataGridView.TabIndex = 31;
            // 
            // UrunListeleBtn
            // 
            this.UrunListeleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.UrunListeleBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunListeleBtn.Image")));
            this.UrunListeleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunListeleBtn.Location = new System.Drawing.Point(887, 176);
            this.UrunListeleBtn.Name = "UrunListeleBtn";
            this.UrunListeleBtn.Size = new System.Drawing.Size(213, 60);
            this.UrunListeleBtn.TabIndex = 40;
            this.UrunListeleBtn.Text = "LİSTELE";
            this.UrunListeleBtn.UseVisualStyleBackColor = true;
            this.UrunListeleBtn.Click += new System.EventHandler(this.UrunListeleBtn_Click);
            // 
            // UrunAraBtn
            // 
            this.UrunAraBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.UrunAraBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunAraBtn.Image")));
            this.UrunAraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunAraBtn.Location = new System.Drawing.Point(668, 176);
            this.UrunAraBtn.Name = "UrunAraBtn";
            this.UrunAraBtn.Size = new System.Drawing.Size(213, 60);
            this.UrunAraBtn.TabIndex = 39;
            this.UrunAraBtn.Text = "ARA";
            this.UrunAraBtn.UseVisualStyleBackColor = true;
            this.UrunAraBtn.Click += new System.EventHandler(this.UrunAraBtn_Click);
            // 
            // UrunGuncelleBtn
            // 
            this.UrunGuncelleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunGuncelleBtn.Image")));
            this.UrunGuncelleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunGuncelleBtn.Location = new System.Drawing.Point(449, 176);
            this.UrunGuncelleBtn.Name = "UrunGuncelleBtn";
            this.UrunGuncelleBtn.Size = new System.Drawing.Size(213, 60);
            this.UrunGuncelleBtn.TabIndex = 38;
            this.UrunGuncelleBtn.Text = "GÜNCELLE";
            this.UrunGuncelleBtn.UseVisualStyleBackColor = true;
            this.UrunGuncelleBtn.Click += new System.EventHandler(this.UrunGuncelleBtn_Click);
            // 
            // UrunSilBtn
            // 
            this.UrunSilBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.UrunSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunSilBtn.Image")));
            this.UrunSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunSilBtn.Location = new System.Drawing.Point(230, 176);
            this.UrunSilBtn.Name = "UrunSilBtn";
            this.UrunSilBtn.Size = new System.Drawing.Size(213, 60);
            this.UrunSilBtn.TabIndex = 37;
            this.UrunSilBtn.Text = "SİL";
            this.UrunSilBtn.UseVisualStyleBackColor = true;
            this.UrunSilBtn.Click += new System.EventHandler(this.UrunSilBtn_Click);
            // 
            // UrunKaydetBtn
            // 
            this.UrunKaydetBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.UrunKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunKaydetBtn.Image")));
            this.UrunKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunKaydetBtn.Location = new System.Drawing.Point(11, 176);
            this.UrunKaydetBtn.Name = "UrunKaydetBtn";
            this.UrunKaydetBtn.Size = new System.Drawing.Size(213, 60);
            this.UrunKaydetBtn.TabIndex = 36;
            this.UrunKaydetBtn.Text = "KAYDET";
            this.UrunKaydetBtn.UseVisualStyleBackColor = true;
            this.UrunKaydetBtn.Click += new System.EventHandler(this.UrunKaydetBtn_Click);
            // 
            // UrunTedarikciTBox
            // 
            this.UrunTedarikciTBox.Location = new System.Drawing.Point(148, 114);
            this.UrunTedarikciTBox.Name = "UrunTedarikciTBox";
            this.UrunTedarikciTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunTedarikciTBox.TabIndex = 41;
            // 
            // UrunTeslimAlanPersonelTBox
            // 
            this.UrunTeslimAlanPersonelTBox.Location = new System.Drawing.Point(645, 115);
            this.UrunTeslimAlanPersonelTBox.Name = "UrunTeslimAlanPersonelTBox";
            this.UrunTeslimAlanPersonelTBox.Size = new System.Drawing.Size(250, 22);
            this.UrunTeslimAlanPersonelTBox.TabIndex = 42;
            // 
            // UrunTedarikciLbl
            // 
            this.UrunTedarikciLbl.AutoSize = true;
            this.UrunTedarikciLbl.BackColor = System.Drawing.Color.Transparent;
            this.UrunTedarikciLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunTedarikciLbl.ForeColor = System.Drawing.Color.White;
            this.UrunTedarikciLbl.Location = new System.Drawing.Point(44, 115);
            this.UrunTedarikciLbl.Name = "UrunTedarikciLbl";
            this.UrunTedarikciLbl.Size = new System.Drawing.Size(85, 19);
            this.UrunTedarikciLbl.TabIndex = 43;
            this.UrunTedarikciLbl.Text = "Tedarikci:";
            // 
            // UrunAlisFiyatiLbl
            // 
            this.UrunAlisFiyatiLbl.AutoSize = true;
            this.UrunAlisFiyatiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.UrunAlisFiyatiLbl.ForeColor = System.Drawing.Color.White;
            this.UrunAlisFiyatiLbl.Location = new System.Drawing.Point(486, 21);
            this.UrunAlisFiyatiLbl.Name = "UrunAlisFiyatiLbl";
            this.UrunAlisFiyatiLbl.Size = new System.Drawing.Size(90, 19);
            this.UrunAlisFiyatiLbl.TabIndex = 22;
            this.UrunAlisFiyatiLbl.Text = "Alış Fiyatı:";
            // 
            // UrunKategorisiLbl
            // 
            this.UrunKategorisiLbl.AutoSize = true;
            this.UrunKategorisiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.UrunKategorisiLbl.ForeColor = System.Drawing.Color.White;
            this.UrunKategorisiLbl.Location = new System.Drawing.Point(481, 52);
            this.UrunKategorisiLbl.Name = "UrunKategorisiLbl";
            this.UrunKategorisiLbl.Size = new System.Drawing.Size(95, 19);
            this.UrunKategorisiLbl.TabIndex = 26;
            this.UrunKategorisiLbl.Text = "Kategorisi:";
            // 
            // UrunAciklamaTBox
            // 
            this.UrunAciklamaTBox.Location = new System.Drawing.Point(148, 86);
            this.UrunAciklamaTBox.Name = "UrunAciklamaTBox";
            this.UrunAciklamaTBox.Size = new System.Drawing.Size(747, 22);
            this.UrunAciklamaTBox.TabIndex = 30;
            // 
            // UrunTeslimAlanPersonelLbl
            // 
            this.UrunTeslimAlanPersonelLbl.AutoSize = true;
            this.UrunTeslimAlanPersonelLbl.BackColor = System.Drawing.Color.Transparent;
            this.UrunTeslimAlanPersonelLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunTeslimAlanPersonelLbl.ForeColor = System.Drawing.Color.White;
            this.UrunTeslimAlanPersonelLbl.Location = new System.Drawing.Point(404, 115);
            this.UrunTeslimAlanPersonelLbl.Name = "UrunTeslimAlanPersonelLbl";
            this.UrunTeslimAlanPersonelLbl.Size = new System.Drawing.Size(181, 19);
            this.UrunTeslimAlanPersonelLbl.TabIndex = 44;
            this.UrunTeslimAlanPersonelLbl.Text = "Teslim Alan Personel: ";
            // 
            // UrunIdLbl
            // 
            this.UrunIdLbl.AutoSize = true;
            this.UrunIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.UrunIdLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunIdLbl.ForeColor = System.Drawing.Color.White;
            this.UrunIdLbl.Location = new System.Drawing.Point(96, 145);
            this.UrunIdLbl.Name = "UrunIdLbl";
            this.UrunIdLbl.Size = new System.Drawing.Size(31, 19);
            this.UrunIdLbl.TabIndex = 45;
            this.UrunIdLbl.Text = "ID:";
            // 
            // UrunIdTBox
            // 
            this.UrunIdTBox.Location = new System.Drawing.Point(148, 142);
            this.UrunIdTBox.Name = "UrunIdTBox";
            this.UrunIdTBox.Size = new System.Drawing.Size(118, 22);
            this.UrunIdTBox.TabIndex = 46;
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1132, 598);
            this.ControlBox = false;
            this.Controls.Add(this.UrunIdTBox);
            this.Controls.Add(this.UrunIdLbl);
            this.Controls.Add(this.UrunTeslimAlanPersonelLbl);
            this.Controls.Add(this.UrunTedarikciLbl);
            this.Controls.Add(this.UrunTeslimAlanPersonelTBox);
            this.Controls.Add(this.UrunTedarikciTBox);
            this.Controls.Add(this.UrunListeleBtn);
            this.Controls.Add(this.UrunAraBtn);
            this.Controls.Add(this.UrunGuncelleBtn);
            this.Controls.Add(this.UrunSilBtn);
            this.Controls.Add(this.UrunKaydetBtn);
            this.Controls.Add(this.UrunDataGridView);
            this.Controls.Add(this.UrunAciklamaTBox);
            this.Controls.Add(this.UrunAciklamaLbl);
            this.Controls.Add(this.UrunMiktariTBox);
            this.Controls.Add(this.UrunKategorisiTBox);
            this.Controls.Add(this.UrunKategorisiLbl);
            this.Controls.Add(this.UrunFiyatiTBox);
            this.Controls.Add(this.UrunAdiTBox);
            this.Controls.Add(this.UrunAlisFiyatiLbl);
            this.Controls.Add(this.UrunMiktariLbl);
            this.Controls.Add(this.UrunAdiLbl);
            this.Controls.Add(this.UrunHomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunForm";
            this.Text = "ÜRÜN";
            ((System.ComponentModel.ISupportInitialize)(this.UrunDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageListStok;
        private System.Windows.Forms.Button UrunHomeBtn;
        private System.Windows.Forms.TextBox UrunKategorisiTBox;
        private System.Windows.Forms.TextBox UrunFiyatiTBox;
        private System.Windows.Forms.TextBox UrunAdiTBox;
        private System.Windows.Forms.Label UrunMiktariLbl;
        private System.Windows.Forms.Label UrunAdiLbl;
        private System.Windows.Forms.TextBox UrunMiktariTBox;
        private System.Windows.Forms.Label UrunAciklamaLbl;
        private System.Windows.Forms.DataGridView UrunDataGridView;
        private System.Windows.Forms.Button UrunListeleBtn;
        private System.Windows.Forms.Button UrunAraBtn;
        private System.Windows.Forms.Button UrunGuncelleBtn;
        private System.Windows.Forms.Button UrunSilBtn;
        private System.Windows.Forms.Button UrunKaydetBtn;
        private System.Windows.Forms.TextBox UrunTedarikciTBox;
        private System.Windows.Forms.TextBox UrunTeslimAlanPersonelTBox;
        private System.Windows.Forms.Label UrunTedarikciLbl;
        private System.Windows.Forms.Label UrunAlisFiyatiLbl;
        private System.Windows.Forms.Label UrunKategorisiLbl;
        private System.Windows.Forms.TextBox UrunAciklamaTBox;
        private System.Windows.Forms.Label UrunTeslimAlanPersonelLbl;
        private System.Windows.Forms.Label UrunIdLbl;
        private System.Windows.Forms.TextBox UrunIdTBox;
    }
}