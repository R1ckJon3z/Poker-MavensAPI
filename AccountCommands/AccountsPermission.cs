using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  add, remove, or query individual permissions for a specified player. Use a Player parameter to specify the account, a Permission parameter for the permission token, and an Action parameter set to either "Add", "Remove", or "Query". The Add and Remove actions will return a Result = Ok response if successful. The Query action will return a Yes or No response indicating if the player has the specified permission </summary>
   public class AccountsPermission
    {
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  name of permission token </summary>
        public string Permission { get; set; }

        /// <summary>  action to perform: Add, Remove or Query </summary>
        public string Action { get; set; }
    }
}
