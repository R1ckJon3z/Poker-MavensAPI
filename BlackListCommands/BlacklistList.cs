using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves a list of all blacklist entries. Calling this with no parameters will just return a count of entries. Set the Fields parameter to a comma separated list of field names that you want returned. Do not include spaces in the list. You may choose any combination of these fields: ID, Date, Player, IP, PC, Match, Note</summary>
    public class BlacklistList
    {
        /// <summary>  ID of banned player </summary>
        public string Fields { get; set; }
        
        
    }
}
