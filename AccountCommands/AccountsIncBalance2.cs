using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    public class AccountsIncBalance2
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  number of chips to add to account </summary>
        public string Amount { get; set; }

        /// <summary>  number of chips to add to account </summary>
        public string Balance2 { get; set; }

    }
}
