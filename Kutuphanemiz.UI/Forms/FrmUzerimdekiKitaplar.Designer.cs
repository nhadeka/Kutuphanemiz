namespace Kutuphanemiz.UI.Forms
{
    partial class FrmUzerimdekiKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUzerimdekiKitaplar));
            this.dgvUKitaplar = new System.Windows.Forms.DataGridView();
            this.pnlKapsayici = new System.Windows.Forms.Panel();
            this.pnlButon = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlFormlar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUKitaplar)).BeginInit();
            this.pnlKapsayici.SuspendLayout();
            this.pnlButon.SuspendLayout();
            this.pnlFormlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUKitaplar
            // 
            this.dgvUKitaplar.AllowUserToAddRows = false;
            this.dgvUKitaplar.AllowUserToDeleteRows = false;
            this.dgvUKitaplar.BackgroundColor = System.Drawing.Color.White;
            this.dgvUKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUKitaplar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.dgvUKitaplar.Location = new System.Drawing.Point(27, 51);
            this.dgvUKitaplar.Name = "dgvUKitaplar";
            this.dgvUKitaplar.ReadOnly = true;
            this.dgvUKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUKitaplar.Size = new System.Drawing.Size(1012, 243);
            this.dgvUKitaplar.TabIndex = 0;
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
            this.pnlKapsayici.TabIndex = 51;
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
            this.btnCikis.Location = new System.Drawing.Point(974, 12);
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
            this.btnMenu.Location = new System.Drawing.Point(15, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(15);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 50);
            this.btnMenu.TabIndex = 14;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlFormlar
            // 
            this.pnlFormlar.Controls.Add(this.dgvUKitaplar);
            this.pnlFormlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.pnlFormlar.Location = new System.Drawing.Point(11, 139);
            this.pnlFormlar.Name = "pnlFormlar";
            this.pnlFormlar.Size = new System.Drawing.Size(1059, 343);
            this.pnlFormlar.TabIndex = 1;
            // 
            // FrmUzerimdekiKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1116, 741);
            this.Controls.Add(this.pnlKapsayici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUzerimdekiKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUzerimdekiKitaplar";
            this.Load += new System.EventHandler(this.FrmUzerimdekiKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUKitaplar)).EndInit();
            this.pnlKapsayici.ResumeLayout(false);
            this.pnlButon.ResumeLayout(false);
            this.pnlFormlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUKitaplar;
        private System.Windows.Forms.Panel pnlKapsayici;
        private System.Windows.Forms.Panel pnlButon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlFormlar;
    }
}