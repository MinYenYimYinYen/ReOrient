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
    
    public partial class ProductLocationHistory
    {
        public int ProductLocationID { get; set; }
        public int produsedid { get; set; }
        public short loc_id { get; set; }
    
        public virtual location location { get; set; }
        public virtual prodused prodused { get; set; }
    }
}