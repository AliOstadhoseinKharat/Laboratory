using DomainModel.Models;
namespace DataAccess.services
{
    public interface ITestCategoryRepository : IBaseRepository<TestCategory, int>
    {
        bool HasTest(int testCategoryID);
    }
}
