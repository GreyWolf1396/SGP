using System.Collections.Generic;

namespace SGP.Domain
{
    public class Resource : BaseObject
    {
        public ResourceType ResourceType { get; set; }

        public int? Limit { get; set; }

        public IEnumerable<AttributeValue> Values { get; set; } 
    }
}
