using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain
{
    public class Actor : BaseType
    {
        public IEnumerable<Attribute> Characteristics { get; set; }

        public bool IsPlayer { get; set; }

        public bool IsMirror => MirrorToId != null;

        public string MirrorToId { get; set; }
    }
}
