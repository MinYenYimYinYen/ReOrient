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
    
    public partial class QuickText
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuickText()
        {
            this.QuickTextCompanies = new HashSet<QuickTextCompany>();
            this.QuickTextLogs = new HashSet<QuickTextLog>();
        }
    
        public int QuickTextId { get; set; }
        public System.Guid FieldId { get; set; }
        public string QuickText1 { get; set; }
        public string emp_id { get; set; }
    
        public virtual employee employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuickTextCompany> QuickTextCompanies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuickTextLog> QuickTextLogs { get; set; }
    }
}