using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 5.19     (Sales Commission Calculator) A large company pays its salespeople on a commission basis. 
 The salespeople receive $200 per week plus 9% of their gross sales for that week. For example, a 
 salesperson who sells $5,000 worth of merchandise in a week receives $200 plus 9% of $5,000, or 
 a total of $650. You’ve been supplied with a list of the items sold by each salesperson. The values of 
 these items are as follows: 

           Item      Value 
           1         239.99 
           2         129.75 
           3           99.95 
           4         350.89 

 Develop a C# app that inputs one salesperson’s items sold for the last week, then calculates and dis- 
 plays that salesperson's earnings. There’s no limit to the number of items that can be sold by a 
 salesperson. 
 */

namespace Chapter_5
    {
    class ch5_19
        {
        static void Main ( string [ ] args )
            {
            Product ( );
            }
        public static void Product ()
            {
            double prod1;
            double prod2;
            double prod3;
            double prod4;
            double comm1;
            double comm2;
            double comm3;
            double comm4;
            double total;


            Console.WriteLine ( "Please enter the amount of Product 1 you have sold last week" );
            prod1 = 239.99 * Convert.ToDouble(Console.ReadLine());
            comm1 = prod1*(0.09);

            Console.WriteLine ( "Please enter the amount of Product 2 you have sold last week" );
            prod2 = 129.75 * Convert.ToDouble(Console.ReadLine());
            comm2 = prod2 * ( 0.09 );

            Console.WriteLine ( "Please enter the amount of Product 3 you have sold last week" );
            prod3 = 99.95 * Convert.ToDouble(Console.ReadLine());
            comm3 = prod3 * ( 0.09 );

            Console.WriteLine ( "Please enter the amount of Product 4 you have sold last week" );
            prod4 = 350.89 * Convert.ToDouble(Console.ReadLine());
            comm4 = prod4 * (0.09);
            Console.WriteLine ( "Your total sales for Product 1 is {0:c} \t Commission {4:c} \nYour total sales for Product 2 is {1:c}\tCommission {5:c} \nYour total sales for Product 3 is {2:c} \t Commission {6:c} \nYour total sales for Product 4 is {3:c} \tCommission {7:c}", prod1, prod2, prod3, prod4, comm1, comm2, comm3, comm4);
            Console.WriteLine ( "Your pay for this week is {0:c}",comm1+comm2+comm3+comm4+200 );

            }
        }
    }
