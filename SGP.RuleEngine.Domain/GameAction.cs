using System.Collections.Generic;

namespace SGP.RuleEngine.Domain
{
    public class GameAction
    {
        public IEnumerable<Condition> Conditions { get; set; }

        public ActionType Type { get; set; }
    }
}
