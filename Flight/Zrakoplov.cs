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
    
    public partial class Zrakoplov
    {
        public int resurs_ID { get; set; }
        public double tezina { get; set; }
        public double duzina { get; set; }
        public double promjer_krila { get; set; }
        public double gorivo_stanje { get; set; }
        public int gorivo_ID { get; set; }
        public double gorivo_spremnik { get; set; }
    
        public virtual Gorivo Gorivo { get; set; }
        public virtual Resurs Resurs { get; set; }
    }
}
