using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = 2;
            //int secondNumber = 6;

            //if(firstNumber > secondNumber)
            //{
            //    //Do Something!
            //    Console.WriteLine("You have broken math. Good job.");
            //}
            //else
            //{
            //    //Do something else
            //    Console.WriteLine("All is well with the world.");
            //}

            Console.WriteLine("What day is today?");
            string userAnswer = Console.ReadLine();

            if(userAnswer == "Monday")
            {
                Console.WriteLine("Back to work.");
            }
            else if(userAnswer == "Friday")
            {
                Console.WriteLine("TGIF!");
            }
            else
            {
                Console.WriteLine("Bloop");
            }





        }
    }
}
