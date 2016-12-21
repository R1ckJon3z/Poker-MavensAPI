using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   This command allows you to get or change the balance of a house account, specified by the Account parameter ("Master", "Ring", "Rake", "Tourney", or "EntryFee"). Set an Action parameter ("Set", "Inc", or "Dec") along with an Amount parameter to set, increment, or decrement the specified account by that amount. To retrieve the current balance, set Action to "Get" (Amount parameter not used in this case). The result will contain a Balance parameter indicating the new balance and a Change parameter indicating the difference between the previous balance and the new balance.   </summary>
    public class SystemAccount
    {
        /// <summary>  parameter ("Master", "Ring", "Rake", "Tourney", or "EntryFee")  </summary>
        public string Account { get; set; }

        /// <summary>  parameter ("Set", "Inc", or "Dec")  </summary>
        public string Action { get; set; }

        /// <summary>  parameter to set, increment, or decrement the specified account by that amount  </summary>
        public string Amount { get; set; }
    }
}
