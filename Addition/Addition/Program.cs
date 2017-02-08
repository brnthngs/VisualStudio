using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Fig. 3.14: Addition.cs
// Displaying the sum of 2 integers input from the keyboard.
namespace Addition
{
    class Program
    {
    // Main Method begins C# application
        static void Main(string[] args)
        {
            int number1; //declare first number to add
            int number2; // declare second number to add
            int sum; //declare sum of number1 and number2

            Console.Write("Enter first integer: "); //prompt user to read in first number
            number1 = Convert.ToInt32(Console.ReadLine()); // take in variable from user

            Console.Write("Enter second integer: "); //prompt user to read in second number
            number2 = Convert.ToInt32(Console.ReadLine()); //take in second variable from user

            sum = number1 + number2; // add number 1 and number 2

            Console.WriteLine("Sum is {0}", sum); // display sum
        }// end Main
    }// end class Addition
}
