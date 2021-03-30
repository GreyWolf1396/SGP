using System;
using System.Collections.Generic;
using SGP.GameCreator.Webhost.Models.BaseModels;

namespace SGP.GameCreator.Webhost.Models.PhaseModels
{
    public class PhaseModel : BaseObjectModel
    {
        public int Number { get; set; }

        public string Type { get; set; }

        public bool IsMandatory { get; set; }
    }
}
