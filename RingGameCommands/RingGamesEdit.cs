using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   edits one or more properties of an offline ring game specified by the Name parameter. Fields not specified will retain their current value.  </summary>
    public class RingGamesEdit
    {
        /// <summary>  get the JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result  </summary>
        public string Error { get; set; }

        /// <summary>  a unique name, from 1 to 25 characters  </summary>
        public string Name { get; set; }

        /// <summary>  a unique name, from 1 to 25 characters  </summary>
        public string NewName { get; set; }

        /// <summary>  optional table description, up to 500 characters  </summary>
        public string Description { get; set; }

        /// <summary>  set to "Yes" or "No" to put game online when server is started  </summary>
        public string Auto { get; set; }

        /// <summary>  specify "Limit Hold'em", "Pot Limit Hold'em", "No Limit Hold'em", "Limit Omaha", "Pot Limit Omaha", "No Limit Omaha", "Limit Omaha Hi-Lo", "Pot Limit Omaha Hi-Lo", "No Limit Omaha Hi-Lo", "Limit Razz", "Limit Stud", "Limit Stud Hi-Lo", "Mixed"  </summary>
        public string Game { get; set; }

        /// <summary>  if Game is set to "Mixed" then this field must contain a comma-separated list of two or more game types  </summary>
        public string MixedList { get; set; }

        /// <summary>  (optional) specify a password needed to take a seat </summary>
        public string PW { get; set; }

        /// <summary>  set to "Yes" to prevent observing without the password or "No" to allow observers </summary>
        public string Private { get; set; }

        /// <summary>  play permission token, 15 alphanumeric characters max </summary>
        public string PermPlay { get; set; }

        /// <summary>  observe permission token, 15 alphanumeric characters max </summary>
        public string PermObserve { get; set; }

        /// <summary>  player chat permission token, 15 alphanumeric characters max </summary>
        public string PermPlayerChat { get; set; }

        /// <summary>  observer chat permission token, 15 alphanumeric characters max </summary>
        public string PermObserverChat { get; set; }

        /// <summary>  either "Yes" or "No" </summary>
        public string SuspendChatAllIn { get; set; }

        /// <summary>  number of seats, from 2 to 10 </summary>
        public string Seats { get; set; }

        /// <summary>  0.01, 0.05, 0.25, 1, 5, 25, 100, 500, 1000, 5000, 25000, 100000, 500000, 1000000, 5000000, 25000000, 100000000, 500000000, 1000000000 </summary>
        public string SmallestChip { get; set; }

        /// <summary>  number of chips </summary>
        public string BuyInMin { get; set; }

        /// <summary>  number of chips </summary>
        public string BuyInMax { get; set; }

        /// <summary>  number of chips </summary>
        public string BuyInDef { get; set; }

        /// <summary>  percent number (Pro/Gold feature) </summary>
        public string RakePercent { get; set; }

        /// <summary>  number of chips, or 0 for no cap (Pro/Gold feature) </summary>
        public string RakeCap { get; set; }

        /// <summary>  number of seconds, from 10 to 120 (Pro/Gold feature) </summary>
        public string TurnClock { get; set; }

        /// <summary>  number of seconds, from 0 to 600 </summary>
        public string TimeBank { get; set; }

        /// <summary>  number of hands, from 0 to 999999 </summary>
        public string BankReset { get; set; }

        /// <summary>  set to "Yes" or "No" for disconnect protection </summary>
        public string DisProtect { get; set; }

        /// <summary>  number of chips </summary>
        public string SmallBlind { get; set; }

        /// <summary>  number of chips </summary>
        public string BigBlind { get; set; }

        /// <summary>  "Yes" or "No" </summary>
        public string AllowStraddle { get; set; }

        /// <summary>  number of chips </summary>
        public string SmallBet { get; set; }

        /// <summary>  number of chips </summary>
        public string BigBet { get; set; }

        /// <summary>  number of chips </summary>
        public string Ante { get; set; }

        /// <summary>  "Yes" or "No" </summary>
        public string AnteAll { get; set; }

        /// <summary>  number of chips </summary>
        public string BringIn { get; set; }

        /// <summary>  set to "Yes" or "No" to allow or disallow players with the same IP address at the table </summary>
        public string DupeIPs { get; set; }

        /// <summary>  number of minutes, from 0 to 120 </summary>
        public string RatholeMinutes { get; set; }

        /// <summary>  number of minutes, from 1 to 120 </summary>
        public string SitoutMinutes { get; set; }

        /// <summary>  set to "Yes" or "No" </summary>
        public string SitoutRelaxed { get; set; }
    }
}
