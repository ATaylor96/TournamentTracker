﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Id of the team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the team name.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// Represents the list of team members in this team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
