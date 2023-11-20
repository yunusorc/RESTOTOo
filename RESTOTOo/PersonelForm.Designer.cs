
namespace RESTOTOo
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.PersonelHomeBtn = new System.Windows.Forms.Button();
            this.ımageListPersonel = new System.Windows.Forms.ImageList(this.components);
            this.PersonelAdiLbl = new System.Windows.Forms.Label();
            this.PersonelPozisyonLbl = new System.Windows.Forms.Label();
            this.PersonelMaasiLbl = new System.Windows.Forms.Label();
            this.PersonelTelefonLbl = new System.Windows.Forms.Label();
            this.PersonelGirisTarihiLbl = new System.Windows.Forms.Label();
            this.PersoneldateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PersonelAdiTBox = new System.Windows.Forms.TextBox();
            this.PersonelTelNoTBox = new System.Windows.Forms.TextBox();
            this.PersonelMaasiTBox = new System.Windows.Forms.TextBox();
            this.PersonelPozisyonuTBox = new System.Windows.Forms.TextBox();
            this.PersonelDataGridView = new System.Windows.Forms.DataGridView();
            this.PersonelListeleBtn = new System.Windows.Forms.Button();
            this.PersonelAraBtn = new System.Windows.Forms.Button();
            this.PersonelGuncelleBtn = new System.Windows.Forms.Button();
            this.PersonelSilBtn = new System.Windows.Forms.Button();
            this.PersonelKaydetBtn = new System.Windows.Forms.Button();
            this.PersonelIdTBox = new System.Windows.Forms.TextBox();
            this.PersonelIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonelHomeBtn
            // 
            this.PersonelHomeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PersonelHomeBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelHomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PersonelHomeBtn.ImageIndex = 0;
            this.PersonelHomeBtn.ImageList = this.ımageListPersonel;
            this.PersonelHomeBtn.Location = new System.Drawing.Point(1000, 10);
            this.PersonelHomeBtn.Name = "PersonelHomeBtn";
            this.PersonelHomeBtn.Size = new System.Drawing.Size(100, 90);
            this.PersonelHomeBtn.TabIndex = 1;
            this.PersonelHomeBtn.Text = "ANA SAYFA";
            this.PersonelHomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PersonelHomeBtn.UseVisualStyleBackColor = false;
            this.PersonelHomeBtn.Click += new System.EventHandler(this.PersonelHomeBtn_Click);
            // 
            // ımageListPersonel
            // 
            this.ımageListPersonel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListPersonel.ImageStream")));
            this.ımageListPersonel.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListPersonel.Images.SetKeyName(0, "home.png");
            // 
            // PersonelAdiLbl
            // 
            this.PersonelAdiLbl.AutoSize = true;
            this.PersonelAdiLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelAdiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAdiLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelAdiLbl.Location = new System.Drawing.Point(29, 19);
            this.PersonelAdiLbl.Name = "PersonelAdiLbl";
            this.PersonelAdiLbl.Size = new System.Drawing.Size(98, 19);
            this.PersonelAdiLbl.TabIndex = 3;
            this.PersonelAdiLbl.Text = "Adı Soyadı:";
            // 
            // PersonelPozisyonLbl
            // 
            this.PersonelPozisyonLbl.AutoSize = true;
            this.PersonelPozisyonLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelPozisyonLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelPozisyonLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelPozisyonLbl.Location = new System.Drawing.Point(454, 19);
            this.PersonelPozisyonLbl.Name = "PersonelPozisyonLbl";
            this.PersonelPozisyonLbl.Size = new System.Drawing.Size(97, 19);
            this.PersonelPozisyonLbl.TabIndex = 4;
            this.PersonelPozisyonLbl.Text = "Pozisyonu:";
            // 
            // PersonelMaasiLbl
            // 
            this.PersonelMaasiLbl.AutoSize = true;
            this.PersonelMaasiLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelMaasiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelMaasiLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelMaasiLbl.Location = new System.Drawing.Point(68, 88);
            this.PersonelMaasiLbl.Name = "PersonelMaasiLbl";
            this.PersonelMaasiLbl.Size = new System.Drawing.Size(59, 19);
            this.PersonelMaasiLbl.TabIndex = 5;
            this.PersonelMaasiLbl.Text = "Maaşı:";
            // 
            // PersonelTelefonLbl
            // 
            this.PersonelTelefonLbl.AutoSize = true;
            this.PersonelTelefonLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelTelefonLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelTelefonLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelTelefonLbl.Location = new System.Drawing.Point(29, 53);
            this.PersonelTelefonLbl.Name = "PersonelTelefonLbl";
            this.PersonelTelefonLbl.Size = new System.Drawing.Size(98, 19);
            this.PersonelTelefonLbl.TabIndex = 6;
            this.PersonelTelefonLbl.Text = "Telefon No:";
            // 
            // PersonelGirisTarihiLbl
            // 
            this.PersonelGirisTarihiLbl.AutoSize = true;
            this.PersonelGirisTarihiLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelGirisTarihiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelGirisTarihiLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelGirisTarihiLbl.Location = new System.Drawing.Point(451, 53);
            this.PersonelGirisTarihiLbl.Name = "PersonelGirisTarihiLbl";
            this.PersonelGirisTarihiLbl.Size = new System.Drawing.Size(100, 19);
            this.PersonelGirisTarihiLbl.TabIndex = 8;
            this.PersonelGirisTarihiLbl.Text = "Giriş Tarihi:";
            // 
            // PersoneldateTimePicker
            // 
            this.PersoneldateTimePicker.Location = new System.Drawing.Point(569, 50);
            this.PersoneldateTimePicker.Name = "PersoneldateTimePicker";
            this.PersoneldateTimePicker.Size = new System.Drawing.Size(250, 22);
            this.PersoneldateTimePicker.TabIndex = 9;
            // 
            // PersonelAdiTBox
            // 
            this.PersonelAdiTBox.Location = new System.Drawing.Point(148, 16);
            this.PersonelAdiTBox.Name = "PersonelAdiTBox";
            this.PersonelAdiTBox.Size = new System.Drawing.Size(250, 22);
            this.PersonelAdiTBox.TabIndex = 10;
            // 
            // PersonelTelNoTBox
            // 
            this.PersonelTelNoTBox.Location = new System.Drawing.Point(148, 50);
            this.PersonelTelNoTBox.Name = "PersonelTelNoTBox";
            this.PersonelTelNoTBox.Size = new System.Drawing.Size(250, 22);
            this.PersonelTelNoTBox.TabIndex = 12;
            // 
            // PersonelMaasiTBox
            // 
            this.PersonelMaasiTBox.Location = new System.Drawing.Point(148, 84);
            this.PersonelMaasiTBox.Name = "PersonelMaasiTBox";
            this.PersonelMaasiTBox.Size = new System.Drawing.Size(250, 22);
            this.PersonelMaasiTBox.TabIndex = 13;
            // 
            // PersonelPozisyonuTBox
            // 
            this.PersonelPozisyonuTBox.Location = new System.Drawing.Point(569, 16);
            this.PersonelPozisyonuTBox.Name = "PersonelPozisyonuTBox";
            this.PersonelPozisyonuTBox.Size = new System.Drawing.Size(250, 22);
            this.PersonelPozisyonuTBox.TabIndex = 14;
            // 
            // PersonelDataGridView
            // 
            this.PersonelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelDataGridView.Location = new System.Drawing.Point(12, 227);
            this.PersonelDataGridView.Name = "PersonelDataGridView";
            this.PersonelDataGridView.RowHeadersWidth = 51;
            this.PersonelDataGridView.RowTemplate.Height = 24;
            this.PersonelDataGridView.Size = new System.Drawing.Size(1088, 314);
            this.PersonelDataGridView.TabIndex = 15;
            // 
            // PersonelListeleBtn
            // 
            this.PersonelListeleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.PersonelListeleBtn.Image = ((System.Drawing.Image)(resources.GetObject("PersonelListeleBtn.Image")));
            this.PersonelListeleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelListeleBtn.Location = new System.Drawing.Point(887, 161);
            this.PersonelListeleBtn.Name = "PersonelListeleBtn";
            this.PersonelListeleBtn.Size = new System.Drawing.Size(213, 60);
            this.PersonelListeleBtn.TabIndex = 45;
            this.PersonelListeleBtn.Text = "LİSTELE";
            this.PersonelListeleBtn.UseVisualStyleBackColor = true;
            this.PersonelListeleBtn.Click += new System.EventHandler(this.PersonelListeleBtn_Click);
            // 
            // PersonelAraBtn
            // 
            this.PersonelAraBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.PersonelAraBtn.Image = ((System.Drawing.Image)(resources.GetObject("PersonelAraBtn.Image")));
            this.PersonelAraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelAraBtn.Location = new System.Drawing.Point(668, 161);
            this.PersonelAraBtn.Name = "PersonelAraBtn";
            this.PersonelAraBtn.Size = new System.Drawing.Size(213, 60);
            this.PersonelAraBtn.TabIndex = 44;
            this.PersonelAraBtn.Text = "ARA";
            this.PersonelAraBtn.UseVisualStyleBackColor = true;
            this.PersonelAraBtn.Click += new System.EventHandler(this.PersonelAraBtn_Click);
            // 
            // PersonelGuncelleBtn
            // 
            this.PersonelGuncelleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("PersonelGuncelleBtn.Image")));
            this.PersonelGuncelleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelGuncelleBtn.Location = new System.Drawing.Point(449, 161);
            this.PersonelGuncelleBtn.Name = "PersonelGuncelleBtn";
            this.PersonelGuncelleBtn.Size = new System.Drawing.Size(213, 60);
            this.PersonelGuncelleBtn.TabIndex = 43;
            this.PersonelGuncelleBtn.Text = "GÜNCELLE";
            this.PersonelGuncelleBtn.UseVisualStyleBackColor = true;
            this.PersonelGuncelleBtn.Click += new System.EventHandler(this.PersonelGuncelleBtn_Click);
            // 
            // PersonelSilBtn
            // 
            this.PersonelSilBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.PersonelSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("PersonelSilBtn.Image")));
            this.PersonelSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelSilBtn.Location = new System.Drawing.Point(230, 161);
            this.PersonelSilBtn.Name = "PersonelSilBtn";
            this.PersonelSilBtn.Size = new System.Drawing.Size(213, 60);
            this.PersonelSilBtn.TabIndex = 42;
            this.PersonelSilBtn.Text = "SİL";
            this.PersonelSilBtn.UseVisualStyleBackColor = true;
            this.PersonelSilBtn.Click += new System.EventHandler(this.PersonelSilBtn_Click);
            // 
            // PersonelKaydetBtn
            // 
            this.PersonelKaydetBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.PersonelKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("PersonelKaydetBtn.Image")));
            this.PersonelKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelKaydetBtn.Location = new System.Drawing.Point(12, 161);
            this.PersonelKaydetBtn.Name = "PersonelKaydetBtn";
            this.PersonelKaydetBtn.Size = new System.Drawing.Size(213, 60);
            this.PersonelKaydetBtn.TabIndex = 41;
            this.PersonelKaydetBtn.Text = "KAYDET";
            this.PersonelKaydetBtn.UseVisualStyleBackColor = true;
            this.PersonelKaydetBtn.Click += new System.EventHandler(this.PersonelKaydetBtn_Click);
            // 
            // PersonelIdTBox
            // 
            this.PersonelIdTBox.Location = new System.Drawing.Point(569, 85);
            this.PersonelIdTBox.Name = "PersonelIdTBox";
            this.PersonelIdTBox.Size = new System.Drawing.Size(118, 22);
            this.PersonelIdTBox.TabIndex = 51;
            // 
            // PersonelIdLbl
            // 
            this.PersonelIdLbl.AutoSize = true;
            this.PersonelIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.PersonelIdLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelIdLbl.ForeColor = System.Drawing.Color.White;
            this.PersonelIdLbl.Location = new System.Drawing.Point(520, 89);
            this.PersonelIdLbl.Name = "PersonelIdLbl";
            this.PersonelIdLbl.Size = new System.Drawing.Size(31, 19);
            this.PersonelIdLbl.TabIndex = 50;
            this.PersonelIdLbl.Text = "ID:";
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1132, 598);
            this.ControlBox = false;
            this.Controls.Add(this.PersonelIdTBox);
            this.Controls.Add(this.PersonelIdLbl);
            this.Controls.Add(this.PersonelListeleBtn);
            this.Controls.Add(this.PersonelAraBtn);
            this.Controls.Add(this.PersonelGuncelleBtn);
            this.Controls.Add(this.PersonelSilBtn);
            this.Controls.Add(this.PersonelKaydetBtn);
            this.Controls.Add(this.PersonelDataGridView);
            this.Controls.Add(this.PersonelPozisyonuTBox);
            this.Controls.Add(this.PersonelMaasiTBox);
            this.Controls.Add(this.PersonelTelNoTBox);
            this.Controls.Add(this.PersonelAdiTBox);
            this.Controls.Add(this.PersoneldateTimePicker);
            this.Controls.Add(this.PersonelGirisTarihiLbl);
            this.Controls.Add(this.PersonelTelefonLbl);
            this.Controls.Add(this.PersonelMaasiLbl);
            this.Controls.Add(this.PersonelPozisyonLbl);
            this.Controls.Add(this.PersonelAdiLbl);
            this.Controls.Add(this.PersonelHomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonelForm";
            this.Text = "PERSONEL";
            ((System.ComponentModel.ISupportInitialize)(this.PersonelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonelHomeBtn;
        private System.Windows.Forms.ImageList ımageListPersonel;
        private System.Windows.Forms.Label PersonelAdiLbl;
        private System.Windows.Forms.Label PersonelPozisyonLbl;
        private System.Windows.Forms.Label PersonelMaasiLbl;
        private System.Windows.Forms.Label PersonelTelefonLbl;
        private System.Windows.Forms.Label PersonelGirisTarihiLbl;
        private System.Windows.Forms.DateTimePicker PersoneldateTimePicker;
        private System.Windows.Forms.TextBox PersonelAdiTBox;
        private System.Windows.Forms.TextBox PersonelTelNoTBox;
        private System.Windows.Forms.TextBox PersonelMaasiTBox;
        private System.Windows.Forms.TextBox PersonelPozisyonuTBox;
        private System.Windows.Forms.DataGridView PersonelDataGridView;
        private System.Windows.Forms.Button PersonelListeleBtn;
        private System.Windows.Forms.Button PersonelAraBtn;
        private System.Windows.Forms.Button PersonelGuncelleBtn;
        private System.Windows.Forms.Button PersonelSilBtn;
        private System.Windows.Forms.Button PersonelKaydetBtn;
        private System.Windows.Forms.TextBox PersonelIdTBox;
        private System.Windows.Forms.Label PersonelIdLbl;
    }
}