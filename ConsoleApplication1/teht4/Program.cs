using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            string merkkijono;
            vehicle auto = new vehicle();
            auto.merkki = "pökötti";
            auto.speed = 250;
            auto.tyres = 2;
            merkkijono = auto.ToString();
            Console.WriteLine(merkkijono);
            auto.PrintData();
        }
    }
}
