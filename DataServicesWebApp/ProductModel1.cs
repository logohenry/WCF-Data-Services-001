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
    
    public partial class ProductModel1
    {
        public ProductModel1()
        {
            this.Products = new HashSet<Product1>();
            this.ProductModelProductDescriptions = new HashSet<ProductModelProductDescription1>();
        }
    
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Product1> Products { get; set; }
        public virtual ICollection<ProductModelProductDescription1> ProductModelProductDescriptions { get; set; }
    }
}
