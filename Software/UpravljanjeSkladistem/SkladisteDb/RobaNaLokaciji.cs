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
    
    public partial class RobaNaLokaciji
    {
        public int IdRoba { get; set; }
        public int IdLokacija { get; set; }
        public Nullable<int> Kolicina { get; set; }
    
        public virtual Lokacija Lokacija { get; set; }
        public virtual Roba Roba { get; set; }
    }
}