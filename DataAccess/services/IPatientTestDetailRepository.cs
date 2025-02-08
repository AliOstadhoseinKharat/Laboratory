using DomainModel.Models;
using DomainModel.ViewModels;
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface IPatientTestDetailRepository
        : IBaseRepository<PatientTestDetail, int>
    {


        List<ReceptionTestViewModel> GetAllPatientTestDetails();
    }
}
