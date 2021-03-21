using System;

namespace SGP.Domain
{
    public abstract class BaseType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
