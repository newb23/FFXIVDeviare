//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SummoningBell
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShopItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShopItem()
        {
            this.ShopItemMaps = new HashSet<ShopItemMap>();
        }
    
        public int id { get; set; }
        public int Item { get; set; }
        public int Quest { get; set; }
        public int Achievement { get; set; }
    
        public virtual Item Item1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopItemMap> ShopItemMaps { get; set; }
    }
}
