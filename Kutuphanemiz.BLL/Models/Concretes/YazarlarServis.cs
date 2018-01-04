using Kutuphanemiz.BLL.Models.Abstracts;
using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Concretes
{
  public  class YazarlarServis:IYazarlarServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();
        public bool YazarEkle(Yazarlar yz)
        {
            //Arakatmana ekliyoruz.
            ent.Yazarlar.Add(yz);
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool YazarKontrolByIsim(string yazarisim, string yazarsoyad)
        {
            var Yazar = ent.Yazarlar.Where(yz => yz.YazarAd == yazarisim && yz.YazarSoyad == yazarsoyad).FirstOrDefault();

            if (Yazar == null)
            {
                //yazar kayıtlı değil
                return false;
            }

            else
            {

                //yazar kayıtlı zaten
                return true;
            }
        }
        public int YazarIdBulByIsim(string yazarisim, string yazarsoyad)
        {
            int yazarid = (from yz in ent.Yazarlar
                           where yz.YazarAd == yazarisim && yz.YazarSoyad == yazarsoyad
                           select yz.YazarID).FirstOrDefault();
            return yazarid;
        }


        public bool YazarGuncelle(Yazarlar degisecekyz)
        {
            Yazarlar guncelyz = (from yz in ent.Yazarlar
                                 where yz.YazarID == degisecekyz.YazarID
                                 select yz).FirstOrDefault();
            guncelyz.YazarAd = degisecekyz.YazarAd;
            guncelyz.YazarSoyad = degisecekyz.YazarSoyad;

            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AdiIcerenYazarVarmi(string yazar)
        {
            Yazarlar varmi = (from y in ent.Yazarlar
                              where  y.YazarAd.Contains(yazar) || y.YazarSoyad.Contains(yazar)
                              select y).FirstOrDefault();
            if (varmi == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

     
        public string YazarAdGetir(int yazarid)
        {
            string yazar = (from y in ent.Yazarlar
                            where y.YazarID == yazarid
                            select y.YazarAd + " " + y.YazarSoyad).FirstOrDefault();
            return yazar;
        }
    }
}
