using System.Collections.Generic;
using DataAccess;
using Model;

namespace ApplicationLogic
{
    public static class VehiclesServices
    {
        static IVehiclesRepository repository;
        static VehiclesServices()
        {
            repository = new VehiclesRepository();
        }

        public static List<Vehicle> GetAll()
        {
            return repository.GetAll();
        }

        public static Vehicle GetByID(int id)
        {
            return repository.GetById(id);
        }

        public static Vehicle Insert(Vehicle obj)
        {
            return repository.Insert(obj);
        }

        public static void Update(Vehicle obj)
        {
            repository.Update(obj);
        }

        public static void Delete(Vehicle obj)
        {
            repository.Delete(obj);
        }
    }
}
