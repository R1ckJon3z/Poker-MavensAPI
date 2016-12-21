using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  ends a popup message to the person at the specified SessionID parameter with the message text specified in the Message parameter. Use an asterisk (*) as the SessionID to send the message to all connections.  </summary>
    public class ConnectionsMessage
    {
        /// <summary>  sessionID of the player </summary>
        public string SessionID { get; set; }

        /// <summary>  sessionID of the player </summary>
        public string Message { get; set; }
    }
}
