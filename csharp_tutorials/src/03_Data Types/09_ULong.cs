using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _09_ULong
    {
        public static void Main()
        {
            ulong a = 98776654;

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'ulong' data type can hold = " + ulong.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'ulong' data type can hold = " + ulong.MaxValue);
            Console.WriteLine();
        }
    }
}
