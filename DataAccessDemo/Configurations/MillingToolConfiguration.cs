using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataAccessDemo.Entity;

namespace DataAccessDemo.Configurations
{
    public class MillingToolConfiguration : EntityTypeConfiguration<MillingTool>
    {
        public MillingToolConfiguration()
        {

            HasKey(x => x.MillingToolId);

            HasRequired(t => t.CurrentTypeMill)
            .WithMany(m => m.MillingTools)
            .HasForeignKey(t => t.CurrentTypeMillId);

        }

    }
}
