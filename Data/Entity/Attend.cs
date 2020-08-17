using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Attend
    {
      
        public int Id { get; set; }
        
        public int EmpId { get; set; }
        
        public int AttenCount { get; set; }
        
        public virtual Employee Employee { get; set; }
    }
}
