using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain
{
    public class ResourceType : BaseType
    {
        public Type ValueType { get; set; }

        public int LimitCount { get; set; }

        public IEnumerable<Mechanic> LinkedMechanics { get; set; }
    }
}
