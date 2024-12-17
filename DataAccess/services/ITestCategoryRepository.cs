using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;
namespace DataAccess.services
{
    interface ITestCategoryRepository
    {
        List<TestCategory> GetAll();
        TestCategory Get(int id);

        int Add(TestCategory testCategory);
        bool Remove(int testCategoryID);
        bool Update(TestCategory testCategory);
        bool HasTest(int testCategoryID);


    }
}
