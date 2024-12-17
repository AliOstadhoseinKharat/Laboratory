using DataAccess.services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class TestRangeRepository : ITestRangeRepository
    {
        private LabotatoryContext2 dbContext = new LabotatoryContext2();
        public int Add(TestRanx testRanx)
        {
            dbContext.TestRanges.Add(testRanx);
            dbContext.SaveChanges();
            return testRanx.RangeID;
        }

        public TestRanx Get(int testRanxID)
        {
            return dbContext.TestRanges.FirstOrDefault(x => x.RangeID == testRanxID);

        }

        public List<TestRanx> GetAll()
        {
            return dbContext.TestRanges.ToList();
        }

        public bool Remove(int testRanxID)
        {
            bool result = false;
            try
            {
                var range = dbContext.TestRanges.FirstOrDefault(x => x.RangeID == testRanxID);
                dbContext.TestRanges.Remove(range);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(TestRanx testRanx)
        {
            try
            {
                var old = dbContext.TestRanges.FirstOrDefault(x => x.RangeID == testRanx.RangeID);
                old.FromAge = testRanx.FromAge;
                old.ToAge = testRanx.ToAge;
                old.FromValue = testRanx.FromValue;
                old.ToValue = testRanx.ToValue;
                old.Gender = testRanx.Gender;
                old.TestID = testRanx.TestID;
                old.Description = testRanx.Description;
                old.Hazard = testRanx.Hazard;
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
