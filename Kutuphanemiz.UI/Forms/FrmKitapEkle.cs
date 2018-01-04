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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }
        KitaplarServis ks = new KitaplarServis();
        YayinevleriServis ys = new YayinevleriServis();
        YazarlarServis yzs = new YazarlarServis();
        KategorilerServis kts = new KategorilerServis();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBarkodNo.Text) || string.IsNullOrEmpty(txtKitapAd.Text) || string.IsNullOrEmpty(txtYazarAd.Text) || string.IsNullOrEmpty(txtYazarSoyad.Text) || string.IsNullOrEmpty(txtYayineviAd.Text) || string.IsNullOrEmpty(cbKategoriler.Text))
            {
                MessageBox.Show("boş alan bırakmayınız");
            }


            else
            {
                if (ks.KitapKontrolByBarkodno(txtBarkodNo.Text))
                {
                    MessageBox.Show("kitap zaten kayıtlı");
                }
                else
                {


                    //kitap kayıtlı değil,bu yeni kitabı ekliyoruz.
                    //eklemek istediğimiz kitap bilgilerini, yeni bir kitaplar nesnesi açıp içine dolduruyoruz.
                    Kitaplar k = new Kitaplar();
                    k.Barkod = txtBarkodNo.Text;
                    k.KitapAd = txtKitapAd.Text;
                    k.Adet = 1;
                    k.EkTarihi = dtpEklenmeTarihi.Value;
                    k.Durum = "serbest";

                    //secilen kategori isminden kategoriID sini bulup,k nesnesine ekliyoruz.
                    string kategori = cbKategoriler.SelectedItem.ToString();
                    k.KategoriID = kts.KategoriIdBul(kategori);


                    //kitaplar tablosuna eklemek için yayıneviID sini bulmak üzere yayınevinin kayıtlı olup olmadığına bakıyoruz.
                    if (ys.YayineviKontrolByIsim(txtYayineviAd.Text))
                    {
                        //yayınevi kayıtlı olduğundan yayınevleri tablosundan yayineviID sini çekip,açmış olduğumuz k nesnesine ekliyoruz.
                        MessageBox.Show("yayınevi kayıtlı");
                        k.YayineviID = ys.YayineviIdBulByIsim(txtYayineviAd.Text);
                    }
                    else
                    {
                        //yayınevi kayıtlı olmadığından yeni yayınevini yayınevleri tablosuna ekliyoruz.
                        Yayinevleri y = new Yayinevleri();
                        y.YayineviAd = txtYayineviAd.Text;
                        ys.YayineviEkle(y);

                        //eklediğimiz yayınevinin IDsini alıp,açmış olduğumuz k nesnesine ekliyoruz.
                        k.YayineviID = y.YayineviID;
                    }
                    //yukarıda açtığımız k nesnenin yayineviID sini eklemiş olduk.


                    //kitaplar tablosuna eklemek için yazarID sini bulmak üzere yazarın kayıtlı olup olmadığına bakıyoruz.
                    if (yzs.YazarKontrolByIsim(txtYazarAd.Text, txtYazarSoyad.Text))
                    {
                        //yazar kayıtlı olduğundan yazarlar tablosundan yazarID sini çekip, açmış olduğumuz k nesnesine) ekliyoruz.
                        MessageBox.Show("yazar kayıtlı");
                        k.YazarID = yzs.YazarIdBulByIsim(txtYazarAd.Text, txtYazarSoyad.Text);
                    }
                    else
                    {
                        //yazar kayıtlı olmadığından yeni yazarı yazarlar tablosuna ekliyoruz.
                        Yazarlar yz = new Yazarlar();
                        yz.YazarAd = txtYazarAd.Text;
                        yz.YazarSoyad = txtYazarSoyad.Text;
                        yzs.YazarEkle(yz);

                        //eklediğimiz yazarun IDsini alıp,açmış olduğumuz k nesnesine ekliyoruz.
                        k.YazarID = yz.YazarID;
                    }
                    //yukarıda açtığımız k nesnenin yazarID sini eklemiş olduk.




                    //bu yeni kitabı ekliyoruz.
                    if (ks.KitapEkle(k))
                    {
                        MessageBox.Show("yeni kitap kaydedildi");
                    }
                    else
                    {
                        MessageBox.Show("kaydedilemedi");
                    }


                }



            }
            Temizle();


        }
        private void Temizle()
        {
            txtBarkodNo.Clear();
            txtKitapAd.Clear();
            txtYazarAd.Clear();
            txtYayineviAd.Clear();
            txtYazarSoyad.Clear();
        }

        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
            cbKategoriler.DataSource = kts.KategorileriGetir();
        }
    }
}
