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
        /// <summary>  name of tournament  </summary>
        public string Name { get; set; }
    }
}
