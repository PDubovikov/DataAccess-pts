using DataAccessDemo.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Initializers
{
    public class IfModelChangeInitializer : DropCreateDatabaseAlways<ExampleContext>
    {

        protected override void Seed(ExampleContext context)
        {
            base.Seed(context);

            var holder1 = new Holder()
            {
                HolderOrderCode = "69871.50ADB-FMH2.40.160",
                Diametr = 40,
                TypeName = "FMH1"
            };

            var holder2 = new Holder()
            {
                HolderOrderCode = "69871.50ADB-W.25.160",
                Diametr = 25,
                TypeName = "Weldon"
            };

            var insertType = new InsertType()
            {
                TypeInsertCode = "ADMX 11"
            };

            var millingInsert1 = new Insert() { InsertCode = "ADMX 11T308SR-F:M8330" };
            var millingInsert2 = new Insert() { InsertCode = "ADMX 11T304SR-M:M8330" };
            var millingInsert3 = new Insert() { InsertCode = "ADMX 11T312SR-M:M8330" };

            var millingTool1 = new MillingTool()
            {
                MillOrderCode = "125A12R-C60HN09",
                ShankType = "FMH1",
                TypeMillCode = "CHN09",
                ShankDiam = 40,
                MillDiametr = 125           
            };

            var millingTool2 = new MillingTool()
            {
                MillOrderCode = "140A08R-S19PD09-C",
                ShankType = "FMH1",
                TypeMillCode = "SPD09",
                ShankDiam = 40,
                MillDiametr = 140
            };

            var millingTool3 = new MillingTool()
            {
                MillOrderCode = "20E2R120B25-SRD10",
                ShankType = "Weldon",
                TypeMillCode = "SRD10",
                ShankDiam = 25,
                MillDiametr = 20
            };

            holder1.MillingTools.Add(millingTool1);
            holder1.MillingTools.Add(millingTool2);
            holder2.MillingTools.Add(millingTool3);
            millingTool1.Inserts.Add(millingInsert1);
            millingTool2.Inserts.Add(millingInsert2);
            millingTool3.Inserts.Add(millingInsert3);

            var millingType = new TypeMill()
            {
                TypeMillCode = "CHN09",
                TypeInserts = new List<InsertType>() { insertType },
                MillingTools = new List<MillingTool>() { millingTool1 }
            };

            context.DbHolders.AddRange(new List<Holder>() { holder1, holder2 });
            context.DbInsertTypes.Add(insertType);
            context.DbMillingInserts.AddRange(new List<Insert>() { millingInsert1, millingInsert2, millingInsert3 });
            context.DbMillingTools.AddRange(new List<MillingTool>() { millingTool1, millingTool2, millingTool3 });
            context.DbMillingToolType.Add(millingType);

            context.SaveChanges();

        }

    }
}
