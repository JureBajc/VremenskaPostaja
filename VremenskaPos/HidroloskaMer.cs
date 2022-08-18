using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class HidroloskaMer: Meritev
    {
        public HidroloskaMer(DateTime casovnizig, int temp, int vodostaj, double pretok)
        {
            this.casovnizig = casovnizig;
            this.temp = temp;
            this.vodostaj = vodostaj;
            this.pretok = pretok;
        }

        public DateTime casovnizig { get; set; }
        public int temp { get; set; }
        public int vodostaj { get; set; }
        public double pretok { get; set; }
    }
}
