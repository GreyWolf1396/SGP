using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SGP.Domain;
using SGP.GameCreator.Webhost.Models;
using SGP.GameCreator.Webhost.Services.Interfaces;

namespace SGP.GameCreator.Webhost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public async Task<GameModel> CreateGame(CreateGameRequest request)
        {
            var game = await _gameService.CreateGame(request.Name, request.Description);

            return GameModel.FromDomain(game);
        }

        [HttpGet]
        public async Task<IEnumerable<GameModel>> GetGames()
        {
            var games = await _gameService.GetList();

            return games.Select(GameModel.FromDomain);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<GameModel> GetGameById(string id)
        {
            var game = await _gameService.GetById(id);

            return GameModel.FromDomain(game);
        }
    }
}
