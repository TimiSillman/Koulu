using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nopeus = "";
            Pesukone kone = new Pesukone();
            kone.onOff = true;
            kone.ohjelma = 3;
            kone.lämpötila = 90;
            kone.kosteus = 100;
            switch (kone.ohjelma)
            {
                case 1: nopeus = "hidas"; break;
                case 2: nopeus = "normi"; break;
                case 3: nopeus = "sairaan nopee"; break;
            }
            Console.WriteLine("Päällä?? " + kone.onOff);
            Console.WriteLine("ohjelma?? {0}", nopeus);
            Console.WriteLine("lämpitla?? " + kone.lämpötila);
            Console.WriteLine("kosteus?? " + kone.kosteus);
        }
    }
}
