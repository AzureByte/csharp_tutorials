using System;

namespace csharp_tutorials.src
{
    class _07_UInt
    {
        public static void Main()
        {
            uint a = 3335;
            UInt16 b = 6555;
            UInt32 c = 7675;
            UInt64 d = 9995;
            
            Console.WriteLine("value contained in the variable 'a' = " + a);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'b' = " + b);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'c' = " + c);
            Console.WriteLine();

            Console.WriteLine("value contained in the variable 'd' = " + d);
            Console.WriteLine();

            Console.WriteLine("minimum value that an 'uint' data type can hold = " + uint.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that an 'uint' data type can hold = " + uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("minimum value that an 'uint16' data type can hold = " + UInt16.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that an 'uint16' data type can hold = " + UInt16.MaxValue);
            Console.WriteLine();

            Console.WriteLine("minimum value that an 'uint32' data type can hold = " + UInt32.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that an 'uint32' data type can hold = " + UInt32.MaxValue);
            Console.WriteLine();

            Console.WriteLine("minimum value that an 'uint64' data type can hold = " + UInt64.MinValue);
            Console.WriteLine();

            Console.WriteLine("maximum value that an 'uint64' data type can hold = " + UInt64.MaxValue);
            Console.WriteLine();
        }
    }
}
