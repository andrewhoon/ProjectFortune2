using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortune2
{
    class Program
    {
        

        static int Retire(int ageRetire)
        {
            if (ageRetire % 2 == 0)
            {
                int oneAge = ageRetire + 7;
                Console.Write("will retire in " + oneAge + " years");
            }
            else
            {
                int oneAge = ageRetire + 14;
                Console.Write("will retire in " + oneAge + " years");
            }
            return ageRetire;

        }


        static double FinalMoney(int monthBorn)
        {
            //monthBorn
            if (monthBorn <= 0 || monthBorn >= 13)
            {
                double lifeSavings = 0;
                return lifeSavings;

            }
            else if (monthBorn <= 4)
            {
                double lifeSavings = 2000000.23;
                return lifeSavings;
            }
            else if (monthBorn <= 8)
            {
                double lifeSavings = 150000.51;
                return lifeSavings;
            }
            else
            {
                double lifeSavings = 1000000.77;
                return lifeSavings;
            }

            
        }





        static void Main(string[] args)
        {
            //data collection up front.
            Console.WriteLine("Please enter your first name.");
            string firstName = (Console.ReadLine());
            if (firstName.ToUpper() == "QUIT" || firstName.ToUpper() == "Q")
            {
                Environment.Exit(0);
            }
            else if (firstName.ToUpper() == "RESTART")
                {
                Main(args);
                Environment.Exit(0);
                }

            Console.WriteLine("Please enter your last name.");
            string lastName = (Console.ReadLine());
            if (lastName.ToUpper() == "QUIT" || lastName.ToUpper() == "Q")
            {
                Environment.Exit(0);
            }
            else if (lastName.ToUpper() == "RESTART")
            {
                Main(args);
                Environment.Exit(0);
            }


            sayHello(firstName, lastName);


            Console.WriteLine("How old were you on your last birthday?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("In numerical form, what month were you born?");
            int monthBorn = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV Color? Enter \"Help\" if you are unsure what ROYGBIV is.");
            string roygbiv = (Console.ReadLine());
            //Help option
            
            if (roygbiv.ToUpper() == "QUIT" || roygbiv.ToUpper() == "Q")
            {
                Environment.Exit(0);
            }
            else if (roygbiv.ToUpper() == "RESTART")
            {
                Main(args);
                Environment.Exit(0);
            }
            else if (roygbiv.ToUpper() == "HELP")
            {
                Console.WriteLine("R is Red \nO is Orange\nY is Yellow\nG is Green\nB is Blue\nI is Indigo\nV is Violet\nPlease enter your favorite ROYGBIV color.");
                roygbiv = (Console.ReadLine());
                if (roygbiv.ToUpper() == "QUIT" || roygbiv.ToUpper() == "Q")
                {
                    Environment.Exit(0);
                }
                else if (roygbiv.ToUpper() == "RESTART")
                {
                    Main(args);
                    Environment.Exit(0);
                }
            }
            



            Console.WriteLine("Please enter numerically how many siblings you have.");
            int siblings = int.Parse(Console.ReadLine());


            //Beginning of fortune that will be printed.
            Console.Write(firstName + " " + lastName + " ");
            //doing in "write" and not "writeline" in order to just make one total sentence.

            //age even or odd and returning a string to declare amount of years until retirement. Odds and evens are adding a number to their age to determine time.
            Retire(age);

            //using method to take month born and returning a string to declare amount of money at retirement
           Console.Write(" with $" + FinalMoney(monthBorn) + " in the bank, ");

            //using method to return a string from an int for vacation home.
            VacationHome(siblings);

            //using method to return a string from a string for mode of tranport.
            Transportation(roygbiv);

            //fortune judgement.  No parameters needed as I used a random number.
            Judgement();
            
        






          

            



        }

        static void sayHello(string firstName, string lastName)  //Name collecting can be void.
        {

            Console.WriteLine("Greetings, " + firstName + " " + lastName + ". I will tell you your fortune!");
        }


        static void VacationHome (int siblings)  //void because we are not returning a value.
        {
            //number of siblings
            if (siblings <= -1)
            {
                Console.Write("a vacation home near Heinz Field in Pittsburgh and a ");
                
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
            else if (siblings == 0)
            {
                Console.Write("a vacation home in Cleveland and a ");
            }
            

        }
        static void Transportation(string roygbiv)
        {
            
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
                    Console.WriteLine("squeaky shopping cart.");
                    break;

            }

            

        }

        static void Judgement()  //using a random number so the judgement isn't using any data we have entered
        {
            Random ran = new Random();
            int anyNumber = ran.Next(0, 11);
            if (anyNumber <= 3)
            {
                Console.WriteLine("I'll bet you\'ve never heard that fortune before!");
            }
           else if (anyNumber <= 7)
            {
                Console.WriteLine("That fortune is 100% accurate. Take it to the bank!");
            }
            else 
            {
                Console.WriteLine("I'm sorry you received such a vague fortune.");
            }

            
                
        }
    }
}
