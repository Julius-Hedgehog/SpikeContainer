namespace SpikeContainer.Spike_Dev_Express_Grid.CodedEntity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    //public class WeightEntity : DbContext
    //{
    //    // Your context has been configured to use a 'WeightEntity' connection string from your application's 
    //    // configuration file (App.config or Web.config). By default, this connection string targets the 
    //    // 'SpikeContainer.Spike_Dev_Express_Grid.CodedEntity.WeightEntity' database on your LocalDb instance. 
    //    // 
    //    // If you wish to target a different database and/or database provider, modify the 'WeightEntity' 
    //    // connection string in the application configuration file.
    //    public WeightEntity()
    //        : base("name=WeightEntity")
    //    {
    //    }

    //    // Add a DbSet for each entity type that you want to include in your model. For more information 
    //    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    //    // public virtual DbSet<MyEntity> MyEntities { get; set; }
    //    public virtual DbSet<WeightInGrid> WeightInGrid { get; set; }
    //}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class WeightInGrid
    {
        public WeightInGrid()
        { }
        public WeightInGrid(decimal dcmlgRossLbs=0, decimal dcmltAreLbs=0, decimal dcmlnEtResultLbs=0)
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