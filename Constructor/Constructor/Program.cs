using System;

namespace Constructor

{
    class Program
    {
        static void Main(string[] args)
        {
            //int test;
            //int test2;
            //int test3;
            PizzaConstructor.Count = 55;
           // test = PizzaConstructor.Count;
           // test2 = PizzaConstructor.Count;
           // test3 = PizzaConstructor.Count;

            //Console.WriteLine(test2; test3);
           // Console.WriteLine("1st homework 'Constructors'");
            PizzaConstructor margarita = new PizzaConstructor("MARGARITA", 25, "thin", true, "mozarella");
            PizzaConstructor italiano = new PizzaConstructor("ITALIANO", 10);
            PizzaConstructor neapolitana = new PizzaConstructor();
            margarita.PrintResult();
            italiano.PrintResult();
            neapolitana.PrintResult();

           /* Console.WriteLine("***************************************");
            Console.WriteLine("2nd homework 'Value and reference type'");

            Value r = new Value();
            Calculate Ref = new Calculate();
            Ref.IncreaceRefType(r);
            Ref.PrintRef(r);

            int y = 5;
            Calculate val = new Calculate();
            val.IncreaceValueType(y);
            val.PrintVal(y);*/

            Console.ReadLine();
        }
    }
}
