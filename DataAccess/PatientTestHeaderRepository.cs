using DataAccess.services;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PatientTestHeaderRepository : IPatientTestHeaderRepository
    {
        private LabotatoryContext2 _dbContext = new LabotatoryContext2();

        public int Add(PatientHeader patientHeader)
        {
            _dbContext.PatientHeaders.Add(patientHeader);
            _dbContext.SaveChanges();
            return patientHeader.PatientTestHeaderID;
        }

        public PatientHeader Get(int ID)
        {
            return _dbContext.PatientHeaders.FirstOrDefault(item => item.PatientTestHeaderID == ID);
        }

        public List<PatientHeader> GetAll()
        {
            return _dbContext.PatientHeaders.OrderByDescending(item => item.PatientTestHeaderID).ToList();
        }

        public List<ReceptionViewModel> GetAllReceptions()
        {
            return _dbContext.PatientHeaders.Select((item) => new ReceptionViewModel
            {
                PatientTestHeaderID = item.PatientTestHeaderID,
                PatientTestHeaderName = (item.Patient.FirstName ?? "") + " " + (item.Patient.LastName ?? "") + " " + item.HeaderDate,
                HeaderDate = item.HeaderDate,
                PatientID = item.PatientID,
                PatientName = (item.Patient.FirstName ?? "") + " " + (item.Patient.LastName ?? ""),
                EmployeeID = item.EmployeeID,
                EmployeeName = (item.Employee.FirstName ?? "") + " " + (item.Employee.LastName ?? ""),
                InsuranceTypeID = (int)item.InsuranceTypeID,
                InsuranceTypeName = item.InsuranceType.InsuranceTypeName ?? "N/A",
                DrName = item.DrName,
                Age = item.Age,
                TotalPrice = item.PatientTestDetails.Sum(itemDetail => (long?)itemDetail.Price) ?? 0
            }).ToList();
        }

        public bool Remove(int ID)
        {
            bool result = false;
            try
            {
                var patientTestHeader = _dbContext.PatientHeaders.FirstOrDefault(x => x.PatientTestHeaderID
                == ID);
                _dbContext.PatientHeaders.Remove(patientTestHeader);
                _dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(PatientHeader newPatientHeader)
        {
            bool result = false;
            try
            {
                var oldPatientHeader = _dbContext.PatientHeaders.FirstOrDefault(item => item.PatientTestHeaderID == newPatientHeader.PatientTestHeaderID); ;

                if (oldPatientHeader != null)
                {
                    oldPatientHeader.HeaderDate = newPatientHeader.HeaderDate;
                    oldPatientHeader.EmployeeID = newPatientHeader.EmployeeID;
                    oldPatientHeader.InsuranceTypeID = newPatientHeader.InsuranceTypeID;
                    oldPatientHeader.PatientID = newPatientHeader.PatientID;
                    oldPatientHeader.DrName = newPatientHeader.DrName;
                    oldPatientHeader.Age = newPatientHeader.Age;
                    oldPatientHeader.TotalPrice = newPatientHeader.TotalPrice;
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
