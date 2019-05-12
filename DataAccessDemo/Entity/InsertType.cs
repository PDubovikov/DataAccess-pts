using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Entity
{
    public class InsertType
    {
        public string TypeInsertCode { get; set; }
        public int InsertTypeId { get; set; }

        public int CurrentTypeMillId { get; set; }
        public TypeMill CurrentTypeMill { get; set; } 
        public ICollection<Insert> Inserts { get; set; }

        public InsertType()
        {
            Inserts = new List<Insert>();
        }

    }
}
