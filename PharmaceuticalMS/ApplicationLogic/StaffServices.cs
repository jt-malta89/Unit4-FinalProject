using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace ApplicationLogic
{
    public static class StaffServices
    {
        static IStaffRepository repository;
        static StaffServices()
        {
            repository = new StaffRepository();
        }

        public static List<Staff> GetAll()
        {
            return repository.GetAll();
        }

        public static Staff GetByID(int id)
        {
            return repository.GetById(id);
        }

        public static Staff Insert(Staff obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(Staff obj)
        {
            repository.Update(obj);
        }

        public static void Delete(Staff obj)
        {
            repository.Delete(obj);
        }
    }
}
