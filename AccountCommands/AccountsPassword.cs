using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  verifies a player's password. Use a Player parameter to specify a player's name and a PW parameter for the player's password. The password will be hashed by the server and compared to the stored hash. </summary>
    public class AccountsPassword
    {
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  player's password to verify </summary>
        public string PW { get; set; }


    }
}
