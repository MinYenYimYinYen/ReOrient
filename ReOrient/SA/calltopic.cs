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
    
    public partial class calltopic
    {
        public int calltop_id { get; set; }
        public int action_id { get; set; }
        public short topic_id { get; set; }
        public byte[] timestamp { get; set; }
    
        public virtual action action { get; set; }
        public virtual topic topic { get; set; }
    }
}
