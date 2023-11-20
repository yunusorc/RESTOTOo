
namespace RESTOTOo
{
    partial class GirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.GirisParolaLbl = new System.Windows.Forms.Label();
            this.GirisKullaniciAdiLbl = new System.Windows.Forms.Label();
            this.GirisParolaTbox = new System.Windows.Forms.TextBox();
            this.GirisKullaniciAdiTBox = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.GirisRestOtoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GirisParolaLbl
            // 
            this.GirisParolaLbl.AutoSize = true;
            this.GirisParolaLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.GirisParolaLbl.ForeColor = System.Drawing.Color.White;
            this.GirisParolaLbl.Location = new System.Drawing.Point(100, 261);
            this.GirisParolaLbl.Name = "GirisParolaLbl";
            this.GirisParolaLbl.Size = new System.Drawing.Size(82, 19);
            this.GirisParolaLbl.TabIndex = 23;
            this.GirisParolaLbl.Text = "PAROLA:";
            // 
            // GirisKullaniciAdiLbl
            // 
            this.GirisKullaniciAdiLbl.AutoSize = true;
            this.GirisKullaniciAdiLbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.GirisKullaniciAdiLbl.ForeColor = System.Drawing.Color.White;
            this.GirisKullaniciAdiLbl.Location = new System.Drawing.Point(49, 212);
            this.GirisKullaniciAdiLbl.Name = "GirisKullaniciAdiLbl";
            this.GirisKullaniciAdiLbl.Size = new System.Drawing.Size(133, 19);
            this.GirisKullaniciAdiLbl.TabIndex = 24;
            this.GirisKullaniciAdiLbl.Text = "KULLANICI ADI:";
            // 
            // GirisParolaTbox
            // 
            this.GirisParolaTbox.Location = new System.Drawing.Point(199, 258);
            this.GirisParolaTbox.Name = "GirisParolaTbox";
            this.GirisParolaTbox.Size = new System.Drawing.Size(193, 22);
            this.GirisParolaTbox.TabIndex = 47;
            // 
            // GirisKullaniciAdiTBox
            // 
            this.GirisKullaniciAdiTBox.Location = new System.Drawing.Point(199, 209);
            this.GirisKullaniciAdiTBox.Name = "GirisKullaniciAdiTBox";
            this.GirisKullaniciAdiTBox.Size = new System.Drawing.Size(193, 22);
            this.GirisKullaniciAdiTBox.TabIndex = 48;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GirisBtn.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.GirisBtn.ForeColor = System.Drawing.Color.Black;
            this.GirisBtn.Image = ((System.Drawing.Image)(resources.GetObject("GirisBtn.Image")));
            this.GirisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GirisBtn.Location = new System.Drawing.Point(275, 304);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(117, 41);
            this.GirisBtn.TabIndex = 49;
            this.GirisBtn.Text = "GİRİŞ";
            this.GirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // GirisRestOtoLbl
            // 
            this.GirisRestOtoLbl.AutoSize = true;
            this.GirisRestOtoLbl.Font = new System.Drawing.Font("Arial", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisRestOtoLbl.ForeColor = System.Drawing.Color.White;
            this.GirisRestOtoLbl.Location = new System.Drawing.Point(47, 76);
            this.GirisRestOtoLbl.Name = "GirisRestOtoLbl";
            this.GirisRestOtoLbl.Size = new System.Drawing.Size(364, 96);
            this.GirisRestOtoLbl.TabIndex = 50;
            this.GirisRestOtoLbl.Text = "RestOto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "İŞLETME SİSTEMİ";
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GirisRestOtoLbl);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.GirisKullaniciAdiTBox);
            this.Controls.Add(this.GirisParolaTbox);
            this.Controls.Add(this.GirisKullaniciAdiLbl);
            this.Controls.Add(this.GirisParolaLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisFormu";
            this.Text = "RestOto";
            this.Load += new System.EventHandler(this.GirisFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GirisParolaLbl;
        private System.Windows.Forms.Label GirisKullaniciAdiLbl;
        private System.Windows.Forms.TextBox GirisParolaTbox;
        private System.Windows.Forms.TextBox GirisKullaniciAdiTBox;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Label GirisRestOtoLbl;
        private System.Windows.Forms.Label label1;
    }
}