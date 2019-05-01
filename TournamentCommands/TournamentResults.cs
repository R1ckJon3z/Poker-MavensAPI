using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    

    /// <summary>   call without any parameters to retrieve a list of dates and tournament names where a tournament results file was created. Call with a Date parameter in the format of yyyy-mm-dd and a Name parameter to retrieve the contents of a tournament results file.    </summary>
    public class TournamentResults
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  tournament name  </summary>
        public List<string> Name { get; set; }

        /// <summary>  parameter in the format of yyyy-mm-dd  </summary>
        public List<string> Date { get; set; }

    }
}
