using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  retrieves a list of player accounts. Calling this with no parameters will just return the number of accounts. Set an optional Players field with a comma separated list (no spaces) of player names. Leave this field blank to retrieve all player accounts. Set the Fields parameter to a comma separated list (no spaces) of field names that you want returned. </summary>
    public class AccountsList
    {

        /// <summary>  get the JSON response for Result </summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Accounts { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }
        
        /// <summary> Set the Fields parameter to a comma separated list (no spaces) of field names that you want returned. You may choose any combination of these fields:Player, Title, Level, RealName, Location, Email, ValCode, Balance, RingChips, RegChips, LastReset, Avatar, AvatarFile, Logins, FirstLogin, LastLogin, Gender, Permissions, ChipsTransfer, ChipsAccept, Chat, ChatColor1, ChatColor2, Custom, Note, SessionID </summary>
        public string Fields { get; set; }

        /// <summary>  Used to get Player from JSON reply</summary>
        public List<string> Player { get; set; }

        /// <summary>  Used to get Title from JSON reply</summary>
        public List<string> Title { get; set; }

        /// <summary>  Used to get RealName from JSON reply</summary>
        public List<string> RealName { get; set; }

        /// <summary>  Used to get Location from JSON reply</summary>
        public List<string> Location { get; set; }

        /// <summary>  Used to get Email from JSON reply</summary>
        public List<string> Email { get; set; }

        /// <summary>  Used to get ValCode from JSON reply</summary>
        public List<string> ValCode { get; set; }

        /// <summary>  Used to get Balance from JSON reply</summary>
        public List<string> Balance { get; set; }

        /// <summary>  Used to get LastReset from JSON reply</summary>
        public List<string> LastReset { get; set; }

        /// <summary>  Used to get Avatar from JSON reply</summary>
        public List<string> Avatar { get; set; }

        /// <summary>  Used to get AvatarFile from JSON reply</summary>
        public List<string> AvatarFile { get; set; }

        /// <summary>  Used to get Logins from JSON reply</summary>
        public List<string> Logins { get; set; }

        /// <summary>  Used to get FirstLogin from JSON reply</summary>
        public List<string> FirstLogin { get; set; }

        /// <summary>  Used to get LastLogin from JSON reply</summary>
        public List<string> LastLogin { get; set; }

        /// <summary>  Used to get Gender from JSON reply</summary>
        public List<string> Gender { get; set; }

        /// <summary>  Used to get Permissions from JSON reply</summary>
        public List<string> Permissions { get; set; }

        /// <summary>  Used to get Tickets from JSON reply</summary>
        public List<string> Tickets { get; set; }

        /// <summary>  Used to get ChipTransfer from JSON reply</summary>
        public List<string> ChipTransfer { get; set; }

        /// <summary>  Used to get ChipsAccept from JSON reply</summary>
        public List<string> ChipsAccept { get; set; }

        /// <summary>  Used to get Chat from JSON reply</summary>
        public List<string> Chat { get; set; }

        /// <summary>  Used to get ChatColor1 from JSON reply</summary>
        public List<string> ChatColor1 { get; set; }

        /// <summary>  Used to get ChatColor2 from JSON reply</summary>
        public List<string> ChatColor2 { get; set; }

        /// <summary>  Used to get Custom from JSON reply</summary>
        public List<string> Custom { get; set; }

        /// <summary>  Used to get Note from JSON reply</summary>
        public List<string> Note { get; set; }

        /// <summary>  Used to get ERake from JSON reply</summary>
        public List<string> ERake { get; set; }

        /// <summary>  Used to get PRake from JSON reply</summary>
        public List<string> PRake { get; set; }

        /// <summary>  Used to get TFees from JSON reply</summary>
        public List<string> TFees { get; set; }

        /// <summary>  Used to get RingChips from JSON reply</summary>
        public List<string> RingChips { get; set; }

        /// <summary>  Used to get SessionID from JSON reply</summary>
        public List<string> SessionID { get; set; }
    }
}
