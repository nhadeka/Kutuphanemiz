namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKitapGuncelle
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
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYayineviAd = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNosu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlKitapaGore = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.btnTumKitaplariGetir = new System.Windows.Forms.Button();
            this.pnlBarkodaGore = new System.Windows.Forms.Panel();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRbtn = new System.Windows.Forms.Panel();
            this.rbKitapAdinaGore = new System.Windows.Forms.RadioButton();
            this.rbBarkodaGore = new System.Windows.Forms.RadioButton();
            this.rbYazaraGore = new System.Windows.Forms.RadioButton();
            this.pnlYazaraGore = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlKapsayici.SuspendLayout();
            this.pnlKitapaGore.SuspendLayout();
            this.pnlBarkodaGore.SuspendLayout();
            this.pnlRbtn.SuspendLayout();
            this.pnlYazaraGore.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(136, 169);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(151, 21);
            this.cbKategoriler.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "KATEGORİ";
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(135, 101);
            this.txtYazarSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(152, 20);
            this.txtYazarSoyad.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(29, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "YAZAR SOYAD";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(135, 74);
            this.txtYazarAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(152, 20);
            this.txtYazarAd.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "YAZAR AD";
            // 
            // txtYayineviAd
            // 
            this.txtYayineviAd.Location = new System.Drawing.Point(135, 137);
            this.txtYayineviAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtYayineviAd.Name = "txtYayineviAd";
            this.txtYayineviAd.Size = new System.Drawing.Size(152, 20);
            this.txtYayineviAd.TabIndex = 5;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(135, 48);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(152, 20);
            this.txtKitapAdi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "YAYINEVİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "KİTAP AD";
            // 
            // txtBarkodNosu
            // 
            this.txtBarkodNosu.Location = new System.Drawing.Point(135, 25);
            this.txtBarkodNosu.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkodNosu.Name = "txtBarkodNosu";
            this.txtBarkodNosu.Size = new System.Drawing.Size(152, 20);
            this.txtBarkodNosu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "BARKOD";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(90, 251);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(87, 29);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(217, 251);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 29);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.dgvKitaplar.Location = new System.Drawing.Point(8, 207);
            this.dgvKitaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(690, 278);
            this.dgvKitaplar.TabIndex = 43;
            this.dgvKitaplar.DoubleClick += new System.EventHandler(this.dgvKitaplar_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtBarkodNosu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbKategoriler);
            this.panel1.Controls.Add(this.txtKitapAdi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtYayineviAd);
            this.panel1.Controls.Add(this.txtYazarSoyad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtYazarAd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(713, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 322);
            this.panel1.TabIndex = 60;
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Controls.Add(this.pnlKitapaGore);
            this.pnlKapsayici.Controls.Add(this.btnTumKitaplariGetir);
            this.pnlKapsayici.Controls.Add(this.pnlBarkodaGore);
            this.pnlKapsayici.Controls.Add(this.pnlRbtn);
            this.pnlKapsayici.Controls.Add(this.pnlYazaraGore);
            this.pnlKapsayici.Controls.Add(this.btnAra);
            this.pnlKapsayici.Location = new System.Drawing.Point(25, 14);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(656, 183);
            this.pnlKapsayici.TabIndex = 61;
            // 
            // pnlKitapaGore
            // 
            this.pnlKitapaGore.Controls.Add(this.label8);
            this.pnlKitapaGore.Controls.Add(this.txtKitapAd);
            this.pnlKitapaGore.Location = new System.Drawing.Point(235, 64);
            this.pnlKitapaGore.Name = "pnlKitapaGore";
            this.pnlKitapaGore.Size = new System.Drawing.Size(249, 51);
            this.pnlKitapaGore.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "KİTAP AD";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(78, 13);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(151, 20);
            this.txtKitapAd.TabIndex = 0;
            // 
            // btnTumKitaplariGetir
            // 
            this.btnTumKitaplariGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnTumKitaplariGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumKitaplariGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumKitaplariGetir.ForeColor = System.Drawing.Color.White;
            this.btnTumKitaplariGetir.Location = new System.Drawing.Point(490, 152);
            this.btnTumKitaplariGetir.Name = "btnTumKitaplariGetir";
            this.btnTumKitaplariGetir.Size = new System.Drawing.Size(163, 28);
            this.btnTumKitaplariGetir.TabIndex = 47;
            this.btnTumKitaplariGetir.Text = "TÜM KİTAPLARI GETİR";
            this.btnTumKitaplariGetir.UseVisualStyleBackColor = false;
            this.btnTumKitaplariGetir.Click += new System.EventHandler(this.btnTumKitaplariGetir_Click);
            // 
            // pnlBarkodaGore
            // 
            this.pnlBarkodaGore.Controls.Add(this.txtBarkod);
            this.pnlBarkodaGore.Controls.Add(this.label3);
            this.pnlBarkodaGore.Location = new System.Drawing.Point(235, 64);
            this.pnlBarkodaGore.Name = "pnlBarkodaGore";
            this.pnlBarkodaGore.Size = new System.Drawing.Size(249, 51);
            this.pnlBarkodaGore.TabIndex = 44;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(78, 14);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(151, 20);
            this.txtBarkod.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "BARKOD";
            // 
            // pnlRbtn
            // 
            this.pnlRbtn.Controls.Add(this.rbKitapAdinaGore);
            this.pnlRbtn.Controls.Add(this.rbBarkodaGore);
            this.pnlRbtn.Controls.Add(this.rbYazaraGore);
            this.pnlRbtn.Location = new System.Drawing.Point(38, 28);
            this.pnlRbtn.Name = "pnlRbtn";
            this.pnlRbtn.Size = new System.Drawing.Size(170, 134);
            this.pnlRbtn.TabIndex = 26;
            // 
            // rbKitapAdinaGore
            // 
            this.rbKitapAdinaGore.AutoSize = true;
            this.rbKitapAdinaGore.Checked = true;
            this.rbKitapAdinaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKitapAdinaGore.Location = new System.Drawing.Point(14, 25);
            this.rbKitapAdinaGore.Name = "rbKitapAdinaGore";
            this.rbKitapAdinaGore.Size = new System.Drawing.Size(142, 17);
            this.rbKitapAdinaGore.TabIndex = 2;
            this.rbKitapAdinaGore.TabStop = true;
            this.rbKitapAdinaGore.Text = "KİTAP ADINA GÖRE";
            this.rbKitapAdinaGore.UseVisualStyleBackColor = true;
            this.rbKitapAdinaGore.CheckedChanged += new System.EventHandler(this.rbKitapAdinaGore_CheckedChanged);
            // 
            // rbBarkodaGore
            // 
            this.rbBarkodaGore.AutoSize = true;
            this.rbBarkodaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBarkodaGore.Location = new System.Drawing.Point(14, 58);
            this.rbBarkodaGore.Name = "rbBarkodaGore";
            this.rbBarkodaGore.Size = new System.Drawing.Size(123, 17);
            this.rbBarkodaGore.TabIndex = 1;
            this.rbBarkodaGore.Text = "BARKODA GÖRE";
            this.rbBarkodaGore.UseVisualStyleBackColor = true;
            this.rbBarkodaGore.CheckedChanged += new System.EventHandler(this.rbBarkodaGore_CheckedChanged);
            // 
            // rbYazaraGore
            // 
            this.rbYazaraGore.AutoSize = true;
            this.rbYazaraGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYazaraGore.Location = new System.Drawing.Point(14, 90);
            this.rbYazaraGore.Name = "rbYazaraGore";
            this.rbYazaraGore.Size = new System.Drawing.Size(113, 17);
            this.rbYazaraGore.TabIndex = 0;
            this.rbYazaraGore.Text = "YAZARA GÖRE";
            this.rbYazaraGore.UseVisualStyleBackColor = true;
            this.rbYazaraGore.CheckedChanged += new System.EventHandler(this.rbYazaraGore_CheckedChanged);
            // 
            // pnlYazaraGore
            // 
            this.pnlYazaraGore.Controls.Add(this.label10);
            this.pnlYazaraGore.Controls.Add(this.txtYazar);
            this.pnlYazaraGore.Location = new System.Drawing.Point(235, 64);
            this.pnlYazaraGore.Name = "pnlYazaraGore";
            this.pnlYazaraGore.Size = new System.Drawing.Size(249, 51);
            this.pnlYazaraGore.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(11, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "YAZAR";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(77, 14);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(151, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(504, 70);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 32);
            this.btnAra.TabIndex = 25;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmKitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.pnlKapsayici);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitapGuncelle";
            this.Text = "FrmKitapGuncelle";
            this.Load += new System.EventHandler(this.FrmKitapGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlKitapaGore.ResumeLayout(false);
            this.pnlKitapaGore.PerformLayout();
            this.pnlBarkodaGore.ResumeLayout(false);
            this.pnlBarkodaGore.PerformLayout();
            this.pnlRbtn.ResumeLayout(false);
            this.pnlRbtn.PerformLayout();
            this.pnlYazaraGore.ResumeLayout(false);
            this.pnlYazaraGore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYayineviAd;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodNosu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlKitapaGore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Button btnTumKitaplariGetir;
        private System.Windows.Forms.Panel pnlRbtn;
        private System.Windows.Forms.RadioButton rbKitapAdinaGore;
        private System.Windows.Forms.RadioButton rbBarkodaGore;
        private System.Windows.Forms.RadioButton rbYazaraGore;
        private System.Windows.Forms.Panel pnlBarkodaGore;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlYazaraGore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Button btnAra;
    }
}