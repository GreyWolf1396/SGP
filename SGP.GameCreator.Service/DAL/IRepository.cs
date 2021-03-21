using SGP.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGP.GameCreator.Service.DAL
{
    interface IRepository<T> where T : BaseType
    {
        Task<T> Create(T entity);

        Task<T> Update(T entity);

        Task Delete(int id);

        Task<T> GetById(int id);

        Task<IEnumerable<T>> Get();
    }
}
