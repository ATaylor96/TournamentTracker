using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Represents the tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee for this tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of entered teams in this tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of prices that can be won in this tournmanet.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the amount of rounds in this tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
