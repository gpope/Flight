//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flight
{
    using System;
    using System.Collections.Generic;
    
    public partial class Let
    {
        public int let_ID { get; set; }
        public string vreme_prognoza { get; set; }
        public string plan_leta { get; set; }
        public Nullable<System.TimeSpan> trajanje_leta { get; set; }
        public Nullable<double> gorivo_utroseno { get; set; }
        public string napomena { get; set; }
        public int rezervacija_ID { get; set; }
        public int korisnik_ID { get; set; }
        public int status_leta_ID { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Rezervacija Rezervacija { get; set; }
        public virtual StatusLeta StatusLeta { get; set; }
    }
}