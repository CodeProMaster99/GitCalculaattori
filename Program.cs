﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GitCalculaattori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka numero");
            int eka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna toka numero");
            int toka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kumpi tulostetaan: summa vai erotus?");
            string which = Console.ReadLine();
            Console.WriteLine("\n");
            if (which == "summa")
            {
                Console.WriteLine("Summa : " + (eka + toka));
            }
            else if (which == "erotus")
            {
                Console.WriteLine("Erotus : " + (eka - toka));
            }
            else
            {
                Console.WriteLine("Jotain meni pieleen! Kokeile uudelleen");
            }


            Thread.Sleep(3000);


        }
    }
}
