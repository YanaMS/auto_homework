using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaConstructor variable1 = new PizzaConstructor();
            PizzaConstructor variable2 = new PizzaConstructor();
            PizzaConstructor variable3 = new PizzaConstructor();

            variable1.SetCount(5);
            variable2.GetCount();
            variable3.GetCount();
            Console.ReadLine();
        }
    }
}
