using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  call without any parameters to retrieve a list of dates where an event log file was created.  </summary>
    public class LogsEvent
    {
        /// <summary>  parameter in the format of yyyy-mm-dd to retrieve the contents of an error log file </summary>
        public string Date { get; set; }
    }
}
