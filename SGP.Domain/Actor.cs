using System.Collections.Generic;

namespace SGP.Domain
{
    public class Actor : BaseObject
    {
        public IEnumerable<Attribute> Characteristics { get; set; }

        public IEnumerable<Actor> SubActors { get; set; }

        public bool IsPlayer { get; set; }

        public string MirrorToId { get; set; }

        public bool IsTeam { get; set; }

        public bool IsTeamMember { get; set; }

        public string TeamId { get; set; }

        public bool IsMirror => MirrorToId != null;
    }
}
