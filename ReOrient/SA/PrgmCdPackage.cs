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
    
    public partial class PrgmCdPackage
    {
        public int PrgmCdPackage_ID { get; set; }
        public int Package_ID { get; set; }
        public short progdefid { get; set; }
        public string disccode { get; set; }
        public Nullable<byte> ApplyDiscount { get; set; }
        public byte[] timestamp { get; set; }
    
        public virtual disccode disccode1 { get; set; }
        public virtual Package Package { get; set; }
        public virtual prgmcd prgmcd { get; set; }
    }
}
