using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialize variable and holds value
            int input = 0;
            
            while (input <= 0)
            {
                //Prompts user for number
                Console.WriteLine("Enter a number:");
                //Converts user input to integer variable and stores in memory
                input = Convert.ToInt32(Console.ReadLine());
                //Nested if statement to prompt user for different number provided (no negatives or 0 allowed) 
                if (input < 0)
                {
                    //Output statement that number is not allowed for calculation
                    Console.WriteLine("Number is invalid. Please input a different number."); 
                }
            }
            //Divides program for better visibility
            Console.WriteLine("");
            //Calls function CalculateFactorial while using the user input
            CalculateFactorial(input);
            //Pauses program to allow user to view before end
            Console.ReadLine();
        }
        public static int CalculateFactorial(int num)
        {
            //Intialize variable and holds value of 1
            int retValue = 1;
            for (int i = 1; i <= num; i++)
            {
                retValue *= i; //Multiplies itself starting at one and continues till it reaches number inputted
            }
            //Outputs the factorial
            Console.WriteLine($"The factorial is {retValue}.");
            return retValue;
        }
    }
}
