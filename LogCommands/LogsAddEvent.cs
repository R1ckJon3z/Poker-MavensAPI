using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  adds a line to the Event Log without performing any other command. Use the Log parameter to append custom text to the entry. Note that this Log parameter is an option with all of the other API commands, also.  </summary>
    public class LogsAddEvent
    {
        /// <summary>  append custom text to event log </summary>
        public string Log { get; set; }
    }
}
