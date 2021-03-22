using System.Collections.Generic;
using System.Threading.Tasks;
using SGP.Domain;

namespace SGP.GameCreator.Webhost.Services.Interfaces
{
    public interface IQueryService<T> where T : BaseObject
    {
        Task<List<T>> GetList();

        Task<T> GetById(string id);
    }
}
