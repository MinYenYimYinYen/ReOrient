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
    
    public partial class attach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public attach()
        {
            this.attachxmldatas = new HashSet<attachxmldata>();
        }
    
        public int attachid { get; set; }
        public Nullable<int> cust_no { get; set; }
        public Nullable<System.DateTime> enterdate { get; set; }
        public byte[] timestamp { get; set; }
        public string filename { get; set; }
        public string filedesc { get; set; }
        public Nullable<short> attacatid { get; set; }
        public bool printinv { get; set; }
        public Nullable<int> mcust_no { get; set; }
        public Nullable<int> prog_id { get; set; }
        public string emp_id { get; set; }
        public Nullable<System.Guid> attachtype { get; set; }
        public bool handheld { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attachxmldata> attachxmldatas { get; set; }
    }
}