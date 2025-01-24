using DataAccess.services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class UnitRepository : IUnitRepository
    {

        private readonly LabotatoryContext2 _dbContext = new LabotatoryContext2();
        public int Add(Unit unit)
        {
            _dbContext.Units.Add(unit);
            _dbContext.SaveChanges();
            return unit.UnitID;
        }

        public Unit Get(int id)
        {
            return _dbContext.Units.FirstOrDefault(item => item.UnitID == id);
        }

        public List<Unit> GetAll()
        {
            return _dbContext.Units.OrderByDescending(item => item.UnitID).ToList();
        }

        public bool HasTest(int UnitID)
        {
            return _dbContext.Units.Any(item => item.UnitID == UnitID);
        }

        public bool Remove(int UnitID)
        {

            bool result = false;
            try
            {
                Unit unitFounded = _dbContext.Units.FirstOrDefault(item => item.UnitID == UnitID);
                if (unitFounded != null)
                {
                    _dbContext.Units.Remove(unitFounded);
                    _dbContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Unit unit)
        {

            bool result = false;
            try
            {
                Unit oldUnit = _dbContext.Units.FirstOrDefault(item => item.UnitID == unit.UnitID);

                if (oldUnit != null)
                {
                    oldUnit.UnitName = unit.UnitName;
                    _dbContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
