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
    public partial class FrmArsiv : Form
    {
        public FrmArsiv()
        {
            InitializeComponent();
        }

        private void FrmArsiv_Load(object sender, EventArgs e)
        {
            btnKullaniciArsiv_Click( sender,  e);
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

        private void btnKullaniciArsiv_Click(object sender, EventArgs e)
        {
           

            pnlFormlar.Controls.Clear();
            FrmKullanicilarRapor frm = new Forms.FrmKullanicilarRapor();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;

        }

        private void btnKitapArsiv_Click(object sender, EventArgs e)
        {
            
          
            pnlFormlar.Controls.Clear();
            FrmKitaplarRapor frm = new Forms.FrmKitaplarRapor();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;

        }

        private void btnEmanetArsiv_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmEmanetlerRapor frm = new Forms.FrmEmanetlerRapor();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }
    }
}
