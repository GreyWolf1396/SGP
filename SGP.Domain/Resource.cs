using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Domain
{
    public class Resource : BaseObject
    {
        public ResourceType ResourceType { get; set; }

        public int? Limit { get; set; }

        public IEnumerable<AttributeValue> Values { get; set; } 
        public IEnumerable<Mechanic> LinkedMechanics { get; set; }
    }
}
