using DataAccess.services;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class InsuranceTypeRepository : IInsuranceTypeRepository
    {

        private LabotatoryContext2 dbContext = new LabotatoryContext2();


        public int Add(InsuranceType insurance)
        {
            dbContext.InsuranceTypes.Add(insurance);
            dbContext.SaveChanges();
            return insurance.InsuranceTypeID;
        }

        public InsuranceType Get(int ID)
        {
            return dbContext.InsuranceTypes.FirstOrDefault(item => item.InsuranceTypeID == ID);
        }

        public List<InsuranceType> GetAll()
        {
            return dbContext.InsuranceTypes.OrderByDescending(item => item.InsuranceTypeID).ToList();
        }

        public bool Remove(int ID)
        {
            bool result = false;
            try
            {
                InsuranceType FoundedInsurance = dbContext.InsuranceTypes.FirstOrDefault(
                    item => item.InsuranceTypeID == ID
                    );

                if (FoundedInsurance != null)
                {
                    dbContext.InsuranceTypes.Remove(FoundedInsurance);
                    dbContext.SaveChanges();
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

        public bool Update(InsuranceType newInsurance)
        {
            bool result = false;
            try
            {

                InsuranceType oldInsurance = dbContext.InsuranceTypes.FirstOrDefault(item =>
                item.InsuranceTypeID == newInsurance.InsuranceTypeID);
                if (oldInsurance != null)
                {
                    oldInsurance.InsuranceTypeName = newInsurance.InsuranceTypeName;
                    oldInsurance.Description = newInsurance.Description;

                    dbContext.SaveChanges();
                    result = true;
                }
                else
                {
                    result = false;
                }


            }
            catch (Exception ex) { result = false; }
            return result;
        }
    }
}
