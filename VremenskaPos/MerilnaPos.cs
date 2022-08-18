using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    abstract class MerilnaPos
    {
        public abstract List<double> minmax();
        public abstract double Avg();
        public abstract DateTime GetDate();
    }
}
