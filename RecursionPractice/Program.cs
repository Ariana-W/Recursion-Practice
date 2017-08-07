using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractice
{
    class Program
    {
        //private static double factorial;

        static void Main(string[] args)
        {
           Boolean run = true;

            while (run ==true)
            {
                double userInput;

                double factorial = 0;

                // We want our end value to stop at 1, " 0 > 1" because whe calculating 
                // factorials you start from the chosen number and go down

                //Equation : n * (n-1)
                Console.WriteLine("Please enter a number! Any number!");
                Console.WriteLine();

                userInput = double.Parse(Console.ReadLine());


                for (double i = userInput; i > 0; i--)
                {
                    factorial = userInput * (userInput - 1);  // This is the recursive call 
                }

                    Console.WriteLine($"The factorial of  {userInput} is  {factorial} ");


                 run = Continue();

           }
        }


        //Let's create a Continu method!
        //This will allow us to ask the user whether or not they want to contniue after a certain point. 
        public static Boolean Continue()
        {
            bool run = true ;

            Console.WriteLine("Would you like to continue? Yes or No?");
            string userInput = Console.ReadLine().ToLower().Trim();
      

            //User wants to continue 

            if (userInput == "yes")
            {
                run = true;
            }

            //User does not want to continue 

            if (userInput == "no")
            {
                Console.WriteLine("Thank You for your time!");

                return false;
            }

            if ((userInput != "yes") && (userInput != "no"))
            {
                Console.WriteLine(" I am sorry you entered an invlaid answer. Please try again!");

                run = Continue();
            }

            return run;
        }
        

        
    }


}





/*NOTES : Topic: Recursion  
 * 
 * Recursive solutions call versions of itself! 
 * 
 * With the example above with Factorials!
 * 
 * Factorials call themselves over and over again in order to arrive to a solution
 * 
 * Example: The equation for factorials are n * (n - 1)
 * 
 * (n - 1) represents the recursor (made up word)
 * 
 * It is the part of the function above that is repeatedly being used to over and over again 
 * 
 * until it gains its desired solution! A recursion method has parameters and calls itself with new parameters 


    */