//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HaliStokTakipDLL
{
    using System;
    
    public partial class sp_KargoListesi_Result
    {
        public int ID { get; set; }
        public string SiparisAdi { get; set; }
        public string FirmaAdi { get; set; }
        public string TakipKodu { get; set; }
        public System.DateTime TahminiTeslimTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public bool AktifMi { get; set; }
        public string Aciklama { get; set; }
    }
}