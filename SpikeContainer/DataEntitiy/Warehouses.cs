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
    
    public partial class Warehouses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouses()
        {
            this.Locations = new HashSet<Locations>();
            this.Packages = new HashSet<Packages>();
        }
    
        public string Warehouse { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public bool Allocatable { get; set; }
        public bool Inv { get; set; }
        public bool Virtual { get; set; }
        public string ParentWarehouse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locations> Locations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Packages> Packages { get; set; }
    }
}
