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
    
    public partial class auditlog
    {
        public int audit_id { get; set; }
        public Nullable<int> cust_no { get; set; }
        public Nullable<int> prog_id { get; set; }
        public Nullable<int> service_id { get; set; }
        public string emp_id { get; set; }
        public string changetype { get; set; }
        public Nullable<System.DateTime> changetime { get; set; }
        public string oldvalue { get; set; }
        public string newvalue { get; set; }
        public byte[] timestamp { get; set; }
    
        public virtual customer customer { get; set; }
    }
}