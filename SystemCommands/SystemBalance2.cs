using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    public class SystemBalance2
    {

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        /// <summary>  Used to get Master Account from JSON reply</summary>
        public string Master2 { get; set; }

        /// <summary>  Used to get Ring Account from JSON reply</summary>
        public string Ring2 { get; set; }

        /// <summary>  Used to get Rake Account from JSON reply</summary>
        public string Rake2 { get; set; }

        /// <summary>  Used to get Tourney Account from JSON reply</summary>
        public string Tourney2 { get; set; }

        /// <summary>  Used to get EntryFee Account from JSON reply</summary>
        public string EntryFee2 { get; set; }

        /// <summary>  Used to get House Accounts from JSON reply</summary>
        public string House2 { get; set; }

        /// <summary>  Used to get Sum of Player Accounts from JSON reply</summary>
        public string Players2 { get; set; }

    }
}
