using SGP.Domain.Enums;


namespace SGP.Domain
{
    public class Action : BaseObject
    {
        public string MechanicId { get; set; }

        public Mechanic Mechanic { get; set; }

        public ActionType Type { get; set; }
        
        public Condition PreCondition { get; set; }

        public Attribute SourceAttribute { get; set; }

        public Attribute TargetAttribute { get; set; }

        public bool IsMandatory { get; set; }

        public Attribute OrderingField { get; set; }

        public OrderingDirection OrderingDirection { get; set; }

        public Condition ExecutionConditions { get; set; }

        public QuantityType QuantityType { get; set; }

        public int QuantityConstant { get; set; }

        public Attribute QuantityAttribute { get; set; }
    }
}
