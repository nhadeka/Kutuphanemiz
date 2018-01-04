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
    public partial class FrmKullaniciGuncelle : Form
    {
        public FrmKullaniciGuncelle()
        {
            InitializeComponent();
        }
        int SecilenKullaniciID;
        KullanicilarServis kls = new KullanicilarServis();
        EmanetlerServis es = new EmanetlerServis();

        private void FrmKullaniciGuncelle_Load(object sender, EventArgs e)
        {
            pnlKullaniciIDyeGore.BringToFront();
           
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            Doldur();
        }
        private void Doldur()
        {
            dgvKullanicilar.DataSource = kls.TumKullanicilariYukle();
            dgvKullanicilar.Columns[0].Visible = false;
            dgvKullanicilar.Columns[1].Visible = false;
            dgvKullanicilar.Columns[2].Visible = false;
            dgvKullanicilar.Columns[8].Visible = false;
            dgvKullanicilar.Columns[10].Visible = false;
            dgvKullanicilar.Columns[11].Visible = false;
            dgvKullanicilar.Columns[12].Visible = false;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (es.UzerindeKitapVarmi(SecilenKullaniciID))
            {
                if (kls.KullaniciSil(SecilenKullaniciID))
                {
                    MessageBox.Show("Kullanıcı Silindi.", "Silme İşlemi");
                    Doldur();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Silinemedi..", "Hata Mesajı");
                }
            }
            else
            {
                MessageBox.Show("üzerinde emanet kitap varken kullanıcı silinemez.");
            }
            Temizle();
        }
        private void Temizle()
        {
            txtTcKNo.Clear();
            txtKullaniciTuru.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            mtxtTelno.Clear();
            txtEmail.Clear();
            txtIlce.Clear();
            txtAdres.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar guncel = new Kullanicilar();
            guncel.KullaniciID = SecilenKullaniciID;
            guncel.TCKNo = txtTcKNo.Text;
            guncel.KullaniciTuru = txtKullaniciTuru.Text;
            guncel.Ad = txtAd.Text;
            guncel.Soyad = txtSoyad.Text;
            guncel.TelNo = mtxtTelno.Text;
            guncel.Adres = txtAdres.Text;
            guncel.Ilce = txtIlce.Text;
            guncel.Il = txtIl.Text;
            guncel.Eposta = txtEmail.Text;
            guncel.Sifre = txtSifre.Text;

            if (kls.KulaniciGuncelle(guncel))
            {
                MessageBox.Show("güncellendi");
                Doldur();
            }
            else
            {
                MessageBox.Show("güncellenemedi");
            }
            Temizle();
        }

        private void dgvKullanicilar_DoubleClick(object sender, EventArgs e)
        {
            SecilenKullaniciID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells[0].Value);
            txtTcKNo.Text = dgvKullanicilar.SelectedRows[0].Cells[1].Value.ToString();
            txtKullaniciTuru.Text = dgvKullanicilar.SelectedRows[0].Cells[2].Value.ToString();
            txtAd.Text = dgvKullanicilar.SelectedRows[0].Cells[3].Value.ToString();
            txtSoyad.Text = dgvKullanicilar.SelectedRows[0].Cells[4].Value.ToString();
            mtxtTelno.Text = dgvKullanicilar.SelectedRows[0].Cells[5].Value.ToString();
            txtAdres.Text = dgvKullanicilar.SelectedRows[0].Cells[6].Value.ToString();
            txtIlce.Text = dgvKullanicilar.SelectedRows[0].Cells[7].Value.ToString();
            txtIl.Text = dgvKullanicilar.SelectedRows[0].Cells[8].Value.ToString();
            txtEmail.Text = dgvKullanicilar.SelectedRows[0].Cells[9].Value.ToString();
            txtSifre.Text = dgvKullanicilar.SelectedRows[0].Cells[10].Value.ToString();
            dtpUyelikTarihi.Value = Convert.ToDateTime(dgvKullanicilar.SelectedRows[0].Cells[11].Value);
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void rbKullaniciIDGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlKullaniciIDyeGore.BringToFront();
        }

        private void rbAdSoyadaGore_CheckedChanged(object sender, EventArgs e)
        {
            pnlAdSoyadaGore.BringToFront();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            if (rbKullaniciIDGore.Checked)
            {
                pnlKullaniciIDyeGore.BringToFront();
                if (string.IsNullOrEmpty(txtKullaniciID.Text))
                {
                    MessageBox.Show("kullanıcı id giriniz");
                }
               
                else
                {
                  int  ArananKullaniciID = Convert.ToInt32(txtKullaniciID.Text);

                    if (kls.KullaniciVarmi(ArananKullaniciID))
                    {
                        dgvKullanicilar.DataSource =kls.IDliKullaniciyiGetir(ArananKullaniciID);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu id de kullanıcı bulunmamaktadır.");

                    }
                    txtKullaniciID.Clear();
                }
            }
            if(rbAdSoyadaGore.Checked)
            {
                pnlAdSoyadaGore.BringToFront();
                if (string.IsNullOrEmpty(txtKullanici.Text))
                {
                    MessageBox.Show("ad veya soyad giriniz");
                }
                
                else
                {
                    if (kls.AdiniIcerenKullaniciVarmi(txtKullanici.Text))
                    {
                        dgvKullanicilar.DataSource = kls.AdiniIcerenKullanicilariGetir(txtKullanici.Text);
                    }
                    else
                    {
                        MessageBox.Show("kütüphanemizde bu isimde kullanıcı bulunmamaktadır");

                    }
                    txtKullaniciID.Clear();
                }
            }
        }

        private void btnTumUyeleriGetir_Click(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
