using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   sends a message to the Lobby chat box. Put the text of the message in the Message parameter. Specify a optional Player parameter to send the message from a specific player account (which must exist but does not need to be logged in) or leave blank to send the message from the Administrator.   </summary>
    public class SystemLobbyMessage
    {
        /// <summary>  text of the message  </summary>
        public string Message { get; set; }

        /// <summary>  name of specific player  </summary>
        public string Player { get; set; }
    }
}
