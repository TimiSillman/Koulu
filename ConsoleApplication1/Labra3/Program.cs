using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labra3
{
    class Program
    {
        static void Main(string[] args)
        {
            testaus();
        }
        static void testaus()
        {
            Kiuas kiuas = new Kiuas();
            kiuas.onOff = true;
            kiuas.lämpötila = 90;
            kiuas.Kosteus = 20;
            Console.WriteLine("Kiuas on päällä: " + kiuas.onOff);
            Console.WriteLine("Kiukaan lämpötila: " + kiuas.lämpötila);
            Console.WriteLine("Kosteus: " + kiuas.Kosteus);

        }
    }
}
