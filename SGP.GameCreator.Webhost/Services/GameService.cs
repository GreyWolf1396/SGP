using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGP.DAL.Interfaces;
using SGP.Domain;
using SGP.GameCreator.Webhost.Services.Interfaces;

namespace SGP.GameCreator.Webhost.Services
{
    public class GameService : IGameService
    {
        private readonly IRepository<Game> _gameRepository;

        public GameService(IRepository<Game> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<Game>> GetList()
        {
            return await _gameRepository.GetList();
        }

        public async Task<Game> GetById(string id)
        {
            return await _gameRepository.GetById(id);
        }

        public async Task<Game> CreateGame(string name, string description)
        {
            var game = new Game()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description
            };

            await _gameRepository.Create(game);

            return game;
        }

        public async Task<Game> UpdateGame(string id, string name, string description)
        {
            var game = new Game()
            {
                Id = id,
                Name = name,
                Description = description
            };

            await _gameRepository.Update(game);

            return game;
        }

        public async Task<bool> DeleteGame(string id)
        {
            return await _gameRepository.Delete(id);
        }
    }
}
