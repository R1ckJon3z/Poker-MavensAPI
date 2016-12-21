using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   deletes the ring game specified by the Name parameter. The game must already be in an offline state before it can be deleted.  </summary>
    public class RingGamesDelete
    {
        /// <summary>  get JSON response for the api result  </summary>
        public string Result { get; set; }

        /// <summary>  a unique name, from 1 to 25 characters  </summary>
        public string Name { get; set; }
    }
}
