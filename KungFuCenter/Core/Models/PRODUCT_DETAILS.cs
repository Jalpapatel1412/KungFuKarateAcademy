//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagement.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT_DETAILS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT_DETAILS()
        {
            this.PAYMENT_DETAILS = new HashSet<PAYMENT_DETAILS>();
        }
    
        public decimal PRODUCT_ID { get; set; }
        public string PRODUCT_CATEGORY { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal PRODUCT_COST_PRICE { get; set; }
        public decimal PRODUCT_SELLING_PRICE { get; set; }
        public decimal PRODUCT_QUANTITY { get; set; }
        public Nullable<System.DateTime> INVENTORY_DATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAYMENT_DETAILS> PAYMENT_DETAILS { get; set; }
    }
}
