using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PropertySample
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=masterDB")
        {
        }

        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
