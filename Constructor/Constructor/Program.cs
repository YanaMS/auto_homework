using System;

namespace Constructor

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st homework 'Constructors'");
            PizzaConstructor margarita = new PizzaConstructor("MARGARITA",25, "thin", true, "mozarella");
            PizzaConstructor italiano = new PizzaConstructor("ITALIANO",10);
            PizzaConstructor neapolitana = new PizzaConstructor();
            margarita.PrintResult();
            italiano.PrintResult();
            neapolitana.PrintResult();

            Console.WriteLine("***************************************");
            Console.WriteLine("2nd homework 'Value and reference type'");

            Value r = new Value();
            Calculate Ref = new Calculate();
            Ref.IncreaceRefType(r);
            Ref.PrintRef(r);

            int y = 5;
            Calculate val = new Calculate();
            val.IncreaceValueType(y);
            val.PrintVal(y);

            Console.ReadLine();
        }
    }
}
