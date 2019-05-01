using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   adds a new tournament to the system. The newly created game will be in an offline state.   </summary>  
    public class TournamentsOffline
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
