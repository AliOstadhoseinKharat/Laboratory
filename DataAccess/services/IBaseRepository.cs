
using System.Collections.Generic;

namespace DataAccess.services
{
    public interface IBaseRepository<TModel, TKey> where TModel : class
    {
        List<TModel> GetAll();
        TModel Get(TKey ID);

        int Add(TModel Model);
        bool Remove(int ID);
        bool Update(TModel Model);
    }
}
