﻿using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numerot = new int[7];
            int[] VoittoNumerot = new int[7];
            string j;
            Random rnd = new Random();

            j = (Console.ReadLine());
            for (int x = 0; x < Int32.Parse(j); x++)
            {


                for (int i = 0; i < VoittoNumerot.Length; i++)
                {
                    Numerot[i] = 0;
                }

                for (int i = 0; i < Numerot.Length; i++)
                {
                    Numerot[i] = rnd.Next(1, 41);
                    if (VoittoNumerot.Contains(Numerot[i]))
                    {
                        i--;
                    }
                    else VoittoNumerot[i] = Numerot[i];

                }
                Array.Sort(VoittoNumerot);
                for (int i = 0; i < VoittoNumerot.Length; i++)
                {

                    Console.Write(VoittoNumerot[i] + " ");
                }
                Console.WriteLine();
            }
        }

    }
    
    
}

