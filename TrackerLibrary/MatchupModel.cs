using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents the two teams involved in this match.
        /// </summary>
        public List<MatchupModel> Entries { get; set; } = new List<MatchupModel>();

        /// <summary>
        /// Represents the winner of this match.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round this match occurs on.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
