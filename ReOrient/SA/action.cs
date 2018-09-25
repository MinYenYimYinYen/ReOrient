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
    
    public partial class action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public action()
        {
            this.attempts1 = new HashSet<attempt>();
            this.calltopics = new HashSet<calltopic>();
        }
    
        public int action_id { get; set; }
        public string category { get; set; }
        public Nullable<int> cust_no { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string enteredby { get; set; }
        public string emp_id { get; set; }
        public Nullable<System.DateTime> enterdate { get; set; }
        public Nullable<System.DateTime> duedate { get; set; }
        public Nullable<System.DateTime> compdate { get; set; }
        public string status { get; set; }
        public bool resolved { get; set; }
        public bool viewed { get; set; }
        public string company { get; set; }
        public bool alarm { get; set; }
        public Nullable<short> attempts { get; set; }
        public Nullable<int> prog_id { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> mcust_no { get; set; }
        public bool privcall { get; set; }
        public Nullable<short> alarmtime { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual markcust markcust { get; set; }
        public virtual actstat actstat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attempt> attempts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calltopic> calltopics { get; set; }
    }
}
