using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieve the settings for the ring game specified by the Name parameter.  </summary>
    public class RingGamesGet
    {
        /// <summary>  get the JSON response for Result  </summary>
        public string Result { get; set; }

        /// <summary>  name of ring game  </summary>
        public string Name { get; set; }

        /// <summary>  get the JSON response for Status  </summary>
        public string Status{ get; set; }

        /// <summary>  get the JSON response for Description  </summary>
        public string Description { get; set; }

        /// <summary>  get the JSON response for Auto  </summary>
        public string Auto { get; set; }

        /// <summary>  get the JSON response for Game  </summary>
        public string Game { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string MixedList { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string MixedHands { get; set; }

        /// <summary>  get the JSON response for PW  </summary>
        public string PW { get; set; }

        /// <summary>  get the JSON response for Private  </summary>
        public string Private { get; set; }

        /// <summary>  get the JSON response for PermPlay </summary>
        public string PermPlay { get; set; }

        /// <summary>  get the JSON response for PermObserve  </summary>
        public string PermObserve { get; set; }

        /// <summary>  get the JSON response for PermPlayerChat </summary>
        public string PermPlayerChat { get; set; }

        /// <summary>  get the JSON response for PermObserverChat  </summary>
        public string PermObserverChat { get; set; }

        /// <summary>  get the JSON response for SuspendChatAllIn  </summary>
        public string SuspendChatAllIn { get; set; }

        /// <summary>  get the JSON response for Seats  </summary>
        public string Seats { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string PrimaryCurrency { get; set; }

        /// <summary>  get the JSON response for SmallestChip  </summary>
        public string SmallestChip { get; set; }

        /// <summary>  get the JSON response for BuyInMin  </summary>
        public string BuyInMin { get; set; }

        /// <summary>  get the JSON response for BuyInMax  </summary>
        public string BuyInMax { get; set; }

        /// <summary>  get the JSON response for BuyInDef  </summary>
        public string BuyInDef { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string CapLimit { get; set; }

        /// <summary>  get the JSON response for RakePercent  </summary>
        public string RakePercent { get; set; }

        /// <summary>  get the JSON response for RakeCap  </summary>
        public string RakeCap { get; set; }

        /// <summary>  get the JSON response for TurnClock  </summary>
        public string TurnClock { get; set; }

        /// <summary>  get the JSON response for TurnWarning </summary>
        public string TurnWarning { get; set; }

        /// <summary>  get the JSON response for TimeBank  </summary>
        public string TimeBank { get; set; }

        /// <summary>  get the JSON response for BankSync  </summary>
        public string BankSync { get; set; }

        /// <summary>  get the JSON response for BankReset  </summary>
        public string BankReset { get; set; }

        /// <summary>  get the JSON response for DisProtect  </summary>
        public string DisProtect { get; set; }

        /// <summary>  get the JSON response for SmallBlind  </summary>
        public string SmallBlind { get; set; }

        /// <summary>  get the JSON response for BigBlind  </summary>
        public string BigBlind { get; set; }

        /// <summary>  get the JSON response for AllowStraddle  </summary>
        public string AllowStraddle { get; set; }

        /// <summary>  get the JSON response for SmallBet  </summary>
        public string SmallBet { get; set; }

        /// <summary>  get the JSON response for BigBet  </summary>
        public string BigBet { get; set; }

        /// <summary>  get the JSON response for Ante  </summary>
        public string Ante { get; set; }

        /// <summary>  get the JSON response for AnteAll  </summary>
        public string AnteAll { get; set; }

        /// <summary>  get the JSON response for BringIn  </summary>
        public string BringIn { get; set; }

        /// <summary>  get the JSON response for DupeIPs  </summary>
        public string DupeIPs { get; set; }

        /// <summary>  get the JSON response for RatholeMinutes  </summary>
        public string RatholeMinutes { get; set; }

        /// <summary>  get the JSON response for SitoutMinutes  </summary>
        public string SitoutMinutes { get; set; }

        /// <summary>  get the JSON response for SitoutRelaxed  </summary>
        public string SitoutRelaxed { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string TableGraphic { get; set; }

        /// <summary>  get the JSON response for MixedList  </summary>
        public string Note { get; set; }

    }
}
