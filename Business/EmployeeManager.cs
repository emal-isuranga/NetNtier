using Data;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class EmployeeManager
    {
        private DemoContext db = new DemoContext();
        public IQueryable<Employee> FindAll()
        {
            return this.db.EmployeeList;
        }

        public void Save(Employee employee)
        {
            this.db.EmployeeList.Add(employee);
            this.db.SaveChanges();
        }

        public Employee Find(int id)
        {
            return this.db.EmployeeList.Find(id);
        }

        public void Modify(Employee employee)
        {
            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee employee = this.Find(id);
            db.EmployeeList.Remove(employee);
            db.SaveChanges();
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}
