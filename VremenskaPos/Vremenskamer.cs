using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class Vremenskamer
    {
        public Vremenskamer(DateTime casovnizig, double temp, int hitrostV, smerVetra smerVetra, int vlaznost)
        {
            this.casovnizig = casovnizig;
            this.temp = temp;
            this.hitrostV = hitrostV;
            SmerVetra = smerVetra;
            this.vlaznost = vlaznost;
        }

        public DateTime casovnizig { get; set; }
        public double temp { get; set; }
        public int hitrostV { get; set; }
        public enum smerVetra
        {
            SV,
            SZ,
            S,
            Z,
            V,
            JV,
            JZ
        }
        public smerVetra SmerVetra { get; set; }
        public int vlaznost { get; set; }

    }
}
