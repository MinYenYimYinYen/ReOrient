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
    
    public partial class servstat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servstat()
        {
            this.services = new HashSet<service>();
        }
    
        public string servstatus { get; set; }
        public string stat_desc { get; set; }
        public bool notchange { get; set; }
        public bool skip { get; set; }
        public byte[] timestamp { get; set; }
        public string stat_descF { get; set; }
        public string stat_descS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service> services { get; set; }
    }
}