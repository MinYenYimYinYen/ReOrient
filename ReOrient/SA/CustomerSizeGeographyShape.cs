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
    
    public partial class CustomerSizeGeographyShape
    {
        public int CustomerSizeGeographyShapeID { get; set; }
        public int cust_no { get; set; }
        public int GeographyShapeID { get; set; }
        public bool Additive0Subtractive1 { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual GeographyShape GeographyShape { get; set; }
    }
}
