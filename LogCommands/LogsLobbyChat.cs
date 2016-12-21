using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  call without any parameters to retrieve a list of dates where a lobby chat log file was created.  </summary>
    public class LogsLobbyChat
    {
        /// <summary>  parameter in the format of yyyy-mm-dd  </summary>
        public string Date { get; set; }
    }
}
