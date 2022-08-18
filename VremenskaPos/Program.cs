using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace VremenskaPos
{
    internal class Program
    {
        static public void Main(String[] args)
        {
            List<MerilnaPos> stations = new List<MerilnaPos>();

            List<Vremenskamer> vremenskamers = new List<Vremenskamer>();
            List<HidroloskaMer> hidroloskaMers = new List<HidroloskaMer>();


            HidroloskaMer hidroloskaMer = new HidroloskaMer(DateTime.Now, 32, 482, 76.5);
            HidroloskaMer hidroloskaMer2 = new HidroloskaMer(DateTime.Now, 12, 42, 7.5);
            Vremenskamer vremenskamer = new Vremenskamer(DateTime.Now, 1.2, 2, Vremenskamer.smerVetra.V, 32);


            HidroloskaPos hidro = new HidroloskaPos("banana", "dgfdhf", "Lisbona", "funny", HidroloskaPos.Tip.Morje, hidroloskaMers);
            VremenskaPosataja weather = new VremenskaPosataja("aswd", 123, "assd22", 82.2, 123123123.232, 32, vremenskamers);
            Vremenskamer vremenskamer2 = new Vremenskamer(DateTime.Now, 12.2, 12, Vremenskamer.smerVetra.V, 3);


            vremenskamers.Add(vremenskamer);
            vremenskamers.Add(vremenskamer2);
            hidroloskaMers.Add(hidroloskaMer);
            hidroloskaMers.Add(hidroloskaMer2);


            stations.Add(hidro);
            stations.Add(weather);


            var maxItem = stations.OrderByDescending(obj => obj.minmax()[0]).First();

            var nekaj = stations.Max(obj => obj.minmax()[0]);
            var nakaj2 = stations.Average(obj => obj.Avg());
            
            var nekaj3=stations.Where(obj=>obj.)

            Console.WriteLine(nakaj2);

            Console.Write(maxItem.minmax()[0]);
            Console.WriteLine( hidro.ToString());
            //var maxObj = stations.Where(obj => obj.Z == maxZ);


        }
    }
}
