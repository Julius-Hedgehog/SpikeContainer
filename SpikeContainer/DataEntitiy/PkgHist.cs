//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpikeContainer.DataEntitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class PkgHist
    {
        public int HistID { get; set; }
        public System.DateTime TransDateTime { get; set; }
        public string TransDescr { get; set; }
        public string OverRide { get; set; }
        public string SerialNo { get; set; }
        public Nullable<int> WorkOrder { get; set; }
        public string Item { get; set; }
        public string MasterItem { get; set; }
        public string Color { get; set; }
        public Nullable<int> LstOpStep { get; set; }
        public string LstOp { get; set; }
        public string LstMach { get; set; }
        public Nullable<decimal> AllowYds { get; set; }
        public Nullable<decimal> CutOffYds { get; set; }
        public Nullable<decimal> FinWidth { get; set; }
        public string Grade { get; set; }
        public string QualCode { get; set; }
        public Nullable<decimal> GrossYds { get; set; }
        public Nullable<decimal> NetYds { get; set; }
        public Nullable<decimal> NetLbs { get; set; }
        public Nullable<decimal> TareLbs { get; set; }
        public string Defect1 { get; set; }
        public string Defect2 { get; set; }
        public string InspMachine { get; set; }
        public string InspClockNo { get; set; }
        public Nullable<System.DateTime> InspBegTime { get; set; }
        public Nullable<System.DateTime> InspEndTime { get; set; }
        public string ReInspReqd { get; set; }
        public string ReInspMachine { get; set; }
        public string ReInspClockNo { get; set; }
        public Nullable<System.DateTime> ReInspBegTime { get; set; }
        public Nullable<System.DateTime> ReInspEndTime { get; set; }
        public string HoldPiece { get; set; }
        public string HoldFor { get; set; }
        public string Reworked { get; set; }
        public string Rejected { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string KnitLot { get; set; }
        public string DyeLot { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<int> BinNo { get; set; }
        public Nullable<int> LstWorkOrder { get; set; }
        public string ShadeGroup { get; set; }
        public Nullable<bool> MilLotRep { get; set; }
        public string SalesOrder { get; set; }
        public Nullable<int> SalesOrderLine { get; set; }
        public Nullable<System.DateTime> PackDt { get; set; }
        public Nullable<System.DateTime> FRFG { get; set; }
    
        public virtual Packages Packages { get; set; }
    }
}
