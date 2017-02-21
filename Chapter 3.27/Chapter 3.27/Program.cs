using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3._27
	{
	class Program
		/*.27 (Integer Equivalent of a Character) Here’s another peek ahead. In this chapter, you have
learned about integers and the type int. C# can also represent uppercase letters, lowercase letters
and a considerable variety of special symbols. Every character has a corresponding integer representation.
The set of characters a computer uses and the corresponding integer representations for those
characters is called that computer’s character set. You can indicate a character value in an app simply
by enclosing that character in single quotes, as in 'A'.
You can determine the integer equivalent of a character by preceding that character with
(int), as in
(int) 'A'
The keyword int in parentheses is known as a cast operator, and the entire expression is called a
cast expression. (You’ll learn about cast operators in Chapter 5.) The following statement outputs a
character and its integer equivalent:
Console.WriteLine( "The character {0} has the value {1}",
'A', ( ( int ) 'A' ) );
When the preceding statement executes, it displays the character A and the value 65 as part of the
string. See Appendix C for a list of characters and their integer equivalents.
Using statements similar to the one shown earlier in this exercise, write an app that displays
the integer equivalents of some uppercase letters, lowercase letters, digits and special symbols. Display
the integer equivalents of the following: A B C a b c 0 1 2 $ * + / and the space character*/
		{
		static void Main ( string [ ] args )
			{
			Console.WriteLine ( "The character {0} is {1} \n The character {2} is {3}  \n The character {4} is {5}  \n The character {6} is {7}  \n The character {8} is {9}  \n The character {10} is {11}  \n The character {12} is {13}  \n The character {14} is {15}  \n The character {16} is {17}  \n The character {18} is {19}  \n The character {20} is {21}  \n The character {22} is {23}  \n The character {24} is {25}  \n The character {26} is {27}", 'A', ( int ) 'A', 'B', ( int ) 'B', 'C', ( int ) 'C', 'a', ( int ) 'a', 'b', ( int ) 'b', 'c', ( int ) 'c', '0', ( int ) '0', '1', ( int ) '1', '2', ( int ) '2', '$', ( int ) '$', '*', ( int ) '*', '+', ( int ) '+', '/', ( int ) '/', ' ', ( int ) ' ' );// masive code dump, probably a more eloquent way to do this, but 12 in the morning i'm not at my brightest.
			}
		}
	}
