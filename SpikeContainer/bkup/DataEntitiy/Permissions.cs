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
    
    public partial class Permissions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permissions()
        {
            this.ViewOnly = false;
        }
    
        public int ID { get; set; }
        public string UserId { get; set; }
        public string MenuItem { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public bool ViewOnly { get; set; }
    
        public virtual MenuItems MenuItems { get; set; }
        public virtual Users Users { get; set; }
    }
}
