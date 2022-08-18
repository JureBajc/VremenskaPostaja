using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaPos
{
    internal class HidroloskaPos: MerilnaPos
    {
        public HidroloskaPos(string znamka, string serijska, string kraj, string merilnomesto, Tip tip, List<HidroloskaMer> hidroloska)
        {
            Znamka = znamka;
            this.serijska = serijska;
            this.kraj = kraj;
            this.measurment = merilnomesto;
            this.tip = tip;
            this.hidroloska = hidroloska;
        }

        public string Znamka { get; set; }
        public string serijska { get; set; }
        public string kraj { get; set; }
        public string measurment { get; set; }
        public enum Tip
        {
            Reka,
            Jezero,
            Morje
        }
        public Tip tip { get; set; }
        public List<HidroloskaMer> hidroloska { get; set; }

        public override List<double> minmax()
        {
            List<double> list = new List<double>();

            var max = hidroloska.Max(obj => obj.pretok);
            var min = hidroloska.Min(obj => obj.pretok);

            list.Add(max);
            list.Add(min);
            return list;
        }
        
        public override string ToString()
        {
            string a;
            a = measurment;
            return a;
        }

        public override double Avg()
        {
            var avg = hidroloska.Average(obj => obj.temp);
            return avg;
        }

        public override DateTime GetDate()
        {
            return hidroloska.casovnizig
        }
    }
}