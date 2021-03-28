using SGP.DAL.Interfaces;
using SGP.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.DAL
{
    public class InMemoryRepository<T> : IRepository<T> where T : BaseObject
    {
        private static List<T> InMemoryList = new List<T>();

        public async Task<string> Create(T entity)
        {
            InMemoryList.Add(entity);

            return entity.Id;
        }

        public async Task<bool> Delete(string id)
        {
            var game = InMemoryList.FirstOrDefault(game => game.Id == id);

            if(game != null)
            {
                InMemoryList.Remove(game);

                return true;
            }

            return false;
        }

        public async Task<T> GetById(string id)
        {
            var game = InMemoryList.FirstOrDefault(game => game.Id == id);

            return game;
        }

        public async Task<List<T>> GetList()
        {
            return InMemoryList;
        }

        public async Task<bool> Update(T entity)
        {
            var game = InMemoryList.FirstOrDefault(game => game.Id == entity.Id);

            if (game != null)
            {
                InMemoryList.Remove(game);
                InMemoryList.Add(entity);
                return true;
            }

            return false;
        }
    }
}
