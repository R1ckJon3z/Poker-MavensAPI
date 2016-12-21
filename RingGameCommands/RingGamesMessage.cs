using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   sends an Administrator message to the chat box for the ring game specified by the Name parameter. Put the text of the message in the Message parameter. Use an asterisk (*) as the Name parameter to send the message to all ring game tables.  </summary>
    public class RingGamesMessage
    {
        /// <summary>  get the JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result  </summary>
        public string Error { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }

        /// <summary>  text of the message  </summary>
        public string Message { get; set; }
    }
}
