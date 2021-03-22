using SGP.Domain.Enums;

namespace SGP.Domain
{
    public class Action : BaseObject
    {
        public string MechanicId { get; set; }

        public Mechanic Mechanic { get; set; }

        public ActionType Type { get; set; }

        public Attribute SourceAttribute { get; set; }

        public Attribute TargetAttribute { get; set; }

        public int? NumberInChain { get; set; }

        public bool IsChained => NumberInChain.HasValue;
    }
}
