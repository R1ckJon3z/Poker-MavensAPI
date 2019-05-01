using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    public class SystemAccount2
    {
        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }
        /// <summary>  parameter ("Master", "Ring", "Rake", "Tourney", or "EntryFee")  </summary>
        public string Account { get; set; }

        /// <summary>  parameter ("Set", "Inc", or "Dec")  </summary>
        public string Action { get; set; }

        /// <summary>  parameter to set, increment, or decrement the specified account by that amount  </summary>
        public string Amount { get; set; }

        /// <summary>  parameter ("Set", "Inc", or "Dec")  </summary>
        public string Balance { get; set; }

        /// <summary>  parameter to set, increment, or decrement the specified account by that amount  </summary>
        public string Change { get; set; }

    }
}
