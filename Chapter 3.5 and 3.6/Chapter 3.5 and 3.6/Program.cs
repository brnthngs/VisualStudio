using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3._5_and_3._6
	{
	class Program
		{
		/*3.5 Write declarations, statements or comments that accomplish each of the following tasks:
a) State that an app will calculate the product of three integers.
b) Declare the variables x, y, z and result to be of type int.
c) Prompt the user to enter the first integer.
d) Read the first integer from the user and store it in the variable x.
e) Prompt the user to enter the second integer.
f) Read the second integer from the user and store it in the variable y.
g) Prompt the user to enter the third integer.
h) Read the third integer from the user and store it in the variable z.
i) Compute the product of the three integers contained in variables x, y and z, and assign
the result to the variable result.
j) Display the message "Product is", followed by the value of the variable result.
3.6 Using the statements you wrote in Exercise 3.5, write a complete app that calculates and
displays the product of three integers.*/

		static void Main ( string [ ] args )// this app will calculate the product of 3 integers
			{
			int x;
			int y;
			int z;
			int result;

			Console.WriteLine ( "Enter the first integer" );//Prompt user for first integer
			x = Convert.ToInt32(Console.ReadLine ( ));
			Console.WriteLine ( "Enter the second integer" );
			y = Convert.ToInt32 ( Console.ReadLine ( ) );
			Console.WriteLine ( "Enter the third integer" );
			z = Convert.ToInt32 ( Console.ReadLine ( ) );
			result = x * y * z;
			Console.WriteLine ( "The Product Is {0}", result );
			}
		}
	}
