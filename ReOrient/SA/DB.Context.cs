﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAEntities1 : DbContext
    {
        public SAEntities1()
            : base("name=SAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<action> actions { get; set; }
        public virtual DbSet<actrea> actreas { get; set; }
        public virtual DbSet<actstat> actstats { get; set; }
        public virtual DbSet<adjacent> adjacents { get; set; }
        public virtual DbSet<adjcarr> adjcarrs { get; set; }
        public virtual DbSet<adjcode> adjcodes { get; set; }
        public virtual DbSet<adjrea> adjreas { get; set; }
        public virtual DbSet<adjust> adjusts { get; set; }
        public virtual DbSet<alarm> alarms { get; set; }
        public virtual DbSet<alarmsch> alarmsches { get; set; }
        public virtual DbSet<appext> appexts { get; set; }
        public virtual DbSet<appextdata> appextdatas { get; set; }
        public virtual DbSet<appmethod> appmethods { get; set; }
        public virtual DbSet<attacat> attacats { get; set; }
        public virtual DbSet<attach> attaches { get; set; }
        public virtual DbSet<attachxmldata> attachxmldatas { get; set; }
        public virtual DbSet<attempt> attempts { get; set; }
        public virtual DbSet<auditlog> auditlogs { get; set; }
        public virtual DbSet<BaitStation> BaitStations { get; set; }
        public virtual DbSet<BaitStationActivity> BaitStationActivities { get; set; }
        public virtual DbSet<BaitStationActivityNoSrvRea> BaitStationActivityNoSrvReas { get; set; }
        public virtual DbSet<BaitStationActivityProdUsed> BaitStationActivityProdUseds { get; set; }
        public virtual DbSet<BaitStationActivityServCond> BaitStationActivityServConds { get; set; }
        public virtual DbSet<BaitStationType> BaitStationTypes { get; set; }
        public virtual DbSet<batch> batches { get; set; }
        public virtual DbSet<blockld> blocklds { get; set; }
        public virtual DbSet<budget> budgets { get; set; }
        public virtual DbSet<ca_account> ca_account { get; set; }
        public virtual DbSet<ca_action> ca_action { get; set; }
        public virtual DbSet<ca_actreas> ca_actreas { get; set; }
        public virtual DbSet<ca_actstat> ca_actstat { get; set; }
        public virtual DbSet<ca_adjcode> ca_adjcode { get; set; }
        public virtual DbSet<ca_attacat> ca_attacat { get; set; }
        public virtual DbSet<ca_attempt> ca_attempt { get; set; }
        public virtual DbSet<ca_auditlog> ca_auditlog { get; set; }
        public virtual DbSet<ca_batch> ca_batch { get; set; }
        public virtual DbSet<ca_budget> ca_budget { get; set; }
        public virtual DbSet<ca_callcode> ca_callcode { get; set; }
        public virtual DbSet<ca_cancode> ca_cancode { get; set; }
        public virtual DbSet<ca_carrzip> ca_carrzip { get; set; }
        public virtual DbSet<ca_cawautopayinstque> ca_cawautopayinstque { get; set; }
        public virtual DbSet<ca_collcode> ca_collcode { get; set; }
        public virtual DbSet<ca_company> ca_company { get; set; }
        public virtual DbSet<ca_companyaging> ca_companyaging { get; set; }
        public virtual DbSet<ca_compcond> ca_compcond { get; set; }
        public virtual DbSet<ca_compdisc> ca_compdisc { get; set; }
        public virtual DbSet<ca_completr> ca_completr { get; set; }
        public virtual DbSet<ca_compprep> ca_compprep { get; set; }
        public virtual DbSet<ca_compprg> ca_compprg { get; set; }
        public virtual DbSet<ca_comppric> ca_comppric { get; set; }
        public virtual DbSet<ca_compprod> ca_compprod { get; set; }
        public virtual DbSet<ca_compserv> ca_compserv { get; set; }
        public virtual DbSet<ca_compsrce> ca_compsrce { get; set; }
        public virtual DbSet<ca_comptax> ca_comptax { get; set; }
        public virtual DbSet<ca_condcat> ca_condcat { get; set; }
        public virtual DbSet<ca_condcode> ca_condcode { get; set; }
        public virtual DbSet<ca_contpay> ca_contpay { get; set; }
        public virtual DbSet<ca_contract> ca_contract { get; set; }
        public virtual DbSet<ca_crrteprg> ca_crrteprg { get; set; }
        public virtual DbSet<ca_csswautopayque> ca_csswautopayque { get; set; }
        public virtual DbSet<ca_custflag> ca_custflag { get; set; }
        public virtual DbSet<ca_custinv> ca_custinv { get; set; }
        public virtual DbSet<ca_custltr> ca_custltr { get; set; }
        public virtual DbSet<ca_customer> ca_customer { get; set; }
        public virtual DbSet<ca_dbversion> ca_dbversion { get; set; }
        public virtual DbSet<ca_disccode> ca_disccode { get; set; }
        public virtual DbSet<ca_doneby> ca_doneby { get; set; }
        public virtual DbSet<ca_employee> ca_employee { get; set; }
        public virtual DbSet<ca_flag> ca_flag { get; set; }
        public virtual DbSet<ca_franchisefees> ca_franchisefees { get; set; }
        public virtual DbSet<ca_histhist> ca_histhist { get; set; }
        public virtual DbSet<ca_history> ca_history { get; set; }
        public virtual DbSet<ca_holdcode> ca_holdcode { get; set; }
        public virtual DbSet<ca_invoice> ca_invoice { get; set; }
        public virtual DbSet<ca_langmess> ca_langmess { get; set; }
        public virtual DbSet<ca_letters> ca_letters { get; set; }
        public virtual DbSet<ca_location> ca_location { get; set; }
        public virtual DbSet<ca_markcust> ca_markcust { get; set; }
        public virtual DbSet<ca_market> ca_market { get; set; }
        public virtual DbSet<ca_mastcat> ca_mastcat { get; set; }
        public virtual DbSet<ca_paytype> ca_paytype { get; set; }
        public virtual DbSet<ca_prepay> ca_prepay { get; set; }
        public virtual DbSet<ca_prepcode> ca_prepcode { get; set; }
        public virtual DbSet<ca_prepserv> ca_prepserv { get; set; }
        public virtual DbSet<ca_prgmcd> ca_prgmcd { get; set; }
        public virtual DbSet<ca_prgmserv> ca_prgmserv { get; set; }
        public virtual DbSet<ca_pricetab> ca_pricetab { get; set; }
        public virtual DbSet<ca_pricrang> ca_pricrang { get; set; }
        public virtual DbSet<ca_prodcat> ca_prodcat { get; set; }
        public virtual DbSet<ca_prodcode> ca_prodcode { get; set; }
        public virtual DbSet<ca_prodused> ca_prodused { get; set; }
        public virtual DbSet<ca_program> ca_program { get; set; }
        public virtual DbSet<ca_progtype> ca_progtype { get; set; }
        public virtual DbSet<ca_propinv> ca_propinv { get; set; }
        public virtual DbSet<ca_region> ca_region { get; set; }
        public virtual DbSet<ca_rejcode> ca_rejcode { get; set; }
        public virtual DbSet<ca_route> ca_route { get; set; }
        public virtual DbSet<ca_salemsg> ca_salemsg { get; set; }
        public virtual DbSet<ca_saleserv> ca_saleserv { get; set; }
        public virtual DbSet<ca_servcd> ca_servcd { get; set; }
        public virtual DbSet<ca_servcond> ca_servcond { get; set; }
        public virtual DbSet<ca_servhist> ca_servhist { get; set; }
        public virtual DbSet<ca_service> ca_service { get; set; }
        public virtual DbSet<ca_servprod> ca_servprod { get; set; }
        public virtual DbSet<ca_servstat> ca_servstat { get; set; }
        public virtual DbSet<ca_servtax> ca_servtax { get; set; }
        public virtual DbSet<ca_setupprm> ca_setupprm { get; set; }
        public virtual DbSet<ca_source> ca_source { get; set; }
        public virtual DbSet<ca_subdiv> ca_subdiv { get; set; }
        public virtual DbSet<ca_suffix> ca_suffix { get; set; }
        public virtual DbSet<ca_taxid> ca_taxid { get; set; }
        public virtual DbSet<ca_title> ca_title { get; set; }
        public virtual DbSet<ca_unitcode> ca_unitcode { get; set; }
        public virtual DbSet<ca_vehicle> ca_vehicle { get; set; }
        public virtual DbSet<ca_zipcode> ca_zipcode { get; set; }
        public virtual DbSet<callcode> callcodes { get; set; }
        public virtual DbSet<calltopic> calltopics { get; set; }
        public virtual DbSet<CallTracking> CallTrackings { get; set; }
        public virtual DbSet<cancelcat> cancelcats { get; set; }
        public virtual DbSet<cancode> cancodes { get; set; }
        public virtual DbSet<carrier> carriers { get; set; }
        public virtual DbSet<carrzip> carrzips { get; set; }
        public virtual DbSet<collcode> collcodes { get; set; }
        public virtual DbSet<collhist> collhists { get; set; }
        public virtual DbSet<compadj> compadjs { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<CompanyAging> CompanyAgings { get; set; }
        public virtual DbSet<CompanyDownTime> CompanyDownTimes { get; set; }
        public virtual DbSet<CompBaitStationType> CompBaitStationTypes { get; set; }
        public virtual DbSet<compcond> compconds { get; set; }
        public virtual DbSet<compdisc> compdiscs { get; set; }
        public virtual DbSet<compest> compests { get; set; }
        public virtual DbSet<compfav> compfavs { get; set; }
        public virtual DbSet<completr> completrs { get; set; }
        public virtual DbSet<ComponentVersion> ComponentVersions { get; set; }
        public virtual DbSet<ComponentVersionHist> ComponentVersionHists { get; set; }
        public virtual DbSet<CompPackage> CompPackages { get; set; }
        public virtual DbSet<compprep> comppreps { get; set; }
        public virtual DbSet<compprg> compprgs { get; set; }
        public virtual DbSet<comppric> compprics { get; set; }
        public virtual DbSet<compprod> compprods { get; set; }
        public virtual DbSet<compprop> compprops { get; set; }
        public virtual DbSet<compsale> compsales { get; set; }
        public virtual DbSet<compserv> compservs { get; set; }
        public virtual DbSet<compservmess> compservmesses { get; set; }
        public virtual DbSet<compsrce> compsrces { get; set; }
        public virtual DbSet<comptax> comptaxes { get; set; }
        public virtual DbSet<condcat> condcats { get; set; }
        public virtual DbSet<condcode> condcodes { get; set; }
        public virtual DbSet<contpay> contpays { get; set; }
        public virtual DbSet<contract> contracts { get; set; }
        public virtual DbSet<county> counties { get; set; }
        public virtual DbSet<crew> crews { get; set; }
        public virtual DbSet<crewmemb> crewmembs { get; set; }
        public virtual DbSet<crrteprg> crrteprgs { get; set; }
        public virtual DbSet<custflag> custflags { get; set; }
        public virtual DbSet<custinv> custinvs { get; set; }
        public virtual DbSet<custinvgeographyshape> custinvgeographyshapes { get; set; }
        public virtual DbSet<custltr> custltrs { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<CustomerGeographyShape> CustomerGeographyShapes { get; set; }
        public virtual DbSet<CustomerSizeGeographyShape> CustomerSizeGeographyShapes { get; set; }
        public virtual DbSet<disccode> disccodes { get; set; }
        public virtual DbSet<doneby> donebies { get; set; }
        public virtual DbSet<donebyen> donebyens { get; set; }
        public virtual DbSet<dontcall> dontcalls { get; set; }
        public virtual DbSet<dupcust> dupcusts { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<errorlog> errorlogs { get; set; }
        public virtual DbSet<estform> estforms { get; set; }
        public virtual DbSet<estimate> estimates { get; set; }
        public virtual DbSet<faq> faqs { get; set; }
        public virtual DbSet<favgroup> favgroups { get; set; }
        public virtual DbSet<favorite> favorites { get; set; }
        public virtual DbSet<flag> flags { get; set; }
        public virtual DbSet<franchisefee> franchisefees { get; set; }
        public virtual DbSet<gcstatmap> gcstatmaps { get; set; }
        public virtual DbSet<GeographyShape> GeographyShapes { get; set; }
        public virtual DbSet<GeographyShapeHistory> GeographyShapeHistories { get; set; }
        public virtual DbSet<histhist> histhists { get; set; }
        public virtual DbSet<history> histories { get; set; }
        public virtual DbSet<HistorySignature> HistorySignatures { get; set; }
        public virtual DbSet<holdcode> holdcodes { get; set; }
        public virtual DbSet<IBase_Dups> IBase_Dups { get; set; }
        public virtual DbSet<imptemp> imptemps { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<key> keys { get; set; }
        public virtual DbSet<langmess> langmesses { get; set; }
        public virtual DbSet<letter> letters { get; set; }
        public virtual DbSet<location> locations { get; set; }
        public virtual DbSet<mapcode> mapcodes { get; set; }
        public virtual DbSet<markcust> markcusts { get; set; }
        public virtual DbSet<MarkCustGeographyShape> MarkCustGeographyShapes { get; set; }
        public virtual DbSet<MarkCustSizeGeographyShape> MarkCustSizeGeographyShapes { get; set; }
        public virtual DbSet<market> markets { get; set; }
        public virtual DbSet<mastcat> mastcats { get; set; }
        public virtual DbSet<nosrvrea> nosrvreas { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<PaymentSignature> PaymentSignatures { get; set; }
        public virtual DbSet<paytype> paytypes { get; set; }
        public virtual DbSet<PI_ActiveCustomers> PI_ActiveCustomers { get; set; }
        public virtual DbSet<PI_CustomerStatus> PI_CustomerStatus { get; set; }
        public virtual DbSet<PI_Done2004> PI_Done2004 { get; set; }
        public virtual DbSet<PI_JulyPriceIncrease> PI_JulyPriceIncrease { get; set; }
        public virtual DbSet<PI_NewSales> PI_NewSales { get; set; }
        public virtual DbSet<PI_PDCustomers> PI_PDCustomers { get; set; }
        public virtual DbSet<PI_RemPrepay> PI_RemPrepay { get; set; }
        public virtual DbSet<planwk> planwks { get; set; }
        public virtual DbSet<ppayserv> ppayservs { get; set; }
        public virtual DbSet<precust> precusts { get; set; }
        public virtual DbSet<prenot> prenots { get; set; }
        public virtual DbSet<prepay> prepays { get; set; }
        public virtual DbSet<prepcode> prepcodes { get; set; }
        public virtual DbSet<prepserv> prepservs { get; set; }
        public virtual DbSet<prgmcd> prgmcds { get; set; }
        public virtual DbSet<PrgmCdPackage> PrgmCdPackages { get; set; }
        public virtual DbSet<prgmserv> prgmservs { get; set; }
        public virtual DbSet<pricetab> pricetabs { get; set; }
        public virtual DbSet<pricrang> pricrangs { get; set; }
        public virtual DbSet<prodcat> prodcats { get; set; }
        public virtual DbSet<prodcode> prodcodes { get; set; }
        public virtual DbSet<prodcond> prodconds { get; set; }
        public virtual DbSet<prodentr> prodentrs { get; set; }
        public virtual DbSet<prodtax> prodtaxes { get; set; }
        public virtual DbSet<ProductCodeVehicle> ProductCodeVehicles { get; set; }
        public virtual DbSet<ProductCondHistory> ProductCondHistories { get; set; }
        public virtual DbSet<ProductCondition> ProductConditions { get; set; }
        public virtual DbSet<ProductCondJournal> ProductCondJournals { get; set; }
        public virtual DbSet<ProductLocationHistory> ProductLocationHistories { get; set; }
        public virtual DbSet<ProductLocationJournal> ProductLocationJournals { get; set; }
        public virtual DbSet<prodused> produseds { get; set; }
        public virtual DbSet<produsen> produsens { get; set; }
        public virtual DbSet<progcond> progconds { get; set; }
        public virtual DbSet<program> programs { get; set; }
        public virtual DbSet<ProgramCustomerSignature> ProgramCustomerSignatures { get; set; }
        public virtual DbSet<progtype> progtypes { get; set; }
        public virtual DbSet<propinct> propincts { get; set; }
        public virtual DbSet<propinv> propinvs { get; set; }
        public virtual DbSet<QuickText> QuickTexts { get; set; }
        public virtual DbSet<QuickTextCompany> QuickTextCompanies { get; set; }
        public virtual DbSet<QuickTextLog> QuickTextLogs { get; set; }
        public virtual DbSet<RALog> RALogs { get; set; }
        public virtual DbSet<region> regions { get; set; }
        public virtual DbSet<rejcode> rejcodes { get; set; }
        public virtual DbSet<repprod> repprods { get; set; }
        public virtual DbSet<reptrak> reptraks { get; set; }
        public virtual DbSet<route> routes { get; set; }
        public virtual DbSet<routprog> routprogs { get; set; }
        public virtual DbSet<routtrak> routtraks { get; set; }
        public virtual DbSet<rptparam> rptparams { get; set; }
        public virtual DbSet<rtdetail> rtdetails { get; set; }
        public virtual DbSet<salemsg> salemsgs { get; set; }
        public virtual DbSet<saleserv> saleservs { get; set; }
        public virtual DbSet<secucode> secucodes { get; set; }
        public virtual DbSet<SentriconSetup> SentriconSetups { get; set; }
        public virtual DbSet<servcd> servcds { get; set; }
        public virtual DbSet<ServcdBaitstationtype> ServcdBaitstationtypes { get; set; }
        public virtual DbSet<servcond> servconds { get; set; }
        public virtual DbSet<servhist> servhists { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<ServiceCustomerSignature> ServiceCustomerSignatures { get; set; }
        public virtual DbSet<ServiceEmployeeSignature> ServiceEmployeeSignatures { get; set; }
        public virtual DbSet<servprod> servprods { get; set; }
        public virtual DbSet<servstat> servstats { get; set; }
        public virtual DbSet<servtax> servtaxes { get; set; }
        public virtual DbSet<setupprm> setupprms { get; set; }
        public virtual DbSet<sigkey> sigkeys { get; set; }
        public virtual DbSet<Signature> Signatures { get; set; }
        public virtual DbSet<sigpoint> sigpoints { get; set; }
        public virtual DbSet<source> sources { get; set; }
        public virtual DbSet<srvnosrv> srvnosrvs { get; set; }
        public virtual DbSet<SS_failed_email> SS_failed_email { get; set; }
        public virtual DbSet<SS_jobs_transaction_log> SS_jobs_transaction_log { get; set; }
        public virtual DbSet<SS_srv_log> SS_srv_log { get; set; }
        public virtual DbSet<statemnt> statemnts { get; set; }
        public virtual DbSet<subassy> subassies { get; set; }
        public virtual DbSet<subdiv> subdivs { get; set; }
        public virtual DbSet<suffix> suffixes { get; set; }
        public virtual DbSet<taxid> taxids { get; set; }
        public virtual DbSet<terrcode> terrcodes { get; set; }
        public virtual DbSet<timewindow> timewindows { get; set; }
        public virtual DbSet<title> titles { get; set; }
        public virtual DbSet<tmdetail> tmdetails { get; set; }
        public virtual DbSet<tmheader> tmheaders { get; set; }
        public virtual DbSet<topic> topics { get; set; }
        public virtual DbSet<unitcode> unitcodes { get; set; }
        public virtual DbSet<unitofmeasure> unitofmeasures { get; set; }
        public virtual DbSet<UserSetting> UserSettings { get; set; }
        public virtual DbSet<utiltrak> utiltraks { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
        public virtual DbSet<vehodom> vehodoms { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<vendord> vendords { get; set; }
        public virtual DbSet<zipcode> zipcodes { get; set; }
        public virtual DbSet<zone> zones { get; set; }
        public virtual DbSet<backup_custflag> backup_custflag { get; set; }
        public virtual DbSet<backup_customer> backup_customer { get; set; }
        public virtual DbSet<backup_program> backup_program { get; set; }
        public virtual DbSet<bkp_custflag> bkp_custflag { get; set; }
        public virtual DbSet<bkp_flag> bkp_flag { get; set; }
        public virtual DbSet<rpt_Employee_Access> rpt_Employee_Access { get; set; }
        public virtual DbSet<rpt_Group_Access> rpt_Group_Access { get; set; }
        public virtual DbSet<secStringDetail> secStringDetails { get; set; }
        public virtual DbSet<slscustcarr> slscustcarrs { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityErrorLog> SLSDataArchiveUtilityErrorLogs { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityMarketingTable> SLSDataArchiveUtilityMarketingTables { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityMasterDeleteAfterInsert> SLSDataArchiveUtilityMasterDeleteAfterInserts { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityMasterTable> SLSDataArchiveUtilityMasterTables { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityMasterTablesDelete> SLSDataArchiveUtilityMasterTablesDeletes { get; set; }
        public virtual DbSet<SLSDataArchiveUtilityTransactionTable> SLSDataArchiveUtilityTransactionTables { get; set; }
        public virtual DbSet<SQL01_SinceDateSoldDate> SQL01_SinceDateSoldDate { get; set; }
        public virtual DbSet<tblNCE_Send_01> tblNCE_Send_01 { get; set; }
        public virtual DbSet<tblProvidence> tblProvidences { get; set; }
        public virtual DbSet<Temp_IBase> Temp_IBase { get; set; }
        public virtual DbSet<Temp_IBase_Dups> Temp_IBase_Dups { get; set; }
        public virtual DbSet<TempCustPriceBlend> TempCustPriceBlends { get; set; }
        public virtual DbSet<tempsumacct> tempsumaccts { get; set; }
    }
}