using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            testaus();
        }
        static void testaus()
        {
            Tv televisio = new Teht3.Tv(42, "LUL", 1900, true);
            Console.WriteLine("tuuma? " + televisio.tuuma);
            Console.WriteLine("vuosi? " + televisio.vuosi);
            Console.WriteLine("malli? " + televisio.malli);
            Console.WriteLine("onko tämä edes päällä? " + televisio.onOff);

        }
    }
}
