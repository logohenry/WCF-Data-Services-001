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
    
    public partial class CustomerAddress1
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string AddressType { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Address1 Address { get; set; }
        public virtual Customer1 Customer { get; set; }
    }
}