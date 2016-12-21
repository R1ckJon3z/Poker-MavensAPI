using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieves basic statistics on a running tournament specified by the Name parameter. The tournament number and running time are also included. The Time parameter will be blank if the tournament is not currently running.   </summary>
    public class TournamentStats
    {
        /// <summary>  tournament name  </summary>
        public string Name { get; set; }
    }
}
