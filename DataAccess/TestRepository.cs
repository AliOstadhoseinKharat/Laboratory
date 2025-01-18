using DataAccess.services;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TestRepository : ITestRepository
    {

        private LabotatoryContext2 dbContext = new LabotatoryContext2();
        public int Add(Test test)
        {
            dbContext.Tests.Add(test);
            dbContext.SaveChanges();
            return test.TestID;
        }

        public Test Get(int id)
        {
            return dbContext.Tests.FirstOrDefault(item => item.TestID == id);
        }

        public List<Test> GetAll()
        {
            return dbContext.Tests.OrderByDescending(item => item.TestID).ToList();
        }

        public List<TestViewModel> GetAllCustomTests()
        {
            return dbContext.Tests.Select(item => new TestViewModel
            {
                TestName = item.TestName,
                UnitName = item.Unit.UnitName ?? "",
                AgeHasEffect = item.AgeHasEffect,
                GenderHasEffect = item.GenderHasEffect,
                CategoryName = item.TestCategory.CategoryName ?? "",
                Price = item.Price
            }).ToList();
        }

        public bool Remove(int testID)
        {
            bool result = false;
            try
            {
                Test testFounded = dbContext.Tests.FirstOrDefault(item => item.TestID == testID);
                dbContext.Tests.Remove(testFounded);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Test test)
        {
            try
            {
                Test oldTest = dbContext.Tests.FirstOrDefault(item => item.TestID == test.TestID);
                oldTest.TestName = test.TestName;
                oldTest.UnitID = test.UnitID;
                oldTest.AgeHasEffect = test.AgeHasEffect;
                oldTest.GenderHasEffect = test.GenderHasEffect;
                oldTest.TestCategoryID = test.TestCategoryID;
                oldTest.Price = test.Price;

                dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
