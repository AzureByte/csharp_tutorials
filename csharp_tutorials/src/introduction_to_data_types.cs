using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_tutorials.src
{
    class introduction_to_data_types
    {
        public static void Main()
        {
            int number; //declares a variable of type integer 
            double another_number; //decalres another variable of type double ( numbers with a decimal point )

            number = 10; //assign the value 10 to the variable 'number'
            another_number = 10.55; //assign the value 10.55 to the variable 'another_number' 

            //print the values of both the variables
            Console.WriteLine("value of variable 'number' = " + number);
            Console.WriteLine("value of variable 'another_number' = " + another_number);

            string myname; //declare a variable of type 'string'
            char letter; //declare a variable of type 'char'

            myname = "neville"; //assign my name to the variable 'myname'
            letter = 'b'; //assign the letter 'b' to the variable 'char'

            Console.WriteLine("value of variable 'myname' = " + myname);
            Console.WriteLine("value of variable 'letter' = " + letter);
        }
    }
}
