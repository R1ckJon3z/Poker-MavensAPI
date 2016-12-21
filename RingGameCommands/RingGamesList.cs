using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PokerMavensAPI
{
    /// <summary>   retrieves the list of all ring games. Calling this with no parameters will just return the number of ring games. Set the Fields parameter to a comma separated list of field names that you want returned. Do not include spaces in the list. You may choose any combination of these fields: Name, Status, Description, Auto, Game, MixedList, PW, Private, PermPlay, PermObserve, PermPlayerChat, PermObserverChat, SuspendChatAllIn, Seats, SmallestChip, BuyInMin, BuyInMax, BuyInDef, RakePercent, RakeCap, TurnClock, TimeBank, BankReset, DisProtect, SmallBlind, BigBlind, AllowStraddle, SmallBet, BigBet, Ante, AnteAll, BringIn, DupeIPs, RatholeMinutes, SitoutMinutes, SitoutRelaxed  </summary>
    public class RingGamesList
    {
        /// <summary>  parameter to a comma separated list of field names that you want returned.  </summary>
        public string Fields { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        
        
        /// <summary>  Used to get Name from JSON reply</summary>
        public List<string> Name { get; set; }

        /// <summary>  Used to get Status from JSON reply</summary>
        public List<string> Status { get; set; }

        /// <summary>  Used to get Description from JSON reply</summary>
        public List<string> Description { get; set; }

        /// <summary>  Used to get Auto from JSON reply</summary>
        public List<string> Auto { get; set; }

        /// <summary>  Used to get Game from JSON reply</summary>
        public List<string> Game { get; set; }

        /// <summary>  Used to get MixedList from JSON reply</summary>
        public List<string> MixedList { get; set; }

        /// <summary>  Used to get PW from JSON reply</summary>
        public List<string> PW { get; set; }

        /// <summary>  Used to get Private from JSON reply</summary>
        public List<string> Private { get; set; }

        /// <summary>  Used to get PermPlay from JSON reply</summary>
        public List<string> PermPlay { get; set; }

        /// <summary>  Used to get PermObserve from JSON reply</summary>
        public List<string> PermObserve { get; set; }

        /// <summary>  Used to get PermPlayerChat from JSON reply</summary>
        public List<string> PermPlayerChat { get; set; }

        /// <summary>  Used to get PermObserverChat from JSON reply</summary>
        public List<string> PermObserverChat { get; set; }

        /// <summary>  Used to get SuspendChatAllIn from JSON reply</summary>
        public List<string> SuspendChatAllIn { get; set; }

        /// <summary>  Used to get Seats from JSON reply</summary>
        public List<string> Seats { get; set; }

        /// <summary>  Used to get SmallestChip from JSON reply</summary>
        public List<string> SmallestChip { get; set; }

        /// <summary>  Used to get BuyInMin from JSON reply</summary>
        public List<string> BuyInMin { get; set; }

        /// <summary>  Used to get BuyInMax from JSON reply</summary>
        public List<string> BuyInMax { get; set; }

        /// <summary>  Used to get BuyInDef from JSON reply</summary>
        public List<string> BuyInDef { get; set; }

        /// <summary>  Used to get RakePercent from JSON reply</summary>
        public List<string> RakePercent { get; set; }

        /// <summary>  Used to get RakeCap from JSON reply</summary>
        public List<string> RakeCap { get; set; }

        /// <summary>  Used to get TurnClock from JSON reply</summary>
        public List<string> TurnClock { get; set; }

        /// <summary>  Used to get TimeBank from JSON reply</summary>
        public List<string> TimeBank { get; set; }

        /// <summary>  Used to get BankReset from JSON reply</summary>
        public List<string> BankReset { get; set; }

        /// <summary>  Used to get DisProtect from JSON reply</summary>
        public List<string> Disprotect { get; set; }

        /// <summary>  Used to get SmallBlind from JSON reply</summary>
        public List<string> SmallBlind { get; set; }

        /// <summary>  Used to get BigBlind from JSON reply</summary>
        public List<string> BigBlind { get; set; }

        /// <summary>  Used to get AllowStraddle from JSON reply</summary>
        public List<string> AllowStraddle { get; set; }

        /// <summary>  Used to get SmallBet from JSON reply</summary>
        public List<string> SmallBet { get; set; }

        /// <summary>  Used to get BigBet from JSON reply</summary>
        public List<string> BigBet { get; set; }

        /// <summary>  Used to get Ante from JSON reply</summary>
        public List<string> Ante { get; set; }

        /// <summary>  Used to get AnteAll from JSON reply</summary>
        public List<string> AnteAll { get; set; }

        /// <summary>  Used to get BringIn from JSON reply</summary>
        public List<string> BringIn { get; set; }

        /// <summary>  Used to get DupeIPs from JSON reply</summary>
        public List<string> DupeIPs { get; set; }

        /// <summary>  Used to get RatholeMinutes from JSON reply</summary>
        public List<string> RatholeMinutes { get; set; }

        /// <summary>  Used to get SitoutMinutes from JSON reply</summary>
        public List<string> SitoutMinutes { get; set; }

        /// <summary>  Used to get SitoutRelaxed from JSON reply</summary>
        public List<string> SitoutRelaxed { get; set; }




    }
}
