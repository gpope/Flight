﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class flightnetEntities : DbContext
    {
        public flightnetEntities()
            : base("name=flightnetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cjenik> Cjenik { get; set; }
        public DbSet<Clanarina> Clanarina { get; set; }
        public DbSet<Dozvola> Dozvola { get; set; }
        public DbSet<Gorivo> Gorivo { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Let> Let { get; set; }
        public DbSet<OvlastiKorisnika> OvlastiKorisnika { get; set; }
        public DbSet<Paraglajder> Paraglajder { get; set; }
        public DbSet<Resurs> Resurs { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<StatusKorisnika> StatusKorisnika { get; set; }
        public DbSet<StatusLeta> StatusLeta { get; set; }
        public DbSet<StatusResursa> StatusResursa { get; set; }
        public DbSet<TipDozvole> TipDozvole { get; set; }
        public DbSet<Zrakoplov> Zrakoplov { get; set; }
    }
}
