namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKitaplarRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.kitaplarRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphanemizDataSet = new Kutuphanemiz.UI.KutuphanemizDataSet();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.rbYazaraGore = new System.Windows.Forms.RadioButton();
            this.rbKitapAdaGore = new System.Windows.Forms.RadioButton();
            this.rbSilinmisKitaplar = new System.Windows.Forms.RadioButton();
            this.rbKayitliKitaplar = new System.Windows.Forms.RadioButton();
            this.pnlAraKapsayici = new System.Windows.Forms.Panel();
            this.pnlKitapAdaGore = new System.Windows.Forms.Panel();
            this.pnlYazarinaGore = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlYazaraGore = new System.Windows.Forms.Panel();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kitaplarRaporTableAdapter = new Kutuphanemiz.UI.KutuphanemizDataSetTableAdapters.KitaplarRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).BeginInit();
            this.pnlButonlar.SuspendLayout();
            this.pnlAraKapsayici.SuspendLayout();
            this.pnlKitapAdaGore.SuspendLayout();
            this.pnlYazarinaGore.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlYazaraGore.SuspendLayout();
            this.pnlKapsayici.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // kitaplarRaporBindingSource
            // 
            this.kitaplarRaporBindingSource.DataMember = "KitaplarRapor";
            this.kitaplarRaporBindingSource.DataSource = this.kutuphanemizDataSet;
            // 
            // kutuphanemizDataSet
            // 
            this.kutuphanemizDataSet.DataSetName = "KutuphanemizDataSet";
            this.kutuphanemizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Controls.Add(this.rbYazaraGore);
            this.pnlButonlar.Controls.Add(this.rbKitapAdaGore);
            this.pnlButonlar.Controls.Add(this.rbSilinmisKitaplar);
            this.pnlButonlar.Controls.Add(this.rbKayitliKitaplar);
            this.pnlButonlar.Controls.Add(this.pnlAraKapsayici);
            this.pnlButonlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlButonlar.Location = new System.Drawing.Point(66, 6);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(744, 91);
            this.pnlButonlar.TabIndex = 18;
            // 
            // rbYazaraGore
            // 
            this.rbYazaraGore.AutoSize = true;
            this.rbYazaraGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbYazaraGore.Location = new System.Drawing.Point(246, 58);
            this.rbYazaraGore.Name = "rbYazaraGore";
            this.rbYazaraGore.Size = new System.Drawing.Size(113, 17);
            this.rbYazaraGore.TabIndex = 7;
            this.rbYazaraGore.Text = "YAZARA GÖRE";
            this.rbYazaraGore.UseVisualStyleBackColor = true;
            this.rbYazaraGore.CheckedChanged += new System.EventHandler(this.rbYazaraGore_CheckedChanged);
            // 
            // rbKitapAdaGore
            // 
            this.rbKitapAdaGore.AutoSize = true;
            this.rbKitapAdaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKitapAdaGore.Location = new System.Drawing.Point(246, 27);
            this.rbKitapAdaGore.Name = "rbKitapAdaGore";
            this.rbKitapAdaGore.Size = new System.Drawing.Size(142, 17);
            this.rbKitapAdaGore.TabIndex = 6;
            this.rbKitapAdaGore.Text = "KİTAP ADINA GÖRE";
            this.rbKitapAdaGore.UseVisualStyleBackColor = true;
            this.rbKitapAdaGore.CheckedChanged += new System.EventHandler(this.rbKitapAdaGore_CheckedChanged);
            // 
            // rbSilinmisKitaplar
            // 
            this.rbSilinmisKitaplar.AutoSize = true;
            this.rbSilinmisKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSilinmisKitaplar.Location = new System.Drawing.Point(3, 58);
            this.rbSilinmisKitaplar.Name = "rbSilinmisKitaplar";
            this.rbSilinmisKitaplar.Size = new System.Drawing.Size(143, 17);
            this.rbSilinmisKitaplar.TabIndex = 2;
            this.rbSilinmisKitaplar.Text = "SİLİNMİŞ KİTAPLAR";
            this.rbSilinmisKitaplar.UseVisualStyleBackColor = true;
            this.rbSilinmisKitaplar.CheckedChanged += new System.EventHandler(this.rbSilinmisKitaplar_CheckedChanged);
            // 
            // rbKayitliKitaplar
            // 
            this.rbKayitliKitaplar.AutoSize = true;
            this.rbKayitliKitaplar.Checked = true;
            this.rbKayitliKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKayitliKitaplar.Location = new System.Drawing.Point(3, 27);
            this.rbKayitliKitaplar.Name = "rbKayitliKitaplar";
            this.rbKayitliKitaplar.Size = new System.Drawing.Size(136, 17);
            this.rbKayitliKitaplar.TabIndex = 0;
            this.rbKayitliKitaplar.TabStop = true;
            this.rbKayitliKitaplar.Text = "KAYITLI KİTAPLAR";
            this.rbKayitliKitaplar.UseVisualStyleBackColor = true;
            this.rbKayitliKitaplar.CheckedChanged += new System.EventHandler(this.rbKayitliKitaplar_CheckedChanged);
            // 
            // pnlAraKapsayici
            // 
            this.pnlAraKapsayici.Controls.Add(this.pnlYazarinaGore);
            this.pnlAraKapsayici.Controls.Add(this.pnlKitapAdaGore);
            this.pnlAraKapsayici.Controls.Add(this.btnAra);
            this.pnlAraKapsayici.Location = new System.Drawing.Point(407, 14);
            this.pnlAraKapsayici.Name = "pnlAraKapsayici";
            this.pnlAraKapsayici.Size = new System.Drawing.Size(325, 61);
            this.pnlAraKapsayici.TabIndex = 54;
            // 
            // pnlKitapAdaGore
            // 
            this.pnlKitapAdaGore.Controls.Add(this.pnlYazaraGore);
            this.pnlKitapAdaGore.Controls.Add(this.txtKitapAd);
            this.pnlKitapAdaGore.Controls.Add(this.label1);
            this.pnlKitapAdaGore.Location = new System.Drawing.Point(22, 5);
            this.pnlKitapAdaGore.Name = "pnlKitapAdaGore";
            this.pnlKitapAdaGore.Size = new System.Drawing.Size(210, 43);
            this.pnlKitapAdaGore.TabIndex = 19;
            // 
            // pnlYazarinaGore
            // 
            this.pnlYazarinaGore.Controls.Add(this.panel2);
            this.pnlYazarinaGore.Controls.Add(this.txtYazari);
            this.pnlYazarinaGore.Controls.Add(this.label4);
            this.pnlYazarinaGore.Location = new System.Drawing.Point(22, 5);
            this.pnlYazarinaGore.Name = "pnlYazarinaGore";
            this.pnlYazarinaGore.Size = new System.Drawing.Size(210, 43);
            this.pnlYazarinaGore.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(434, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 50);
            this.panel2.TabIndex = 54;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar";
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(68, 12);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(109, 20);
            this.txtYazari.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "YAZARI";
            // 
            // pnlYazaraGore
            // 
            this.pnlYazaraGore.Controls.Add(this.txtYazar);
            this.pnlYazaraGore.Controls.Add(this.label2);
            this.pnlYazaraGore.Location = new System.Drawing.Point(434, 11);
            this.pnlYazaraGore.Name = "pnlYazaraGore";
            this.pnlYazaraGore.Size = new System.Drawing.Size(210, 50);
            this.pnlYazaraGore.TabIndex = 54;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(68, 12);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(109, 20);
            this.txtYazar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(79, 12);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(109, 20);
            this.txtKitapAd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KİTAP AD";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(238, 17);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKapsayici.Controls.Add(this.pnlFormlar);
            this.pnlKapsayici.Controls.Add(this.pnlButonlar);
            this.pnlKapsayici.Location = new System.Drawing.Point(91, 32);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(876, 475);
            this.pnlKapsayici.TabIndex = 53;
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.reportViewer1);
            this.pnlFormlar.Location = new System.Drawing.Point(17, 100);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(832, 363);
            this.pnlFormlar.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.kitaplarRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kutuphanemiz.UI.Forms.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(794, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // kitaplarRaporTableAdapter
            // 
            this.kitaplarRaporTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKitaplarRapor
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.pnlKapsayici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitaplarRapor";
            this.Text = "FrmKitaplarRapor";
            this.Load += new System.EventHandler(this.FrmKitaplarRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).EndInit();
            this.pnlButonlar.ResumeLayout(false);
            this.pnlButonlar.PerformLayout();
            this.pnlAraKapsayici.ResumeLayout(false);
            this.pnlKitapAdaGore.ResumeLayout(false);
            this.pnlKitapAdaGore.PerformLayout();
            this.pnlYazarinaGore.ResumeLayout(false);
            this.pnlYazarinaGore.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlYazaraGore.ResumeLayout(false);
            this.pnlYazaraGore.PerformLayout();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlFormlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.RadioButton rbSilinmisKitaplar;
        private System.Windows.Forms.RadioButton rbKayitliKitaplar;
        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlFormlar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private KutuphanemizDataSet kutuphanemizDataSet;
        private System.Windows.Forms.BindingSource kitaplarRaporBindingSource;
        private KutuphanemizDataSetTableAdapters.KitaplarRaporTableAdapter kitaplarRaporTableAdapter;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel pnlKitapAdaGore;
        private System.Windows.Forms.Panel pnlYazaraGore;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbYazaraGore;
        private System.Windows.Forms.RadioButton rbKitapAdaGore;
        private System.Windows.Forms.Panel pnlYazarinaGore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlAraKapsayici;
    }
}