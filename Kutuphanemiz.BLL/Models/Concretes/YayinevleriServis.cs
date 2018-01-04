using Kutuphanemiz.BLL.Models.Abstracts;
using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Concretes
{
  public  class YayinevleriServis:IYayinevleriServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();
        public bool YayineviEkle(Yayinevleri y)
        {
            //Arakatmana ekliyoruz.
            ent.Yayinevleri.Add(y);
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool YayineviGuncelle(Yayinevleri degiseceky)
        {
            Yayinevleri guncely = (from y in ent.Yayinevleri
                                   where y.YayineviID == degiseceky.YayineviID
                                   select y).FirstOrDefault();
            guncely.YayineviAd = degiseceky.YayineviAd;
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int YayineviIdBulByIsim(string yayineviisim)
        {
            int yayineviid = (from y in ent.Yayinevleri
                              where y.YayineviAd == yayineviisim
                              select y.YayineviID).FirstOrDefault();
            return yayineviid;
        }

        public bool YayineviKontrolByIsim(string yayinevisim)
        {
            var Yayinevi = ent.Yayinevleri.Where(c => c.YayineviAd == yayinevisim).FirstOrDefault();

            if (Yayinevi == null)
            {
                //yayinevi kayıtlı değil
                return false;
            }

            else
            {

                //yayinevi kayıtlı zaten
                return true;
            }
        }
        public string YayineviAdGetir(int yayineviid)
        {
            string yAd = (from y in ent.Yayinevleri
                          where y.YayineviID == yayineviid
                          select y.YayineviAd).FirstOrDefault();
            return yAd;
        }
    }
}
