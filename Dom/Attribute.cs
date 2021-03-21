using SGP.Domain.Enums;
using System.Collections.Generic;

namespace SGP.Domain
{
    public class Attribute : BaseType
    {
        public ResourceType ResourceType { get; set; }

        public AttributeType Type { get; set; }

        public IList<int> ValueInt { get; set; }

        public IList<string> ValueString { get; set; }

        public IList<bool> ValueBool { get; set; }

        public IList<Attribute> SubAttributres { get; set; }

        public bool IsMultiValued { get; set; }

        public bool IsConstant { get; set; }
    }
}
