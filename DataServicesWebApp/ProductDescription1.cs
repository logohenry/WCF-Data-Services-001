//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataServicesWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDescription1
    {
        public ProductDescription1()
        {
            this.ProductModelProductDescriptions = new HashSet<ProductModelProductDescription1>();
        }
    
        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductModelProductDescription1> ProductModelProductDescriptions { get; set; }
    }
}
