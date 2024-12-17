using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccess.services
{
    interface ITestRangeRepository
    {
        List<TestRanx> GetAll();
        TestRanx Get(int testRanxID);
        int Add(TestRanx testRanx);
        bool Remove(int testRanxID);
        bool Update(TestRanx testRanx);
    }
}
