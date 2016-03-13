using System;

namespace csharp_tutorials.src._03_Data_Types
{
    class _13_bool
    {
        public static void Main()
        {
            bool a = true; 
            bool b = false;

            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("values that a 'bool' data type can either be = " + bool.TrueString + " or " + bool.FalseString);
            Console.WriteLine();
        }
    }
}
