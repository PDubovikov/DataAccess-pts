using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessDemo.Entity
{
    public class Insert
    {
        public int InsertId { get; set; }
        public string InsertCode { get; set; }
        
        public int CurrentInsertTypeId { get; set; }
        public InsertType CurrentInsertType { get; set; } 

    }
}
