using SGP.Domain.Enums;
using System.Collections.Generic;

namespace SGP.Domain
{
    public class Attribute : BaseObject
    {
        public ResourceType ResourceType { get; set; }

        public AttributeType Type { get; set; }

        public IList<Attribute> SubAttributres { get; set; }



        public string ParentAttributeId { get; set; }

        public Attribute ParentAttribute { get; set; }

        public bool IsMultiValued { get; set; }

        public bool IsConstant { get; set; }

        public AttributeViewMode ViewMode { get; set; }
    }
}
