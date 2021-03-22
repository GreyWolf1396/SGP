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

        [HttpPost]
        public async Task<GameModel> CreateGame(CreateGameRequest request)
        {
            var game = await _gameService.CreateGame(request.Name, request.Description);

            return new GameModel()
            {
                Id = game.Id, Description = game.Description, Name = game.Name
            };
        }
    }
}
