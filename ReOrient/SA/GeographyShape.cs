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
    
    public partial class GeographyShape
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeographyShape()
        {
            this.custinvgeographyshapes = new HashSet<custinvgeographyshape>();
            this.CustomerGeographyShapes = new HashSet<CustomerGeographyShape>();
            this.CustomerSizeGeographyShapes = new HashSet<CustomerSizeGeographyShape>();
            this.GeographyShapeHistories = new HashSet<GeographyShapeHistory>();
            this.MarkCustGeographyShapes = new HashSet<MarkCustGeographyShape>();
            this.MarkCustSizeGeographyShapes = new HashSet<MarkCustSizeGeographyShape>();
        }
    
        public int GeographyShapeID { get; set; }
        public byte[] Geography { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public bool Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<custinvgeographyshape> custinvgeographyshapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerGeographyShape> CustomerGeographyShapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerSizeGeographyShape> CustomerSizeGeographyShapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GeographyShapeHistory> GeographyShapeHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarkCustGeographyShape> MarkCustGeographyShapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarkCustSizeGeographyShape> MarkCustSizeGeographyShapes { get; set; }
    }
}