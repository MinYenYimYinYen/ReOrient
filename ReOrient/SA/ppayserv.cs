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
    
    public partial class ppayserv
    {
        public int ppayservid { get; set; }
        public int payid { get; set; }
        public Nullable<int> service_id { get; set; }
        public string prepcode { get; set; }
        public Nullable<decimal> prepamt { get; set; }
        public Nullable<int> contpayid { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> hist_id { get; set; }
    
        public virtual service service { get; set; }
    }
}
