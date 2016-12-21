using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   adds a new tournament to the system. The newly created game will be in an offline state.   </summary>
     public class TournamentsAdd
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  a unique name, from 1 to 25 characters  </summary>
        public string Name { get; set; }

        /// <summary>  specify "Limit Hold'em", "Pot Limit Hold'em", "No Limit Hold'em", "Limit Omaha", "Pot Limit Omaha", "No Limit Omaha", "Limit Omaha Hi-Lo", "Pot Limit Omaha Hi-Lo", "No Limit Omaha Hi-Lo", "Limit Razz", "Limit Stud", "Limit Stud Hi-Lo", "Mixed" </summary>
        public string Game { get; set; }

        /// <summary>  if Game is set to "Mixed" then this field must contain a comma-separated list of two or more game types  </summary>
        public string MixedList { get; set; }

        /// <summary>  set to "Yes" for a shootout format or "No" for a standard format  </summary>
        public string Shootout { get; set; }

        /// <summary>  optional tournament description, up to 500 characters  </summary>
        public string Description { get; set; }

        /// <summary>  set to "Yes" or "No" to put game online when server is started  </summary>
        public string Auto { get; set; }

        /// <summary>  (optional) specify a password needed to register  </summary>
        public string PW { get; set; }

        /// <summary>  set to "Yes" to prevent observing without the password or "No" to allow observers  </summary>
        public string Private { get; set; }

        /// <summary>  register permission token, 15 alphanumeric characters max  </summary>
        public string PermRegister { get; set; }

        /// <summary>  unregister permission token, 15 alphanumeric characters max  </summary>
        public string PermUnregister { get; set; }

        /// <summary>  observe permission token, 15 alphanumeric characters max  </summary>
        public string PermObserve { get; set; }

        /// <summary>  player chat permission token, 15 alphanumeric characters max  </summary>
        public string PermPlayerChat { get; set; }

        /// <summary>  observer chat permission token, 15 alphanumeric characters max  </summary>
        public string PermObserverChat { get; set; }

        /// <summary>  either "Yes" or "No"  </summary>
        public string SuspendChatAllIn { get; set; }

        /// <summary>  number of tables, from 1 to 100  </summary>
        public string Tables { get; set; }

        /// <summary>  number of seats per table, from 2 to 10  </summary>
        public string Seats { get; set; }

        /// <summary>  either "Yes" or "No"  </summary>
        public string StartFull { get; set; }

        /// <summary>  number from 0 to 10  </summary>
        public string StartMin { get; set; }

        /// <summary>  number from 0 (disabled) to 999999  </summary>
        public string StartCode { get; set; }

        /// <summary>  yyyy-mm-dd hh:mm format (0000-00-00 00:00 = disabled)  </summary>
        public string StartTime { get; set; }

        /// <summary>  number of minutes, 0 to 999999  </summary>
        public string RegMinutes { get; set; }

        /// <summary>  number of minutes, 0 to 999999  </summary>
        public string LateRegMinutes { get; set; }

        /// <summary>  number from 2 to 1000  </summary>
        public string MinPlayers { get; set; }

        /// <summary>  number from -1 to 999999  </summary>
        public string RecurMinutes { get; set; }

        /// <summary>  number from 0 to 999999  </summary>
        public string NoShowMinutes { get; set; }

        /// <summary>  number of chips  </summary>
        public string BuyIn { get; set; }

        /// <summary>  number of chips  </summary>
        public string EntryFee { get; set; }

        /// <summary>  ticket token  </summary>
        public string Ticket { get; set; }

        /// <summary>  "Yes" or "No"  </summary>
        public string TicketRequired { get; set; }

        /// <summary>  "Yes" or "No"  </summary>
        public string TicketFunded { get; set; }

        /// <summary>  number of chips  </summary>
        public string PrizeBonus { get; set; }

        /// <summary>  set to "Yes", "No", or "Min"  </summary>
        public string MultiplyBonus { get; set; }

        /// <summary>  number of starting chips, from 10 to 25000  </summary>
        public string Chips { get; set; }

        /// <summary>  number of add-on chips, from 0 to 50000  </summary>
        public string AddOnChips { get; set; }

        /// <summary>  number of seconds, from 10 to 120  </summary>
        public string TurnClock { get; set; }

        /// <summary>  number of seconds, from 0 to 600  </summary>
        public string TimeBank { get; set; }

        /// <summary>  number of hands, from 0 to 999999  </summary>
        public string BankReset { get; set; }

        /// <summary>  set to "Yes" or "No" for disconnect protection  </summary>
        public string DisProtect { get; set; }

        /// <summary>  level minutes, from 1 to 1000  </summary>
        public string Level { get; set; }

        /// <summary>  number of levels in rebuy period, 0 to 1000  </summary>
        public string RebuyLevels { get; set; }

        /// <summary>  max chips allowed before rebuy, 0 to 999999  </summary>
        public string Threshold { get; set; }

        /// <summary>  maximum rebuys allowed (-1 = unlimited)  </summary>
        public string MaxRebuys { get; set; }

        /// <summary>  number of chips  </summary>
        public string RebuyCost { get; set; }

        /// <summary>  number of chips  </summary>
        public string RebuyFee { get; set; }

        /// <summary>  number of minutes per rest break, 0 to 60  </summary>
        public string BreakTime { get; set; }

        /// <summary>  number of levels between rest breaks, 0 to 1000  </summary>
        public string BreakLevels { get; set; }

        /// <summary>  either "Yes" or "No"  </summary>
        public string StopOnChop { get; set; }

        /// <summary>  number 1 to 99  </summary>
        public string BringInPercent { get; set; }

        /// <summary>  blind schedule in the format of "SB1/BB1/Ante1, SB2/BB2/Ante2", etc. Leave blank for the default schedule  </summary>
        public string Blinds { get; set; }

        /// <summary>  payout structure in the format of "2-4, 100.00|5-7, 65.00, 35.00|8-10, 50.00, 30.00, 20.00". Leave blank for the default structure  </summary>
        public string Payout { get; set; }

        /// <summary>  optional comma-separated list of ticket tokens  </summary>
        public string PayoutTickets { get; set; }

        /// <summary>  "Yes" or "No", indicates if player should be unregistered if they log out  </summary>
        public string UnregLogout { get; set; }

    }
}
