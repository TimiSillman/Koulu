﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            player pelaaja = new player();
            pelaaja.asetus();
            pelaaja.printData();
        }
    }
}
