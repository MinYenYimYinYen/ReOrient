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
    
    public partial class CompanyDownTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyDownTime()
        {
            this.routes = new HashSet<route>();
        }
    
        public int companydowntimeid { get; set; }
        public int comp_id { get; set; }
        public string subject { get; set; }
        public string description { get; set; }
        public System.DateTime start { get; set; }
        public System.DateTime end { get; set; }
        public string icalendardata { get; set; }
        public System.DateTime lastoccurrenceend { get; set; }
    
        public virtual company company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<route> routes { get; set; }
    }
}
