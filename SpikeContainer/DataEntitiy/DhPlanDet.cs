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
    
    public partial class DhPlanDet
    {
        public string DyeLot { get; set; }
        public int WorkOrder { get; set; }
        public int OpStep { get; set; }
    
        public virtual DhPlanMstr DhPlanMstr { get; set; }
    }
}
