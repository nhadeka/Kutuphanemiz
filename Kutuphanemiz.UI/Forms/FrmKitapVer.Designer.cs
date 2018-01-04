namespace Kutuphanemiz.UI.Forms
{
    partial class FrmKitapVer
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
            this.dtpIEdilecekTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpVerilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKitapBul = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUyeSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUyeAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeBul = new System.Windows.Forms.Button();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpIEdilecekTarih
            // 
            this.dtpIEdilecekTarih.Location = new System.Drawing.Point(309, 241);
            this.dtpIEdilecekTarih.Name = "dtpIEdilecekTarih";
            this.dtpIEdilecekTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpIEdilecekTarih.TabIndex = 9;
            // 
            // dtpVerilisTarihi
            // 
            this.dtpVerilisTarihi.Location = new System.Drawing.Point(309, 197);
            this.dtpVerilisTarihi.Name = "dtpVerilisTarihi";
            this.dtpVerilisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpVerilisTarihi.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(341, 298);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 37);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKitapBul
            // 
            this.btnKitapBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnKitapBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapBul.ForeColor = System.Drawing.Color.White;
            this.btnKitapBul.Location = new System.Drawing.Point(647, 14);
            this.btnKitapBul.Name = "btnKitapBul";
            this.btnKitapBul.Size = new System.Drawing.Size(75, 23);
            this.btnKitapBul.TabIndex = 53;
            this.btnKitapBul.Text = "BUL";
            this.btnKitapBul.UseVisualStyleBackColor = false;
            this.btnKitapBul.Click += new System.EventHandler(this.btnKitapBul_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(161, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "İADE EDİLECEK TARİH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(161, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "VERİLİŞ TARİHİ";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(541, 56);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(461, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "KİTAP AD";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(541, 16);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 20);
            this.txtBarkod.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label6.Location = new System.Drawing.Point(461, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "BARKOD";
            // 
            // txtUyeSoyad
            // 
            this.txtUyeSoyad.Location = new System.Drawing.Point(86, 95);
            this.txtUyeSoyad.Name = "txtUyeSoyad";
            this.txtUyeSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtUyeSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(2, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "SOYAD";
            // 
            // txtUyeAd
            // 
            this.txtUyeAd.Location = new System.Drawing.Point(86, 56);
            this.txtUyeAd.Name = "txtUyeAd";
            this.txtUyeAd.Size = new System.Drawing.Size(100, 20);
            this.txtUyeAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "AD";
            // 
            // txtUyeId
            // 
            this.txtUyeId.Location = new System.Drawing.Point(86, 19);
            this.txtUyeId.Name = "txtUyeId";
            this.txtUyeId.Size = new System.Drawing.Size(100, 20);
            this.txtUyeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ÜYE NO";
            // 
            // btnUyeBul
            // 
            this.btnUyeBul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.btnUyeBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeBul.ForeColor = System.Drawing.Color.White;
            this.btnUyeBul.Location = new System.Drawing.Point(192, 19);
            this.btnUyeBul.Name = "btnUyeBul";
            this.btnUyeBul.Size = new System.Drawing.Size(75, 23);
            this.btnUyeBul.TabIndex = 40;
            this.btnUyeBul.Text = "BUL";
            this.btnUyeBul.UseVisualStyleBackColor = false;
            this.btnUyeBul.Click += new System.EventHandler(this.btnUyeBul_Click);
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(541, 92);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(461, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "YAZAR";
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(541, 128);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinevi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(462, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "YAYINEVİ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUyeBul);
            this.panel1.Controls.Add(this.txtYayinevi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUyeId);
            this.panel1.Controls.Add(this.txtYazar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUyeAd);
            this.panel1.Controls.Add(this.dtpIEdilecekTarih);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpVerilisTarihi);
            this.panel1.Controls.Add(this.txtUyeSoyad);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnKitapBul);
            this.panel1.Controls.Add(this.txtBarkod);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtKitapAd);
            this.panel1.Location = new System.Drawing.Point(155, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 338);
            this.panel1.TabIndex = 61;
            // 
            // FrmKitapVer
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKitapVer";
            this.Text = "FrmKitapVer";
            this.Load += new System.EventHandler(this.FrmKitapVer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIEdilecekTarih;
        private System.Windows.Forms.DateTimePicker dtpVerilisTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKitapBul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUyeSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUyeAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUyeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUyeBul;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}