using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface IPatientTestHeaderRepository : IBaseRepository<PatientHeader, int>
    {


        List<ReceptionViewModel> GetAllReceptions();
    }
}
