using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    class Sweepstakes
    {
        //Member Variables
        private Dictionary<int, Contestant> contestants;
        private string name;

        public string Name;

        public int winningNumber;
        //Constructor
        public Sweepstakes(string name)
        {
            this.Name = name;
        }

        //Member Methods
	    public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.ContestantFirstName();
            UserInterface.ContestantFirstName();
            contestant.LastName = UserInterface.ContestantLastName();
            UserInterface.ContestantLastName();
            contestant.EmailAddress = UserInterface.ContestantEmail();
            UserInterface.ContestantEmail();
            contestant.RegistrationNumber = UserInterface.ContestantRegistrationNumber();
            UserInterface.ContestantRegistrationNumber();
        }
	    public Contestant PickWinner()
        {
            Random random = new Random();
            winningNumber = random.Next();
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == winningNumber)
                {
                    return contestant.Value;
                }
            }
            return null;
        }
	    public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName + contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }

    }
}
