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
    public partial class FrmUzerimdekiKitaplar : Form
    {
        public FrmUzerimdekiKitaplar()
        {
            InitializeComponent();
        }
        int GunFarki;
       
        EmanetlerServis es = new EmanetlerServis();
        KullanicilarServis kls = new KullanicilarServis();
        private void FrmUzerimdekiKitaplar_Load(object sender, EventArgs e)
        {
            pnlKapsayici.Location = new Point(this.ClientSize.Width / 2 - pnlKapsayici.Size.Width / 2, this.ClientSize.Height / 2 - pnlKapsayici.Size.Height / 2);
            pnlKapsayici.Anchor = AnchorStyles.None;
            pnlKapsayici.SendToBack();







            dgvUKitaplar.DataSource = es.KullanicininEmanetleriniGetir(csGenel.KullaniciIdFromLogin);
            Gorunmezler();
            DateTime IEdilecekTarih, Bugun;
            Bugun = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            int BirimCeza =Convert.ToInt32( dgvUKitaplar.Rows[0].Cells[12].Value);
            for (int k = 0; k < dgvUKitaplar.Rows.Count; k++)
            {
                IEdilecekTarih = Convert.ToDateTime(dgvUKitaplar.Rows[k].Cells[11].Value);


                if (Bugun > IEdilecekTarih)
                {
                    TimeSpan TarihFarki = Bugun - IEdilecekTarih;

                    GunFarki = Convert.ToInt32(TarihFarki.Days);

           //yıl atlamalarını -negatif değer verme ihtimali- dikkate almalıyız.Bu yüzden tarihfarkıbul adlı yeni bir metod oluşturuyoruz.(29 şubat durumu vs. gözardı ediyoruz.)
                
                    dgvUKitaplar.Rows[k].Cells[14].Value = TarihFarkiBul(GunFarki).ToString();
                    dgvUKitaplar.Rows[k].Cells[15].Value = Convert.ToDecimal(BirimCeza * TarihFarkiBul(GunFarki));

                }
                else
                {
                    dgvUKitaplar.Columns[14].Visible = false;
                    dgvUKitaplar.Columns[15].Visible = false;
                }
            }
        
           
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
        private void Gorunmezler()
        {
            dgvUKitaplar.Columns[0].Visible = false;
            dgvUKitaplar.Columns[1].Visible = false;
            dgvUKitaplar.Columns[2].Visible = false;
            dgvUKitaplar.Columns[9].Visible = false;
            dgvUKitaplar.Columns[12].Visible = false;
            dgvUKitaplar.Columns[13].Visible = false;
            dgvUKitaplar.Columns[16].Visible = false;

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
