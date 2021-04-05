using System.Collections.Generic;

namespace SGP.Domain
{
    public class ResourceType : BaseObject
    {
        public IEnumerable<Attribute> Attributes { get; set; }
    }
}
