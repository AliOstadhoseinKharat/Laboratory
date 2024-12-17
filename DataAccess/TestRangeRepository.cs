using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.services;
using DomainModel.Models;

namespace DataAccess
{
    public class TestRangeRepository : ITestRangeRepository
    {
        private DomainModel.Models.LabotatoryContext2 db = new DomainModel.Models.LabotatoryContext2();
        public int Add(TestRanx testRanx)
        {
            db.TestRanges.Add(testRanx);
            db.SaveChanges();
            return testRanx.RangeID;
        }

        public TestRanx Get(int testRanxID)
        {
            return db.TestRanges.FirstOrDefault(x => x.RangeID == testRanxID);

        }

        public List<TestRanx> GetAll()
        {
            return db.TestRanges.ToList();
        }

        public bool Remove(int testRanxID)
        {
            bool result = false;
            try
            {
                var range = db.TestRanges.FirstOrDefault(x => x.RangeID == testRanxID);
                db.TestRanges.Remove(range);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(TestRanx testRanx)
        {
            try
            {
                var old = db.TestRanges.FirstOrDefault(x => x.RangeID == testRanx.RangeID);
                old.FromAge = testRanx.FromAge;
                old.ToAge = testRanx.ToAge;
                old.FromValue = testRanx.FromValue;
                old.ToValue = testRanx.ToValue;
                old.Gender = testRanx.Gender;
                old.TestID = testRanx.TestID;
                old.Description = testRanx.Description;
                old.Hazard = testRanx.Hazard;
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
