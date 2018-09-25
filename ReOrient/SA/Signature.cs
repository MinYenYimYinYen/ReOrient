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
    
    public partial class Signature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Signature()
        {
            this.HistorySignatures = new HashSet<HistorySignature>();
            this.PaymentSignatures = new HashSet<PaymentSignature>();
            this.ProgramCustomerSignatures = new HashSet<ProgramCustomerSignature>();
            this.ServiceCustomerSignatures = new HashSet<ServiceCustomerSignature>();
            this.ServiceEmployeeSignatures = new HashSet<ServiceEmployeeSignature>();
        }
    
        public int SignatureID { get; set; }
        public byte[] Signature1 { get; set; }
        public string PrintedName { get; set; }
        public Nullable<System.DateTime> SignatureDate { get; set; }
        public byte[] timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorySignature> HistorySignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentSignature> PaymentSignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramCustomerSignature> ProgramCustomerSignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceCustomerSignature> ServiceCustomerSignatures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceEmployeeSignature> ServiceEmployeeSignatures { get; set; }
    }
}
