using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieves the list of seated and finished players for the tournament specified by the Name parameter. The tournament number and running time are also included. The Away field shows the number of minutes that a player has been sitting out.   </summary>
    public class TournamentsPlaying
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  name of tournament  </summary>
        public string Name { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Number { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Time { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Count { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Player { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Table { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Seat { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Chips { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Rebuys { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> AddOns { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Rank { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> NoShow { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Away { get; set; }
    }
}
