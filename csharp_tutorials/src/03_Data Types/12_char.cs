using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _12_char
    {
        public static void Main()
        {
            char a = 'z';
            char b = 'n';

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'char' data type can hold = " + char.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'char' data type can hold = " + char.MaxValue);
            Console.WriteLine();
        }
    }
}
