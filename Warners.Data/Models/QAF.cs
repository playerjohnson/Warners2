using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Warners.Data.Models
{
    public partial class QAF : DbContext
    {
        public QAF() : base("name=QAF")
        {
        }

        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<Tester> Testers { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
