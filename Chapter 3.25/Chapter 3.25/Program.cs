using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3._25
	{
	class Program
		{
		/*3.25 (Multiples) Write an app that reads two integers, determines whether the first is a multiple of the second and displays the result. [Hint: Use the remainder operator.]*/
		static void Main ( string [ ] args )
			{
			// Explain program and prompt user for first number
			Console.WriteLine ( "This program will read in two integers, and determine if the first is a multiple of the second /n Please enter the first integer:" );
			int Number1; // instanciate first number
			int Number2; // declare second number
			int result; // result to print out
			Number1 = Convert.ToInt32 ( Console.ReadLine ( ) ); // read input from user
			Console.WriteLine ( "You entered {0}", Number1 ); //print out user input
			Console.WriteLine ( "Enter the second number:" ); // prompt user for second input
			Number2 = Convert.ToInt32 ( Console.ReadLine ( ) );// read in second number
			Console.WriteLine ( "You entered {0}", Number2 ); //print out user input

			if ( Number1 % Number2 == 0 ) // check if there is a remainder
				Console.WriteLine ( "{0} is a multiple of {1}", Number1, Number2 );//print out a positive result
			else
				Console.WriteLine ( "{0} is not a multiple of {1}", Number1, Number2 ); // else print out negative result

			}
		}
	}
