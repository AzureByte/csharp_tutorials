//this program introduces you to variables
using System;

class introduction_to_variables
{
    public static void Main()
    {
        int length; //delcares a variable named 'length'
        int width; //declares another variable named 'width'
        int area; //declares yet another variable named 'area'

        length = 9; //assign a value of 9 to the variable length

        //print the value of variable 'length'
        Console.WriteLine("value of variable length is " + length);

        width = 7; //assign a value of 7 to the variable width

        //print the value of the variable 'width'
        Console.WriteLine("value of variable width is " + width);

        area = length * width; //assign the result of multiplying 'length * width' to variable 'area'

        //print the value of the variable 'area'
        Console.WriteLine("value of variable area is " + area);
    }
}