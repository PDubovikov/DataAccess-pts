using DataAccessDemo.Entity;
using DataAccessDemo.Initializers;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccessDemo
{
    public class ExampleContext : DbContext
    {
        public ExampleContext()
            : base("name=ExampleContext")
        {
            Database.SetInitializer(new IfModelChangeInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.AddFromAssembly(typeof(ExampleContext).Assembly);
        }


        public virtual DbSet<Holder> DbHolders { get; set; }
        public virtual DbSet<InsertType> DbInsertTypes { get; set; }
        public virtual DbSet<Insert> DbMillingInserts { get; set; }
        public virtual DbSet<MillingTool> DbMillingTools { get; set; }
        public virtual DbSet<TypeMill> DbMillingToolType { get; set; }

    }

}