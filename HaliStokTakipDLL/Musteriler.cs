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
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            this.Siparisler = new HashSet<Siparisler>();
        }
    
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Adresi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string VergiNo { get; set; }
        public string Aciklama { get; set; }
        public bool AktifMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparisler> Siparisler { get; set; }
    }
}