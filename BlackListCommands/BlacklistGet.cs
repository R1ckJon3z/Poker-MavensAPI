using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves the fields for the specified blacklist item, as determined by an ID parameter. </summary>
    public class BlacklistGet
    {
        /// <summary>  ID of banned player </summary>
        public string ID { get; set; }
    }
}
