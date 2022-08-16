using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class HidroloskaPos: MerlilnaPos
    {
        public string Znamka { get; set; }
        public string serijska { get; set; }
        public string kraj { get; set; }
        public string merilnomesto { get; set; }
        public enum Tip
        {
            Reka,
            Jezero,
            Morje
        }
        public Tip tip { get; set; }
        public HidroloskaMer hidroloska { get; set; }
    }
}
