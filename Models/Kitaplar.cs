//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTekrar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitaplar()
        {
            this.Satislar = new HashSet<Satislar>();
        }
    
        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public int YazarId { get; set; }
        public int KategoriId { get; set; }
        public int AltKategoriId { get; set; }
        public System.DateTime BasimYili { get; set; }
        public int StokMiktari { get; set; }
        public decimal Fiyati { get; set; }
    
        public virtual AltKategori AltKategori { get; set; }
        public virtual AnaKategori AnaKategori { get; set; }
        public virtual Yazarlar Yazarlar { get; set; }
        public virtual Yazarlar Yazarlar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satislar> Satislar { get; set; }
    }
}