using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  terminates the connection at the specified SessionID parameter.  </summary>
    public class ConnectionsTerminate
    {
        /// <summary>  sessionID of the player </summary>
        public string SessionID { get; set; }
    }
}
