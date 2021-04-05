﻿using System.Collections.Generic;

namespace SGP.Domain
{
    public class Phase : BaseObject
    {
        public string GameId { get; set; }

        public string Game { get; set; }

        public int Number { get; set; }

        public bool IsMandatory { get; set; }

        public Phase NextPhase { get; set; }

        public string NextPhaseId { get; set; }

        public IEnumerable<Mechanic> Mechanics { get; set; }

        public IEnumerable<Condition> Conditions { get; set; }
    }
}
