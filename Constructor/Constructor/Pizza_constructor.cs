using System;

namespace Constructor
{
    public class PizzaConstructor
    {
        public static int Count{ get; set;}
        private string name;
        private int size;
        private string duff;
        private bool souce;
        private string cheese;

        static PizzaConstructor()
        {
            Console.WriteLine("Pizza Constructor");
        }
        public PizzaConstructor (string name, int size, string duff, bool souce, string cheese)
        {
            this.name = name;
            this.size = size;
            this.duff = duff;
            this.souce = souce;
            this.cheese = cheese;  
        }
        public PizzaConstructor(string name, int size)
        {
            this.name = name;
            this.size = size;
            duff = "thick";
            souce = true;
            cheese = "feta";
        }
        public PizzaConstructor()
        {
      
            name = "NEAPOLITANA";
            size = 15;
            duff = "thick";
            souce = false;
            cheese = "parmesan";
        }
        public void PrintResult()
        {
            Console.WriteLine(Count);
            Console.WriteLine(name);
            Console.WriteLine(size);
            Console.WriteLine(duff);
            Console.WriteLine(souce);
            Console.WriteLine(cheese);
        }
    }
}
