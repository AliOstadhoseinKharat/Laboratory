using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface IEmployeeRepository : IBaseRepository<Employee, int>
    {

        List<EmployeeViewModel> GetAllEmployee();
    }
}
