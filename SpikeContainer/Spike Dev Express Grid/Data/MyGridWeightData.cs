using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeContainer.Spike_Dev_Express_Grid.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;

    public class MyGridWeightDataEntity : DbContext
    {
        public MyGridWeightDataEntity()
            : base("name=MyGridWeightDataEntity")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<GridWeightData> GridWeightData { get; set; }
    }


}
