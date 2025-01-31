using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;


namespace DataAccess.services
{
    interface ITestRangeRepository : IBaseRepository<TestRanx, int>
    {
        List<TestRangeViewModel> GetTestRanges();
    }
}
