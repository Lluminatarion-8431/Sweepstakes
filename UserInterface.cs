using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    public static class UserInterface
    {
        //Member Variables
        public static int contestantNumber;

        //Constructor
        static UserInterface()
        {
            contestantNumber = 0;
        }

        //Member Methods
        public static string ContestantFirstName()
        {
            Console.WriteLine("Enter your first name here: ");
            return Console.ReadLine();
        }

        public static string ContestantLastName()
        {
            Console.WriteLine("Enter your last name here: ");
            return Console.ReadLine();
        }

        public static string ContestantEmail()
        {
            Console.WriteLine("Enter your e-mail address here:");
            return Console.ReadLine();
        }

        public static int ContestantRegistrationNumber()
        {
            contestantNumber = +1;
            Console.WriteLine("Your registration number is " + contestantNumber);
            return contestantNumber;
        }

        public static string ManagerType()
        {
            bool type = false;
            while (!type)
            {
                Console.WriteLine("How would you like to manage the Sweepstakes: stack or queue?");
                string choice = Console.ReadLine();

                if (choice == "stack" || choice == "queue")
                {
                    type = true;
                    return choice;
                }
                else
                {
                    Console.WriteLine("Wrong Input please try again. Type {0}stack{0} or {0}queue{0}.", Convert.ToChar(34));
                    type = false;
                }
            }
            return null;
        }
    }
}
