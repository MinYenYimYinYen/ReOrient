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
    
    public partial class pricetab
    {
        public short price_id { get; set; }
        public string price_desc { get; set; }
        public bool available { get; set; }
        public Nullable<decimal> maxsize { get; set; }
        public Nullable<decimal> maxrate { get; set; }
        public Nullable<decimal> maxmanhr { get; set; }
        public byte[] timestamp { get; set; }
        public string price_descf { get; set; }
        public string price_descs { get; set; }
    }
}
