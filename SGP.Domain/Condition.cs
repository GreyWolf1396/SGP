using SGP.Domain.Enums;

namespace SGP.Domain
{
    public class Condition : BaseType
    {
        public Attribute TargetAttribute { get; set; }

        public Attribute SourceAttribute { get; set; }

        public ConditionType Type { get; set; }
    }
}
