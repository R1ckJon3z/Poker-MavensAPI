using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   resumes a paused ring game specified by the Name parameter.  </summary>
    public class RingGamesResume
    {

        /// <summary>  get teh JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }
    }
}
