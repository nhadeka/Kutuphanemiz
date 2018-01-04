namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKullaniciBilgi
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
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtTelno
            // 
            this.mtxtTelno.Location = new System.Drawing.Point(133, 75);
            this.mtxtTelno.Mask = "(999) 000-0000";
            this.mtxtTelno.Name = "mtxtTelno";
            this.mtxtTelno.ReadOnly = true;
            this.mtxtTelno.Size = new System.Drawing.Size(145, 20);
            this.mtxtTelno.TabIndex = 277;
            // 
            // txtIlce
            // 
            this.txtIlce.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlce.Location = new System.Drawing.Point(229, 149);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(2);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.ReadOnly = true;
            this.txtIlce.Size = new System.Drawing.Size(92, 20);
            this.txtIlce.TabIndex = 273;
            // 
            // txtIl
            // 
            this.txtIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIl.Location = new System.Drawing.Point(133, 149);
            this.txtIl.Margin = new System.Windows.Forms.Padding(2);
            this.txtIl.Name = "txtIl";
            this.txtIl.ReadOnly = true;
            this.txtIl.Size = new System.Drawing.Size(83, 20);
            this.txtIl.TabIndex = 272;
            this.txtIl.Text = "İstanbul";
            this.txtIl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpUyelikTarihi
            // 
            this.dtpUyelikTarihi.Enabled = false;
            this.dtpUyelikTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpUyelikTarihi.Location = new System.Drawing.Point(133, 126);
            this.dtpUyelikTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUyelikTarihi.Name = "dtpUyelikTarihi";
            this.dtpUyelikTarihi.Size = new System.Drawing.Size(188, 20);
            this.dtpUyelikTarihi.TabIndex = 271;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(133, 176);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(188, 64);
            this.txtAdres.TabIndex = 270;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAdres.Location = new System.Drawing.Point(11, 178);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 13);
            this.lblAdres.TabIndex = 269;
            this.lblAdres.Text = "ADRES";
            // 
            // lblIlIlce
            // 
            this.lblIlIlce.AutoSize = true;
            this.lblIlIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlIlce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblIlIlce.Location = new System.Drawing.Point(11, 152);
            this.lblIlIlce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlIlce.Name = "lblIlIlce";
            this.lblIlIlce.Size = new System.Drawing.Size(59, 13);
            this.lblIlIlce.TabIndex = 268;
            this.lblIlIlce.Text = "İL / İLÇE";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTarih.Location = new System.Drawing.Point(11, 132);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(118, 13);
            this.lblTarih.TabIndex = 267;
            this.lblTarih.Text = "ÜYE KAYIT TARİHİ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(133, 104);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 264;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(133, 50);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.ReadOnly = true;
            this.txtSoyad.Size = new System.Drawing.Size(145, 20);
            this.txtSoyad.TabIndex = 263;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(133, 26);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(145, 20);
            this.txtAd.TabIndex = 262;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblEposta.Location = new System.Drawing.Point(11, 111);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(60, 13);
            this.lblEposta.TabIndex = 260;
            this.lblEposta.Text = "E-POSTA";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblTelefon.Location = new System.Drawing.Point(11, 82);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(63, 13);
            this.lblTelefon.TabIndex = 259;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblSoyad.Location = new System.Drawing.Point(11, 57);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(49, 13);
            this.lblSoyad.TabIndex = 258;
            this.lblSoyad.Text = "SOYAD";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.lblAd.Location = new System.Drawing.Point(11, 33);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 13);
            this.lblAd.TabIndex = 257;
            this.lblAd.Text = "AD";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.mtxtTelno);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.txtIlce);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.txtIl);
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.dtpUyelikTarihi);
            this.panel1.Controls.Add(this.lblEposta);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.lblAdres);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.lblIlIlce);
            this.panel1.Controls.Add(this.lblTarih);
            this.panel1.Location = new System.Drawing.Point(77, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 268);
            this.panel1.TabIndex = 278;
            // 
            // FrmKullaniciBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 367);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKullaniciBilgi";
            this.Text = "FrmKullaniciBilgi";
            this.Load += new System.EventHandler(this.FrmKullaniciBilgi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Panel panel1;
    }
}