using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  creates a random 80-bit session key for a player specified by the Player parameter. The session key serves as a one-time-only password for an automated login. See the Technical Information/Misc topic for instructions on using session keys. </summary>
    public class AccountsSessionKey
    {
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  player's SessionKey from server </summary>
        public string SessionKey { get; set; }
    }
}
