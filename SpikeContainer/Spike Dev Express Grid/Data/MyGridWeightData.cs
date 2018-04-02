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

        public virtual DbSet<Weights> Weights { get; set; }
    }

    public class Weights
    {
        public Weights()
        { }
        public Weights(decimal dcmlgRossLbs, decimal dcmltAreLbs, decimal dcmlnEtResultLbs)
        {

            GrossLbs = dcmlgRossLbs;
            TareLbs = dcmltAreLbs;
            NetResultLbs = dcmlnEtResultLbs;
        }
        public Int64 Index { get; set; }
        public decimal GrossLbs { get; set; }
        public decimal TareLbs { get; set; }
        public decimal NetResultLbs { get; set; }
    }
}
