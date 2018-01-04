using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
  public  interface IYazarlarServis
    {
        bool YazarEkle(Yazarlar yz);
        bool YazarKontrolByIsim(string yazarisim, string yazarsoyad);
        int YazarIdBulByIsim(string yazarisim, string yazarsoyad);
        bool YazarGuncelle(Yazarlar degisecekyz);
        bool AdiIcerenYazarVarmi(string yazar);
      
        string YazarAdGetir(int yazarid);
    }
}
