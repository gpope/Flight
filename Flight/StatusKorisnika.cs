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
    
    public partial class StatusKorisnika
    {
        public StatusKorisnika()
        {
            this.Korisnik = new HashSet<Korisnik>();
        }
    
        public int status_korisnika_ID { get; set; }
        public string status_korisnika { get; set; }
    
        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}
