using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   puts the tournament specified by the Name parameter into an online state, making it available for play.   </summary>
    public class TournamentsOnline
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        // <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  name of the tournament  </summary>
        public string Name { get; set; }
    }
}
