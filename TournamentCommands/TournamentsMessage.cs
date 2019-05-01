using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   sends an Administrator message to the chat box for all tables in the tournament specified by the Name parameter. Put the text of the message in the Message parameter. Use an asterisk (*) as the Name parameter to send the message to all tournaments.   </summary>
    public class TournamentsMessage
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        // <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  name of the tournament  </summary>
        public string Name { get; set; }

        /// <summary>  message to send to tournament  </summary>
        public string Message { get; set; }
    }
}
