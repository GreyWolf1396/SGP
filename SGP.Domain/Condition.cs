using SGP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain
{
    public class Condition : BaseType
    {
        public Attribute TargetAttribute { get; set; }

        public Attribute SourceAttribute { get; set; }

        public ConditionType Type { get; set; }
    }
}
