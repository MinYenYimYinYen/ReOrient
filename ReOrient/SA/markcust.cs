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
    
    public partial class markcust
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public markcust()
        {
            this.actions = new HashSet<action>();
            this.CallTrackings = new HashSet<CallTracking>();
            this.custinvs = new HashSet<custinv>();
            this.MarkCustGeographyShapes = new HashSet<MarkCustGeographyShape>();
            this.MarkCustSizeGeographyShapes = new HashSet<MarkCustSizeGeographyShape>();
            this.SS_jobs_transaction_log = new HashSet<SS_jobs_transaction_log>();
        }
    
        public int cust_no { get; set; }
        public Nullable<byte> title_cd { get; set; }
        public string company { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string streetno { get; set; }
        public string predir { get; set; }
        public string streetnm { get; set; }
        public string suffix { get; set; }
        public string postdir { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public Nullable<short> sourcecd { get; set; }
        public Nullable<int> subdiv_id { get; set; }
        public Nullable<decimal> size { get; set; }
        public string phone_home { get; set; }
        public string phone_work { get; set; }
        public string phone_fax { get; set; }
        public string phone_page { get; set; }
        public string phone_cell { get; set; }
        public string phone_othr { get; set; }
        public string email { get; set; }
        public string direction { get; set; }
        public string r_c { get; set; }
        public Nullable<decimal> latitude { get; set; }
        public Nullable<decimal> longitude { get; set; }
        public Nullable<decimal> housecost { get; set; }
        public Nullable<short> yearbuilt { get; set; }
        public string yarddim { get; set; }
        public string tractinfo { get; set; }
        public string technote { get; set; }
        public string custmemo { get; set; }
        public string carr_rte { get; set; }
        public string altnum { get; set; }
        public Nullable<short> unitcode { get; set; }
        public Nullable<System.DateTime> importdate { get; set; }
        public string trackingid { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<int> comp_id { get; set; }
        public string contallow { get; set; }
        public string countycd { get; set; }
        public string estby { get; set; }
        public Nullable<System.DateTime> estgiven { get; set; }
        public Nullable<decimal> geotype { get; set; }
        public string sizesource { get; set; }
        public bool memoalert { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action> actions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CallTracking> CallTrackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<custinv> custinvs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarkCustGeographyShape> MarkCustGeographyShapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarkCustSizeGeographyShape> MarkCustSizeGeographyShapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SS_jobs_transaction_log> SS_jobs_transaction_log { get; set; }
    }
}
