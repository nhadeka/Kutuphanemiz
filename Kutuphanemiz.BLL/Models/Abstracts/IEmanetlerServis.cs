using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
  public  interface IEmanetlerServis
    {
        bool EmanetiKaydet(Emanetler emanet);
        List<EmanetlerView> TumEmanetleriGetir();
        List<EmanetlerView> KullanicininEmanetleriniGetir(int id);
        bool EmanetiGeriAl(Emanetler emanet);

        bool UstundekiKitapSayisi(int kullaniciId);
        List<EmanetlerView> KullanicininGecmisi(int id);
        bool UzerindeKitapVarmi(int kullaniciid);
        List<EmanetlerView> BarkodaGoreGetir(string barkod);
        List<EmanetlerView> KitapAdaGoreGetir(string kitapad);

    }
}
