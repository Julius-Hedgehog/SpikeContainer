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
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.WorkStation = false;
            this.Permissions = new HashSet<Permissions>();
            this.Packages = new HashSet<Packages>();
            this.ShopOrders = new HashSet<ShopOrders>();
        }
    
        public System.Guid UserGuid { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Middle { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public int TimeOut { get; set; }
        public bool ChangePass { get; set; }
        public string Email { get; set; }
        public bool Admin { get; set; }
        public System.DateTime ChangedDate { get; set; }
        public string ChangedBy { get; set; }
        public bool WorkStation { get; set; }
        public string BadgeNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissions> Permissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Packages> Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopOrders> ShopOrders { get; set; }
    }
}
