using Kutuphanemiz.BLL;
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
    public partial class FrmSifreDegistir : Form
    {
        public FrmSifreDegistir()
        {
            InitializeComponent();
        }
        KullanicilarServis kls = new KullanicilarServis();
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEskiSifre.Text) || string.IsNullOrEmpty(txtYeniSifre.Text) || string.IsNullOrEmpty(txtYeniSifre2.Text))
            {
                MessageBox.Show("alanları boş bırakmayın");
            }

            else
            {
                if (kls.KullaniciBulFromLogin(csGenel.KullaniciIdFromLogin, txtEskiSifre.Text))
                {

                    if (txtYeniSifre.Text == txtYeniSifre2.Text)
                    {
                        Kullanicilar kul = new Kullanicilar();

                        kul.KullaniciID = csGenel.KullaniciIdFromLogin;
                        kul.Sifre = txtYeniSifre2.Text;
                        if (kls.SifreDegistir(kul))
                        {
                            MessageBox.Show("değişti");
                        }
                        else
                        {
                            MessageBox.Show("hata");
                        }
                    }
                    else
                    {
                        MessageBox.Show("aynı yeni şifreyi girdiğinizden emin olun");
                    }
                }
              else
              {
                 MessageBox.Show("eski şifrenizi doğru girdiğinizden emin olun.");
              }



            }



        }




    }
}
