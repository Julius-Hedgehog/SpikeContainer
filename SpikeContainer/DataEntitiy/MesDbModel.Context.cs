﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestMesDbEntities : DbContext
    {
        public TestMesDbEntities()
            : base("name=TestMesDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ArelContainer> ArelContainers { get; set; }
        public virtual DbSet<ArelLot> ArelLots { get; set; }
        public virtual DbSet<ArelLotsRecipe> ArelLotsRecipes { get; set; }
        public virtual DbSet<AutomatedEmail> AutomatedEmails { get; set; }
        public virtual DbSet<LocalVariable> LocalVariables { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PkgHist> PkgHists { get; set; }
        public virtual DbSet<ShopOrder> ShopOrders { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SystemParam> SystemParams { get; set; }
        public virtual DbSet<tr_hist> tr_hist { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        [DbFunction("TestMesDbEntities", "fn_GetDyeLotBatches")]
        public virtual IQueryable<fn_GetDyeLotBatches_Result> fn_GetDyeLotBatches(string dyeLot, Nullable<int> machineNo, Nullable<int> arelKey)
        {
            var dyeLotParameter = dyeLot != null ?
                new ObjectParameter("DyeLot", dyeLot) :
                new ObjectParameter("DyeLot", typeof(string));
    
            var machineNoParameter = machineNo.HasValue ?
                new ObjectParameter("MachineNo", machineNo) :
                new ObjectParameter("MachineNo", typeof(int));
    
            var arelKeyParameter = arelKey.HasValue ?
                new ObjectParameter("ArelKey", arelKey) :
                new ObjectParameter("ArelKey", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_GetDyeLotBatches_Result>("[TestMesDbEntities].[fn_GetDyeLotBatches](@DyeLot, @MachineNo, @ArelKey)", dyeLotParameter, machineNoParameter, arelKeyParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_DyeLotStarted(string dyeLot, Nullable<int> machineNo)
        {
            var dyeLotParameter = dyeLot != null ?
                new ObjectParameter("DyeLot", dyeLot) :
                new ObjectParameter("DyeLot", typeof(string));
    
            var machineNoParameter = machineNo.HasValue ?
                new ObjectParameter("MachineNo", machineNo) :
                new ObjectParameter("MachineNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_DyeLotStarted", dyeLotParameter, machineNoParameter);
        }
    
        public virtual int sp_InsertPkgHist(string where, string transDescr, Nullable<System.DateTime> transDateTime, string orverRideUser)
        {
            var whereParameter = where != null ?
                new ObjectParameter("Where", where) :
                new ObjectParameter("Where", typeof(string));
    
            var transDescrParameter = transDescr != null ?
                new ObjectParameter("TransDescr", transDescr) :
                new ObjectParameter("TransDescr", typeof(string));
    
            var transDateTimeParameter = transDateTime.HasValue ?
                new ObjectParameter("TransDateTime", transDateTime) :
                new ObjectParameter("TransDateTime", typeof(System.DateTime));
    
            var orverRideUserParameter = orverRideUser != null ?
                new ObjectParameter("OrverRideUser", orverRideUser) :
                new ObjectParameter("OrverRideUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertPkgHist", whereParameter, transDescrParameter, transDateTimeParameter, orverRideUserParameter);
        }
    
        public virtual int sp_IssueToShopOrderPkg(Nullable<int> sO, Nullable<System.DateTime> dT, string userID)
        {
            var sOParameter = sO.HasValue ?
                new ObjectParameter("SO", sO) :
                new ObjectParameter("SO", typeof(int));
    
            var dTParameter = dT.HasValue ?
                new ObjectParameter("DT", dT) :
                new ObjectParameter("DT", typeof(System.DateTime));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_IssueToShopOrderPkg", sOParameter, dTParameter, userIDParameter);
        }
    
        public virtual int sp_QcRelease(Nullable<int> sO, string user, string status)
        {
            var sOParameter = sO.HasValue ?
                new ObjectParameter("SO", sO) :
                new ObjectParameter("SO", typeof(int));
    
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_QcRelease", sOParameter, userParameter, statusParameter);
        }
    }
}
