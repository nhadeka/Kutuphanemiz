using Kutuphanemiz.BLL.Models.Abstracts;
using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Concretes
{
  public  class KitaplarServis:IKitaplarServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();

        public bool KitapEkle(Kitaplar k)
        {
            //Arakatmana ekliyoruz.
            ent.Kitaplar.Add(k);
            //Veritabanını güncelliyoruz.

            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KitapKontrolByBarkodno(string barkod)
        {
            var sonuc = (from b in ent.Kitaplar
                         where b.Barkod == barkod
                         select b).FirstOrDefault();

            if (sonuc == null)
            {
                // girilen barkodnoya sahip  bir kitap kayıtlı değil
                return false;

            }
            else
            {
                // girilen barkodno ya sahip kitap kayıtlı
                return true;
            }
        }

        public List<KitaplarView> KitaplariYukleByKitapGuncelle()
        {
            List<KitaplarView> kitaplarlist =(from k in ent.KitaplarView
                                             where k.Durum=="serbest"
                                             select k).ToList();
            return kitaplarlist;
        }

        //kitaplarview de silindi=0 ve durum=serbest şartı old. double click ile secilen kitapda bu şartları sağlad. silerken tekrar kontrole gerek yok.
        //eğer kitap sil metodu başka bir sayfadan(kitap guncelle hariç) çağrılsaydı bu şartlar kontrol edilmeliydi.
        public bool KitapSil(int SecilenKitapID)
        {
            Kitaplar silinecek = (from k in ent.Kitaplar
                                  where k.KitapID == SecilenKitapID
                                  select k).FirstOrDefault();
            ent.Kitaplar.Remove(silinecek);
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool KitapGuncelle(Kitaplar degisenk)
        {
            Kitaplar guncelk = (from k in ent.Kitaplar
                                where k.KitapID == degisenk.KitapID
                                select k).FirstOrDefault();
            guncelk.KitapAd = degisenk.KitapAd;
            guncelk.Barkod = degisenk.Barkod;
            guncelk.KategoriID = degisenk.KategoriID;
            ent.SaveChanges();
          
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<KitaplarView> KitaplariYukleByKitapAra()
        {
            List<KitaplarView> klist = ent.KitaplarView.ToList();
            return klist;
        }

        public bool AdiIcerenKitapVarmi(string kitapad)
        {
            Kitaplar varmi = (from k in ent.Kitaplar
                              where k.KitapAd.Contains(kitapad) /*&& k.Silindi == false && k.Durum == "serbest"*/
                              select k).FirstOrDefault();
            if (varmi == null)
            {
                return false;
            }
            else
            {
                return true;


            }
        }

        public List<KitaplarView> AdiIcerenKitaplariGetir(string kitapad)
        {
            List<KitaplarView> kitaplarlist = (from k in ent.KitaplarView
                                               where k.KitapAd.Contains(kitapad)
                                               select k).ToList();
            return kitaplarlist;
        }

        public List<KitaplarView> AdiIcerenKitaplariGetirKG(string kitapad)
        {
            List<KitaplarView> kitaplarlist = (from k in ent.KitaplarView
                                               where k.KitapAd.Contains(kitapad) && k.Durum == "serbest"
                                               select k).ToList();
            return kitaplarlist;
        }
        public List<KitaplarView> YazarAdiIcerenKitaplariGetir(string yazar)
        {
            List<KitaplarView> klist = (from k in ent.KitaplarView
                                            where (k.YazarAd.Contains(yazar) || k.YazarSoyad.Contains(yazar)) && k.Durum == "serbest"
                                            select k).ToList();
            return klist;
        }

        public bool KitapDurumDegistirByKitapVer(int Kitapid)
        {
            
            Kitaplar kitap = (from k in ent.Kitaplar
                            where k.KitapID == Kitapid
                            select k).FirstOrDefault();




            kitap.Durum = "üyede";
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KitapVarmi(int id)
        {
            Kitaplar varmi = (from k in ent.Kitaplar
                              where k.KitapID == id && k.Silindi == false
                              select k).FirstOrDefault();
            if (varmi == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Kitaplar KitabiGetir(int id)
        {
            Kitaplar kitap = (from k in ent.Kitaplar
                              where k.KitapID == id && k.Silindi == false
                              select k).FirstOrDefault();
            return kitap;
        }

        public Kitaplar KitabiGetirKV(string barkod)
        {
            Kitaplar kitap = (from k in ent.Kitaplar
                              where k.Barkod==barkod && k.Silindi == false && k.Durum=="serbest"
                              select k).FirstOrDefault();
            return kitap;
        }


        public List<KitaplarView> BarkodaGoreGetir(string barkod)
        {
            List<KitaplarView> klist = (from k in ent.KitaplarView
                              where k.Barkod == barkod  && k.Durum=="serbest"
                              select k).ToList();
            return klist;

        }

        public bool KitapUyedeMi(int Kitapid)
        {
            string durum = (from k in ent.Kitaplar
                            where k.KitapID == Kitapid
                            select k.Durum).FirstOrDefault();
            if (durum == "üyede")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool KitapDurumDegistirByKitapGeriAl(int Kitapid)
        {

            Kitaplar kitap = (from k in ent.Kitaplar
                              where k.KitapID == Kitapid
                              select k).FirstOrDefault();




            kitap.Durum = "serbest";
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
        public List<KitaplarView> KategoridekiKitaplariGetir(string kategoriad)
        {
            List<KitaplarView> klist = (from k in ent.KitaplarView
                                        where k.KategoriAd==kategoriad
                                        select k).ToList();
            return klist;
        }
    }
}
