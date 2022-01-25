using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_01_25_Fuvar
{
    class Fuvar
    {
        public int taxiid { get; set; }
        public string indidő { get; set; }
        public int idotartam { get; set; }
        public double tavolsag { get; set; }
        public double viteldij { get; set; }
        public double Borravalo { get; set; }
        public string fizetesmod { get; set; }

        public Fuvar(string sor)
        {
            string[] t = sor.Split(';');
            taxiid = int.Parse(t[0]);
            indidő = t[1];
            idotartam = int.Parse(t[2]);
            tavolsag = double.Parse(t[3]);
            viteldij = double.Parse(t[4]);
            Borravalo = double.Parse(t[5]);
            fizetesmod = t[6];
        }
    }
}
