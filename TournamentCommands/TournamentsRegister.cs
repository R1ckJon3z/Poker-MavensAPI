using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   puts the tournament specified by the Name parameter into an online state, making it available for play.   </summary>
    public class TournamentsRegister
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  tournament name  </summary>
        public string Name { get; set; }

        /// <summary>  parameter to bypass the system "Allow negative balance" setting  </summary>
        public string Negative { get; set; }

        /// <summary>  name of player  </summary>
        public string Player { get; set; }
    }
}
