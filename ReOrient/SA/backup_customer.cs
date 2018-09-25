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
    
    public partial class backup_customer
    {
        public int cust_no { get; set; }
        public string status { get; set; }
        public Nullable<byte> title_cd { get; set; }
        public string company { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string predir { get; set; }
        public string streetno { get; set; }
        public string streetnm { get; set; }
        public string suffix { get; set; }
        public string postdir { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public bool billto { get; set; }
        public Nullable<decimal> invoicetyp { get; set; }
        public Nullable<byte> b_title_cd { get; set; }
        public string b_company { get; set; }
        public string b_lastname { get; set; }
        public string b_firstnm { get; set; }
        public string b_predir { get; set; }
        public string b_streetno { get; set; }
        public string b_streetnm { get; set; }
        public string b_suffix { get; set; }
        public string b_postdir { get; set; }
        public string b_address2 { get; set; }
        public string b_city { get; set; }
        public string b_state { get; set; }
        public string b_zip { get; set; }
        public Nullable<short> sourcecd { get; set; }
        public Nullable<int> subdiv_id { get; set; }
        public Nullable<short> comp_id { get; set; }
        public string taxid1 { get; set; }
        public string taxid2 { get; set; }
        public string taxid3 { get; set; }
        public string terrcode { get; set; }
        public Nullable<int> group_no { get; set; }
        public bool groupbill { get; set; }
        public Nullable<short> cancode { get; set; }
        public Nullable<short> holdcode { get; set; }
        public Nullable<short> collect_id { get; set; }
        public string cardtype { get; set; }
        public Nullable<decimal> size { get; set; }
        public string mapcode { get; set; }
        public Nullable<byte> callahead { get; set; }
        public string phone_home { get; set; }
        public string phone_work { get; set; }
        public string phone_fax { get; set; }
        public string phone_page { get; set; }
        public string phone_cell { get; set; }
        public string phone_othr { get; set; }
        public string email { get; set; }
        public Nullable<decimal> credit_lim { get; set; }
        public string direction { get; set; }
        public Nullable<System.DateTime> sincedate { get; set; }
        public string route { get; set; }
        public byte[] diagram { get; set; }
        public string r_c { get; set; }
        public Nullable<System.DateTime> candate { get; set; }
        public string cancelby { get; set; }
        public Nullable<System.DateTime> holdbegin { get; set; }
        public Nullable<System.DateTime> holddate { get; set; }
        public string cardacct { get; set; }
        public Nullable<System.DateTime> cardexp { get; set; }
        public Nullable<int> bankrt { get; set; }
        public string bankacct { get; set; }
        public Nullable<System.DateTime> statedate { get; set; }
        public Nullable<decimal> latitude { get; set; }
        public Nullable<decimal> longitude { get; set; }
        public Nullable<System.DateTime> lastserv { get; set; }
        public Nullable<decimal> housecost { get; set; }
        public Nullable<short> yearbuilt { get; set; }
        public string yarddim { get; set; }
        public string tractinfo { get; set; }
        public string technote { get; set; }
        public string custmemo { get; set; }
        public Nullable<decimal> statetype { get; set; }
        public bool masteracct { get; set; }
        public string billtype { get; set; }
        public bool nointerest { get; set; }
        public Nullable<System.DateTime> intdate { get; set; }
        public Nullable<decimal> lastint { get; set; }
        public Nullable<decimal> balance { get; set; }
        public Nullable<decimal> prepbal { get; set; }
        public Nullable<System.DateTime> agedate { get; set; }
        public Nullable<decimal> due1 { get; set; }
        public Nullable<decimal> due2 { get; set; }
        public Nullable<decimal> due3 { get; set; }
        public Nullable<decimal> due4 { get; set; }
        public Nullable<decimal> due5 { get; set; }
        public Nullable<decimal> due6 { get; set; }
        public Nullable<decimal> due7 { get; set; }
        public Nullable<decimal> ph { get; set; }
        public Nullable<System.DateTime> colldate { get; set; }
        public string disccode { get; set; }
        public string carr_rte { get; set; }
        public string altnum { get; set; }
        public Nullable<short> unitcode { get; set; }
        public bool nocredhold { get; set; }
        public string contallow { get; set; }
        public string taxexmptid { get; set; }
        public string trackingid { get; set; }
        public string userid { get; set; }
        public string password { get; set; }
        public byte[] timestamp { get; set; }
        public Nullable<System.DateTime> collexpdt { get; set; }
        public string countycd { get; set; }
    }
}