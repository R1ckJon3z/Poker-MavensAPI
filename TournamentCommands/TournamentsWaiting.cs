using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   manually starts the tournament specified by the Name parameter. There must be at least two players registered to start a tournament.   </summary>
    public class TournamentsWaiting
    {
        /// <summary>  tournament name  </summary>
        public string Name { get; set; }
    }
}
