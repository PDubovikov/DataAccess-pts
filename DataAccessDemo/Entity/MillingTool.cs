using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Entity
{
    public class MillingTool
    {
        public int MillingToolId { get; set; }
        public int CurrentTypeMillId { get; set; }
        public int CurrentTypeInsertId { get; set; }
        public string ShankType { get; set; }
        public int ShankDiam { get; set; }
        public int ShankLength { get; set; }
        public string TypeMillCode { get; set; }
        public TypeMill CurrentTypeMill { get; set; } 
 //       public InsertType CurrentIsertType { get; set; } 
        public string MillOrderCode { get; set; }
        public int MillDiametr { get; set; }

        public ICollection<Holder> Holders { get; set; } 
        public ICollection<Insert> Inserts { get; set; } 

        public MillingTool()
        {
            Holders = new List<Holder>();
            Inserts = new List<Insert>();
        }
    }
}
