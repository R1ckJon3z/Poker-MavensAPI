using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   adds a new tournament to the system. The newly created game will be in an offline state.   </summary>
    public class TournamentsGet
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }


        /// <summary>  name of the tournament  </summary>
        public string Name { get; set; }

        /// <summary>  Status of the tournament  </summary>
        public string Status { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Game { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string MixedList { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Shootout { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Description { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Auto { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PW { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Private { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PermRegister { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PermUnregister { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PermObserve { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PermPlayerChat { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PermObserverChat { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string SuspendChatAllIn { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Tables { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Seats { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string StartFull { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string StartMin { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string StartCode { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string StartTime { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string RegMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string LateRegMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string MinPlayers { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string RecurMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string NoShowMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BuyIn { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string EntryFee { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Ticket { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string TicketRequired { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string TicketFunded { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PrizeBonus { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string MultiplyBonus { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Chips { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string AddOnChips { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string TurnClock { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string TurnWarning { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string TimeBank { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BankSync { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BankReset { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string DisProtect { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Level { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string RebuyLevels { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Threshold { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string MaxRebuys { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string RebuyCost { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string RebuyFee { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BreakTime { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BreakLevels { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string StopOnChop { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string BringInPercent { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Blinds { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string Payout { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string PayoutTickets { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public string UnregLogout { get; set; }

    }
}
