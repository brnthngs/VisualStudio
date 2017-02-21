using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._24
	{
	class Program
		{
		/*
		 * 3.24 (Odd or Even) Write an app that reads an integer, then determines and displays whether
		 * it’s odd or even. [Hint: Use the remainder operator. An even number is a multiple of 2. Anymultiple
		 * of 2 leaves a remainder of 0 when divided by 2.]
		 */ 
		static void Main ( string [ ] args )
			{
			Console.WriteLine ( "Enter any whole number" );// prompt user for numerical input
			int NewInteger; // create Integer to assign to input
			NewInteger = Convert.ToInt32(Console.ReadLine ( )); // read in number provided

			Console.WriteLine ( "You've entered " + NewInteger ); // Test, print out the integer given

			int TestInt = NewInteger/2; // create new integer TestInt, if TestInt has a remander, it's odd, no remainder, it's even

			if ( NewInteger % 2 == 0 )// test for a remainder
				Console.WriteLine ( "Your number is even" );// if true, number is even
			else Console.WriteLine ( "Your number is odd" );// if not, number must be odd
			Console.ReadLine ( );
			}
		}
	}
