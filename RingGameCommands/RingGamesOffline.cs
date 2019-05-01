using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   closes the ring game specified by the Name parameter and puts it in an offline state. Set an optional Now parameter to "Yes" to close the table immediately. Otherwise, the table will close when the current hand is finished.  </summary>
    public class RingGamesOffline
    {
        /// <summary>  get teh JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  get teh JSON response for Result  </summary>
        public string Error { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }

        /// <summary>  parameter to "Yes" to close the table immediately. Otherwise, the table will close when the current hand is finished.  </summary>
        public string Now { get; set; }
    }
}
