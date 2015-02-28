using System;

namespace csharp_tutorials.src
{
    class for_loop_demo
    {
        public static void Main()
        {
            Console.WriteLine("counting from 1 to 10");

            //start from 1 and count till 10 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("counting..." + i);
            }

            Console.WriteLine("Done counting...");
        }
    }
}
