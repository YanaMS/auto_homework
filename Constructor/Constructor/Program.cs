﻿using System;

namespace constructors_hm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza_constructor margarita = new Pizza_constructor("MARGARITA",25, "thin", true, "mozarella");
            Pizza_constructor italiano = new Pizza_constructor("ITALIANO",10);
            Pizza_constructor neapolitana = new Pizza_constructor();
            margarita.PrintResult();

            italiano.PrintResult();

            neapolitana.PrintResult();
            Console.ReadLine();
        }
    }
}