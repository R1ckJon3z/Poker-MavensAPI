using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   gets the value for the specified Property parameter.   </summary>
    public class SystemGet
    {
        /// <summary>  check api docs for all the available properties.  </summary>
        public string Property { get; set; }

        /// <summary>  Used to get Value from JSON reply</summary>
        public string Value { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }


    }
}
