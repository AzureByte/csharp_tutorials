/*
    This program demonstrates the 'signed byte' data type
*/

using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _03_signed_byte
    {
        public static void Main()
        {
            sbyte sb1 = 103;
            sbyte sb2 = -99;

            Console.WriteLine("value contained in the variable 'sb1' = " + sb1);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'sb2' = " + sb2);
            Console.WriteLine();

            Console.WriteLine("minimum value that an 'sbyte' variable can hold = " + sbyte.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that an 'sbyte' variable can hold = " + sbyte.MaxValue);
            Console.WriteLine();
        }
    }
}
