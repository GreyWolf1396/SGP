using SGP.Domain.Enums;
using System.Collections.Generic;

namespace SGP.Domain
{
    public class Condition : BaseObject
    {
        public Attribute TargetAttribute { get; set; }

        public Attribute SourceAttribute { get; set; }

        public ConditionType Type { get; set; }

        public IEnumerable<Condition> SubConditions { get; set; }
    }
}
