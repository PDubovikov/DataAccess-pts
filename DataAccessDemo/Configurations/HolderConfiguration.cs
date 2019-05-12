using DataAccessDemo.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Configurations
{
    public class HolderConfiguration : EntityTypeConfiguration<Holder>
    {
        public HolderConfiguration()
        {

            HasKey(x => x.HolderId);

            HasMany(m => m.MillingTools)
                .WithMany(h => h.Holders)
                .Map(mh =>
                        {
                            mh.ToTable("MillHolders");
                            mh.MapLeftKey("HolderRefId");
                            mh.MapRightKey("MillingRefToolId");
                        }
                );

        }

    }
}
