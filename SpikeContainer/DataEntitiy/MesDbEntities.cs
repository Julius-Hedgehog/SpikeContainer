using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.EntityClient;
using PFCS.Classes;

namespace PFCS.DataEntities
{
    public partial class MesDbEntities : DbContext
    {
        public MesDbEntities(bool custom)
            : base(
                new EntityConnectionStringBuilder
                {
                    Metadata =
                        "res://*/DataEntities.MesDbModel.csdl|res://*/DataEntities.MesDbModel.ssdl|res://*/DataEntities.MesDbModel.msl",
                    Provider = "System.Data.SqlClient",
                    ProviderConnectionString = Data.Global.LoggedIn && !Data.Global.Admin
                        ? $"data source = MANUFACTURING; initial catalog = {Data.Global.Catalog}; " +
                          $"integrated security = True; MultipleActiveResultSets = True; " +
                          $"User ID = {Data.SystemVariables.SysUser}; " +
                          $"Password ={Crypto.DecryptText(Data.SystemVariables.SysHash, Data.Global.Config + Data.Global.Catalog)}; " +
                          $"MultipleActiveResultSets = True; App = EntityFramework; "
                        : $"data source = MANUFACTURING; initial catalog = {Data.Global.Catalog}; " +
                          $"integrated security = True; MultipleActiveResultSets = True; " +
                          $"MultipleActiveResultSets = True; App = EntityFramework; "
                }.ToString()
            )
        {
        }
    }
}