using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  deletes the specified account. Player is the only required parameter. </summary>
    public class AccountsDelete
    {
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

    }
}
