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
    public partial class FrmEmanetlerRapor : Form
    {
        public FrmEmanetlerRapor()
        {
            InitializeComponent();
        }

        private void FrmEmanetlerRapor_Load(object sender, EventArgs e)
        {
           
           
            // TODO: This line of code loads data into the 'kutuphanemizDataSet.EmanetlerRapor' table. You can move, or remove it, as needed.
            this.emanetlerRaporTableAdapter.Fill(this.kutuphanemizDataSet.EmanetlerRapor);

            this.reportViewer1.RefreshReport();
        }

        private void rbEmanetler_CheckedChanged(object sender, EventArgs e)
        {
            this.emanetlerRaporTableAdapter.Fill(this.kutuphanemizDataSet.EmanetlerRapor);

            this.reportViewer1.RefreshReport();
        }

        private void rbSilinmisKitaplar_CheckedChanged(object sender, EventArgs e)
        {
            this.emanetlerRaporTableAdapter.FillBy(this.kutuphanemizDataSet.EmanetlerRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
