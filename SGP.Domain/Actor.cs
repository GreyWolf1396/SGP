using System.Collections.Generic;

namespace SGP.Domain
{
    public class Actor : BaseObject
    {
        public IEnumerable<Attribute> Characteristics { get; set; }

        public bool IsPlayer { get; set; }

        public bool IsMirror => MirrorToId != null;

        public string MirrorToId { get; set; }
    }
}
