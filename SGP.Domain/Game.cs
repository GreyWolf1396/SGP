using System;
using System.Collections.Generic;
using System.Text;

namespace SGP.Domain
{
    public class Game : BaseType
    {
        IEnumerable<Attribute> GameAttributes { get; set; }

        IEnumerable<Phase> Phases { get; set; }

        IEnumerable<ResourceType> ResourceTypes { get; set; }

        IEnumerable<Actor> Actors { get; set; }
    }
}
