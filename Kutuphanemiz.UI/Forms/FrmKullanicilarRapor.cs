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
    public partial class FrmKullanicilarRapor : Form
    {
        public FrmKullanicilarRapor()
        {
            InitializeComponent();
        }
        private void FrmKullanicilarRapor_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'kutuphanemizDataSet.KullanicilarRapor' table. You can move, or remove it, as needed.
            this.kullanicilarRaporTableAdapter.FillTumKullanicilar(this.kutuphanemizDataSet.KullanicilarRapor);
            this.reportViewer1.RefreshReport();
            pnlKullaniciKapsayici.Visible = false;

        }

        private void rbTumKullanicilar_CheckedChanged(object sender, EventArgs e)
        {
            this.kullanicilarRaporTableAdapter.FillTumKullanicilar(this.kutuphanemizDataSet.KullanicilarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void rbUyeKayitlari_CheckedChanged(object sender, EventArgs e)
        {
            
            this.kullanicilarRaporTableAdapter.FillByKayitliUyeler(this.kutuphanemizDataSet.KullanicilarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void rbSilinmisUyeler_CheckedChanged(object sender, EventArgs e)
        {
           
            this.kullanicilarRaporTableAdapter.FillBySilinmisUyeler(this.kutuphanemizDataSet.KullanicilarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void rbAdminKayitlari_CheckedChanged(object sender, EventArgs e)
        {
            
            this.kullanicilarRaporTableAdapter.FillByAdminler(this.kutuphanemizDataSet.KullanicilarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           
            this.kullanicilarRaporTableAdapter.FillByKullanici(this.kutuphanemizDataSet.KullanicilarRapor,txtKullanici.Text);
            this.reportViewer1.RefreshReport();
            txtKullanici.Clear();
        }

        private void rbKullaniciyaGore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKullaniciyaGore.Checked)
            {
                pnlKullaniciKapsayici.Visible = true;
            }
            else
            {
                pnlKullaniciKapsayici.Visible = false;
            }
           
        }
    }
}
