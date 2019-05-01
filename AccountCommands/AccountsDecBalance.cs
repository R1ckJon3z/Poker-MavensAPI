using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{

    /// <summary>  decrements the account balance of a player. This command does not check to see if you have "Allow negative balance" turned on or not in the account settings. An "Amount" parameter is included in the response that specifies the number of chips that were actually subtracted. A "Balance" parameter is returned with the player's new chip balance. This command is safe to use even while the player is logged in and playing. </summary>
   public class AccountsDecBalance
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  player's account name </summary>
        public string Player { get; set; }

       /// <summary>  number of chips to subtract from account </summary>
       public string Amount { get; set; }

       /// <summary>  optional parameter set to "Allow", "Zero", or "Skip". Use Allow (the default) to let the player's balance go below 0. Use Zero to reset the account to 0 if the command results in a negative balance. Use Skip to not subtract any chips if the result would be a negative balance </summary>
       public string Negative { get; set; }

        /// <summary>  number of chips to subtract from account </summary>
        public string Balance { get; set; }


    }
}
