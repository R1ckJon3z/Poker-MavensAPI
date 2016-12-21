using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieves the list of players in the waiting list for the ring game specified by the Name parameter.   </summary>
    public class RingGamesWaiting
    {

        /// <summary>  get teh JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }
    }
}
