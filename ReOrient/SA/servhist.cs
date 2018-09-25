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
    
    public partial class servhist
    {
        public int service_id { get; set; }
        public Nullable<System.DateTime> donedate { get; set; }
        public Nullable<decimal> rating { get; set; }
        public Nullable<short> temp { get; set; }
        public Nullable<byte> windspeed { get; set; }
        public string winddir { get; set; }
        public Nullable<short> start { get; set; }
        public Nullable<short> end { get; set; }
        public Nullable<int> duration { get; set; }
        public Nullable<byte> crewsize { get; set; }
        public Nullable<int> actmanhour { get; set; }
        public string feedback { get; set; }
        public Nullable<decimal> ph { get; set; }
        public string post_by { get; set; }
        public int comp_id { get; set; }
        public string billtype { get; set; }
        public string progdisccd { get; set; }
        public Nullable<System.DateTime> datesold { get; set; }
        public string soldby1 { get; set; }
        public string soldby2 { get; set; }
        public Nullable<System.DateTime> paid { get; set; }
        public string taxid1 { get; set; }
        public string taxid2 { get; set; }
        public string taxid3 { get; set; }
        public Nullable<decimal> taxrate1 { get; set; }
        public Nullable<decimal> taxrate2 { get; set; }
        public Nullable<decimal> taxrate3 { get; set; }
        public Nullable<System.DateTime> gldate { get; set; }
        public byte[] timestamp { get; set; }
        public int cust_no { get; set; }
        public Nullable<int> vehicleid { get; set; }
        public Nullable<int> contractid { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual service service { get; set; }
    }
}
