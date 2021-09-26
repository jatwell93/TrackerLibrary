﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of the person 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the surname of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email of the person 
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the mobile of the person 
        /// </summary>
        public string MobileNumber { get; set; }
    }
}
