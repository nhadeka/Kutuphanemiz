using Kutuphanemiz.BLL.Models.Abstracts;
using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Concretes
{
  public  class KategorilerServis:IKategorilerServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();
        public List<string> KategorileriGetir()
        {

            List<string> kategoriler = (from k in ent.Kategoriler
                                        select k.KategoriAd).ToList();

            return kategoriler;

        }
        public int KategoriIdBul(string kategoriad)
        {
            int kategoriid = (from kt in ent.Kategoriler
                              where kt.KategoriAd == kategoriad
                              select kt.KategoriID).FirstOrDefault();
            return kategoriid;

        }

        public bool KategoriGuncelle(string kategoriad,int eskikategoriid)
        {
            var guncelkatg = (from katg in ent.Kategoriler
                                      where katg.KategoriAd == kategoriad
                                      select katg.KategoriID).FirstOrDefault();

            eskikategoriid = guncelkatg;
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
