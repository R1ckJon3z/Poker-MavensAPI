using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieves the list of seated players for the ring game specified by the Name parameter. The Away field shows the number of minutes that a player has been sitting out.  </summary>
    public class RingGamesPlaying
    {

        /// <summary>  get the JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public int Count { get; set; }
        public List<string> Player {get; set;}
        public List<int> Seat {get; set;}
        public List<double> Chips {get; set;}
        public List<double> Net {get; set;}
        public List<int> Away {get; set;}
    }
}
