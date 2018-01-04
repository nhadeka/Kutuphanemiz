using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
  public  interface IYayinevleriServis
    {
        bool YayineviEkle(Yayinevleri y);
        bool YayineviKontrolByIsim(string yayinevisim);
        int YayineviIdBulByIsim(string yayineviisim);
        bool YayineviGuncelle(Yayinevleri degiseceky);
        string YayineviAdGetir(int yayineviid);
    }
}
