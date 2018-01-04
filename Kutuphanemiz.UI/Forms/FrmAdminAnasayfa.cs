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
    public partial class FrmAdminAnasayfa : Form
    {
        public FrmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        
        }
        private void Gizle()
        {
            btnArsiv.Visible = false;
            btnAyarlar.Visible = false;
            btnKitapAra.Visible = false;
            btnKitapIslem.Visible = false;
            btnOduncKitapIslem.Visible = false;
            btnUyeIslem.Visible = false;
        }
        private void Gorunur()
        {
            btnArsiv.Visible = true;
            btnAyarlar.Visible = true;
            btnKitapAra.Visible = true;
            btnKitapIslem.Visible = true;
            btnOduncKitapIslem.Visible = true;
            btnUyeIslem.Visible = true;
        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            //btnMenu.Visible = true;
            //Gizle();
            //pnlFormlar1.Controls.Clear();


            //FrmKitapAra frm = new Forms.FrmKitapAra();

            //frm.TopLevel = false;
            //pnlFormlar1.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();




            FrmKitapAra frm = new Forms.FrmKitapAra();
            frm.Show();
            this.Hide();
        }

        private void btnOduncKitapIslem_Click(object sender, EventArgs e)
        {
            //btnMenu.Visible = true;
            //Gizle();
            //pnlFormlar1.Controls.Clear();

            FrmOduncKitapIslem frm = new Forms.FrmOduncKitapIslem();
            frm.Show();
            this.Hide();

            //frm.TopLevel = false;
            //pnlFormlar1.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();
        }

        private void btnUyeIslem_Click(object sender, EventArgs e)
        {
            //btnMenu.Visible = true;
            //Gizle();
            //pnlFormlar1.Controls.Clear();

            FrmKullaniciIslem frm = new FrmKullaniciIslem();
            frm.Show();
            this.Hide();

            //frm.TopLevel = false;
            //pnlFormlar1.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();


        }

        private void btnKitapIslem_Click(object sender, EventArgs e)
        {

            //btnMenu.Visible = true;
            //Gizle();
            //pnlFormlar1.Controls.Clear();


            FrmKitapIslem frm = new FrmKitapIslem();
            frm.Show();
            this.Hide();

            //frm.TopLevel = false;
            //pnlFormlar1.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();

        }

        private void btnArsiv_Click(object sender, EventArgs e)
        {
            FrmArsiv frm = new FrmArsiv();
            frm.Show();
            this.Hide();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {


            //btnMenu.Visible = true;
            //Gizle();
            //pnlFormlar1.Controls.Clear();

            FrmAyarlar frm = new FrmAyarlar();
            frm.Show();
            this.Hide();

            //frm.TopLevel = false;
            //pnlFormlar1.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();

        }

        public void FrmAdminAnasayfa_Load(object sender, EventArgs e)
        {
            //pnlFormlar1.Controls.Clear();
            //paneli ekran boyutuna göre ortaladık.
            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();


          
            //btnMenu.Visible = false;
           
            pnlFormlar1.BringToFront();
            Gorunur();
            //pnlFormlar.Controls.Clear();
        }

       
    }
}
