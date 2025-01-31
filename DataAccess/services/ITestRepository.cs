using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;


namespace DataAccess.services
{
    internal interface ITestRepository : IBaseRepository<Test, int>
    {

        List<TestViewModel> GetAllCustomTests();
    }
}
