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
    
    public partial class KitaplarView
    {
        public string Durum { get; set; }
        public int KitapID { get; set; }
        public string Barkod { get; set; }
        public string KitapAd { get; set; }
        public string KategoriAd { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string YayineviAd { get; set; }
        public bool Silindi { get; set; }
        public int KategoriID { get; set; }
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public string RafNo { get; set; }
    }
}