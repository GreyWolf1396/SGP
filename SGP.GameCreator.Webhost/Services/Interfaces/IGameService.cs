using System.Threading.Tasks;
using SGP.Domain;

namespace SGP.GameCreator.Webhost.Services.Interfaces
{
    public interface IGameService : IQueryService<Game>
    {
        Task<Game> CreateGame(string name, string description);
    }
}