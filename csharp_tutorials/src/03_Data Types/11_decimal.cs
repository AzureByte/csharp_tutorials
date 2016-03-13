using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _11_decimal
    {
        public static void Main()
        {
            decimal a = 1234.1234998756M;
            decimal b = -3456.7688944567M;

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'float' data type can hold = " + decimal.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'float' data type can hold = " + decimal.MaxValue);
            Console.WriteLine();
        }
    }
}
