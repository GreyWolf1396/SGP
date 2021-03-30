using System.Collections.Generic;

namespace SGP.Domain
{
    public class Game : BaseObject
    {
        public IEnumerable<Attribute> GameAttributes { get; set; }

        public IEnumerable<Phase> Phases { get; set; }

        public IEnumerable<ResourceType> ResourceTypes { get; set; }

        public IEnumerable<Resource> Resources { get; set; }

        public IEnumerable<Actor> Actors { get; set; }
    }
}
