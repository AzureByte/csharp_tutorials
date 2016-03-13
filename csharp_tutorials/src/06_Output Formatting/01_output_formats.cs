using System;

namespace csharp_tutorials.src._06_Output_Formatting
{
    class _01_output_formats
    {
        public static void Main()
        {
            //variant 1.
            Console.WriteLine("a sports car of model " + 239 + " runs at " + 300 + " miles per hour.");

            Console.WriteLine();

            //variant 2.
            Console.WriteLine("value of 20.0 / 7.0 = " + 20.0 / 7.0);

            Console.WriteLine();

            //variant 3.
            Console.WriteLine("value of 20.0 / 7.0 again = {0}", 20.0 / 7.0);

            Console.WriteLine();

            //variant 4.
            Console.WriteLine("value of 20.0 / 7.0 once again = {0:#.###}", 20.0 / 7.0);

            Console.WriteLine();

            //variant 5.
            Console.WriteLine("february has either {0} or {1} days!", 28, 29);

            Console.WriteLine();

            //variant 6.
            Console.WriteLine("february has either {0,4} or {1,3} days !!!", 28, 29);

            Console.WriteLine();
        }
    }
}
