//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ekos
{
    using System;
    using System.Collections.Generic;
    
    public partial class SmsGecmisi
    {
        public int Id { get; set; }
        public Nullable<int> OgrId { get; set; }
        public string Smsİcerik { get; set; }
        public Nullable<System.DateTime> KayitTarih { get; set; }
    
        public virtual KitapAlanOgrenci KitapAlanOgrenci { get; set; }
    }
}
