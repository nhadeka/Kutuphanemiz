using Kutuphanemiz.BLL;
using Kutuphanemiz.BLL.Models.Concretes;
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
    public partial class FrmAyarlar : Form
    {
       
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        KullanicilarServis kls = new KullanicilarServis();
        private void btnKullaniciBilgi_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmKullaniciBilgi frm = new Forms.FrmKullaniciBilgi();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmSifreDegistir frm = new FrmSifreDegistir();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            btnKullaniciBilgi_Click(sender, e);

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
            if (kls.AdminMi(csGenel.KullaniciIdFromLogin))
            {
                FrmAdminAnasayfa frm = new FrmAdminAnasayfa();
                frm.Show();
            }
            else
            {
                FrmUyeAnasayfa frm = new FrmUyeAnasayfa();
                frm.Show();

            }
            this.Hide();
        }
    }
}
