using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class Vremenskamer:Meritev
    {
        
        public DateTime casovnizig { get; set; }
        public int temp { get; set; }
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
