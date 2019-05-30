using System.Collections.Generic;
using System.Linq;
using Model;

namespace DataAccess
{
    public class VehiclesRepository : IVehiclesRepository
    {
        public void Delete(Vehicle obj)
        {
            using(PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
                {
                db.Vehicles.Attach(obj);
                db.Vehicles.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Vehicle> GetAll()
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                return db.Vehicles.ToList();
            }
        }

        public Vehicle GetById(int id)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                return db.Vehicles.Find(id);
            }
        }

        public Vehicle Insert(Vehicle obj)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                db.Vehicles.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Vehicle obj)
        {
            using (PharmaceuticalDBEntities db = new PharmaceuticalDBEntities())
            {
                db.Vehicles.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
