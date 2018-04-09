using System;


namespace constructors_hm1
{
    public class Calculate
    {
        public void IncreaceRefType(Value a)
        {
            Console.WriteLine($"Reference type = {a.b + 1}");
        }
        public void IncreaceValueType(int a)
        {
            Console.WriteLine($"Value type ={a + 1}");
        }
    }
}
