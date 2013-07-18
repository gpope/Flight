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
    
    public partial class Korisnik
    {
        public Korisnik()
        {
            this.Clanarina = new HashSet<Clanarina>();
            this.Dozvola = new HashSet<Dozvola>();
            this.Let = new HashSet<Let>();
            this.Rezervacija = new HashSet<Rezervacija>();
        }
    
        public int korisnik_ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public string oib { get; set; }
        public string lozinka { get; set; }
        public Nullable<int> status_korisnika_ID { get; set; }
        public Nullable<int> ovlasti_korisnika_ID { get; set; }
    
        public virtual ICollection<Clanarina> Clanarina { get; set; }
        public virtual ICollection<Dozvola> Dozvola { get; set; }
        public virtual OvlastiKorisnika OvlastiKorisnika { get; set; }
        public virtual StatusKorisnika StatusKorisnika { get; set; }
        public virtual ICollection<Let> Let { get; set; }
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
    }
}