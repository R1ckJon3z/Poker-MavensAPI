using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   resumes a paused tournament specified by the Name parameter.   </summary>
    public class TournamentsResume
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        // <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  tournament name  </summary>
        public string Name { get; set; }
    }
}
