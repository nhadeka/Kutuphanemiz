//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutuphanemiz.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmanetlerView
    {
        public int EmanetID { get; set; }
        public int KullaniciID { get; set; }
        public int KitapID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KategoriAd { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
        public string YayineviAd { get; set; }
        public bool Silindi { get; set; }
        public System.DateTime KVerilisTarihi { get; set; }
        public System.DateTime KIEdilecekTarih { get; set; }
        public decimal BirimCeza { get; set; }
        public Nullable<System.DateTime> KIEdildigiTarih { get; set; }
        public Nullable<int> GGunSayisi { get; set; }
        public Nullable<decimal> ToplamCeza { get; set; }
        public string Barkod { get; set; }
    }
}