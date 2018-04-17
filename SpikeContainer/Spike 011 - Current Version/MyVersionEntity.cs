using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeContainer.Spike_011___Current_Version
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core.EntityClient;
    using System.Linq;

    class MyVersionEntity : DbContext
    {
        public MyVersionEntity()
            : base("name=MyVersionEntity")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<VersionedItems> VersionedItem { get; set; }
    }


    public class VersionedItems
    {
        public VersionedItems()
        { }
        public VersionedItems(string name, bool isExten, string extension, string fullPathName, Version vers, bool isFile, FileInfo fi)
        {
            Name = name;
            IsExtensionable = isExten;
            Extension = extension;
            FullPathandName = fullPathName;
            version = vers;
            IsFileNotFolder = isFile;
            Info = fi;
        }

        public string Name { get; set; }
        public bool IsExtensionable { get; set; }
        public string Extension { get; set; }
        public string FullPathandName { get; set; }
        public Version version { get; set; }
        public bool IsFileNotFolder { get; set; }
        public FileInfo Info { get; set; }





    }
}
