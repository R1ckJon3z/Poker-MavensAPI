using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   opens a ring game table in the player client for the specified player (who must already be logged in). Specify the ring game by the Name parameter and the player by the Player parameter.  </summary>
    public class RingGamesOpen
    {

        /// <summary>  get teh JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }

        /// <summary>  name of player  </summary>
        public string Player { get; set; }
    }
}
