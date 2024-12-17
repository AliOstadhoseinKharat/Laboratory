using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestCategoryRepository : services.ITestCategoryRepository
    {
        public DomainModel.Models.LabotatoryContext2 db = new LabotatoryContext2();
        public int Add(TestCategory testCategory)
        {
            db.TestCategories.Add(testCategory);
            db.SaveChanges();
            return testCategory.CategoryID;
        }

        public TestCategory Get(int id)
        {
            var cat = db.TestCategories.FirstOrDefault(x => x.CategoryID == id);
            return cat;
        }

        public List<TestCategory> GetAll()
        {
            return db.TestCategories.OrderByDescending(x => x.CategoryID).ToList();
        }

        public bool HasTest(int testCategoryID)
        {
            bool r = db.Tests.Any(x => x.TestCategoryID == testCategoryID);
            return r;
        }

        public bool Remove(int testCategoryID)
        {
            try
            {
                var cat = db.TestCategories.FirstOrDefault(x => x.CategoryID == testCategoryID);
                db.TestCategories.Remove(cat);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(TestCategory testCategory)
        {
            try
            {
                var old = db.TestCategories.FirstOrDefault(x => x.CategoryID == testCategory.CategoryID);
                old.CategoryName = testCategory.CategoryName;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
