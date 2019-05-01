using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   sets the Value of the specified system Property. For example, to turn off the login chime, set the Property parameter to "LoginChime" and the Value parameter to "No". See the SystemGet command above for a list of all available system property names. Properties marked as "read-only" cannot be changed while the game server is online.   </summary>
    public class SystemSet
    {
        /// <summary>  check api docs for all the available properties.  </summary>
        public string Property { get; set; }

        /// <summary>  value for the property  </summary>
        public string Value { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }
    }
}
