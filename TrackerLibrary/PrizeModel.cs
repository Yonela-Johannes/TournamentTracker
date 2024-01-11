using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents at which place the team placement that won the tournament
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents a place name for winning teams placements
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount for winning teams placements
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage for winning teams placements
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
