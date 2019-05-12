using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataAccessDemo.Entity;

namespace DataAccessDemo.Configurations
{
    public class InsertTypeConfiguration : EntityTypeConfiguration<InsertType>
    {

        public InsertTypeConfiguration()
        {

            HasKey(x => x.InsertTypeId);

            HasMany(x => x.Inserts)
                .WithRequired(x => x.CurrentInsertType)
                .HasForeignKey(x => x.CurrentInsertTypeId);

        //    HasRequired(m => m.TypeMill)
        //        .WithMany(i => i.TypeInserts);
                

        }

    }
}
