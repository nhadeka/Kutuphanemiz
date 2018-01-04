namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKullaniciGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGecmisi));
            this.dgvKullaniciGecmis = new System.Windows.Forms.DataGridView();
            this.pnlButon = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciGecmis)).BeginInit();
            this.pnlButon.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            this.pnlKapsayici.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullaniciGecmis
            // 
            this.dgvKullaniciGecmis.AllowUserToAddRows = false;
            this.dgvKullaniciGecmis.AllowUserToDeleteRows = false;
            this.dgvKullaniciGecmis.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullaniciGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciGecmis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.dgvKullaniciGecmis.Location = new System.Drawing.Point(3, 13);
            this.dgvKullaniciGecmis.Name = "dgvKullaniciGecmis";
            this.dgvKullaniciGecmis.ReadOnly = true;
            this.dgvKullaniciGecmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullaniciGecmis.Size = new System.Drawing.Size(1053, 318);
            this.dgvKullaniciGecmis.TabIndex = 0;
            // 
            // pnlButon
            // 
            this.pnlButon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlButon.Controls.Add(this.btnCikis);
            this.pnlButon.Controls.Add(this.btnMenu);
            this.pnlButon.Location = new System.Drawing.Point(3, 628);
            this.pnlButon.Name = "pnlButon";
            this.pnlButon.Size = new System.Drawing.Size(1067, 77);
            this.pnlButon.TabIndex = 17;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.White;
            this.btnCikis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(974, 15);
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
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(15, 15);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 50);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.dgvKullaniciGecmis);
            this.pnlFormlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlFormlar.Location = new System.Drawing.Point(3, 146);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(1059, 343);
            this.pnlFormlar.TabIndex = 1;
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
            this.pnlKapsayici.TabIndex = 52;
            // 
            // FrmKullaniciGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1116, 741);
            this.Controls.Add(this.pnlKapsayici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKullaniciGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKullaniciGecmisi";
            this.Load += new System.EventHandler(this.FrmKullaniciGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciGecmis)).EndInit();
            this.pnlButon.ResumeLayout(false);
            this.pnlFormlar.ResumeLayout(false);
            this.pnlKapsayici.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciGecmis;
        private System.Windows.Forms.Panel pnlButon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlFormlar;
        private System.Windows.Forms.Panel pnlKapsayici;
    }
}