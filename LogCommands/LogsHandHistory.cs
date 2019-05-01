using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  call without any parameters to retrieve a list of dates and table names where a hand history file was created.  </summary>
    public class LogsHandHistory
    {
        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  parameter in the format of yyyy-mm-dd  </summary>
        public string Date { get; set; }

        /// <summary>  parameter to retrieve the contents of a hand history file </summary>
        public string Name { get; set; }

        /// <summary>  parameter (indicating the hand number) to retrieve the hand history of a single hand. The Date and Name parameters are not needed when the Hand parameter is used. The server caches the last 100 hands played so the specified hand must still be in the cache or an error will be returned. Although the full hand number can be specified, only the first portion (left of the dash) is required. Use the Hand callback event system to get notified when a new hand is available. </summary>
        public string Hand { get; set; }
    }
}
