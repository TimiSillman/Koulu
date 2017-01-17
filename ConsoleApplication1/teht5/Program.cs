using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<opiskelija> lista = new List<opiskelija>();
            lista.Add(new opiskelija("Matti", 2, "JAMK", "k8482"));
            lista.Add(new opiskelija("Antti", 312, "JAMK", "k824"));
            lista.Add(new opiskelija("Juuli", 445, "juu on koulu", "k2848"));
            lista.Add(new opiskelija("Pekka", 9, "asd", "k284"));
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", lista[i].nimi, lista[i].ika, lista[i].koulu, lista[i].tunnus);

            }
        }
    }
}
