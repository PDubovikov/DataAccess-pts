using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Entity
{
    public class TypeMill
    {
        public int TypeMillId { get; set; }
        public string TypeMillCode { get; set; }

        public ICollection<MillingTool> MillingTools { get; set; }
        public ICollection<InsertType> TypeInserts { get; set; }

        public TypeMill()
        {
            MillingTools = new List<MillingTool>();
            TypeInserts = new List<InsertType>();
        }

    }
}
