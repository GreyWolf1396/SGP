using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<GameModel> CreateGame(CreateGameRequest request)
        {
            var game = await _gameService.CreateGame(request.Name, request.Description);

            return GameModel.FromDomain(game);
        }

        [HttpPut, HttpPatch]
        [Route("{id}")]
        public async Task<GameModel> UpdateGame(string id, GameModel model)
        {
            var game = await _gameService.UpdateGame(id, model.Name, model.Description);

            return GameModel.FromDomain(game);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteGame(string id)
        {
            return Ok(await _gameService.DeleteGame(id));
        }
    }
}
