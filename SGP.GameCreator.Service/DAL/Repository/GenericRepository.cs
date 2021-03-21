using SGP.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGP.GameCreator.Service.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseType
    {
        public string Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.Create(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
