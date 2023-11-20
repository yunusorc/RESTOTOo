
namespace RESTOTOo
{
    partial class GiderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiderForm));
            this.ımageListGider = new System.Windows.Forms.ImageList(this.components);
            this.GiderHomeBtn = new System.Windows.Forms.Button();
            this.GiderdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GiderAciklamaTBox = new System.Windows.Forms.TextBox();
            this.GiderMiktarTBox = new System.Windows.Forms.TextBox();
            this.GiderAciklamaLbl = new System.Windows.Forms.Label();
            this.GiderTarihLbl = new System.Windows.Forms.Label();
            this.GiderMiktarLbl = new System.Windows.Forms.Label();
            this.GiderDataGridView = new System.Windows.Forms.DataGridView();
            this.GiderListeleBtn = new System.Windows.Forms.Button();
            this.GiderAraBtn = new System.Windows.Forms.Button();
            this.GiderGuncelleBtn = new System.Windows.Forms.Button();
            this.GiderSilBtn = new System.Windows.Forms.Button();
            this.GiderKaydetBtn = new System.Windows.Forms.Button();
            this.GiderIdTBox = new System.Windows.Forms.TextBox();
            this.GiderIdLbl = new System.Windows.Forms.Label();
            this.GiderHesaplaTBox = new System.Windows.Forms.TextBox();
            this.GiderHesaplaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GiderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageListGider
            // 
            this.ımageListGider.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListGider.ImageStream")));
            this.ımageListGider.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListGider.Images.SetKeyName(0, "home.png");
            // 
            // GiderHomeBtn
            // 
            this.GiderHomeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GiderHomeBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderHomeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GiderHomeBtn.ImageIndex = 0;
            this.GiderHomeBtn.ImageList = this.ımageListGider;
            this.GiderHomeBtn.Location = new System.Drawing.Point(1000, 10);
            this.GiderHomeBtn.Name = "GiderHomeBtn";
            this.GiderHomeBtn.Size = new System.Drawing.Size(100, 90);
            this.GiderHomeBtn.TabIndex = 2;
            this.GiderHomeBtn.Text = "ANA SAYFA";
            this.GiderHomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GiderHomeBtn.UseVisualStyleBackColor = false;
            this.GiderHomeBtn.Click += new System.EventHandler(this.GiderHomeBtn_Click);
            // 
            // GiderdateTimePicker
            // 
            this.GiderdateTimePicker.Location = new System.Drawing.Point(148, 53);
            this.GiderdateTimePicker.Name = "GiderdateTimePicker";
            this.GiderdateTimePicker.Size = new System.Drawing.Size(250, 22);
            this.GiderdateTimePicker.TabIndex = 17;
            // 
            // GiderAciklamaTBox
            // 
            this.GiderAciklamaTBox.Location = new System.Drawing.Point(148, 91);
            this.GiderAciklamaTBox.Name = "GiderAciklamaTBox";
            this.GiderAciklamaTBox.Size = new System.Drawing.Size(250, 22);
            this.GiderAciklamaTBox.TabIndex = 16;
            // 
            // GiderMiktarTBox
            // 
            this.GiderMiktarTBox.Location = new System.Drawing.Point(148, 16);
            this.GiderMiktarTBox.Name = "GiderMiktarTBox";
            this.GiderMiktarTBox.Size = new System.Drawing.Size(250, 22);
            this.GiderMiktarTBox.TabIndex = 15;
            // 
            // GiderAciklamaLbl
            // 
            this.GiderAciklamaLbl.AutoSize = true;
            this.GiderAciklamaLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.GiderAciklamaLbl.ForeColor = System.Drawing.Color.White;
            this.GiderAciklamaLbl.Location = new System.Drawing.Point(47, 92);
            this.GiderAciklamaLbl.Name = "GiderAciklamaLbl";
            this.GiderAciklamaLbl.Size = new System.Drawing.Size(84, 19);
            this.GiderAciklamaLbl.TabIndex = 14;
            this.GiderAciklamaLbl.Text = "Açıklama:";
            // 
            // GiderTarihLbl
            // 
            this.GiderTarihLbl.AutoSize = true;
            this.GiderTarihLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.GiderTarihLbl.ForeColor = System.Drawing.Color.White;
            this.GiderTarihLbl.Location = new System.Drawing.Point(73, 53);
            this.GiderTarihLbl.Name = "GiderTarihLbl";
            this.GiderTarihLbl.Size = new System.Drawing.Size(58, 19);
            this.GiderTarihLbl.TabIndex = 13;
            this.GiderTarihLbl.Text = "Tarihi:";
            // 
            // GiderMiktarLbl
            // 
            this.GiderMiktarLbl.AutoSize = true;
            this.GiderMiktarLbl.BackColor = System.Drawing.Color.Transparent;
            this.GiderMiktarLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderMiktarLbl.ForeColor = System.Drawing.Color.White;
            this.GiderMiktarLbl.Location = new System.Drawing.Point(16, 17);
            this.GiderMiktarLbl.Name = "GiderMiktarLbl";
            this.GiderMiktarLbl.Size = new System.Drawing.Size(115, 19);
            this.GiderMiktarLbl.TabIndex = 12;
            this.GiderMiktarLbl.Text = "Gider Miktarı:";
            // 
            // GiderDataGridView
            // 
            this.GiderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiderDataGridView.Location = new System.Drawing.Point(12, 215);
            this.GiderDataGridView.Name = "GiderDataGridView";
            this.GiderDataGridView.RowHeadersWidth = 51;
            this.GiderDataGridView.RowTemplate.Height = 24;
            this.GiderDataGridView.Size = new System.Drawing.Size(1088, 326);
            this.GiderDataGridView.TabIndex = 20;
            // 
            // GiderListeleBtn
            // 
            this.GiderListeleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.GiderListeleBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderListeleBtn.Image")));
            this.GiderListeleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GiderListeleBtn.Location = new System.Drawing.Point(887, 149);
            this.GiderListeleBtn.Name = "GiderListeleBtn";
            this.GiderListeleBtn.Size = new System.Drawing.Size(213, 60);
            this.GiderListeleBtn.TabIndex = 45;
            this.GiderListeleBtn.Text = "LİSTELE";
            this.GiderListeleBtn.UseVisualStyleBackColor = true;
            this.GiderListeleBtn.Click += new System.EventHandler(this.GiderListeleBtn_Click);
            // 
            // GiderAraBtn
            // 
            this.GiderAraBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.GiderAraBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderAraBtn.Image")));
            this.GiderAraBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GiderAraBtn.Location = new System.Drawing.Point(668, 149);
            this.GiderAraBtn.Name = "GiderAraBtn";
            this.GiderAraBtn.Size = new System.Drawing.Size(213, 60);
            this.GiderAraBtn.TabIndex = 44;
            this.GiderAraBtn.Text = "ARA";
            this.GiderAraBtn.UseVisualStyleBackColor = true;
            this.GiderAraBtn.Click += new System.EventHandler(this.GiderAraBtn_Click);
            // 
            // GiderGuncelleBtn
            // 
            this.GiderGuncelleBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderGuncelleBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderGuncelleBtn.Image")));
            this.GiderGuncelleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GiderGuncelleBtn.Location = new System.Drawing.Point(449, 149);
            this.GiderGuncelleBtn.Name = "GiderGuncelleBtn";
            this.GiderGuncelleBtn.Size = new System.Drawing.Size(213, 60);
            this.GiderGuncelleBtn.TabIndex = 43;
            this.GiderGuncelleBtn.Text = "GÜNCELLE";
            this.GiderGuncelleBtn.UseVisualStyleBackColor = true;
            this.GiderGuncelleBtn.Click += new System.EventHandler(this.GiderGuncelleBtn_Click);
            // 
            // GiderSilBtn
            // 
            this.GiderSilBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.GiderSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderSilBtn.Image")));
            this.GiderSilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GiderSilBtn.Location = new System.Drawing.Point(230, 149);
            this.GiderSilBtn.Name = "GiderSilBtn";
            this.GiderSilBtn.Size = new System.Drawing.Size(213, 60);
            this.GiderSilBtn.TabIndex = 42;
            this.GiderSilBtn.Text = "SİL";
            this.GiderSilBtn.UseVisualStyleBackColor = true;
            this.GiderSilBtn.Click += new System.EventHandler(this.GiderSilBtn_Click);
            // 
            // GiderKaydetBtn
            // 
            this.GiderKaydetBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.GiderKaydetBtn.Image = ((System.Drawing.Image)(resources.GetObject("GiderKaydetBtn.Image")));
            this.GiderKaydetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GiderKaydetBtn.Location = new System.Drawing.Point(12, 149);
            this.GiderKaydetBtn.Name = "GiderKaydetBtn";
            this.GiderKaydetBtn.Size = new System.Drawing.Size(213, 60);
            this.GiderKaydetBtn.TabIndex = 41;
            this.GiderKaydetBtn.Text = "KAYDET";
            this.GiderKaydetBtn.UseVisualStyleBackColor = true;
            this.GiderKaydetBtn.Click += new System.EventHandler(this.GiderKaydetBtn_Click);
            // 
            // GiderIdTBox
            // 
            this.GiderIdTBox.Location = new System.Drawing.Point(544, 17);
            this.GiderIdTBox.Name = "GiderIdTBox";
            this.GiderIdTBox.Size = new System.Drawing.Size(118, 22);
            this.GiderIdTBox.TabIndex = 49;
            // 
            // GiderIdLbl
            // 
            this.GiderIdLbl.AutoSize = true;
            this.GiderIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.GiderIdLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderIdLbl.ForeColor = System.Drawing.Color.White;
            this.GiderIdLbl.Location = new System.Drawing.Point(507, 20);
            this.GiderIdLbl.Name = "GiderIdLbl";
            this.GiderIdLbl.Size = new System.Drawing.Size(31, 19);
            this.GiderIdLbl.TabIndex = 48;
            this.GiderIdLbl.Text = "ID:";
            // 
            // GiderHesaplaTBox
            // 
            this.GiderHesaplaTBox.Location = new System.Drawing.Point(544, 91);
            this.GiderHesaplaTBox.Name = "GiderHesaplaTBox";
            this.GiderHesaplaTBox.Size = new System.Drawing.Size(118, 22);
            this.GiderHesaplaTBox.TabIndex = 50;
            // 
            // GiderHesaplaBtn
            // 
            this.GiderHesaplaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderHesaplaBtn.Location = new System.Drawing.Point(417, 91);
            this.GiderHesaplaBtn.Name = "GiderHesaplaBtn";
            this.GiderHesaplaBtn.Size = new System.Drawing.Size(121, 22);
            this.GiderHesaplaBtn.TabIndex = 52;
            this.GiderHesaplaBtn.Text = "Kar Hesapla";
            this.GiderHesaplaBtn.UseVisualStyleBackColor = true;
            // 
            // GiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1132, 598);
            this.ControlBox = false;
            this.Controls.Add(this.GiderHesaplaBtn);
            this.Controls.Add(this.GiderHesaplaTBox);
            this.Controls.Add(this.GiderIdTBox);
            this.Controls.Add(this.GiderIdLbl);
            this.Controls.Add(this.GiderListeleBtn);
            this.Controls.Add(this.GiderAraBtn);
            this.Controls.Add(this.GiderGuncelleBtn);
            this.Controls.Add(this.GiderSilBtn);
            this.Controls.Add(this.GiderKaydetBtn);
            this.Controls.Add(this.GiderDataGridView);
            this.Controls.Add(this.GiderdateTimePicker);
            this.Controls.Add(this.GiderAciklamaTBox);
            this.Controls.Add(this.GiderMiktarTBox);
            this.Controls.Add(this.GiderAciklamaLbl);
            this.Controls.Add(this.GiderTarihLbl);
            this.Controls.Add(this.GiderMiktarLbl);
            this.Controls.Add(this.GiderHomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiderForm";
            this.Text = "GİDER";
            ((System.ComponentModel.ISupportInitialize)(this.GiderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageListGider;
        private System.Windows.Forms.Button GiderHomeBtn;
        private System.Windows.Forms.DateTimePicker GiderdateTimePicker;
        private System.Windows.Forms.TextBox GiderAciklamaTBox;
        private System.Windows.Forms.TextBox GiderMiktarTBox;
        private System.Windows.Forms.Label GiderAciklamaLbl;
        private System.Windows.Forms.Label GiderTarihLbl;
        private System.Windows.Forms.Label GiderMiktarLbl;
        private System.Windows.Forms.DataGridView GiderDataGridView;
        private System.Windows.Forms.Button GiderListeleBtn;
        private System.Windows.Forms.Button GiderAraBtn;
        private System.Windows.Forms.Button GiderGuncelleBtn;
        private System.Windows.Forms.Button GiderSilBtn;
        private System.Windows.Forms.Button GiderKaydetBtn;
        private System.Windows.Forms.TextBox GiderIdTBox;
        private System.Windows.Forms.Label GiderIdLbl;
        private System.Windows.Forms.TextBox GiderHesaplaTBox;
        private System.Windows.Forms.Button GiderHesaplaBtn;
    }
}