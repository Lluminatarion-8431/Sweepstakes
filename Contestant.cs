using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProj
{
    class Contestant
    {
        //Member Variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //Constructor
        public Contestant(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }

        //Member Methods
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
        public int RegistrationNumber { get { return registrationNumber; } set { registrationNumber = value; } }

    }
}
