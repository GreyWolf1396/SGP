using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGP.Domain;
using SGP.GameCreator.Webhost.Services.Interfaces;

namespace SGP.GameCreator.Webhost.Services
{
    public class GameService : IGameService
    {
        private static readonly List<Game> InMemoryList = new List<Game>();

        public async Task<List<Game>> GetList()
        {
            return InMemoryList;
        }

        public async Task<Game> GetById(string id)
        {
            return InMemoryList.FirstOrDefault(g => g.Id == id);
        }

        public async Task<Game> CreateGame(string name, string description)
        {
            var game = new Game()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description
            };

            InMemoryList.Add(game);

            return game;
        }
    }
}
