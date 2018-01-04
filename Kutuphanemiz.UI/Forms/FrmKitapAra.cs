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
    public partial class FrmKitapAra : Form
    {
        public FrmKitapAra()
        {
            InitializeComponent();
        }

        KategorilerServis kts = new KategorilerServis();
        KitaplarServis ks = new KitaplarServis();
        YazarlarServis yzs = new YazarlarServis();
        KullanicilarServis kls = new KullanicilarServis();
        private void Yukle()
        {
            cbKategoriler.DataSource = kts.KategorileriGetir();
            dgvKitaplar.DataSource = ks.KitaplariYukleByKitapAra();
            dgvKitaplar.Columns[1].Visible = false;
            dgvKitaplar.Columns[2].Visible = false;
            dgvKitaplar.Columns[8].Visible = false;
            dgvKitaplar.Columns[9].Visible = false;
            dgvKitaplar.Columns[10].Visible = false;
            dgvKitaplar.Columns[11].Visible = false;
           



        }

        private void FrmKitapAra_Load(object sender, EventArgs e)
        {
               
                Yukle();

                pnlKitapAd.BringToFront();

            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();


        }

        private void rbKitapAdinagore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKitapAd.BringToFront();
        }



        private void rbKategoriyeGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKategori.BringToFront();


        }

      
        private void rbYazaraGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlYazaraGore.BringToFront();

        }

        private void btnTumKitaplariGetir_Click(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            if (rbKitapAdinagore.Checked)
            {
                if (string.IsNullOrEmpty(txtKitapAd.Text))
                {
                    MessageBox.Show("kitap adı giriniz");
                }
                else
                {
                    if (ks.AdiIcerenKitapVarmi(txtKitapAd.Text))
                    {
                        dgvKitaplar.DataSource = ks.AdiIcerenKitaplariGetir(txtKitapAd.Text);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu isimde kitap bulunmamaktadır");

                    }
                    txtKitapAd.Clear();
                }

            }
            if (rbYazaraGore.Checked)
            {
                if (string.IsNullOrEmpty(txtYazar.Text))
                {
                    MessageBox.Show("yazar adı giriniz");
                }
                else
                {
                    if (yzs.AdiIcerenYazarVarmi(txtYazar.Text))
                    {
                        dgvKitaplar.DataSource = ks.YazarAdiIcerenKitaplariGetir(txtYazar.Text);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu isimdeki yazarın bir kitabı  bulunmamaktadır");
                    }
                    txtYazar.Clear();
                }
            }
            if (rbKategoriyeGore.Checked)
            {
                dgvKitaplar.DataSource = ks.KategoridekiKitaplariGetir(cbKategoriler.SelectedItem.ToString());
            }

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
