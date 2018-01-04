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
    public partial class FrmKitapVer : Form
    {
        public FrmKitapVer()
        {
            InitializeComponent();
        }
        int SecilenUyeid, SecilenKitapid;
        KullanicilarServis kls = new KullanicilarServis();
        KitaplarServis ks = new KitaplarServis();
        EmanetlerServis es = new EmanetlerServis();
        YayinevleriServis yys = new YayinevleriServis();
        YazarlarServis yzs = new YazarlarServis();
        private void FrmKitapVer_Load(object sender, EventArgs e)
        {
            dtpIEdilecekTarih.Text = dtpVerilisTarihi.Value.AddDays(7).ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (es.UstundekiKitapSayisi(SecilenUyeid))
            {
                Emanetler emanet = new Emanetler();
                emanet.KullaniciID = Convert.ToInt32(txtUyeId.Text);
                emanet.KitapID = Convert.ToInt32(txtBarkod.Text);
                emanet.KVerilisTarihi = dtpVerilisTarihi.Value;
                emanet.KIEdilecekTarih = dtpIEdilecekTarih.Value;
                if (ks.KitapUyedeMi(SecilenKitapid))
                {
                    MessageBox.Show("kitap başka bir üyede");
                }
               
               

                else
                {
                    if (es.EmanetiKaydet(emanet) && ks.KitapDurumDegistirByKitapVer(SecilenKitapid))
                    {
                        MessageBox.Show("kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("hata");
                    }
                }
            }

            else
            {
                MessageBox.Show("Alabileceginiz kitap sayısı maksimum 3 tanedir.");
            }
            Temizle();

        }
        private void Temizle()
        {
            txtKitapAd.Clear();
            txtBarkod.Clear();
            txtUyeAd.Clear();
            txtUyeId.Clear();
            txtUyeSoyad.Clear();
            txtYayinevi.Clear();
            txtYazar.Clear();
        }

        private void btnUyeBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUyeId.Text))
            {
                MessageBox.Show("boş geçmeyin");
                txtUyeId.Focus();
            }
            else
            {
                SecilenUyeid = Convert.ToInt32(txtUyeId.Text);
                if (kls.KullaniciVarmi(SecilenUyeid))
                {
                    Kullanicilar kul = kls.KullaniciyiGetir(SecilenUyeid);
                    txtUyeAd.Text = kul.Ad;
                    txtUyeSoyad.Text = kul.Soyad;
                }
                else
                {
                    MessageBox.Show("kullanıcı id sini doğru girdiğinizden emin olun");
                }
            }
        }

        private void btnKitapBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUyeId.Text))
            {
                MessageBox.Show("boş geçmeyin");
                txtBarkod.Focus();
            }
            else
            {
               
                if (ks.KitapKontrolByBarkodno(txtBarkod.Text))
                {
                    Kitaplar k = ks.KitabiGetirKV(txtBarkod.Text);
                    txtKitapAd.Text = k.KitapAd;
                    txtYayinevi.Text = yys.YayineviAdGetir(k.YayineviID);
                    txtYazar.Text = yzs.YazarAdGetir(k.YazarID);
                  
                }
                else
                {
                    MessageBox.Show("kitap id sini doğru girdiğinizden emin olun");
                }
            }
        }
    }
}
