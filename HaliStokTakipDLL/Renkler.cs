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
    
    public partial class Renkler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Renkler()
        {
            this.Halilar = new HashSet<Halilar>();
        }
    
        public int ID { get; set; }
        public string RenkAdi { get; set; }
        public bool AktifMi { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Halilar> Halilar { get; set; }
    }
}
