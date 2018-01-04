using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanemiz.UI.Forms
{
    public partial class FrmKullaniciIslem : Form
    {
        public FrmKullaniciIslem()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmKullaniciEkle frm = new FrmKullaniciEkle();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmKullaniciGuncelle frm = new FrmKullaniciGuncelle();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void FrmKullaniciIslem_Load(object sender, EventArgs e)
        {
            btnKullaniciEkle_Click( sender,  e);

            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmAdminAnasayfa frm = new Forms.FrmAdminAnasayfa();
            frm.Show();
            this.Hide();
        }
    }
}
