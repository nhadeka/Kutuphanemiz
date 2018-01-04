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
    public partial class FrmKitapGeriAl : Form
    {
        public FrmKitapGeriAl()
        {
            InitializeComponent();
        }
        decimal TopCeza;
        int BirimCeza, GunFarki, SecilenKitapId, SecilenEmanetId, GGunSayisi;
        KutuphanemizEntities ent = new KutuphanemizEntities();
        EmanetlerServis es = new EmanetlerServis();
        KullanicilarServis kls = new KullanicilarServis();
        KitaplarServis ks = new KitaplarServis();
        private void Gorunmezler()
        {
            dgvEmanetler.Columns[0].Visible = false;
            dgvEmanetler.Columns[1].Visible = false;
            dgvEmanetler.Columns[2].Visible = false;
            dgvEmanetler.Columns[9].Visible = false;
            dgvEmanetler.Columns[12].Visible = false;
            dgvEmanetler.Columns[13].Visible = false;
            dgvEmanetler.Columns[14].Visible = false;
            dgvEmanetler.Columns[15].Visible = false;
            
        }
        private int TarihFarkiBul(int gunfarki)
        {

            if (gunfarki > 0)
            {

                return gunfarki;
            }
            else
            {
                return (gunfarki + 365);
            }

        }
        private void TumunuYukle()
        {
            dgvEmanetler.DataSource = es.TumEmanetleriGetir();
            Gorunmezler();
            BirimCeza = Convert.ToInt32(dgvEmanetler.Rows[0].Cells[12].Value);
            
        }
        private void FrmKitapGeriAl_Load(object sender, EventArgs e)
        {
            btnKitapGeriAl.Enabled = false;
            TumunuYukle();
            pnlKullaniciIdeGore.BringToFront();
            //dtpIEdilişTarihi.Text = DateTime.Now.ToShortDateString();
        }

       

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbKullaniciIdyeGore.Checked)
            {
                pnlKullaniciIdeGore.BringToFront();
                if (string.IsNullOrEmpty(txtKullaniciId.Text))
                {
                    MessageBox.Show("boş geçmeyin");
                }
                else
                {
                    int KulId = Convert.ToInt32(txtKullaniciId.Text);
                    if (kls.KullaniciBulFromEmanetler(KulId))
                    {
                        dgvEmanetler.DataSource = es.KullanicininEmanetleriniGetir(KulId);
                        Gorunmezler();
                       
                    }
                    else
                    {
                        MessageBox.Show("id yanlış veya üzerinde kitap yok");
                    }
                }
            }
            if (rbBarkodaGore.Checked)
            {
                pnlBarkodaGore.BringToFront();
                if (string.IsNullOrEmpty(txtBarkod.Text))
                {
                    MessageBox.Show("boş geçmeyin");
                }
                else
                {
                   
                    if (ks.KitapKontrolByBarkodno(txtBarkod.Text))
                    {
                        dgvEmanetler.DataSource =es.BarkodaGoreGetir(txtBarkod.Text);
                        Gorunmezler();
                        
                    }
                    else
                    {
                        MessageBox.Show("barkodu doğru girdiğinixden emin olun");
                    }
                }
            }
            if (rbKitapAdinaGore.Checked)
            {
                pnlKitapAdGore.BringToFront();
                if (string.IsNullOrEmpty(txtKitapAdi.Text))
                {
                    MessageBox.Show("boş geçmeyin");
                }
                else
                {
                   
                    if (ks.AdiIcerenKitapVarmi(txtKitapAdi.Text))
                    {
                        dgvEmanetler.DataSource = es.KitapAdaGoreGetir(txtKitapAdi.Text);
                        Gorunmezler();
                       
                    }
                    else
                    {
                        MessageBox.Show("id yanlış veya üzerinde kitap yok");
                    }
                }
            }

        }

        private void rbKullaniciIdyeGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKullaniciIdeGore.BringToFront();
        }

        private void rbBarkodaGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlBarkodaGore.BringToFront();
        }

        private void rbKitapAdinaGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKitapAdGore.BringToFront();
        }

        private void btnKitapGeriAl_Click(object sender, EventArgs e)
        {
            Emanetler emanet = new Emanetler();
            emanet.EmanetID = SecilenEmanetId;
            emanet.KIEdildigiTarih = dtpIEdilişTarihi.Value;
            emanet.GGunSayisi = GGunSayisi;
            emanet.ToplamCeza = TopCeza;
            if (es.EmanetiGeriAl(emanet) &&  ks.KitapDurumDegistirByKitapGeriAl(SecilenKitapId))
            {
                MessageBox.Show("kitap iade edildi");
            }
            else
            {
                MessageBox.Show("hata");
            }
            Temizle();
        }
        private void Temizle()
        {
            txtKullaniciId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtKitapAd.Clear();
            txtYazar.Clear();
            txtTopCeza.Clear();
            txtGGunSayisi.Clear();
            //datetime için clear aşağıdaki gibi yapılır!
            dtpIEdilecekTarih.Text =DateTime.Now.ToShortDateString();
            dtpVerilisTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void btnTumunuGetir_Click(object sender, EventArgs e)
        {
            TumunuYukle();
        }

        private void dgvEmanetler_DoubleClick(object sender, EventArgs e)
        {
            btnKitapGeriAl.Enabled = true;
            txtKitapAd.Text = dgvEmanetler.SelectedRows[0].Cells[6].Value.ToString();
            txtAd.Text = dgvEmanetler.SelectedRows[0].Cells[3].Value.ToString();
            txtSoyad.Text = dgvEmanetler.SelectedRows[0].Cells[4].Value.ToString();
            txtYazar.Text = dgvEmanetler.SelectedRows[0].Cells[7].Value.ToString();
            dtpVerilisTarihi.Text = dgvEmanetler.SelectedRows[0].Cells[10].Value.ToString();
            dtpIEdilecekTarih.Text = dgvEmanetler.SelectedRows[0].Cells[11].Value.ToString();
            SecilenKitapId = Convert.ToInt32(dgvEmanetler.SelectedRows[0].Cells[2].Value);
           
            SecilenEmanetId = Convert.ToInt32(dgvEmanetler.SelectedRows[0].Cells[0].Value);

            //ceza kontorulu
            if (dtpIEdilişTarihi.Value > dtpIEdilecekTarih.Value)
            {
                //tarihler arası farkı timespan kullanımı ile yapıyoruz..
                TimeSpan TarihFarki = dtpIEdilişTarihi.Value - dtpIEdilecekTarih.Value;

                GunFarki = Convert.ToInt32(TarihFarki.Days);

                //yıl atlamalarını -negatif değer verme ihtimali- dikkate almalıyız.(29 şubat durumu vs. gözardı ediyoruz.)
                txtGGunSayisi.Text = TarihFarkiBul(GunFarki).ToString();
                GGunSayisi = Convert.ToInt32(txtGGunSayisi.Text);
                txtTopCeza.Text = (BirimCeza * TarihFarkiBul(GunFarki)).ToString();
                TopCeza = Convert.ToDecimal(BirimCeza * TarihFarkiBul(GunFarki));
            }
            else
            {
                txtGGunSayisi.Text = "0";
                txtTopCeza.Text = "0";
            }
        }
    }
}
