using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;


namespace DataAccess.services
{
    interface ITestRangeRepository
    {
        List<TestRanx> GetAll();

        List<TestRangeViewModel> GetTestRanges();

        TestRanx Get(int testRanxID);
        int Add(TestRanx testRanx);
        bool Remove(int testRanxID);
        bool Update(TestRanx testRanx);
    }
}
