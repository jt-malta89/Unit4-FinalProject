//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OderItems = new HashSet<OderItem>();
        }
    
        public string OrderID { get; set; }
        public System.DateTime Date { get; set; }
        public int PharmacieID { get; set; }
        public string IDCard { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OderItem> OderItems { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
