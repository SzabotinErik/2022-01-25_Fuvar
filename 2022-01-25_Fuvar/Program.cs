using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2022_01_25_Fuvar
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Fuvar> fuvarok = new List<Fuvar>();
            foreach (var sor in File.ReadAllLines("Fuvar.csv").Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }
            Console.WriteLine($"3.feladat: {fuvarok.Count}");
            double kapot = 0;
            int fordulo = 0;
            foreach (var i in fuvarok)
            {
                if (i.taxiid==6185)
                {
                    kapot = kapot + i.viteldij + i.Borravalo;
                    fordulo++;

                }
            }
            Console.WriteLine($"4.feladat: {fordulo} fuvat alat: {kapot}$");
            Console.ReadKey();
        }
    }
}
