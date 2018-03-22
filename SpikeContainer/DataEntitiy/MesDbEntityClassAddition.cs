//******************************************************************************************************
// MesDbEntityClassAddition.cs - PFCS: Assembly - PFCS: Solution - PFCS: Project
//
// Copyright © 2017 - 2018, Polartec Tennesee Manufacturing LLC. All Rights Reserved.
//
// Unless agreed to in writing, the subject software distributed under the License is distributed on an
// "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
// License for the specific language governing permissions and limitations.
//
//******************************************************************************************************

// ----------------------------------
// precompile directives and pragmas
// #define
// #pragma
// ----------------------------------
// = = = = = = = = = = = = = = = = = =

// = = = = = = = = = = = = = = = = = =
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PFCS.Classes;
using System.Data.Entity.Core.EntityClient;

namespace PFCS.DataEntities
{
    /// <summary> Extendsion of The DataEntities for MesDb </summary>
    public partial class PackagesInGrid
    {//r.SerialNo,r.Item,r.MasterItem,r.Color,r.BinNo,r.Location,r.NetLbs,r.Status
        /// <summary>Default constructor</summary>
        public PackagesInGrid()
        {

        }

        /// <summary> parameterized contructor </summary>
        public PackagesInGrid(string serialNo, string item, string masterItem, string color, Nullable<decimal> netLbs, string location, string status, int? binNo)
        {
            SerialNo = serialNo;
            Item = item;
            MasterItem = masterItem;
            Color = color;
            NetLbs = netLbs;
            Location = location;
            Status = status;
            BinNo = binNo;
        }

        /// <summary> </summary>
        public string SerialNo { get; set; }
        /// <summary> </summary>
        public string Item { get; set; }
        /// <summary> </summary>
        public string MasterItem { get; set; }
        /// <summary> </summary>
        public string Color { get; set; }
        /// <summary> </summary>
        public Nullable<decimal> NetLbs { get; set; }
        /// <summary>  </summary>
        public string Location { get; set; }
        /// <summary> </summary>
        public string Status { get; set; }
        /// <summary> </summary>
        public Nullable<int> BinNo { get; set; }
    }
    public partial class MesDbEntities : DbContext
    {
        /// <summary> </summary>
        public virtual DbSet<PackagesInGrid> PackagesInGrid { get; set; }

        public virtual int fn_IsGreige(string item)
        {
            var itemParameter = item != null ?
                new ObjectParameter("Item", item) :
                new ObjectParameter("Item", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("fn_IsGreige", itemParameter);
        }

        public virtual int fn_IsGreige_1(string item)
        {
            var itemParameter = item != null ?
                new ObjectParameter("Item", item) :
                new ObjectParameter("Item", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("fn_IsGreige_1", itemParameter);
        }
    }
}
