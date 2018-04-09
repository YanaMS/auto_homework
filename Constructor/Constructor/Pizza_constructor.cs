using System;

namespace constructors_hm1
{
    public class Pizza_constructor
    {
        private string name;
        private int size;
        private string duff;
        private bool souce;
        private string cheese;

        public Pizza_constructor (string name, int size, string duff, bool souce, string cheese)
        {
            this.name = name;
            this.size = size;
            this.duff = duff;
            this.souce = souce;
            this.cheese = cheese;  
        }

        public Pizza_constructor(string name, int size)
        {
            this.name = name;
            this.size = size;
            duff = "thick";
            souce = true;
            cheese = "feta";
        }

        public Pizza_constructor()
        {
            name = "NEAPOLITANA";
            size = 15;
            duff = "thick";
            souce = false;
            cheese = "parmesan";

        }

        public void PrintResult()
        {
            Console.WriteLine(name);
            Console.WriteLine(size);
            Console.WriteLine(duff);
            Console.WriteLine(souce);
            Console.WriteLine(cheese);
        }
    }
}
