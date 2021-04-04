using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of this person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the last name of this person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of this person.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of this person.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
