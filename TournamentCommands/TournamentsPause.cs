using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   pauses a running tournament specified by the Name parameter. Set parameter Now to "Yes" (the default) to pause all tables immediately or to "No" to pause each table individually once the current hand completes.   </summary>
    public class TournamentsPause
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        // <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  name of tournament  </summary>
        public string Name { get; set; }

        /// <summary>  parameter to "Yes" to close the table immediately. Otherwise, the table will close when the current hand is finished.  </summary>
        public string Now { get; set; }
    }
}
