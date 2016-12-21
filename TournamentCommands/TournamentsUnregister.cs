using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   removes a player specified by the Player parameter from the waiting list of a tournament specified by the Name parameter and refunds their account with the applicable buy-in.   </summary>
    public class TournamentsUnregister
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  tournament name  </summary>
        public string Name { get; set; }

        /// <summary>  name of player  </summary>
        public string Player { get; set; }
    }
}
