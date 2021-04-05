using System.Collections.Generic;

namespace SGP.Domain
{
    public class Mechanic : BaseObject
    {
        public string PhaseId { get; set; }

        public Phase Phase { get; set; }

        public string ActorId { get; set; }

        public Actor Actor { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public bool IsMandatory { get; set; }
    }
}
