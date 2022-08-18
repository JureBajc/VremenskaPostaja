using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class VremenskaPosataja: MerilnaPos
    {
        public VremenskaPosataja(string znamka, int series, string measurment, double zemS, double zemD, int visina, List<Vremenskamer> seznammeritve)
        {
            Znamka = znamka;
            Series = series;
            Measurment = measurment;
            this.zemS = zemS;
            this.zemD = zemD;
            this.visina = visina;
            this.seznammeritve = seznammeritve;
        }

        public string Znamka { get; set; }
        public int Series { get; set; }
        public string Measurment { get; set; }
        public double zemS { get; set; }
        public double zemD { get; set; }
        public int visina { get; set; }
        public List<Vremenskamer> seznammeritve {get;set;}

        public override double Avg()
        {
            var avg = seznammeritve.Average(obj => obj.temp);
            return avg;
        }

        public override List<Meritev> GetDate()
        {
            return seznammeritve;
        }

        public override List<double> minmax()
        {
            List<double> list = new List<double>();

            var max = seznammeritve.Max(obj => obj.temp);
            var min = seznammeritve.Min(obj => obj.temp);

            list.Add(max);
            list.Add(min);
            return list;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
