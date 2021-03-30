using System.Threading.Tasks;
using SGP.Domain;

namespace SGP.GameCreator.Webhost.Services.Interfaces
{
    public interface IGameService : IQueryService<Domain.Game>
    {
        Task<Domain.Game> CreateGame(string name, string description);

        Task<Domain.Game> UpdateGame(string id, string name, string description);

        Task<bool> DeleteGame(string id);
    }
}