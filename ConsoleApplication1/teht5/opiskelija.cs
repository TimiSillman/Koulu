using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class opiskelija
    {
        public string nimi { get; set; }
        public int ika { get; set; }
        public string koulu { get; set; }
        public string tunnus { get; set; }

        public opiskelija(string name, int age, string school, string code)
        {
            nimi = name;
            ika = age;
            koulu = school;
            tunnus = code;
        }
    }
}
