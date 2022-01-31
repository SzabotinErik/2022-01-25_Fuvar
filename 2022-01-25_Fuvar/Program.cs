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
            int bankk = 0;
            int keszp = 0;
            int vitato = 0;
            int ingyen = 0;
            int ismeretlen = 0;
            foreach (var i in fuvarok)
            {
                if (i.fizetesmod == "bankkártya")
                {
                    bankk++;
                }
                else if (i.fizetesmod == "készpénz")
                {
                    keszp++;
                }
                else if (i.fizetesmod == "vitatott")
                {
                    vitato++;
                }
                else if (i.fizetesmod == "ingyenes")
                {
                    ingyen++;
                }
                else
                {
                    ismeretlen++;
                }
            }
            Console.WriteLine($"5.feladat:");
            Console.WriteLine($"\t bankártya: {bankk} fuvar");
            Console.WriteLine($"\t bankártya: {keszp} fuvar");
            Console.WriteLine($"\t bankártya: {vitato} fuvar");
            Console.WriteLine($"\t bankártya: {ingyen} fuvar");
            Console.WriteLine($"\t bankártya: {ismeretlen} fuvar");
            Console.ReadKey();
        }
    }
}
