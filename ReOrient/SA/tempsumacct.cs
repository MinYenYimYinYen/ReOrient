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
    
    public partial class tempsumacct
    {
        public string account { get; set; }
        public string acct_desc { get; set; }
        public bool notchange { get; set; }
        public bool cash_acct { get; set; }
        public string acct_type { get; set; }
        public byte[] timestamp { get; set; }
        public decimal rescred { get; set; }
        public decimal resdeb { get; set; }
        public decimal comcred { get; set; }
        public decimal comdeb { get; set; }
    }
}
