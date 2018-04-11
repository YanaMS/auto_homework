using System;

namespace Constructor
{
    public class Calculate
    {
        public void IncreaceRefType(Value a)
        {
            a.x = a.x + 1;
        }

        public void PrintRef(Value a)
        {
            Console.WriteLine($"Reference type:{a.x}");
        }

        public void IncreaceValueType(int a)
        {
            a = a + 1;
        }

        public void PrintVal(int a)
        {
            Console.WriteLine($"Value type:{a}");

        }
    }
}
