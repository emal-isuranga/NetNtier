using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DemoContext: DbContext
    {
        public DemoContext() : base("name=NtityTestEntities")
        { }

        public DbSet<Entity.Employee> EmployeeList { get; set; }
    }
}
