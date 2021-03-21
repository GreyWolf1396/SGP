using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain.Enums
{
    public enum ConditionType
    {
        LessThan,
        LessThanOrEqual,
        Equal,
        NotEqual,
        GreaterThanOrEqual,
        GreaterThan,

        Contains,
        NotContain,
        Any
    }
}
