using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves the list of all current connections. Calling this with no parameters will just return the number of connections. Set the Fields parameter to a comma separated list of field names that you want returned. Do not include spaces in the list. You may choose any combination of these fields: SessionID, Status, Player, PC, IP, Connect, Login, LastAction, PacketsIn, PacketsOut  </summary>
    public class ConnectionsList
    {
        /// <summary>  You may choose any combination of these fields: SessionID, Status, Player, PC, IP, Connect, Login, LastAction, PacketsIn, PacketsOut </summary>
        public string Fields { get; set; }
    }
}
