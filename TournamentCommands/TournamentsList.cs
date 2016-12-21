using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   retrieves the list of all tournaments. Calling this with no parameters will just return the number of tournaments. Set the Fields parameter to a comma separated list of field names that you want returned. Do not include spaces in the list. You may choose any combination of these fields: Name, Status, Description, Auto, Game, MixedList, Shootout, PW, Private, PermRegister, PermUnregister, PermObserve, PermPlayerChat, PermObserverChat, SuspendChatAllIn, Tables, Seats, StartFull, StartMin, StartCode, StartTime, RegMinutes, LateRegMinutes, MinPlayers, RecurMinutes, NoShowMinutes, BuyIn, EntryFee, Ticket, TicketRequired, TicketFunded, PrizeBonus, MultiplyBonus, Chips, AddOnChips, TurnClock, TimeBank, BankReset, DisProtect, Level, RebuyLevels, Threshold, MaxRebuys, RebuyCost, RebuyFee, BreakTime, BreakLevels, StopOnChop, BringInPercent, Blinds, Payout, PayoutTickets, UnregLogout   </summary>
    public class TournamentsList
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  parameter to a comma separated list of field names that you want returned  </summary>
        public string Fields { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Name { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Status { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Game { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> MixedList { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Shootout { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Description { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Auto { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PW { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Private { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PermRegister { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PermUnregister { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PermObserve { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PermPlayerChat { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PermObserverChat { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> SuspendChatAllIn { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Tables { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Seats { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> StartFull { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> StartMin { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> StartCode { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> StartTime { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> RegMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> LateRegMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> MinPlayers { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> RecurMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> NoShowMinutes { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BuyIn { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> EntryFee { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Ticket { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> TicketRequired { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> TicketFunded { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PrizeBonus { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> MultiplyBonus { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Chips { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> AddOnChips { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> TurnClock { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> TurnWarning { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> TimeBank { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BankSync { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BankReset { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> DisProtect { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Level { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> RebuyLevels { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Threshold { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> MaxRebuys { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> RebuyCost { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> RebuyFee { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BreakTime { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BreakLevels { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> StopOnChop { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> BringInPercent { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Blinds { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Payout { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> PayoutTickets { get; set; }

        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> UnregLogout { get; set; }
    }
}
