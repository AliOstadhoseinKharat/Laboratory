using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;


namespace DataAccess.services
{
    internal interface ITestRepository
    {
        List<Test> GetAll();

        List<TestViewModel> GetAllCustomTests();
        Test Get(int id);

        int Add(Test test);
        bool Remove(int testID);
        bool Update(Test test);
    }
}
