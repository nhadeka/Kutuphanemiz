namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKullanicilarRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.kullanicilarRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphanemizDataSet = new Kutuphanemiz.UI.KutuphanemizDataSet();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.pnlKullaniciKapsayici = new System.Windows.Forms.Panel();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbKullaniciyaGore = new System.Windows.Forms.RadioButton();
            this.rbAdminKayitlari = new System.Windows.Forms.RadioButton();
            this.rbUyeKayitlari = new System.Windows.Forms.RadioButton();
            this.rbSilinmisUyeler = new System.Windows.Forms.RadioButton();
            this.rbTumKullanicilar = new System.Windows.Forms.RadioButton();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kullanicilarRaporTableAdapter = new Kutuphanemiz.UI.KutuphanemizDataSetTableAdapters.KullanicilarRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).BeginInit();
            this.pnlKapsayici.SuspendLayout();
            this.pnlButonlar.SuspendLayout();
            this.pnlKullaniciKapsayici.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanicilarRaporBindingSource
            // 
            this.kullanicilarRaporBindingSource.DataMember = "KullanicilarRapor";
            this.kullanicilarRaporBindingSource.DataSource = this.kutuphanemizDataSet;
            // 
            // kutuphanemizDataSet
            // 
            this.kutuphanemizDataSet.DataSetName = "KutuphanemizDataSet";
            this.kutuphanemizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKapsayici.Controls.Add(this.pnlButonlar);
            this.pnlKapsayici.Controls.Add(this.pnlFormlar);
            this.pnlKapsayici.Location = new System.Drawing.Point(12, 0);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(1028, 540);
            this.pnlKapsayici.TabIndex = 52;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Controls.Add(this.pnlKullaniciKapsayici);
            this.pnlButonlar.Controls.Add(this.rbKullaniciyaGore);
            this.pnlButonlar.Controls.Add(this.rbAdminKayitlari);
            this.pnlButonlar.Controls.Add(this.rbUyeKayitlari);
            this.pnlButonlar.Controls.Add(this.rbSilinmisUyeler);
            this.pnlButonlar.Controls.Add(this.rbTumKullanicilar);
            this.pnlButonlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlButonlar.Location = new System.Drawing.Point(23, 16);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(981, 78);
            this.pnlButonlar.TabIndex = 18;
            // 
            // pnlKullaniciKapsayici
            // 
            this.pnlKullaniciKapsayici.Controls.Add(this.txtKullanici);
            this.pnlKullaniciKapsayici.Controls.Add(this.btnAra);
            this.pnlKullaniciKapsayici.Controls.Add(this.label1);
            this.pnlKullaniciKapsayici.Location = new System.Drawing.Point(689, 13);
            this.pnlKullaniciKapsayici.Name = "pnlKullaniciKapsayici";
            this.pnlKullaniciKapsayici.Size = new System.Drawing.Size(276, 57);
            this.pnlKullaniciKapsayici.TabIndex = 53;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(80, 19);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(112, 20);
            this.txtKullanici.TabIndex = 6;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(198, 16);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(62, 23);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KULLANICI";
            // 
            // rbKullaniciyaGore
            // 
            this.rbKullaniciyaGore.AutoSize = true;
            this.rbKullaniciyaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKullaniciyaGore.Location = new System.Drawing.Point(529, 33);
            this.rbKullaniciyaGore.Name = "rbKullaniciyaGore";
            this.rbKullaniciyaGore.Size = new System.Drawing.Size(144, 17);
            this.rbKullaniciyaGore.TabIndex = 7;
            this.rbKullaniciyaGore.Text = "KULLANICIYA GÖRE";
            this.rbKullaniciyaGore.UseVisualStyleBackColor = true;
            this.rbKullaniciyaGore.CheckedChanged += new System.EventHandler(this.rbKullaniciyaGore_CheckedChanged);
            // 
            // rbAdminKayitlari
            // 
            this.rbAdminKayitlari.AutoSize = true;
            this.rbAdminKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdminKayitlari.Location = new System.Drawing.Point(19, 58);
            this.rbAdminKayitlari.Name = "rbAdminKayitlari";
            this.rbAdminKayitlari.Size = new System.Drawing.Size(133, 17);
            this.rbAdminKayitlari.TabIndex = 3;
            this.rbAdminKayitlari.Text = "ADMİN KAYITLARI";
            this.rbAdminKayitlari.UseVisualStyleBackColor = true;
            this.rbAdminKayitlari.CheckedChanged += new System.EventHandler(this.rbAdminKayitlari_CheckedChanged);
            // 
            // rbUyeKayitlari
            // 
            this.rbUyeKayitlari.AutoSize = true;
            this.rbUyeKayitlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUyeKayitlari.Location = new System.Drawing.Point(284, 21);
            this.rbUyeKayitlari.Name = "rbUyeKayitlari";
            this.rbUyeKayitlari.Size = new System.Drawing.Size(125, 17);
            this.rbUyeKayitlari.TabIndex = 2;
            this.rbUyeKayitlari.Text = "KAYITLI ÜYELER";
            this.rbUyeKayitlari.UseVisualStyleBackColor = true;
            this.rbUyeKayitlari.CheckedChanged += new System.EventHandler(this.rbUyeKayitlari_CheckedChanged);
            // 
            // rbSilinmisUyeler
            // 
            this.rbSilinmisUyeler.AutoSize = true;
            this.rbSilinmisUyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSilinmisUyeler.Location = new System.Drawing.Point(284, 58);
            this.rbSilinmisUyeler.Name = "rbSilinmisUyeler";
            this.rbSilinmisUyeler.Size = new System.Drawing.Size(176, 17);
            this.rbSilinmisUyeler.TabIndex = 1;
            this.rbSilinmisUyeler.Text = "SİLİNMİŞ ÜYE KAYITLARI";
            this.rbSilinmisUyeler.UseVisualStyleBackColor = true;
            this.rbSilinmisUyeler.CheckedChanged += new System.EventHandler(this.rbSilinmisUyeler_CheckedChanged);
            // 
            // rbTumKullanicilar
            // 
            this.rbTumKullanicilar.AutoSize = true;
            this.rbTumKullanicilar.Checked = true;
            this.rbTumKullanicilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumKullanicilar.Location = new System.Drawing.Point(19, 21);
            this.rbTumKullanicilar.Name = "rbTumKullanicilar";
            this.rbTumKullanicilar.Size = new System.Drawing.Size(188, 17);
            this.rbTumKullanicilar.TabIndex = 0;
            this.rbTumKullanicilar.TabStop = true;
            this.rbTumKullanicilar.Text = "TÜM KULLANICI KAYITLARI";
            this.rbTumKullanicilar.UseVisualStyleBackColor = true;
            this.rbTumKullanicilar.CheckedChanged += new System.EventHandler(this.rbTumKullanicilar_CheckedChanged);
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.reportViewer1);
            this.pnlFormlar.Location = new System.Drawing.Point(23, 100);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(981, 433);
            this.pnlFormlar.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.kullanicilarRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kutuphanemiz.UI.Forms.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(19, 17);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(946, 413);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // kullanicilarRaporTableAdapter
            // 
            this.kullanicilarRaporTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKullanicilarRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.pnlKapsayici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKullanicilarRapor";
            this.Text = "FrmKullanicilarRapor";
            this.Load += new System.EventHandler(this.FrmKullanicilarRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicilarRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).EndInit();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlButonlar.ResumeLayout(false);
            this.pnlButonlar.PerformLayout();
            this.pnlKullaniciKapsayici.ResumeLayout(false);
            this.pnlKullaniciKapsayici.PerformLayout();
            this.pnlFormlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlFormlar;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.RadioButton rbAdminKayitlari;
        private System.Windows.Forms.RadioButton rbUyeKayitlari;
        private System.Windows.Forms.RadioButton rbSilinmisUyeler;
        private System.Windows.Forms.RadioButton rbTumKullanicilar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private KutuphanemizDataSet kutuphanemizDataSet;
        private KutuphanemizDataSetTableAdapters.KullanicilarRaporTableAdapter kullanicilarRaporTableAdapter;
        private System.Windows.Forms.BindingSource kullanicilarRaporBindingSource;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel pnlKullaniciKapsayici;
        private System.Windows.Forms.RadioButton rbKullaniciyaGore;
    }
}