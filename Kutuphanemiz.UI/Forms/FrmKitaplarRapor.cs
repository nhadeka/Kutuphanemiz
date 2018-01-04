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
    public partial class FrmKitaplarRapor : Form
    {
        public FrmKitaplarRapor()
        {
            InitializeComponent();
        }

        private void FrmKitaplarRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphanemizDataSet.KitaplarRapor' table. You can move, or remove it, as needed.
            this.kitaplarRaporTableAdapter.FillKayitliKitaplar(this.kutuphanemizDataSet.KitaplarRapor);
            this.reportViewer1.RefreshReport();
            
            pnlAraKapsayici.Visible = false;

          
        }
     

        private void rbKayitliKitaplar_CheckedChanged(object sender, EventArgs e)
        {
            
            this.kitaplarRaporTableAdapter.FillKayitliKitaplar(this.kutuphanemizDataSet.KitaplarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void rbSilinmisKitaplar_CheckedChanged(object sender, EventArgs e)
        {
            
            this.kitaplarRaporTableAdapter.FillBySilinmisKitaplar(this.kutuphanemizDataSet.KitaplarRapor);
            this.reportViewer1.RefreshReport();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKitapAd.Text) && string.IsNullOrEmpty(txtYazari.Text))
            {
                MessageBox.Show("boş bırakmayın");
            }
            else
            {
                if (rbKitapAdaGore.Checked)
                {

                    this.kitaplarRaporTableAdapter.FillByKitapAd(this.kutuphanemizDataSet.KitaplarRapor, txtKitapAd.Text);
                    this.reportViewer1.RefreshReport();
                    txtKitapAd.Clear();
                }
                if (rbYazaraGore.Checked)
                {

                    this.kitaplarRaporTableAdapter.FillByYazar(this.kutuphanemizDataSet.KitaplarRapor, txtYazari.Text);
                    this.reportViewer1.RefreshReport();
                    txtYazar.Clear();
                }
            }
           

        }
        private void AraKapsayiciyiAc()
        {
            if (rbKitapAdaGore.Checked == false || rbYazaraGore.Checked == false)
            {
                pnlAraKapsayici.Visible = false;
            }

        }
        private void rbKitapAdaGore_CheckedChanged(object sender, EventArgs e)
        {
            
            pnlAraKapsayici.Visible = true;
            pnlKitapAdaGore.BringToFront();
          
            if (rbKitapAdaGore.Checked == false)
            {
                AraKapsayiciyiAc();
            }
          
        }

        private void rbYazaraGore_CheckedChanged(object sender, EventArgs e)
        {
            
            pnlAraKapsayici.Visible = true;
            pnlYazarinaGore.BringToFront();
           
            if (rbYazaraGore.Checked == false)
            {
                AraKapsayiciyiAc();
            }
        }
    }
}
