using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   opens a tournament table in the player client for the specified player (who must already be logged in). Specify the tournament by the Name parameter, the table number by the Table parameter (defaults to 1), and the player by the Player parameter.   </summary>
    public class TournamentsOpen
    {
        /// <summary>  tournament name  </summary>
        public string Name { get; set; }

        /// <summary>  table number (default is 1)  </summary>
        public string Table { get; set; }

        /// <summary>  name of player  </summary>
        public string Player { get; set; }
    }
}
