namespace Kutuphanemiz.UI.Forms
{
    partial class FrmEmanetlerRapor
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
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.rbSilinmisKitaplar = new System.Windows.Forms.RadioButton();
            this.rbEmanetler = new System.Windows.Forms.RadioButton();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kutuphanemizDataSet = new Kutuphanemiz.UI.KutuphanemizDataSet();
            this.emanetlerRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emanetlerRaporTableAdapter = new Kutuphanemiz.UI.KutuphanemizDataSetTableAdapters.EmanetlerRaporTableAdapter();
            this.pnlKapsayici.SuspendLayout();
            this.pnlButonlar.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerRaporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKapsayici
            // 
            this.pnlKapsayici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlKapsayici.Controls.Add(this.pnlButonlar);
            this.pnlKapsayici.Controls.Add(this.pnlFormlar);
            this.pnlKapsayici.Location = new System.Drawing.Point(28, 23);
            this.pnlKapsayici.Name = "pnlKapsayici";
            this.pnlKapsayici.Size = new System.Drawing.Size(997, 491);
            this.pnlKapsayici.TabIndex = 54;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Controls.Add(this.rbSilinmisKitaplar);
            this.pnlButonlar.Controls.Add(this.rbEmanetler);
            this.pnlButonlar.Location = new System.Drawing.Point(221, 12);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(563, 69);
            this.pnlButonlar.TabIndex = 18;
            // 
            // rbSilinmisKitaplar
            // 
            this.rbSilinmisKitaplar.AutoSize = true;
            this.rbSilinmisKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSilinmisKitaplar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rbSilinmisKitaplar.Location = new System.Drawing.Point(380, 35);
            this.rbSilinmisKitaplar.Name = "rbSilinmisKitaplar";
            this.rbSilinmisKitaplar.Size = new System.Drawing.Size(168, 17);
            this.rbSilinmisKitaplar.TabIndex = 2;
            this.rbSilinmisKitaplar.Text = "GERİ ALINAN KİTAPLAR";
            this.rbSilinmisKitaplar.UseVisualStyleBackColor = true;
            this.rbSilinmisKitaplar.CheckedChanged += new System.EventHandler(this.rbSilinmisKitaplar_CheckedChanged);
            // 
            // rbEmanetler
            // 
            this.rbEmanetler.AutoSize = true;
            this.rbEmanetler.Checked = true;
            this.rbEmanetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEmanetler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.rbEmanetler.Location = new System.Drawing.Point(16, 35);
            this.rbEmanetler.Name = "rbEmanetler";
            this.rbEmanetler.Size = new System.Drawing.Size(182, 17);
            this.rbEmanetler.TabIndex = 0;
            this.rbEmanetler.TabStop = true;
            this.rbEmanetler.Text = "ÖDÜNÇ ALINAN KİTAPLAR";
            this.rbEmanetler.UseVisualStyleBackColor = true;
            this.rbEmanetler.CheckedChanged += new System.EventHandler(this.rbEmanetler_CheckedChanged);
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.reportViewer1);
            this.pnlFormlar.Location = new System.Drawing.Point(3, 87);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(991, 384);
            this.pnlFormlar.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.emanetlerRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kutuphanemiz.UI.Forms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(985, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // kutuphanemizDataSet
            // 
            this.kutuphanemizDataSet.DataSetName = "KutuphanemizDataSet";
            this.kutuphanemizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetlerRaporBindingSource
            // 
            this.emanetlerRaporBindingSource.DataMember = "EmanetlerRapor";
            this.emanetlerRaporBindingSource.DataSource = this.kutuphanemizDataSet;
            // 
            // emanetlerRaporTableAdapter
            // 
            this.emanetlerRaporTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmanetlerRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 540);
            this.Controls.Add(this.pnlKapsayici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmanetlerRapor";
            this.Text = "FrmEmanetlerRapor";
            this.Load += new System.EventHandler(this.FrmEmanetlerRapor_Load);
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlButonlar.ResumeLayout(false);
            this.pnlButonlar.PerformLayout();
            this.pnlFormlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kutuphanemizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetlerRaporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.RadioButton rbSilinmisKitaplar;
        private System.Windows.Forms.RadioButton rbEmanetler;
        private System.Windows.Forms.Panel pnlFormlar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private KutuphanemizDataSet kutuphanemizDataSet;
        private System.Windows.Forms.BindingSource emanetlerRaporBindingSource;
        private KutuphanemizDataSetTableAdapters.EmanetlerRaporTableAdapter emanetlerRaporTableAdapter;
    }
}