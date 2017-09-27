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

            //Console.WriteLine("What day is today?");
            //string userAnswer = Console.ReadLine();

            //if(userAnswer == "Monday")
            //{
            //    Console.WriteLine("Back to work.");
            //}
            //else if(userAnswer == "Friday")
            //{
            //    Console.WriteLine("TGIF!");
            //}
            //else
            //{
            //    Console.WriteLine("Bloop");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge >= 0 && userAge <= 1)
            //{
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if (userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay toddlers!");
            //}
            //else if (userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood.");
            //}
            //else if (userAge >= 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is awkward.");
            //}
            //else if (userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement.");
            //}
            //else
            //{
            //    Console.WriteLine("That's not really your age.");
            //}

            //Console.WriteLine("How many points did you earn?");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("You lose");
            //        break;
            //    case 1:
            //        Console.WriteLine("Needs practice");
            //        break;
            //    case 2:
            //        Console.WriteLine("On target.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Superstar");
            //        break;
            //    case 4:
            //        Console.WriteLine("Overachiever.");
            //        break;
            //    case 5:
            //        Console.WriteLine("You cheated.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid score entered.");
            //        break;
            //}

            //Practice problem


            //Console.WriteLine("How much was the bill?");
            //int dinnerNumber = 4;
            //int dinnerBill = 13;
            //int billTotal = dinnerNumber * dinnerBill;
            //Console.WriteLine(billTotal);

            //Next thing on slide. Replace hard code with user input.

            Console.WriteLine("How much was the bill?");

            Console.WriteLine("How many people were there?");
            int userDinnerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("How much did each dinner cost?");
            int userDinnerBill = int.Parse(Console.ReadLine());

            int userBillTotal = userDinnerNumber * userDinnerBill;
            Console.WriteLine("Your bill total is $" + userBillTotal);

            double newBill;

            if (userBillTotal >= 50)
            {
                newBill = userBillTotal * .9;
                Console.WriteLine("Your discounted total is now $" + newBill);
            }
            else
            {
                newBill = userBillTotal * .95;
                Console.WriteLine("Your discounted total is now $" + newBill);
            }







        }
    }
}
