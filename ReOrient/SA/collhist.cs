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
    
    public partial class collhist
    {
        public int collhistid { get; set; }
        public Nullable<short> collect_id { get; set; }
        public int cust_no { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<System.DateTime> collexpdt { get; set; }
        public string emp_id { get; set; }
        public byte[] timestamp { get; set; }
        public bool manset { get; set; }
    
        public virtual customer customer { get; set; }
    }
}