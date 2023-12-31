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
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.hizliNotSistemi = new HashSet<hizliNotSistemi>();
            this.PersonelBeniHatirla = new HashSet<PersonelBeniHatirla>();
            this.PersonelHataliGiris = new HashSet<PersonelHataliGiris>();
            this.PersonelLogKaydi = new HashSet<PersonelLogKaydi>();
            this.PersonelSifre = new HashSet<PersonelSifre>();
        }
    
        public int Id { get; set; }
        public string PersonelNo { get; set; }
        public string GorselUrl { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        public string TelNo { get; set; }
        public Nullable<int> VarsayilanKitapGeciktirme { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SistemeGirisSayisi { get; set; }
        public Nullable<System.DateTime> KayitTarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hizliNotSistemi> hizliNotSistemi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelBeniHatirla> PersonelBeniHatirla { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelHataliGiris> PersonelHataliGiris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelLogKaydi> PersonelLogKaydi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelSifre> PersonelSifre { get; set; }
    }
}
