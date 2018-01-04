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
    public partial class FrmKullaniciBilgi : Form
    {
        public FrmKullaniciBilgi()
        {
            InitializeComponent();
        }
        KullanicilarServis kls = new KullanicilarServis();
        private void FrmKullaniciBilgi_Load(object sender, EventArgs e)
        {
            Kullanicilar k = kls.KullaniciyiGetir(csGenel.KullaniciIdFromLogin);
            txtAd.Text = k.Ad;
            txtSoyad.Text = k.Soyad;
            mtxtTelno.Text = k.TelNo;
            txtEmail.Text = k.Eposta;
            dtpUyelikTarihi.Text =Convert.ToDateTime( k.KayitTarihi).ToString();
            txtIlce.Text = k.Ilce;
            txtAdres.Text = k.Adres;


        }
    }
}
