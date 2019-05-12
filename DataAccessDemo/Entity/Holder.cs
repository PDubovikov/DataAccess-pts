using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Entity
{
    public class Holder
    {
        public int HolderId { get; set; }
        public string TypeName { get; set; }
        public int Diametr { get; set; }
        public int Length { get; set; }
        public string HolderOrderCode { get; set; }

        public ICollection<MillingTool> MillingTools { get; set; }	

        public Holder()
        {
            MillingTools = new List<MillingTool>();
        }
    }
}
