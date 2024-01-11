using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {

        /// <summary>
        /// Represents first name of the player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents player family name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of the player
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the phone/cell number of the player
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}
