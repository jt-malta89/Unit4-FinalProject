using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DataAccess
{
    public interface IStaffRepository
    {
        List<Staff> GetAll();

        Staff GetById(int id);

        Staff Insert(Staff obj);

        void Update(Staff obj);

        void Delete(Staff obj);

    }
}
