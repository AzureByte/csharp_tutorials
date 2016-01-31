using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _08_long
    {
        public static void Main()
        {
            long a = 123456789;

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'long' data type can hold = " + long.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'long' data type can hold = " + long.MaxValue);
            Console.WriteLine();
        }
    }
}
