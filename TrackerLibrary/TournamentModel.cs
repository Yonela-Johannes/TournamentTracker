using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {

        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee to enter tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the count of teams who joined the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the joining prize for every team/player
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the rounds of the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
