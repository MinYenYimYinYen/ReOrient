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
    
    public partial class custinvgeographyshape
    {
        public int custinvgeographyshapeid { get; set; }
        public int custinv_id { get; set; }
        public int GeographyShapeID { get; set; }
        public bool additive0subtractive1 { get; set; }
    
        public virtual custinv custinv { get; set; }
        public virtual GeographyShape GeographyShape { get; set; }
    }
}