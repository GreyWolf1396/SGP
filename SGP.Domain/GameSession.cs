using SGP.Domain.Enums;
using System.Collections.Generic;

namespace SGP.Domain
{
    public class GameSession
    {
        public string GameId { get; set; }

        public Game Game { get; set; }

        public IEnumerable<Player> Players { get; set; }

        public IEnumerable<AttributeValue> Values { get; set; }

        public GameSessionStatus Status { get; set; }

        public Phase CurrentPhase { get; set; }

        public Player ActivePlayer { get; set; }
    }
}
