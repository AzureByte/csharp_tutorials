//a program that demonstrates the if statement
using System;

namespace csharp_tutorials.src
{
    class if_statement_demo
    {
        public static void Main()
        {
            int a, b, c;

            a = 2;
            b = 3;

            //check if a is less than b
            if (a < b)
                Console.WriteLine("a is less than b");
            else
                Console.WriteLine("a contains the value 3");

            //check if b is equal to a + a
            if (b == a + a)
                Console.WriteLine("b is equal to a");
            else
                Console.WriteLine("b is not equal to a");
        }
    }
}
