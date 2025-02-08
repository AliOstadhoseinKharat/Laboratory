using DataAccess.services;
using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class PatientRepository : IPatientRepository
    {
        private LabotatoryContext2 dbContext = new LabotatoryContext2();

        public int Add(Patient patient)
        {
            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();
            return patient.PatientID;
        }

        public Patient Get(int ID)
        {
            return dbContext.Patients.FirstOrDefault(item => item.PatientID == ID);
        }

        public List<Patient> GetAll()
        {
            return dbContext.Patients.OrderByDescending(item => item.PatientID).ToList();
        }

        public List<PatientViewModel> GetAllPatients()
        {
            return dbContext.Patients.Select(item => new PatientViewModel
            {
                PatientID = item.PatientID,
                FirstName = item.FirstName,
                LastName = item.LastName,
                FullName = (item.FirstName ?? "") + " " + (item.LastName ?? ""),
                Address = item.Address,
                Mobile = item.Mobile,
                NationalCode = item.NationalCode,
                Gender = item.Gender == true ? "Male" : "Female",
            }
            ).ToList();
        }

        public bool Remove(int patientID)
        {
            bool result = false;
            try
            {
                var patient = dbContext.Patients.FirstOrDefault(x => x.PatientID == patientID);
                dbContext.Patients.Remove(patient);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool Update(Patient newPatient)
        {
            try
            {
                var old = dbContext.Patients.FirstOrDefault(x => x.PatientID == newPatient.PatientID);
                old.FirstName = newPatient.FirstName;
                old.LastName = newPatient.LastName;
                old.NationalCode = newPatient.NationalCode;
                old.Address = newPatient.Address;
                old.Gender = newPatient.Gender;
                old.Mobile = newPatient.Mobile;

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
