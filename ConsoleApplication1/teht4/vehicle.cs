using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class vehicle
    {
        public string merkki;
        public int speed;
        public int tyres;

        public void PrintData()
        {
            Console.Write("ominaisuudet: ");
            Console.Write("merkki: {0} renkaat: {1}kpl maksiminopeus: {2}km/h!!!!", merkki, tyres, speed);
        }

        public string ToString()
        {
            string merkkijono;
            merkkijono = merkki + ", " + speed + "km/h, " + tyres + "kpl.";
            return merkkijono;
        }
    }
}
