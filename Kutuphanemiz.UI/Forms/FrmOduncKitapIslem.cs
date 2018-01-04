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
    public partial class FrmOduncKitapIslem : Form
    {
        public FrmOduncKitapIslem()
        {
            InitializeComponent();
        }

        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmKitapVer frm = new FrmKitapVer();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            //frm.BringToFront();


            
           

        }

        private void btnKitapGeriAl_Click(object sender, EventArgs e)
        {
            pnlFormlar.Controls.Clear();
            FrmKitapGeriAl frm = new Forms.FrmKitapGeriAl();
            frm.TopLevel = false;
            pnlFormlar.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            //frm.BringToFront();



           
           
        }

        private void FrmOduncKitapIslem_Load(object sender, EventArgs e)
        {
            btnKitapVer_Click(sender, e);

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
