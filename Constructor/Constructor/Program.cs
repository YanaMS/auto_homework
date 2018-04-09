using System;

namespace constructors_hm1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st homework 'Constructors'");
            Pizza_constructor margarita = new Pizza_constructor("MARGARITA",25, "thin", true, "mozarella");
            Pizza_constructor italiano = new Pizza_constructor("ITALIANO",10);
            Pizza_constructor neapolitana = new Pizza_constructor();
            margarita.PrintResult();
            italiano.PrintResult();
            neapolitana.PrintResult();

            Console.WriteLine("***************************************");
            Console.WriteLine("2nd homework 'Value and reference type'");
            Value r = new Value();
            Calculate Ref = new Calculate();
            Ref.IncreaceRefType(r);

            Calculate val = new Calculate();
            val.IncreaceValueType(5);

            Console.ReadLine();
        }
    }
}
