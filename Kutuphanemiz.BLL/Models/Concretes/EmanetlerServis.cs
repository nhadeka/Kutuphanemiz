using Kutuphanemiz.BLL.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphanemiz.DAL.DataModel;

namespace Kutuphanemiz.BLL.Models.Concretes
{
    public class EmanetlerServis : IEmanetlerServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();
        public bool EmanetiKaydet(Emanetler emanet)
        {
            ent.Emanetler.Add(emanet);
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmanetiGeriAl(Emanetler emanet)
        {
            Emanetler guncel = (from emnt in ent.Emanetler
                                where emnt.EmanetID == emanet.EmanetID
                                select emnt).FirstOrDefault();

            guncel.KIEdildigiTarih = emanet.KIEdildigiTarih;
            guncel.GGunSayisi = emanet.GGunSayisi;
            guncel.ToplamCeza = emanet.ToplamCeza;
            guncel.Silindi = true;

            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<EmanetlerView> KullanicininEmanetleriniGetir(int id)
        {
            List<EmanetlerView> elist = (from el in ent.EmanetlerView
                                         where el.KullaniciID == id && el.Silindi == false
                                         select el).ToList();
            return elist;
        }

        public List<EmanetlerView> TumEmanetleriGetir()
        {


          
            List<EmanetlerView> elist = (from el in ent.EmanetlerView
                                         where  el.Silindi == false
                                         select el).ToList();



            return elist;
        }

       
        public bool UstundekiKitapSayisi(int kullaniciId)
        {
            int KitapSayisi = (from k in ent.Emanetler
                               where k.KullaniciID == kullaniciId && k.Silindi == false
                               select k.EmanetID).Count();

            if (KitapSayisi > 3)
            {
                //maksimum kitap sayısını aldınız, 3 kitaptan fazla alamazsınız.
                return false;
            }
            else
            {
                //3 kitap sayısından az oldugu için kitap alabilirsiniz.
                return true;
            }
        }
        public List<EmanetlerView> KullanicininGecmisi(int id)
        {
            List<EmanetlerView> elist = (from el in ent.EmanetlerView
                                         where el.KullaniciID == id && el.Silindi == true
                                         select el).ToList();
            return elist;
        }

        public bool UzerindeKitapVarmi(int kullaniciid)
        {
            int emanetsayisi = (from em in ent.Emanetler
                                where em.KullaniciID == kullaniciid && em.Silindi == false
                                select em).Count();
            if (emanetsayisi == 0)
            {
                //emanet olmad. kullanıcı silinebilir.
                return true;
            }
            else
            {
                //emanet old. kullanıcı silinemez.
                return false;
            }
        }

        public List<EmanetlerView> BarkodaGoreGetir(string barkod)
        {
            List<EmanetlerView> elist = (from list in ent.EmanetlerView
                                           where list.Barkod == barkod && list.Silindi==false
                                           select list).ToList();
            return elist;
        }
        public List<EmanetlerView> KitapAdaGoreGetir(string kitapad)
        {
            List<EmanetlerView> elist = (from list in ent.EmanetlerView
                                         where list.KitapAd == kitapad && list.Silindi == false
                                         select list).ToList();
            return elist;
        }

    }
}
