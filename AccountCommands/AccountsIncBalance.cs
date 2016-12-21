using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  increments the account balance of a player. Use a Player parameter to specify the player's name and an Amount parameter to specify the number of chips to add to the account. A "Balance" parameter is returned in the result indicating the player's new chip balance. This command is safe to use even while the player is logged in and playing. </summary>
     public class AccountsIncBalance
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  number of chips to add to account </summary>
        public string Amount { get; set; }
    }
}
