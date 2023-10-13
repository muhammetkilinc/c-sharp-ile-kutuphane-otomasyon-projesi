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
    
    public partial class Kitaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitaplar()
        {
            this.CokAratilanKitaplar = new HashSet<CokAratilanKitaplar>();
            this.KitapAlanOgrenci = new HashSet<KitapAlanOgrenci>();
            this.KitapNotlar = new HashSet<KitapNotlar>();
        }
    
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string SnNumarasi { get; set; }
        public string FotoURL { get; set; }
        public string KitapAdi { get; set; }
        public Nullable<int> YazarId { get; set; }
        public Nullable<int> TercumanId { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public Nullable<int> YayineviId { get; set; }
        public Nullable<int> SayfaSayisi { get; set; }
        public Nullable<bool> KitapRafta { get; set; }
        public Nullable<bool> KitapArsivde { get; set; }
        public Nullable<System.DateTime> KayitTarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CokAratilanKitaplar> CokAratilanKitaplar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitapAlanOgrenci> KitapAlanOgrenci { get; set; }
        public virtual KitapKategori KitapKategori { get; set; }
        public virtual Yayinevi Yayinevi { get; set; }
        public virtual Yazarlar Yazarlar { get; set; }
        public virtual Yazarlar Yazarlar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KitapNotlar> KitapNotlar { get; set; }
    }
}