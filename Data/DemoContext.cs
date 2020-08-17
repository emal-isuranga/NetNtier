using Data.Entity;
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

        public DbSet<Employee> EmployeeList { get; set; }
        public DbSet<Attend> AttendsList { get; set; }
    }
}
