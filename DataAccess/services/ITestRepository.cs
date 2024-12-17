using DomainModel.Models;
using System.Collections.Generic;

namespace DataAccess.services
{
    internal interface ITestRepository
    {
        List<Test> GetAll();
        Test Get(int id);

        int Add(Test test);
        bool Remove(int testID);
        bool Update(Test test);
    }
}
