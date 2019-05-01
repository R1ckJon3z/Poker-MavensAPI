using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves settings for the account specified by the Player parameter. In additional, a non-blank SessionID will be returned if the player is currently logged in. If they are seated at any ring games, the total amount of chips they have in play will be returned with the RingChips parameter. If they are in the waiting list for any tournaments that have not yet started, the total buy-in and entry fee amounts will be returned with the RegChips parameter. </summary>
    public class AccountsGet
    {
        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  3 to 12 character name (allowed: a to z, A to Z, 0 to 9, underscore and dash) </summary>
        public string Player { get; set; }

        /// <summary>  Used to get AdminProfile from JSON reply</summary>
        public string AdminProfile { get; set; }

        /// <summary>  Used to get Title from JSON reply</summary>
        public string Title { get; set; }

        /// <summary>  Used to get Level from JSON reply</summary>
        public string Level { get; set; }

        /// <summary>  Used to get RealName from JSON reply</summary>
        public string RealName { get; set; }

        /// <summary>  Used to get PW from JSON reply</summary>
        public string PW { get; set; }

        /// <summary>  Used to get Location from JSON reply</summary>
        public string Location { get; set; }

        /// <summary>  Used to get Email from JSON reply</summary>
        public string Email { get; set; }

        /// <summary>  Used to get Valcode from JSON reply</summary>
        public string ValCode { get; set; }

        /// <summary>  Used to get balance from JSON reply</summary>
        public string Balance { get; set; }

        /// <summary>  Used to get balance from JSON reply</summary>
        public string Balance2 { get; set; }

        /// <summary>  Used to get RingChips from JSON reply</summary>
        public string RingChips { get; set; }

        /// <summary>  Used to get RingChips from JSON reply</summary>
        public string RingChips2 { get; set; }

        /// <summary>  Used to get RegChips from JSON reply</summary>
        public string RegChips { get; set; }

        /// <summary>  Used to get RegChips from JSON reply</summary>
        public string RegChips2 { get; set; }

        /// <summary>  Used to get LastReset from JSON reply</summary>
        public string LastReset { get; set; }

        /// <summary>  Used to get LastReset from JSON reply</summary>
        public string LastReset2 { get; set; }

        /// <summary>  Used to get Avatar from JSON reply</summary>
        public string Avatar { get; set; }

        /// <summary>  Used to get AvatarFile from JSON reply</summary>
        public string AvatarFile { get; set; }

        /// <summary>  Used to get Logins from JSON reply</summary>
        public string Logins { get; set; }

        /// <summary>  Used to get FirstLogin from JSON reply</summary>
        public string FirstLogin { get; set; }

        /// <summary>  Used to get LastLogin from JSON reply</summary>
        public string LastLogin { get; set; }

        /// <summary>  Used to get Gender from JSON reply</summary>
        public string Gender { get; set; }

        /// <summary>  Used to get Permissions from JSON reply</summary>
        public string Permissions { get; set; }

        /// <summary>  Used to get Tickets from JSON reply</summary>
        public string Tickets { get; set; }

        /// <summary>  Used to get ChipsTransfer from JSON reply</summary>
        public string ChipsTransfer { get; set; }

        /// <summary>  Used to get ChipsTransfer from JSON reply</summary>
        public string ChipsTransfer2 { get; set; }

        /// <summary>  Used to get ChipsAccept from JSON reply</summary>
        public string ChipsAccept { get; set; }

        /// <summary>  Used to get ChipsAccept from JSON reply</summary>
        public string ChipsAccept2 { get; set; }

        /// <summary>  Used to get Chat from JSON reply</summary>
        public string Chat { get; set; }

        /// <summary>  Used to get ChatColor1 from JSON reply</summary>
        public string ChatColor1 { get; set; }

        /// <summary>  Used to get ChatColor2 from JSON reply</summary>
        public string ChatColor2 { get; set; }

        /// <summary>  Used to get Custom from JSON reply</summary>
        public string Custom { get; set; }

        /// <summary>  Used to get Note from JSON reply</summary>
        public string Note { get; set; }

        /// <summary>  Used to get ERake from JSON reply</summary>
        public string ERake { get; set; }

        /// <summary>  Used to get ERake from JSON reply</summary>
        public string ERake2 { get; set; }

        /// <summary>  Used to get PRake from JSON reply</summary>
        public string PRake { get; set; }

        /// <summary>  Used to get PRake from JSON reply</summary>
        public string PRake2 { get; set; }

        /// <summary>  Used to get TFees from JSON reply</summary>
        public string TFees { get; set; }

        /// <summary>  Used to get TFees from JSON reply</summary>
        public string TFees2 { get; set; }

        /// <summary>  Used to get SesionID from JSON reply</summary>
        public string SessionID { get; set; }
    }
}
