using SGP.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGP.DAL.Interfaces
{
    public interface IRepository<T> where T : BaseObject
    {
        Task<string> Create(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(string id);

        Task<T> GetById(string id);

        Task<List<T>> GetList();
    }
}
