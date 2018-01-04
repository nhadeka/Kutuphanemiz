namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKullaniciGuncelle
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
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.txtIl = new System.Windows.Forms.TextBox();
            this.dtpUyelikTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIlIlce = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtKullaniciTuru = new System.Windows.Forms.TextBox();
            this.lblKullaniciTuru = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcKNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlAdSoyadaGore = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnTumUyeleriGetir = new System.Windows.Forms.Button();
            this.pnlRbtn = new System.Windows.Forms.Panel();
            this.rbKullaniciIDGore = new System.Windows.Forms.RadioButton();
            this.rbAdSoyadaGore = new System.Windows.Forms.RadioButton();
            this.pnlKullaniciIDyeGore = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlKapsayici.SuspendLayout();
            this.pnlAdSoyadaGore.SuspendLayout();
            this.pnlRbtn.SuspendLayout();
            this.pnlKullaniciIDyeGore.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtTelno
            // 
            this.mtxtTelno.Location = new System.Drawing.Point(137, 141);
            this.mtxtTelno.Mask = "(999) 000-0000";
            this.mtxtTelno.Name = "mtxtTelno";
            this.mtxtTelno.Size = new System.Drawing.Size(111, 20);
            this.mtxtTelno.TabIndex = 5;
            // 
            // txtIlce
            // 
            this.txtIlce.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.Location = new System.Drawing.Point(234, 211);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(92, 20);
            this.txtIlce.TabIndex = 7;
            // 
            // txtIl
            // 
            this.txtIl.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIl.Location = new System.Drawing.Point(137, 208);
            this.txtIl.Margin = new System.Windows.Forms.Padding(2);
            this.txtIl.Name = "txtIl";
            this.txtIl.ReadOnly = true;
            this.txtIl.Size = new System.Drawing.Size(92, 20);
            this.txtIl.TabIndex = 298;
            this.txtIl.Text = "İstanbul";
            this.txtIl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpUyelikTarihi
            // 
            this.dtpUyelikTarihi.Enabled = false;
            this.dtpUyelikTarihi.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpUyelikTarihi.Location = new System.Drawing.Point(137, 186);
            this.dtpUyelikTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUyelikTarihi.Name = "dtpUyelikTarihi";
            this.dtpUyelikTarihi.Size = new System.Drawing.Size(188, 20);
            this.dtpUyelikTarihi.TabIndex = 297;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(137, 233);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(188, 64);
            this.txtAdres.TabIndex = 8;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAdres.Location = new System.Drawing.Point(11, 236);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 13);
            this.lblAdres.TabIndex = 295;
            this.lblAdres.Text = "ADRES";
            // 
            // lblIlIlce
            // 
            this.lblIlIlce.AutoSize = true;
            this.lblIlIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblIlIlce.Location = new System.Drawing.Point(11, 213);
            this.lblIlIlce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlIlce.Name = "lblIlIlce";
            this.lblIlIlce.Size = new System.Drawing.Size(59, 13);
            this.lblIlIlce.TabIndex = 294;
            this.lblIlIlce.Text = "İL / İLÇE";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTarih.Location = new System.Drawing.Point(11, 188);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(118, 13);
            this.lblTarih.TabIndex = 293;
            this.lblTarih.Text = "ÜYE KAYIT TARİHİ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(137, 163);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(111, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblEposta.Location = new System.Drawing.Point(13, 164);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(60, 13);
            this.lblEposta.TabIndex = 291;
            this.lblEposta.Text = "E-POSTA";
            // 
            // txtKullaniciTuru
            // 
            this.txtKullaniciTuru.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciTuru.Location = new System.Drawing.Point(137, 45);
            this.txtKullaniciTuru.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciTuru.Name = "txtKullaniciTuru";
            this.txtKullaniciTuru.Size = new System.Drawing.Size(111, 20);
            this.txtKullaniciTuru.TabIndex = 2;
            // 
            // lblKullaniciTuru
            // 
            this.lblKullaniciTuru.AutoSize = true;
            this.lblKullaniciTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblKullaniciTuru.Location = new System.Drawing.Point(13, 45);
            this.lblKullaniciTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciTuru.Name = "lblKullaniciTuru";
            this.lblKullaniciTuru.Size = new System.Drawing.Size(110, 13);
            this.lblKullaniciTuru.TabIndex = 289;
            this.lblKullaniciTuru.Text = "KULLANICI TÜRÜ";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(137, 116);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.ReadOnly = true;
            this.txtSifre.Size = new System.Drawing.Size(111, 20);
            this.txtSifre.TabIndex = 288;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblSifre.Location = new System.Drawing.Point(13, 114);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(43, 13);
            this.lblSifre.TabIndex = 287;
            this.lblSifre.Text = "ŞİFRE";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(137, 91);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(111, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(137, 68);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(111, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtTcKNo
            // 
            this.txtTcKNo.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKNo.Location = new System.Drawing.Point(137, 21);
            this.txtTcKNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKNo.Name = "txtTcKNo";
            this.txtTcKNo.Size = new System.Drawing.Size(111, 20);
            this.txtTcKNo.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTelefon.Location = new System.Drawing.Point(13, 138);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(63, 13);
            this.lblTelefon.TabIndex = 283;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblSoyad.Location = new System.Drawing.Point(13, 89);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(49, 13);
            this.lblSoyad.TabIndex = 282;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAd.Location = new System.Drawing.Point(13, 69);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 13);
            this.lblAd.TabIndex = 281;
            this.lblAd.Text = "AD";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTc.Location = new System.Drawing.Point(13, 23);
            this.lblTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(90, 13);
            this.lblTc.TabIndex = 280;
            this.lblTc.Text = "TC KİMLİK NO";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnSil.Enabled = false;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSil.Location = new System.Drawing.Point(233, 326);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 28);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = " SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(103, 326);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(98, 28);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToDeleteRows = false;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.dgvKullanicilar.Location = new System.Drawing.Point(28, 220);
            this.dgvKullanicilar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(662, 288);
            this.dgvKullanicilar.TabIndex = 277;
            this.dgvKullanicilar.DoubleClick += new System.EventHandler(this.dgvKullanicilar_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTc);
            this.panel1.Controls.Add(this.mtxtTelno);
            this.panel1.Controls.Add(this.txtIlce);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtIl);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.dtpUyelikTarihi);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.lblIlIlce);
            this.panel1.Controls.Add(this.txtTcKNo);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.lblEposta);
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.txtKullaniciTuru);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.lblKullaniciTuru);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.panel1.Location = new System.Drawing.Point(707, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 395);
            this.panel1.TabIndex = 301;
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Controls.Add(this.pnlAdSoyadaGore);
            this.pnlKapsayici.Controls.Add(this.btnTumUyeleriGetir);
            this.pnlKapsayici.Controls.Add(this.pnlRbtn);
            this.pnlKapsayici.Controls.Add(this.pnlKullaniciIDyeGore);
            this.pnlKapsayici.Controls.Add(this.btnAra);
            this.pnlKapsayici.Location = new System.Drawing.Point(29, 32);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(656, 183);
            this.pnlKapsayici.TabIndex = 302;
            // 
            // pnlAdSoyadaGore
            // 
            this.pnlAdSoyadaGore.Controls.Add(this.label8);
            this.pnlAdSoyadaGore.Controls.Add(this.txtKullanici);
            this.pnlAdSoyadaGore.Location = new System.Drawing.Point(235, 64);
            this.pnlAdSoyadaGore.Name = "pnlAdSoyadaGore";
            this.pnlAdSoyadaGore.Size = new System.Drawing.Size(249, 51);
            this.pnlAdSoyadaGore.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "AD SOYAD";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(78, 13);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(151, 20);
            this.txtKullanici.TabIndex = 0;
            // 
            // btnTumUyeleriGetir
            // 
            this.btnTumUyeleriGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnTumUyeleriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumUyeleriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumUyeleriGetir.ForeColor = System.Drawing.Color.White;
            this.btnTumUyeleriGetir.Location = new System.Drawing.Point(504, 148);
            this.btnTumUyeleriGetir.Name = "btnTumUyeleriGetir";
            this.btnTumUyeleriGetir.Size = new System.Drawing.Size(149, 30);
            this.btnTumUyeleriGetir.TabIndex = 47;
            this.btnTumUyeleriGetir.Text = "TÜM ÜYELERİ GETİR";
            this.btnTumUyeleriGetir.UseVisualStyleBackColor = false;
            this.btnTumUyeleriGetir.Click += new System.EventHandler(this.btnTumUyeleriGetir_Click);
            // 
            // pnlRbtn
            // 
            this.pnlRbtn.Controls.Add(this.rbKullaniciIDGore);
            this.pnlRbtn.Controls.Add(this.rbAdSoyadaGore);
            this.pnlRbtn.Location = new System.Drawing.Point(41, 43);
            this.pnlRbtn.Name = "pnlRbtn";
            this.pnlRbtn.Size = new System.Drawing.Size(170, 96);
            this.pnlRbtn.TabIndex = 26;
            // 
            // rbKullaniciIDGore
            // 
            this.rbKullaniciIDGore.AutoSize = true;
            this.rbKullaniciIDGore.Checked = true;
            this.rbKullaniciIDGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKullaniciIDGore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rbKullaniciIDGore.Location = new System.Drawing.Point(3, 21);
            this.rbKullaniciIDGore.Name = "rbKullaniciIDGore";
            this.rbKullaniciIDGore.Size = new System.Drawing.Size(145, 17);
            this.rbKullaniciIDGore.TabIndex = 2;
            this.rbKullaniciIDGore.TabStop = true;
            this.rbKullaniciIDGore.Text = "ÜYE NOSUNA GÖRE";
            this.rbKullaniciIDGore.UseVisualStyleBackColor = true;
            this.rbKullaniciIDGore.CheckedChanged += new System.EventHandler(this.rbKullaniciIDGore_CheckedChanged);
            // 
            // rbAdSoyadaGore
            // 
            this.rbAdSoyadaGore.AutoSize = true;
            this.rbAdSoyadaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdSoyadaGore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rbAdSoyadaGore.Location = new System.Drawing.Point(3, 54);
            this.rbAdSoyadaGore.Name = "rbAdSoyadaGore";
            this.rbAdSoyadaGore.Size = new System.Drawing.Size(135, 17);
            this.rbAdSoyadaGore.TabIndex = 1;
            this.rbAdSoyadaGore.Text = "AD SOYADA GÖRE";
            this.rbAdSoyadaGore.UseVisualStyleBackColor = true;
            this.rbAdSoyadaGore.CheckedChanged += new System.EventHandler(this.rbAdSoyadaGore_CheckedChanged);
            // 
            // pnlKullaniciIDyeGore
            // 
            this.pnlKullaniciIDyeGore.Controls.Add(this.label10);
            this.pnlKullaniciIDyeGore.Controls.Add(this.txtKullaniciID);
            this.pnlKullaniciIDyeGore.Location = new System.Drawing.Point(235, 64);
            this.pnlKullaniciIDyeGore.Name = "pnlKullaniciIDyeGore";
            this.pnlKullaniciIDyeGore.Size = new System.Drawing.Size(249, 51);
            this.pnlKullaniciIDyeGore.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label10.Location = new System.Drawing.Point(11, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "ÜYE NO";
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(77, 14);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(151, 20);
            this.txtKullaniciID.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(504, 69);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(71, 35);
            this.btnAra.TabIndex = 25;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmKullaniciGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.pnlKapsayici);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKullaniciGuncelle";
            this.Text = "FrmKullaniciGuncelle";
            this.Load += new System.EventHandler(this.FrmKullaniciGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlAdSoyadaGore.ResumeLayout(false);
            this.pnlAdSoyadaGore.PerformLayout();
            this.pnlRbtn.ResumeLayout(false);
            this.pnlRbtn.PerformLayout();
            this.pnlKullaniciIDyeGore.ResumeLayout(false);
            this.pnlKullaniciIDyeGore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtTelno;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.DateTimePicker dtpUyelikTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblIlIlce;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtKullaniciTuru;
        private System.Windows.Forms.Label lblKullaniciTuru;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcKNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlAdSoyadaGore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Button btnTumUyeleriGetir;
        private System.Windows.Forms.Panel pnlRbtn;
        private System.Windows.Forms.RadioButton rbKullaniciIDGore;
        private System.Windows.Forms.RadioButton rbAdSoyadaGore;
        private System.Windows.Forms.Panel pnlKullaniciIDyeGore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Button btnAra;
    }
}