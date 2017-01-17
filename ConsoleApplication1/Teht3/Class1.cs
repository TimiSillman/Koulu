using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Tv
    {
        public float tuuma { get; set; }
        public string malli { get; set; }
        public int vuosi { get; set; }
        public bool onOff { get; set; }

        public Tv(float a, string b, int c, bool d)
        {
            tuuma = a;
            malli = b;
            vuosi = c;
            onOff = d;

        }

    
    }
}
