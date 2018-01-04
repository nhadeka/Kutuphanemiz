namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKullaniciEkle
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
            this.mtxtTelno = new System.Windows.Forms.MaskedTextBox();
            this.cbSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.dtpUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIlIlce = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcKNo = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtTelno
            // 
            this.mtxtTelno.Location = new System.Drawing.Point(166, 153);
            this.mtxtTelno.Mask = "(999) 000-0000";
            this.mtxtTelno.Name = "mtxtTelno";
            this.mtxtTelno.Size = new System.Drawing.Size(111, 20);
            this.mtxtTelno.TabIndex = 6;
            // 
            // cbSifreGoster
            // 
            this.cbSifreGoster.AutoSize = true;
            this.cbSifreGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSifreGoster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.cbSifreGoster.Location = new System.Drawing.Point(283, 118);
            this.cbSifreGoster.Name = "cbSifreGoster";
            this.cbSifreGoster.Size = new System.Drawing.Size(129, 17);
            this.cbSifreGoster.TabIndex = 254;
            this.cbSifreGoster.Text = "ŞİFREYİ GÖSTER";
            this.cbSifreGoster.UseVisualStyleBackColor = true;
            this.cbSifreGoster.CheckedChanged += new System.EventHandler(this.cbSifreGoster_CheckedChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnKaydet.Location = new System.Drawing.Point(194, 375);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(111, 32);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtIlce
            // 
            this.txtIlce.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.Location = new System.Drawing.Point(262, 257);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(92, 20);
            this.txtIlce.TabIndex = 8;
            // 
            // txtIl
            // 
            this.txtIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIl.Location = new System.Drawing.Point(166, 257);
            this.txtIl.Margin = new System.Windows.Forms.Padding(2);
            this.txtIl.Name = "txtIl";
            this.txtIl.ReadOnly = true;
            this.txtIl.Size = new System.Drawing.Size(92, 20);
            this.txtIl.TabIndex = 249;
            this.txtIl.Text = "İstanbul";
            this.txtIl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpUyelikTarihi
            // 
            this.dtpUyelikTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpUyelikTarihi.Location = new System.Drawing.Point(166, 220);
            this.dtpUyelikTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUyelikTarihi.Name = "dtpUyelikTarihi";
            this.dtpUyelikTarihi.Size = new System.Drawing.Size(188, 20);
            this.dtpUyelikTarihi.TabIndex = 248;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(166, 295);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(188, 64);
            this.txtAdres.TabIndex = 9;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAdres.Location = new System.Drawing.Point(23, 299);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 13);
            this.lblAdres.TabIndex = 246;
            this.lblAdres.Text = "ADRES";
            // 
            // lblIlIlce
            // 
            this.lblIlIlce.AutoSize = true;
            this.lblIlIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblIlIlce.Location = new System.Drawing.Point(23, 262);
            this.lblIlIlce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlIlce.Name = "lblIlIlce";
            this.lblIlIlce.Size = new System.Drawing.Size(59, 13);
            this.lblIlIlce.TabIndex = 245;
            this.lblIlIlce.Text = "İL / İLÇE";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTarih.Location = new System.Drawing.Point(23, 225);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(118, 13);
            this.lblTarih.TabIndex = 244;
            this.lblTarih.Text = "ÜYE KAYIT TARİHİ";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(166, 117);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(111, 20);
            this.txtSifre.TabIndex = 5;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblSifre.Location = new System.Drawing.Point(24, 116);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(43, 13);
            this.lblSifre.TabIndex = 242;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(166, 187);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(111, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(166, 84);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(111, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(166, 51);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(111, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtTcKNo
            // 
            this.txtTcKNo.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKNo.Location = new System.Drawing.Point(166, 15);
            this.txtTcKNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKNo.MaxLength = 11;
            this.txtTcKNo.Name = "txtTcKNo";
            this.txtTcKNo.Size = new System.Drawing.Size(111, 20);
            this.txtTcKNo.TabIndex = 1;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblEposta.Location = new System.Drawing.Point(25, 189);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(60, 13);
            this.lblEposta.TabIndex = 237;
            this.lblEposta.Text = "E-POSTA";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTelefon.Location = new System.Drawing.Point(24, 151);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(63, 13);
            this.lblTelefon.TabIndex = 236;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblSoyad.Location = new System.Drawing.Point(24, 83);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(49, 13);
            this.lblSoyad.TabIndex = 235;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAd.Location = new System.Drawing.Point(24, 53);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 13);
            this.lblAd.TabIndex = 234;
            this.lblAd.Text = "AD";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTc.Location = new System.Drawing.Point(24, 17);
            this.lblTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(90, 13);
            this.lblTc.TabIndex = 233;
            this.lblTc.Text = "TC KİMLİK NO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTc);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.mtxtTelno);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.cbSifreGoster);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.lblEposta);
            this.panel1.Controls.Add(this.txtTcKNo);
            this.panel1.Controls.Add(this.txtIlce);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtIl);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.dtpUyelikTarihi);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.lblIlIlce);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Location = new System.Drawing.Point(327, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 418);
            this.panel1.TabIndex = 256;
            // 
            // FrmKullaniciEkle
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKullaniciEkle";
            this.Text = "FrmKullaniciEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtTelno;
        private System.Windows.Forms.CheckBox cbSifreGoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.DateTimePicker dtpUyelikTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblIlIlce;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcKNo;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Panel panel1;
    }
}