using System.Collections.Generic;

namespace SGP.Domain
{
    public class Mechanic : BaseObject
    {
        public string PhaseId { get; set; }

        public Phase Phase { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public IEnumerable<Condition> Conditions { get; set; }
    }
}
