//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReOrient.SA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCondition
    {
        public int ProductConditionID { get; set; }
        public int prodid { get; set; }
        public string condcode { get; set; }
    
        public virtual condcode condcode1 { get; set; }
        public virtual prodcode prodcode { get; set; }
    }
}
