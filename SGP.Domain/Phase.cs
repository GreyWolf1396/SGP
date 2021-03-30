using System.Collections.Generic;
using SGP.Domain.Enums;

namespace SGP.Domain
{
    public class Phase : BaseObject
    {
        public int Number { get; set; }

        public bool IsMandatory { get; set; }

        public PhaseType Type { get; set; }

        public Phase NextPhase { get; set; }

        public string NextPhaseId { get; set; }

        public IEnumerable<Mechanic> Mechanics { get; set; }

        public IEnumerable<Condition> Conditions { get; set; }
    }
}
