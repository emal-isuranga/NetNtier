using Data;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Collections;

namespace Business
{
    public class AttendManager
    {
        private DemoContext db = new DemoContext();
        public IQueryable<Attend> FindAll()
        {
            return this.db.AttendsList.Include(p => p.Employee);
        }

        public Attend Find(int id)
        {
            return this.db.AttendsList.Find(id);
        }

        public void Save(Attend attend)
        {
            this.db.AttendsList.Add(attend);
            this.db.SaveChanges();
        }

        public void Modify(Attend attend)
        {
            db.Entry(attend).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Attend attend = this.Find(id);
            db.AttendsList.Remove(attend);
            db.SaveChanges();
        }

        public IEnumerable<Employee> EmployeeList
        {
            get
            {
                return this.db.EmployeeList;
            }
        }

        public void Dispose()
        {
            this.db.Dispose();
        }

    }

}
