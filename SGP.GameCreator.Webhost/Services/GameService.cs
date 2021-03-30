using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SGP.DAL.Interfaces;
using SGP.Domain;
using SGP.Domain.Enums;
using SGP.GameCreator.Webhost.Services.Interfaces;

namespace SGP.GameCreator.Webhost.Services
{
    public class GameService : ServiceBase, IGameService
    {
        private readonly IRepository<Domain.Game> _gameRepository;

        public GameService(IRepository<Domain.Game> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<Domain.Game>> GetList()
        {
            return await _gameRepository.GetList();
        }

        public async Task<Domain.Game> GetById(string id)
        {
            return await _gameRepository.GetById(id);
        }

        public async Task<Domain.Game> CreateGame(string name, string description)
        {
            var game = new Domain.Game
            {
                Id = GenerateId(),
                Name = name,
                Description = description,
                Phases = CreateInitialPhases()
            };

            await _gameRepository.Create(game);

            return game;
        }

        public async Task<Domain.Game> UpdateGame(string id, string name, string description)
        {
            var game = new Domain.Game()
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

        private IEnumerable<Phase> CreateInitialPhases()
        {
            var phases = new List<Phase>();

            foreach (PhaseType val in Enum.GetValues(typeof(PhaseType)))
            {
                var phase = new Phase
                {
                    Id = GenerateId(),
                    Name = val.ToString(),
                    IsMandatory = true,
                    Number = (int) val,
                    Type = val
                };

                phases.Add(phase);
            }

            return phases;
        }
    }
}
