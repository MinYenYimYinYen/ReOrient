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
    
    public partial class servcd
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servcd()
        {
            this.prgmcds = new HashSet<prgmcd>();
            this.services = new HashSet<service>();
            this.ServcdBaitstationtypes = new HashSet<ServcdBaitstationtype>();
        }
    
        public string serv_code { get; set; }
        public string servname { get; set; }
        public string longname { get; set; }
        public bool available { get; set; }
        public string inv_msg { get; set; }
        public string inv_smsg { get; set; }
        public Nullable<short> price_id { get; set; }
        public string resacct { get; set; }
        public string comacct { get; set; }
        public bool progserv { get; set; }
        public bool jobserv { get; set; }
        public Nullable<decimal> priceby { get; set; }
        public Nullable<decimal> manhrrate { get; set; }
        public Nullable<decimal> baseprice { get; set; }
        public Nullable<System.DateTime> startdate { get; set; }
        public bool ignorecred { get; set; }
        public Nullable<short> letterid { get; set; }
        public string progtype { get; set; }
        public bool isservcall { get; set; }
        public string prodparam { get; set; }
        public string technote { get; set; }
        public Nullable<short> mapsymbol { get; set; }
        public Nullable<short> mapsymbol2 { get; set; }
        public Nullable<short> mapsymbol3 { get; set; }
        public Nullable<short> mapsymbol4 { get; set; }
        public Nullable<short> mapdays1 { get; set; }
        public Nullable<short> mapdays2 { get; set; }
        public Nullable<short> mapdays3 { get; set; }
        public bool isestimate { get; set; }
        public bool anybranch { get; set; }
        public byte[] timestamp { get; set; }
        public string rsuracct { get; set; }
        public string csuracct { get; set; }
        public string rdiscacct { get; set; }
        public string cdiscacct { get; set; }
        public string rprepacct { get; set; }
        public string cprepacct { get; set; }
        public Nullable<int> backcolor { get; set; }
        public Nullable<int> forecolor { get; set; }
        public bool pesticide { get; set; }
        public Nullable<byte> callahead { get; set; }
        public Nullable<int> estmanhour { get; set; }
        public Nullable<short> mindays { get; set; }
        public Nullable<short> maxdays { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prgmcd> prgmcds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service> services { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServcdBaitstationtype> ServcdBaitstationtypes { get; set; }
    }
}