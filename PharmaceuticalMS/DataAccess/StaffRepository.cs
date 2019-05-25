using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class StaffRepository : IStaffRepository
    {
        public void Delete(Staff obj)
        {
            using(PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
                {
                db.Staffs.Attach(obj);
                db.Staffs.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Staff> GetAll()
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                return db.Staffs.ToList();
            }
        }

        public Staff GetById(int id)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                return db.Staffs.Find(id);
            }
        }

        public Staff Insert(Staff obj)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                db.Staffs.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Staff obj)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                db.Staffs.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
