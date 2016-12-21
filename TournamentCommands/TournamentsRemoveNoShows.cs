using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   removes all "no-show" players (never clicked their Ready button) from a running tournament specified by the Name parameter. Their buyin/entry fees are removed from the prizepool and added back to their accounts. No-shows can be removed up to the point of payout distribution.   </summary>
    public class TournamentsRemoveNoShows
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  tournament name  </summary>
        public string Name { get; set; }

    }
}
