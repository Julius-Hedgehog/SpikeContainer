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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Packages = new HashSet<Package>();
            this.Permissions = new HashSet<Permission>();
            this.ShopOrders = new HashSet<ShopOrder>();
        }
    
        public System.Guid UserGuid { get; set; }
        public string UserId { get; set; }
        public string BadgeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middle { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public int TimeOut { get; set; }
        public bool ChangePass { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }
        public bool WorkStation { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public Nullable<int> TtmAccess { get; set; }
        public Nullable<int> SantexAccess { get; set; }
        public Nullable<int> KenyonAccess { get; set; }
        public bool SupOverRide { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permission> Permissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopOrder> ShopOrders { get; set; }
    }
}
