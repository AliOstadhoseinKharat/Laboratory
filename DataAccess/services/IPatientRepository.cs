using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface IPatientRepository : IBaseRepository<Patient, int>
    {

        List<PatientViewModel> GetAllPatients();
    }
}
