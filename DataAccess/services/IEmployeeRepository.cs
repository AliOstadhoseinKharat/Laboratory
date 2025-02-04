using DomainModel.Models;

namespace DataAccess.services
{
    public interface IEmployeeRepository : IBaseRepository<Employee, int>
    {
    }
}
