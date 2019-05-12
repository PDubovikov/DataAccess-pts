using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataAccessDemo.Entity;

namespace DataAccessDemo.Configurations
{
    public class InsertConfiguration : EntityTypeConfiguration<Insert>
    {
        public InsertConfiguration()
        {

            HasKey(x => x.InsertId);

     //       HasRequired(i => i.CurrentInsertType)
     //           .WithMany(s => s.Inserts);

        }

    }
}
