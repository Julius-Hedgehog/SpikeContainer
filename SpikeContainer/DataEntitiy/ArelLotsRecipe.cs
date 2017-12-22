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
    
    public partial class ArelLotsRecipe
    {
        public string Lot_Number { get; set; }
        public short Machine { get; set; }
        public short Program { get; set; }
        public string Product_Status { get; set; }
        public short Tank_No { get; set; }
        public Nullable<int> Reserved__do_not_use { get; set; }
        public string Product_Code { get; set; }
        public Nullable<double> Concentration { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Last_Add { get; set; }
        public Nullable<double> Total_Adds { get; set; }
        public Nullable<short> Additions_Count { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Weighed_Quantity { get; set; }
        public Nullable<int> Date { get; set; }
        public Nullable<int> Time { get; set; }
        public short Product_Order { get; set; }
        public string Quantity_changed { get; set; }
        public short Step { get; set; }
        public string Cancelled { get; set; }
        public string Product_unit_for_sca { get; set; }
        public string OriginalLotNumber { get; set; }
        public Nullable<short> LotCode { get; set; }
        public string Master_recipe_unit { get; set; }
        public Nullable<float> Specific_gravity { get; set; }
        public int ArelKey { get; set; }
        public string Addition_Done { get; set; }
        public string SmallQuantity { get; set; }
        public Nullable<short> LotRedyeIndex { get; set; }
        public Nullable<short> PrepNumber { get; set; }
        public string Filler { get; set; }
    
        public virtual ArelLots ArelLots { get; set; }
    }
}
