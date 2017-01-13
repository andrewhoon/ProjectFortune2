using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortune2
{
    class Program
    {
        static void Main(string[] args)
        {
            //data collection up front.
            Console.WriteLine("Please enter your first name.");
            string firstName = (Console.ReadLine());

            Console.WriteLine("Please enter your last name.");
            string lastName = (Console.ReadLine());

            Console.WriteLine("How old were you on your last birthday?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("In numerical form, what month were you born?");
            int monthBorn = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV Color? Enter \"Help\" if you are unsure what ROYGBIV is.");
            string roygbiv = (Console.ReadLine());

            //Help option
            if (roygbiv.ToUpper() == "HELP")
            {
                Console.WriteLine("R is Red \nO is Orange\nY is Yellow\nG is Green\nB is Blue\nI is Indigo\nV is Violet\nPlease enter your favorite ROYGBIV color.");
                roygbiv = (Console.ReadLine());
            }


            Console.WriteLine("Please enter numerically how many siblings you have.");
            int siblings = int.Parse(Console.ReadLine());


            //Beginning of what will be shown.
            Console.Write(firstName + " " + lastName + " ");
            //doing in "write" and not "writeline" in order to just make one total sentence.

            //age even or odd
            if (age % 2 == 0)
            {
                Console.Write("will retire in 25 years");
            }
            else
            {
                Console.Write("will retire in 17 years");
            }



            //monthBorn
            if (monthBorn <= 0 || monthBorn >= 13)
            {
                Console.Write(" with $0.00 in the bank, ");
            }
            else if (monthBorn <= 4)
            {
                Console.Write(" with $2,000,000 in the bank, ");
            }
            else if (monthBorn <= 8)
            {
                Console.Write(" with $150,000 in the bank, ");
            }
            else
            {
                Console.Write(" with $1,000,000,000 in the bank, ");
            }



            //number of siblings
            if (siblings <= -1)
            {
                Console.Write("a horrible vacation home near Heinz Field in Pittsburgh and a ");
            }
            else if (siblings == 1)
            {
                Console.Write("a vacation home in the Outer Banks and a ");
            }
            else if (siblings == 2)
            {
                Console.Write("a vacation home in Fiji and a ");
            }
            else if (siblings == 3)
            {
                Console.Write("a vacation home in Hawai\'i and a ");
            }
            else if (siblings >= 4)
            {
                Console.Write("a vacation home in Key West and a ");
            }



            //favColor for transportation
            switch (roygbiv.ToUpper())
            {
                case "R":
                    Console.WriteLine("boat.");
                    break;
                case "RED":
                    Console.WriteLine("boat.");
                    break;
                case "O":
                    Console.WriteLine("minivan.");
                    break;
                case "ORANGE":
                    Console.WriteLine("minivan.");
                    break;
                case "Y":
                    Console.WriteLine("yacht.");
                    break;
                case "YELLOW":
                    Console.WriteLine("yacht.");
                    break;
                case "G":
                    Console.WriteLine("private jet.");
                    break;
                case "GREEN":
                    Console.WriteLine("private jet.");
                    break;
                case "B":
                    Console.WriteLine("golf cart.");
                    break;
                case "BLUE":
                    Console.WriteLine("golf cart.");
                    break;
                case "I":
                    Console.WriteLine("motorcycle.");
                    break;
                case "INDIGO":
                    Console.WriteLine("motorcycle.");
                    break;
                case "V":
                    Console.WriteLine("glider.");
                    break;
                case "VIOLET":
                    Console.WriteLine("glider.");
                    break;
                default:
                    Console.WriteLine("blimp.");
                    break;

            }
        }
    }
}
