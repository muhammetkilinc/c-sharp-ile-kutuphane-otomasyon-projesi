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
    
    public partial class PersonelHataliGiris
    {
        public int Id { get; set; }
        public Nullable<int> PersonelId { get; set; }
        public string BilgisayarAdi { get; set; }
        public Nullable<System.DateTime> GirisTespitTarih { get; set; }
        public Nullable<bool> aktif { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}