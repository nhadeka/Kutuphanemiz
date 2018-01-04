using Kutuphanemiz.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphanemiz.BLL.Models.Abstracts
{
  public  interface IKategorilerServis
    {
        List<string> KategorileriGetir();
        int KategoriIdBul(string kategoriad);
        bool KategoriGuncelle(string kategoriad, int eskikategoriid);
       
    }
}
