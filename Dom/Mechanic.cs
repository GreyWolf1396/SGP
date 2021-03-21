﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain
{
    public class Mechanic : BaseType
    {
        public string PhaseId { get; set; }

        public Phase Phase { get; set; }

        public IEnumerable<Action> Actions { get; set; }

        public IEnumerable<Condition> Conditions { get; set; }
    }
}