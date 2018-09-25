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
    
    public partial class produsen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produsen()
        {
            this.ProductCondJournals = new HashSet<ProductCondJournal>();
            this.ProductLocationJournals = new HashSet<ProductLocationJournal>();
        }
    
        public int produsedid { get; set; }
        public int prodentrid { get; set; }
        public int prodid { get; set; }
        public Nullable<decimal> estamount { get; set; }
        public Nullable<decimal> actamount { get; set; }
        public Nullable<decimal> unitprice { get; set; }
        public Nullable<decimal> unitcost { get; set; }
        public string prop { get; set; }
        public bool useprop { get; set; }
        public string crew { get; set; }
        public bool usecrew { get; set; }
        public Nullable<System.DateTime> donedate { get; set; }
        public bool tax1 { get; set; }
        public bool tax2 { get; set; }
        public bool tax3 { get; set; }
        public Nullable<short> loc_id { get; set; }
        public Nullable<decimal> actcost { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<decimal> treatdarea { get; set; }
        public string lot_no { get; set; }
        public Nullable<short> appmethid { get; set; }
        public Nullable<decimal> methodrate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCondJournal> ProductCondJournals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductLocationJournal> ProductLocationJournals { get; set; }
    }
}
