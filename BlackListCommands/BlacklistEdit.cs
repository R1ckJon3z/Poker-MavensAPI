using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  edit one or more fields for a blacklist item, as specified with an ID parameter. Other than the ID, only include parameters for the fields you want to change, otherwise the field will retain its current value </summary>
    public class BlacklistEdit
    {
        /// <summary>  ID of banned player </summary>
        public string ID { get; set; }
        
        /// <summary>  player's account name </summary>
        public string Player { get; set; }

        /// <summary>  optional date in the format of yyyy-mm-dd hh:mm, otherwise the current date will be used </summary>
        public string Date { get; set; }

        /// <summary>  player's IP address </summary>
        public string IP { get; set; }

        /// <summary>  player's computer ID in 8-digit hexadecimal format </summary>
        public string PC { get; set; }

        /// <summary>  this is either "All" or "Any" </summary>
        public string Match { get; set; }

        /// <summary>  optional note </summary>
        public string Note { get; set; }
    }
}
