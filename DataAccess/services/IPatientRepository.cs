using DomainModel.Models;

namespace DataAccess.services
{
    public interface IPatientRepository : IBaseRepository<Patient, int>
    {
    }
}
