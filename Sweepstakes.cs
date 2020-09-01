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
        private Dictionary<int, Contestant> constestants;
        private string name;

        public string Name;

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
            UI.ContestantLastName();
            contestant.EmailAddress = UI.ContestantEmail();
            UI.ContestantEmail();
            contestant.RegistrationNumber = UI.ContestantRegistrationNumber();
            UI.ContestantRegistrationNumber();
        }
	    public Contestant PickWinner()
        {
            return null;
        }
	    public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
