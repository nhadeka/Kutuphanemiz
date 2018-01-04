using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
  public  interface IKitaplarServis
    {
        bool KitapEkle(Kitaplar k);
        bool KitapKontrolByBarkodno(string barkod);
        List<KitaplarView> KitaplariYukleByKitapGuncelle();
        bool KitapSil(int SecilenKitapID);
        bool KitapGuncelle(Kitaplar degisenk);
        List<KitaplarView> KitaplariYukleByKitapAra();
        bool AdiIcerenKitapVarmi(string kitapad);
       
        bool KitapDurumDegistirByKitapVer(int Kitapid);
        bool KitapVarmi(int id);
        Kitaplar KitabiGetir(int id);
        Kitaplar KitabiGetirKV(string barkod);
        List<KitaplarView> AdiIcerenKitaplariGetirKG(string kitapad);
        List<KitaplarView> BarkodaGoreGetir(string barkod);
        bool KitapUyedeMi(int Kitapid);
        bool KitapDurumDegistirByKitapGeriAl(int Kitapid);
        List<KitaplarView> YazarAdiIcerenKitaplariGetir(string yazar);
        List<KitaplarView> KategoridekiKitaplariGetir(string kategoriad);


    }
}
