using Kutuphanemiz.BLL;
using Kutuphanemiz.BLL.Models.Concretes;
using Kutuphanemiz.DAL.DataModel;
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
    public partial class FrmKullaniciGecmisi : Form
    {
        public FrmKullaniciGecmisi()
        {
            InitializeComponent();
        }
       
        EmanetlerServis es = new EmanetlerServis();
        KullanicilarServis kls = new KullanicilarServis();
        private void FrmKullaniciGecmisi_Load(object sender, EventArgs e)
        {
            dgvKullaniciGecmis.DataSource = es.KullanicininGecmisi(csGenel.KullaniciIdFromLogin);
            Gorunmezler();
            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();



        }
        private void Gorunmezler()
        {
            dgvKullaniciGecmis.Columns[0].Visible = false;
            dgvKullaniciGecmis.Columns[1].Visible = false;
            dgvKullaniciGecmis.Columns[2].Visible = false;
            dgvKullaniciGecmis.Columns[9].Visible = false;
            dgvKullaniciGecmis.Columns[12].Visible = false;
            
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
