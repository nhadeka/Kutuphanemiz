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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        KullanicilarServis kls = new KullanicilarServis();
       
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciID.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("lütfen kullanıcı adı ve şifre alanlarını doldurunuz");
                txtKullaniciID.Focus();
                return;
            }
            else
            {
                csGenel.KullaniciIdFromLogin = Convert.ToInt32(txtKullaniciID.Text);
                if (kls.KullaniciBulFromLogin(csGenel.KullaniciIdFromLogin, txtSifre.Text))
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
                else
                {
                    MessageBox.Show("doğru id ve şifre girdiğinizden emin olunuz.");
                }




            }
        }



        private void cbSifreGoster_CheckedChanged(object sender, EventArgs e)
        {


            if (cbSifreGoster.Checked)
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbSifreGoster.Checked = false;
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
