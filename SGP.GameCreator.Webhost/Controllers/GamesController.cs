using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutoMapper;
using SGP.GameCreator.Webhost.Models;
using SGP.GameCreator.Webhost.Models.GameModels;
using SGP.GameCreator.Webhost.Services.Interfaces;

namespace SGP.GameCreator.Webhost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public GamesController(IGameService gameService, IMapper mapper)
        {
            _gameService = gameService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<GameModel>> GetGames()
        {
            var games = await _gameService.GetList();

            return _mapper.Map<IEnumerable<GameModel>>(games);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<GameModel> GetGameById(string id)
        {
            var game = await _gameService.GetById(id);

            return _mapper.Map<GameModel>(game);
        }

        [HttpPost]
        public async Task<GameModel> CreateGame(CreateGameRequest request)
        {
            var game = await _gameService.CreateGame(request.Name, request.Description);

            return _mapper.Map<GameModel>(game);
        }

        [HttpPut, HttpPatch]
        [Route("{id}")]
        public async Task<GameModel> UpdateGame(string id, GameModel model)
        {
            var game = await _gameService.UpdateGame(id, model.Name, model.Description);

            return _mapper.Map<GameModel>(game);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteGame(string id)
        {
            return Ok(await _gameService.DeleteGame(id));
        }
    }
}
