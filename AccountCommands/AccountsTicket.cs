using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  dd, remove, or query individual tournament tickets for a specified player. Use a Player parameter to specify the account, a Ticket parameter for the ticket token, and an Action parameter set to either "Add", "Remove", or "Query". The Add and Remove actions will return a Result = Ok response if successful. The Query action will return a Yes or No response indicating if the player has the specified ticket </summary>
    public class AccountsTicket
    {
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  name of ticket token </summary>
        public string Ticket { get; set; }

        /// <summary>  action to perform: Add, Remove or Query </summary>
        public string Action { get; set; }
    }
}
