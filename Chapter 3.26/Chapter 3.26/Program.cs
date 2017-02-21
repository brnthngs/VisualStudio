using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3._26
	{
	class Program
		{
		/* 3.26 (Diameter, Circumference and Area of a Circle) Here’s a peek ahead. 
		 * In this chapter, you have learned about integers and the type int. C# can 
		 * also represent floating-point numbers that contain decimal points, such 
		 * as 3.14159. Write an app that inputs from the user the radius of a 
		 * circle as an integer and displays the circle’s diameter, circumference 
		 * and area using the floating-point value 3.14159 for π. Use the techniques 
		 * shown in Fig. 3.14. [Note: You may also use the predefined constant Math.PI 
		 * for the value of π. This constant is more precise than the value 3.14159. 
		 * Class Math is defined in namespace System]. Use the following formulas 
		 * (r is the radius): 
		 * diameter = 2r 
		 * circumference = 2πr 
		 * area = πr2 
		 * Don’t store each calculation’s result in a variable. 
		 * Rather, specify each calculation as the value to be output in a Console.WriteLine statement. 
		 * The values produced by the circumference and area calculations are floating-point numbers. 
		 * You’ll learn more about floating-point numbers in Chapter 4.
		 */
		static void Main ( string [ ] args )
			{
			float radius; // float radius
			float diameter;// float diameter
			float circumference; // float circumfrence
			float area; // float area


			Console.WriteLine ( "Enter the radius of your circle: " );// prompt user for radius
			radius = Convert.ToInt32 ( Console.ReadLine ( ) );// read input from user
			diameter = 2 * radius; // calc diameter
			circumference = 2 * (float)Math.PI * radius; // calc circumference
			area = (float)Math.Pow((float)Math.PI * radius,2); // calc area
			Console.WriteLine ( " Your radius was {0} \n Your diameter is {1} \n Your circumference is {2} \n Your area is {3}", radius, diameter, circumference, area );// print answers to user

			}
		}
	}
