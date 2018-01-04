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
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        KullanicilarServis kls = new KullanicilarServis();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text)|| string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtIl.Text) || string.IsNullOrEmpty(txtIlce.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTcKNo.Text) || string.IsNullOrEmpty(mtxtTelno.Text)  )
            {
                MessageBox.Show("boş bırakmayın");
            }
            else
            {
                if (kls.KullaniciKontrolByTcNo(txtTcKNo.Text))
                {
                    MessageBox.Show("zaten kayıtlı üye");
                }
                else
                {
                    Kullanicilar kul = new Kullanicilar();
                    kul.TCKNo = txtTcKNo.Text;
                    kul.KullaniciTuru = "üye";
                    kul.Ad = txtAd.Text;
                    kul.Soyad = txtSoyad.Text;
                    kul.TelNo = mtxtTelno.Text;
                    kul.Adres = txtAdres.Text;
                    kul.Ilce = txtIlce.Text;
                    kul.Il = "istanbul";
                    kul.Eposta = txtEmail.Text;
                    kul.Sifre = txtSifre.Text;
                    kul.KayitTarihi = dtpUyelikTarihi.Value;

                    if (kls.KullaniciEkle(kul))
                    {
                        txtSifre.Text = (kls.EklenenKullaniciId(txtTcKNo.Text)).ToString();
                        MessageBox.Show("kaydedildi");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("kaydedilemedi");
                    }
                }
            }
        }
        private void Temizle()
        {
            txtTcKNo.Clear();
           
            txtAd.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            mtxtTelno.Clear();
            txtEmail.Clear();
            txtIlce.Clear();
            txtAdres.Clear();
        }

        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSifreGoster .Checked)
            {
                //karakteri göster.
                txtSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

   

     
    }
}
