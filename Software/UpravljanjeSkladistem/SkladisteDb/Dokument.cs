//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkladisteDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dokument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dokument()
        {
            this.StavkeDokumentas = new HashSet<StavkeDokumenta>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Vrsta { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<int> Klijent { get; set; }
        public Nullable<int> Unio { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Korisnik Korisnik1 { get; set; }
        public virtual VrstaDokumenta VrstaDokumenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StavkeDokumenta> StavkeDokumentas { get; set; }
    }
}
