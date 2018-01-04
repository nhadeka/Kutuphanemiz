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
    public partial class FrmKitapGuncelle : Form
    {
        public FrmKitapGuncelle()
        {
            InitializeComponent();
        }
        KitaplarServis ks = new KitaplarServis();
        KategorilerServis kts = new KategorilerServis();
        YazarlarServis yzs = new YazarlarServis();
        YayinevleriServis yys = new YayinevleriServis();
        int SecilenKitapID, SecilenKategoriID, SecilenYazarID, SecilenYayineviID;

        

        private void FrmKitapGuncelle_Load(object sender, EventArgs e)
        {
            Yukle();
           
            

            pnlKitapaGore.BringToFront();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void dgvKitaplar_DoubleClick(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;

            txtBarkodNosu.Text = dgvKitaplar.SelectedRows[0].Cells[2].Value.ToString();
            txtKitapAdi.Text = dgvKitaplar.SelectedRows[0].Cells[3].Value.ToString();

            txtYazarAd.Text = dgvKitaplar.SelectedRows[0].Cells[5].Value.ToString();
            txtYazarSoyad.Text = dgvKitaplar.SelectedRows[0].Cells[6].Value.ToString();
            txtYayineviAd.Text = dgvKitaplar.SelectedRows[0].Cells[7].Value.ToString();
            cbKategoriler.Text = dgvKitaplar.SelectedRows[0].Cells[4].Value.ToString();
           

            SecilenKitapID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[1].Value);
            SecilenKategoriID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[9].Value);
            SecilenYazarID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[10].Value);
            SecilenYayineviID = Convert.ToInt32(dgvKitaplar.SelectedRows[0].Cells[11].Value);

        }
        private void Yukle()
        {
            cbKategoriler.DataSource = kts.KategorileriGetir();
            dgvKitaplar.DataSource = ks.KitaplariYukleByKitapGuncelle();
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].Visible = false;
            dgvKitaplar.Columns[8].Visible = false;
            dgvKitaplar.Columns[9].Visible = false;
            dgvKitaplar.Columns[10].Visible = false;
            dgvKitaplar.Columns[11].Visible = false;
        }

        private void rbKitapAdinaGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKitapaGore.BringToFront();
        }

        private void rbBarkodaGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlBarkodaGore.BringToFront();
        }

        private void rbYazaraGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlYazaraGore.BringToFront();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {


            if (rbKitapAdinaGore.Checked)
            {
                pnlKitapaGore.BringToFront();
                if (string.IsNullOrEmpty(txtKitapAd.Text))
                {
                    MessageBox.Show("kitap adı giriniz");
                }
                else
                {
                    if (ks.AdiIcerenKitapVarmi(txtKitapAd.Text))
                    {
                        dgvKitaplar.DataSource = ks.AdiIcerenKitaplariGetirKG(txtKitapAd.Text);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu isimde kitap bulunmamaktadır veya ödünç alınmıştır.");

                    }
                    txtKitapAd.Clear();
                }

            }
            if (rbYazaraGore.Checked)
            {
                pnlYazaraGore.BringToFront();
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
            if (rbBarkodaGore.Checked)
            {


                pnlBarkodaGore.BringToFront();

                if (string.IsNullOrEmpty(txtBarkod.Text))
                {
                    MessageBox.Show("barkodu giriniz");
                }
                else
                {
                    if (ks.KitapKontrolByBarkodno(txtBarkod.Text))
                    {
                        dgvKitaplar.DataSource = ks.BarkodaGoreGetir(txtBarkod.Text);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu isimdeki yazarın bir kitabı  bulunmamaktadır");
                    }
                    txtBarkod.Clear();
                }


            }

        }

        private void btnTumKitaplariGetir_Click(object sender, EventArgs e)
        {
            Temizle();
            Yukle();
        }

        private void Temizle()
        {
            txtBarkodNosu.Clear();
            txtKitapAdi.Clear();
            txtYazarAd.Clear();
            txtYazarSoyad.Clear();
            txtYayineviAd.Clear();
           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            if ((txtKitapAdi.Text == dgvKitaplar.SelectedRows[0].Cells[2].Value.ToString()) && (txtBarkodNosu.Text == dgvKitaplar.SelectedRows[0].Cells[1].Value.ToString()) && (txtYayineviAd.Text == dgvKitaplar.SelectedRows[0].Cells[6].Value.ToString()) && (txtYazarAd.Text == dgvKitaplar.SelectedRows[0].Cells[4].Value.ToString()) && (txtYazarSoyad.Text == dgvKitaplar.SelectedRows[0].Cells[5].Value.ToString()) && (cbKategoriler.Text == dgvKitaplar.SelectedRows[0].Cells[3].Value.ToString()) )
            {
                MessageBox.Show("aynı bilgiler zaten kayıtlı, herhangi bir değişiklik yapmadınız");
            }

            else
            {

                Kitaplar degisenk = new Kitaplar();
                degisenk.KitapID = SecilenKitapID;
                degisenk.KitapAd = txtKitapAdi.Text;
                degisenk.Barkod = txtBarkodNosu.Text;
                degisenk.KategoriID = kts.KategoriIdBul(cbKategoriler.SelectedItem.ToString());

                if ((txtKitapAdi.Text != dgvKitaplar.SelectedRows[0].Cells[2].Value.ToString()) || (txtBarkodNosu.Text != dgvKitaplar.SelectedRows[0].Cells[1].Value.ToString())|| (cbKategoriler.Text != dgvKitaplar.SelectedRows[0].Cells[3].Value.ToString()))
                {
                    if (ks.KitapGuncelle(degisenk))
                    {
                        MessageBox.Show("kitap  guncellendi");
                    }
                    else
                    {
                        MessageBox.Show("hata kitap güncellenemedi");
                    }
                }



                //yayınevi değiştirilmiş ise yayınevi tablosundan güncelleme yapılır.
                if (txtYayineviAd.Text != dgvKitaplar.SelectedRows[0].Cells[6].Value.ToString())
                {
                    Yayinevleri yy = new Yayinevleri();
                    yy.YayineviID = SecilenYayineviID;
                    yy.YayineviAd = txtYayineviAd.Text;
                    if (yys.YayineviGuncelle(yy))
                    {
                        degisenk.YayineviID = yy.YayineviID;
                        MessageBox.Show("yayınevi guncellendi");
                    }
                    else
                    {
                        MessageBox.Show("hata yayınevi guncellenemedi");
                    }

                }


                //yazar değiştirilmiş ise yazar tablosundan güncelleme yapılır.
                if ((txtYazarAd.Text != dgvKitaplar.SelectedRows[0].Cells[4].Value.ToString()) || (txtYazarSoyad.Text != dgvKitaplar.SelectedRows[0].Cells[5].Value.ToString()))
                {
                    Yazarlar yz = new Yazarlar();
                    yz.YazarID = SecilenYazarID;
                    yz.YazarAd = txtYazarAd.Text;
                    yz.YazarSoyad = txtYazarSoyad.Text;
                    if (yzs.YazarGuncelle(yz))
                    {
                        degisenk.YazarID = yz.YazarID;
                        MessageBox.Show("yazar guncellendi");
                    }
                    else
                    {
                        MessageBox.Show("hata yazar guncellenemedi");
                    }
                }

               

            }
            Temizle();
            Yukle();
        }

      

        private void btnSil_Click(object sender, EventArgs e)
        {
            //dgv de zaten serbest olan kitaplar gösterild. silinecek kitap üyede mi kontrolüne gerek yok.
            if (ks.KitapSil(SecilenKitapID))
            {
                MessageBox.Show("kitap silindi");

            }
            else
            {
                MessageBox.Show("hata");
            }
            Yukle();
            Temizle();
        }

      

    }
}
