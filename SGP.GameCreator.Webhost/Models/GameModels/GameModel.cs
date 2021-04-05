using System.Collections.Generic;
using SGP.GameCreator.Webhost.Models.BaseModels;
using SGP.GameCreator.Webhost.Models.PhaseModels;

namespace SGP.GameCreator.Webhost.Models.GameModels
{
    public class GameModel : BaseObjectModel
    {
        public IEnumerable<PhaseModel> Phases { get; set; }
    }
}
