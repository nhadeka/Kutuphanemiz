namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKitapAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapAra));
            this.btnTumKitaplariGetir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.pnlKategori = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.pnlKitapAd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.pnlYazaraGore = new System.Windows.Forms.Panel();
            this.rbKategoriyeGore = new System.Windows.Forms.RadioButton();
            this.rbYazaraGore = new System.Windows.Forms.RadioButton();
            this.rbKitapAdinagore = new System.Windows.Forms.RadioButton();
            this.pnlRbtn = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.pnlKapsayici2 = new System.Windows.Forms.Panel();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlButon = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            this.pnlKategori.SuspendLayout();
            this.pnlKitapAd.SuspendLayout();
            this.pnlYazaraGore.SuspendLayout();
            this.pnlRbtn.SuspendLayout();
            this.pnlKapsayici2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.pnlKapsayici.SuspendLayout();
            this.pnlButon.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTumKitaplariGetir
            // 
            this.btnTumKitaplariGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnTumKitaplariGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumKitaplariGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumKitaplariGetir.ForeColor = System.Drawing.Color.White;
            this.btnTumKitaplariGetir.Location = new System.Drawing.Point(486, 151);
            this.btnTumKitaplariGetir.Name = "btnTumKitaplariGetir";
            this.btnTumKitaplariGetir.Size = new System.Drawing.Size(167, 29);
            this.btnTumKitaplariGetir.TabIndex = 47;
            this.btnTumKitaplariGetir.Text = "TÜM KİTAPLARI GETİR";
            this.btnTumKitaplariGetir.UseVisualStyleBackColor = false;
            this.btnTumKitaplariGetir.Click += new System.EventHandler(this.btnTumKitaplariGetir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "YAZAR";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(77, 14);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(151, 20);
            this.txtYazar.TabIndex = 2;
            // 
            // pnlKategori
            // 
            this.pnlKategori.Controls.Add(this.label4);
            this.pnlKategori.Controls.Add(this.cbKategoriler);
            this.pnlKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlKategori.Location = new System.Drawing.Point(235, 64);
            this.pnlKategori.Name = "pnlKategori";
            this.pnlKategori.Size = new System.Drawing.Size(249, 51);
            this.pnlKategori.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "KATEGORİ";
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(78, 14);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(151, 21);
            this.cbKategoriler.TabIndex = 42;
            // 
            // pnlKitapAd
            // 
            this.pnlKitapAd.Controls.Add(this.label1);
            this.pnlKitapAd.Controls.Add(this.txtKitapAd);
            this.pnlKitapAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlKitapAd.Location = new System.Drawing.Point(235, 64);
            this.pnlKitapAd.Name = "pnlKitapAd";
            this.pnlKitapAd.Size = new System.Drawing.Size(249, 51);
            this.pnlKitapAd.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP AD";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(78, 13);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(151, 20);
            this.txtKitapAd.TabIndex = 0;
            // 
            // pnlYazaraGore
            // 
            this.pnlYazaraGore.Controls.Add(this.label2);
            this.pnlYazaraGore.Controls.Add(this.txtYazar);
            this.pnlYazaraGore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlYazaraGore.Location = new System.Drawing.Point(235, 64);
            this.pnlYazaraGore.Name = "pnlYazaraGore";
            this.pnlYazaraGore.Size = new System.Drawing.Size(249, 51);
            this.pnlYazaraGore.TabIndex = 45;
            // 
            // rbKategoriyeGore
            // 
            this.rbKategoriyeGore.AutoSize = true;
            this.rbKategoriyeGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKategoriyeGore.Location = new System.Drawing.Point(12, 96);
            this.rbKategoriyeGore.Name = "rbKategoriyeGore";
            this.rbKategoriyeGore.Size = new System.Drawing.Size(143, 17);
            this.rbKategoriyeGore.TabIndex = 2;
            this.rbKategoriyeGore.Text = "KATEGORİYE GÖRE";
            this.rbKategoriyeGore.UseVisualStyleBackColor = true;
            this.rbKategoriyeGore.CheckedChanged += new System.EventHandler(this.rbKategoriyeGore_CheckedChanged);
            // 
            // rbYazaraGore
            // 
            this.rbYazaraGore.AutoSize = true;
            this.rbYazaraGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYazaraGore.Location = new System.Drawing.Point(12, 59);
            this.rbYazaraGore.Name = "rbYazaraGore";
            this.rbYazaraGore.Size = new System.Drawing.Size(113, 17);
            this.rbYazaraGore.TabIndex = 1;
            this.rbYazaraGore.Text = "YAZARA GÖRE";
            this.rbYazaraGore.UseVisualStyleBackColor = true;
            this.rbYazaraGore.CheckedChanged += new System.EventHandler(this.rbYazaraGore_CheckedChanged);
            // 
            // rbKitapAdinagore
            // 
            this.rbKitapAdinagore.AutoSize = true;
            this.rbKitapAdinagore.Checked = true;
            this.rbKitapAdinagore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKitapAdinagore.Location = new System.Drawing.Point(12, 24);
            this.rbKitapAdinagore.Name = "rbKitapAdinagore";
            this.rbKitapAdinagore.Size = new System.Drawing.Size(142, 17);
            this.rbKitapAdinagore.TabIndex = 0;
            this.rbKitapAdinagore.TabStop = true;
            this.rbKitapAdinagore.Text = "KİTAP ADINA GÖRE";
            this.rbKitapAdinagore.UseVisualStyleBackColor = true;
            this.rbKitapAdinagore.CheckedChanged += new System.EventHandler(this.rbKitapAdinagore_CheckedChanged);
            // 
            // pnlRbtn
            // 
            this.pnlRbtn.Controls.Add(this.rbKategoriyeGore);
            this.pnlRbtn.Controls.Add(this.rbYazaraGore);
            this.pnlRbtn.Controls.Add(this.rbKitapAdinagore);
            this.pnlRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlRbtn.Location = new System.Drawing.Point(38, 28);
            this.pnlRbtn.Name = "pnlRbtn";
            this.pnlRbtn.Size = new System.Drawing.Size(170, 134);
            this.pnlRbtn.TabIndex = 26;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(504, 71);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(76, 32);
            this.btnAra.TabIndex = 25;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pnlKapsayici2
            // 
            this.pnlKapsayici2.Controls.Add(this.btnTumKitaplariGetir);
            this.pnlKapsayici2.Controls.Add(this.pnlRbtn);
            this.pnlKapsayici2.Controls.Add(this.pnlKategori);
            this.pnlKapsayici2.Controls.Add(this.pnlKitapAd);
            this.pnlKapsayici2.Controls.Add(this.pnlYazaraGore);
            this.pnlKapsayici2.Controls.Add(this.btnAra);
            this.pnlKapsayici2.Location = new System.Drawing.Point(131, 9);
            this.pnlKapsayici2.Name = "pnlKapsayici2";
            this.pnlKapsayici2.Size = new System.Drawing.Size(656, 183);
            this.pnlKapsayici2.TabIndex = 49;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AllowUserToAddRows = false;
            this.dgvKitaplar.AllowUserToDeleteRows = false;
            this.dgvKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.dgvKitaplar.Location = new System.Drawing.Point(84, 197);
            this.dgvKitaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.RowTemplate.Height = 24;
            this.dgvKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitaplar.Size = new System.Drawing.Size(736, 311);
            this.dgvKitaplar.TabIndex = 48;
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKapsayici.BackColor = System.Drawing.Color.White;
            this.pnlKapsayici.Controls.Add(this.pnlButon);
            this.pnlKapsayici.Controls.Add(this.pnlFormlar);
            this.pnlKapsayici.Location = new System.Drawing.Point(23, 17);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(1072, 708);
            this.pnlKapsayici.TabIndex = 50;
            // 
            // pnlButon
            // 
            this.pnlButon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButon.Controls.Add(this.btnCikis);
            this.pnlButon.Controls.Add(this.btnMenu);
            this.pnlButon.Location = new System.Drawing.Point(7, 628);
            this.pnlButon.Name = "pnlButon";
            this.pnlButon.Size = new System.Drawing.Size(1062, 77);
            this.pnlButon.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(967, 12);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 50);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(24, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 50);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.dgvKitaplar);
            this.pnlFormlar.Controls.Add(this.pnlKapsayici2);
            this.pnlFormlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlFormlar.Location = new System.Drawing.Point(93, 88);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(897, 522);
            this.pnlFormlar.TabIndex = 1;
            // 
            // FrmKitapAra
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1116, 741);
            this.Controls.Add(this.pnlKapsayici);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitapAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapAra";
            this.Load += new System.EventHandler(this.FrmKitapAra_Load);
            this.pnlKategori.ResumeLayout(false);
            this.pnlKategori.PerformLayout();
            this.pnlKitapAd.ResumeLayout(false);
            this.pnlKitapAd.PerformLayout();
            this.pnlYazaraGore.ResumeLayout(false);
            this.pnlYazaraGore.PerformLayout();
            this.pnlRbtn.ResumeLayout(false);
            this.pnlRbtn.PerformLayout();
            this.pnlKapsayici2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlButon.ResumeLayout(false);
            this.pnlFormlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTumKitaplariGetir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Panel pnlKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Panel pnlKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Panel pnlYazaraGore;
        private System.Windows.Forms.RadioButton rbKategoriyeGore;
        private System.Windows.Forms.RadioButton rbYazaraGore;
        private System.Windows.Forms.RadioButton rbKitapAdinagore;
        private System.Windows.Forms.Panel pnlRbtn;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel pnlKapsayici2;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlFormlar;
        private System.Windows.Forms.Panel pnlButon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMenu;
    }
}