using DataAccess.services;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PatientTestDetailRepository : IPatientTestDetailRepository
    {
        private LabotatoryContext2 dbContext = new LabotatoryContext2();

        public int Add(PatientTestDetail patientTestDetail)
        {
            try
            {
                if (patientTestDetail != null)
                {
                    dbContext.PatientTestDetails.Add(patientTestDetail);
                    dbContext.SaveChanges();
                    return patientTestDetail.PatientTestDetailsID;

                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public PatientTestDetail Get(int ID)
        {
            return dbContext.PatientTestDetails.FirstOrDefault(x => x.PatientTestDetailsID == ID);
        }

        public List<PatientTestDetail> GetAll()
        {
            return dbContext.PatientTestDetails.ToList();
        }

        public List<ReceptionTestViewModel> GetAllPatientTestDetails()
        {
            List<ReceptionTestViewModel> result = dbContext.PatientTestDetails.Select(item => new ReceptionTestViewModel
            {
                PatientTestDetailsID = item.PatientTestDetailsID,
                PatientTestHeaderID = item.PatientHeader.PatientTestHeaderID,
                PatientID = item.PatientHeader.PatientID,
                PatientName = (item.PatientHeader.Patient.FirstName ?? "") + " " + (item.PatientHeader.Patient.LastName ?? ""),
                HeaderDate = item.PatientHeader.HeaderDate,
                TestID = item.TestID,
                TestName = item.Test.TestName,
                Price = (int)item.Test.Price,
                Result = (float)(item.Result ?? 0),
                HasStar = (bool)(item.HasStar ?? false)

            }).ToList();

            return result;
        }

        public bool Remove(int ID)
        {
            bool result = false;
            try
            {
                var patientTestDetails = dbContext.PatientTestDetails.FirstOrDefault(x =>
                x.PatientTestDetailsID == ID);
                dbContext.PatientTestDetails.Remove(patientTestDetails);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(PatientTestDetail newPatientTestDetail)
        {
            try
            {
                var old = dbContext.PatientTestDetails.FirstOrDefault(
                    x => x.PatientTestDetailsID == newPatientTestDetail.PatientTestDetailsID);
                old.TestID = newPatientTestDetail.TestID;
                old.Price = newPatientTestDetail.Price;
                old.PatientTestHeaderID = newPatientTestDetail.PatientTestHeaderID;
                old.HasStar = newPatientTestDetail.HasStar;
                old.Result = newPatientTestDetail.Result;
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
