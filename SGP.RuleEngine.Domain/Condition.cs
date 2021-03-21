namespace SGP.RuleEngine.Domain
{
    public class Condition
    {
        public ConditionOperatorType Operator { get; set; }

        public int TargetValue { get; set; }

        public int CurrentValue { get; set; }
    }
}
