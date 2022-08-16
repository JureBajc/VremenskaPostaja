using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class VremenskaPosataja: MerlilnaPos
    {
        public string Znamka { get; set; }
        public int Serijska { get; set; }
        public string MerilnoMesto { get; set; }
        public double zemS { get; set; }
        public double zemD { get; set; }
        public int visina { get; set; }
        public List<Vremenskamer> seznammeritve {get;set;}
    }
}
