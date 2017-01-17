using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class player
    {
        public string etunimi;
        public string sukunimi;
        public string lempinimi;
        public int ika;
        public int voittanut;


        public void asetus()
        {
            Console.WriteLine("etunimi??");
            this.etunimi = Console.ReadLine();
            Console.WriteLine("sukunimi??");
            this.sukunimi = Console.ReadLine();
            Console.WriteLine("lempinimi??");
            this.lempinimi = Console.ReadLine();
            Console.WriteLine("ikä??");
            this.ika = int.Parse(Console.ReadLine());
            Console.WriteLine("voittanu??");
            this.voittanut = int.Parse(Console.ReadLine());

        }
        public void printData()
        {
            Console.WriteLine("henkilö: {0} '{1}' {2} on voittanut {3}e ja hänen ikänsä on {4}", etunimi,lempinimi,sukunimi,voittanut,ika);

        }
    }
}
