using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGP.GameCreator.Webhost.Services
{
    public abstract class ServiceBase
    {
        public string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
