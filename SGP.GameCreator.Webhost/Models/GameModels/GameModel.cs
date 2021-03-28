using SGP.Domain;

namespace SGP.GameCreator.Webhost.Models
{
    public class GameModel : BaseObjectModel
    {
        public static GameModel FromDomain(Game game)
        {
            if (game == null)
            {
                return null;
            }

            return new GameModel
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description
            };
        }
    }
}
