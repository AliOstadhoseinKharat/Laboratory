using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.services
{
    interface IUnitRepository
    {
        List<Unit> GetAll();
        Unit Get(int id);
        int Add(Unit unit);
        bool Remove(int UnitID);
        bool Update(Unit unit);
        bool HasTest(int UnitID);
        
    }
}
