using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   pauses an online ring game specified by the Name parameter. Set parameter Now to "Yes" (the default) to pause the table immediately or to "No" to pause it once the current hand completes.  </summary>
    public class RingGamesPause
    {
        /// <summary>  get teh JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }

        /// <summary>  parameter to "Yes" to close the table immediately. Otherwise, the table will close when the current hand is finished.  </summary>
        public string Now { get; set; }
    }
}
