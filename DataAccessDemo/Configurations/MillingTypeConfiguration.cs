using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataAccessDemo.Entity;

namespace DataAccessDemo.Configurations
{
    public class MillingTypeConfiguration : EntityTypeConfiguration<TypeMill>
    {
        public MillingTypeConfiguration()
        {
            HasKey(x => x.TypeMillId);

            //          HasMany(x => x.MillingTools)
            //              .WithRequired(p => p.CurrentTypeMill)
            //              .HasForeignKey(m => m.TypeMillCode);

            HasMany(i => i.TypeInserts)
                .WithRequired(m => m.CurrentTypeMill)
                .HasForeignKey(i => i.CurrentTypeMillId);
        }

    }
}

