using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.EntityClient;

namespace SpikeContainer.Spike_Dev_Express_Grid.Data
{
    public class GridWeightData
    {
        public GridWeightData()
        {  }
        public GridWeightData(decimal dcmlgRossLbs, decimal dcmltAreLbs, decimal dcmlnEtResultLbs)
        {
            GrossLbs = dcmlgRossLbs;
            TareLbs = dcmltAreLbs;
            NetResultLbs = dcmlnEtResultLbs;
        }

        public decimal GrossLbs { get; set; }
        public decimal TareLbs { get; set; }
        public decimal NetResultLbs { get; set; }

    }

}
