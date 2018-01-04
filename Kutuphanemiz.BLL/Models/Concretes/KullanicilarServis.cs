using Kutuphanemiz.BLL.Models.Abstracts;
using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Concretes
{
   public class KullanicilarServis:IKullanicilarServis
    {
        KutuphanemizEntities ent = new KutuphanemizEntities();

        public bool AdminMi(int id)
        {
            string kim = (from a in ent.Kullanicilar
                          where a.KullaniciID == id
                          select a.KullaniciTuru).FirstOrDefault();

            if (kim == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool KullaniciBulFromLogin(int id, string sifre)
        {
            var kul = (from k in ent.Kullanicilar
                       where k.KullaniciID ==id && k.Sifre == sifre && k.Silindi==false
                       select k).FirstOrDefault();
            if (kul == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool KullaniciEkle(Kullanicilar yeni)
        {
            ent.Kullanicilar.Add(yeni);
           
             if(Convert.ToBoolean(ent.SaveChanges()))
            {
               
               
                return true;
            }

            else
            {
                return false;
            }
   
        }

        public bool KullaniciKontrolByTcNo(string tcno)
        {
            var sonuc = (from b in ent.Kullanicilar
                         where b.TCKNo == tcno
                         select b).FirstOrDefault();

            if (sonuc == null)
            {
                //üye kayıtlı değil
                return false;

            }
            else
            {
                //üye kayıtlı
                return true;
            }
        }

        public bool KullaniciSil(int SecilenKullaniciID)
        {
            Kullanicilar silinen = (from k in ent.Kullanicilar
                                    where k.KullaniciID == SecilenKullaniciID
                                    select k).FirstOrDefault();

            silinen.Silindi = true;
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KulaniciGuncelle(Kullanicilar guncel)
        {
            Kullanicilar guncelle = (from k in ent.Kullanicilar
                                     where k.KullaniciID == guncel.KullaniciID
                                     select k).FirstOrDefault();

            guncelle.TCKNo = guncel.TCKNo;
            guncelle.KullaniciTuru = guncel.KullaniciTuru;
            guncelle.Ad = guncel.Ad;
            guncelle.Soyad = guncel.Soyad;
            guncelle.TelNo = guncel.TelNo;
            guncelle.Eposta = guncel.Eposta;
            guncelle.Il = guncel.Il;
            guncelle.Ilce = guncel.Ilce;
            guncelle.Adres = guncel.Adres;
            guncelle.Sifre = guncel.Sifre;
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<KullanicilarView> TumKullanicilariYukle()
        {
            List<KullanicilarView> kullanicilarlist = new List<KullanicilarView>();
            kullanicilarlist= ent.KullanicilarView.ToList();
            return kullanicilarlist;
        }
        public bool SifreDegistir(Kullanicilar kul)
        {
            Kullanicilar kullanici = (from k in ent.Kullanicilar
                                      where k.KullaniciID == kul.KullaniciID
                                      select k).FirstOrDefault();
            kullanici.Sifre = kul.Sifre;
            if (Convert.ToBoolean(ent.SaveChanges()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KullaniciVarmi(int id)
        {
            Kullanicilar varmi = (from k in ent.Kullanicilar
                                  where k.KullaniciID == id
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
        public Kullanicilar KullaniciyiGetir(int id)
        {
            Kullanicilar kullanici = (from k in ent.Kullanicilar
                                      where k.KullaniciID == id
                                      select k).FirstOrDefault();
            return kullanici;
        }
        public bool KullaniciBulFromEmanetler(int id)
        {
            //    List<EmanetlerView> elist = new List<EmanetlerView>();
            var elist = (from k in ent.EmanetlerView
                         where k.KullaniciID == id
                         select k).ToList().FirstOrDefault();

            if (elist == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int EklenenKullaniciId(string tcno)
        {
            int sonuc = (from b in ent.Kullanicilar
                         where b.TCKNo == tcno
                         select b.KullaniciID).FirstOrDefault();
            return sonuc;
        }

        public bool AdiniIcerenKullaniciVarmi(string ad)
        {
            List<KullanicilarView> klist = (from k in ent.KullanicilarView
                                            where k.Ad.Contains(ad) || k.Soyad.Contains(ad)
                                            select k).ToList();
            if (klist == null)
                {
                return false;
                }
            else
                {
                return true;
                }
        }

        public List<KullanicilarView> AdiniIcerenKullanicilariGetir(string ad)
        {
           List<KullanicilarView> klist = (from k in ent.KullanicilarView
                                      where k.Ad.Contains(ad) || k.Soyad.Contains(ad)
                                      select k).ToList();
            return klist;
        }

        public List<KullanicilarView> IDliKullaniciyiGetir(int kullaniciid)
        {
            List<KullanicilarView> klist = (from k in ent.KullanicilarView
                                            where k.KullaniciID==kullaniciid
                                            select k).ToList();
            return klist;
        }
    }
}
