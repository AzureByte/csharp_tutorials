using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _10_float
    {
        public static void Main()
        {
            float a = 1234.1234F;
            float b = -3456.7688944567F;

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'float' data type can hold = " + float.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'float' data type can hold = " + float.MaxValue);
            Console.WriteLine();
        }
    }
}
