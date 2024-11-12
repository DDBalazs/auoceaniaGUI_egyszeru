using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auoceaniaGUI_egyszeru
{
    internal class Orszagok
    {
        private string nev;
        private int terulet;
        private int lakossag;

        public string Nev { get => nev; set => nev = value; }
        public int Terulet { get => terulet; set => terulet = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }
    
    public Orszagok(string sor)
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            terulet = Convert.ToInt32(darabok[1]);
            lakossag = Convert.ToInt32(darabok[2]);

        }
        public double Nepsuruseg()
        {
            return terulet/lakossag;
        }
    }
}
