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
    public partial class FrmUyeAnasayfa : Form
    {
        public FrmUyeAnasayfa()
        {
            InitializeComponent();
        }

        

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            FrmKitapAra frm = new Forms.FrmKitapAra();
            frm.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar frm = new Forms.FrmAyarlar();
            frm.Show();
            this.Hide();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            FrmKullaniciGecmisi frm = new FrmKullaniciGecmisi();
            frm.Show();
            this.Hide();
        }

        private void btnUKitaplar_Click(object sender, EventArgs e)
        {
            FrmUzerimdekiKitaplar frm = new FrmUzerimdekiKitaplar();
            frm.Show();
            this.Hide();
        }

        private void FrmUyeAnasayfa_Load(object sender, EventArgs e)
        {
            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
