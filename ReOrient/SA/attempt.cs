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
    
    public partial class attempt
    {
        public int attemptid { get; set; }
        public int action_id { get; set; }
        public Nullable<short> actreasid { get; set; }
        public Nullable<System.DateTime> attemptdt { get; set; }
        public string attmptnote { get; set; }
        public string emp_id { get; set; }
        public string contatmpt { get; set; }
        public byte[] timestamp { get; set; }
    
        public virtual action action { get; set; }
        public virtual actrea actrea { get; set; }
        public virtual employee employee { get; set; }
    }
}
