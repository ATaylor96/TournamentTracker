using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number for winning this prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the place title for this price i.e. Runner Up.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the price amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize percentage from the prize pool.
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
