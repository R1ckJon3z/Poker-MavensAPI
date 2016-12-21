using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves values for the connection specified by the SessionID parameter.  </summary>
    public class ConnectionsGet
    {
        /// <summary>  sessionID of the player </summary>
        public string SessionID { get; set; }
    }
}
