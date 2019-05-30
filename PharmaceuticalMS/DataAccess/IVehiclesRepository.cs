using System.Collections.Generic;
using Model;


namespace DataAccess
{
    public interface IVehiclesRepository
    {
        List<Vehicle> GetAll();

        Vehicle GetById(int id);

        Vehicle Insert(Vehicle obj);

        void Update(Vehicle obj);

        void Delete(Vehicle obj);

    }
}
