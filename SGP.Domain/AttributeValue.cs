using System.Collections.Generic;

namespace SGP.Domain
{
    public class AttributeValue
    {
        public Attribute AttributeType { get; set; }

        public IList<string> ValuesString { get; set; }

        public IList<int> ValuesInt { get; set; }

        public IList<Resource> ValuesResource { get; set; }

        public bool ValueBool { get; set; }

        public IEnumerable<AttributeValue> SubValues { get; set; }
    }
}
