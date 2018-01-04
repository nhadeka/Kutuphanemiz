using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
   public interface IKullanicilarServis
    {
        
        int EklenenKullaniciId(string tcno);
        bool KullaniciKontrolByTcNo(string tcno);
        bool KullaniciEkle(Kullanicilar yeni);
        bool KullaniciBulFromLogin(int id, string sifre);
        bool AdminMi(int id);
        bool KullaniciSil(int SecilenKullaniciID);
        bool KulaniciGuncelle(Kullanicilar guncel);
        List<KullanicilarView> TumKullanicilariYukle();
        bool SifreDegistir(Kullanicilar kul);
        bool KullaniciVarmi(int id);
        Kullanicilar KullaniciyiGetir(int id);
        bool KullaniciBulFromEmanetler(int id);
        bool AdiniIcerenKullaniciVarmi(string ad);
        List<KullanicilarView> AdiniIcerenKullanicilariGetir(string ad);
        List<KullanicilarView> IDliKullaniciyiGetir(int kullaniciid);
    }
}
