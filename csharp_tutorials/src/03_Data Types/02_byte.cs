/*
    This program demonstrates the 'byte' data type.
*/

using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class byte_data_type
    {
       public static void Main()
        {
            byte b = 129;
            
            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("minimum value that a 'byte' data type can hold = " + byte.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that a 'byte' data type can hold = " + byte.MaxValue);
        }
    }
}
