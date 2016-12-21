using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  deletes an item from the blacklist. Specify the item with an ID parameter. </summary>
    public class BlacklistDelete
    {
        /// <summary>  ID of banned player </summary>
        public string ID { get; set; }

    }
}
