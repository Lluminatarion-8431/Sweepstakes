using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables
         private Stack<Sweepstakes> stack;

        //Constructor
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        //Memeber Mehtods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            UserInterface.ContestantRegistrationNumber();
            return stack.Pop();
        }

    }
}
