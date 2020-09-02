using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    class MarketingFirm
    {
        //Member Variables
        private ISweepstakesManager _manager;


        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = _manager;
        }

        //Member Methods
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            _manager.InsertSweepstakes(sweepstakes);
        }

        public void SelectManager()
        {
            string managerSelection = UserInterface.ManagerType();

            if (managerSelection == "stack")
            {
                _manager = new SweepstakesStackManager();
            }
            else if (managerSelection == "queue")
            {
                _manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }
        }
    }
}
