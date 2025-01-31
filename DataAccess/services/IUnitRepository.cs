using DomainModel.Models;

namespace DataAccess.services
{
    interface IUnitRepository : IBaseRepository<Unit, int>
    {
        bool HasTest(int UnitID);
    }
}
