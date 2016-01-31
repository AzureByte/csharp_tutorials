using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _05_UShort
    {
        public static void Main()
        {
            ushort x = 59000;

            Console.WriteLine("value contained in the variable 'x' = " + x);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'ushort' data type can hold = " + ushort.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'ushort' data type can hold = " + ushort.MaxValue);
            Console.WriteLine();
        }
    }
}
