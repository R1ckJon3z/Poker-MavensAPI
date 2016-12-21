using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>  change one or more settings in a player account. Player is the only required parameter and cannot be changed itself. Include other parameters only for the items you want to change. Parameters not included will retain their current values. </summary>
    public class AccountsEdit
        {
             /// <summary>  get the JSON response for Result </summary>
             public string Result { get; set; }

            /// <summary>  get the JSON response for Result </summary>
             public string Error { get; set; }

            /// <summary>  3 to 12 character name (allowed: a to z, A to Z, 0 to 9, underscore and dash) </summary>
            public string Player { get; set; }

            /// <summary>  0 to 15 characters </summary>
            public string Title { get; set; }

            /// <summary>  0 to 50 characters </summary>
            public string Level { get; set; }

            /// <summary>  optional real name, up to 25 characters </summary>
            public string RealName { get; set; }

            /// <summary>  player's password </summary>
            public string PW { get; set; }

            /// <summary>  male or female </summary>
            public string Gender { get; set; }

            /// <summary>  1 to 30 character player location </summary>
            public string Location { get; set; }

            /// <summary>  chip balance (avoid setting this parameter when player is logged in) </summary>
            public string Balance { get; set; }

            /// <summary>  date in the format of yyyy-mm-dd hh:mm </summary>
            public string LastReset { get; set; }

            /// <summary>  comma-separated list of permission tokens </summary>
            public string Permissions { get; set; }

            /// <summary>  Yes or No (default is Yes) </summary>
            public string ChipsTransfer { get; set; }

            /// <summary>  Yes or No (default is Yes) </summary>
            public string ChipsAccept { get; set; }

            /// <summary>  date in the format of YYYY-MM-DD HH:MM, representing the date and time when the player's chat privileges are enabled. You may also specify Yes for 0000-00-00 00:00 or No for 9999-99-99 99:99 </summary>
            public string Chat { get; set; }

            /// <summary>  optional seated chat color, #RRGGBB format (Pro/Gold feature) </summary>
            public string ChatColor1 { get; set; }

            /// <summary>  optional observer chat color, #RRGGBB format (Pro/Gold feature) </summary>
            public string ChatColor2 { get; set; }

            /// <summary>  date in the format of yyyy-mm-dd hh:mm </summary>
            public string FirstLogin { get; set; }

            /// <summary>  date in the format of yyyy-mm-dd hh:mm </summary>
            public string LastLogin { get; set; }

            /// <summary>  player's email address, up to 80 characters </summary>
            public string Email { get; set; }

            /// <summary>  optional 8 digit hexadecimal number used for email validation </summary>
            public string ValCode { get; set; }

            /// <summary>  a number from 0 to 64 </summary>
            public string Avatar { get; set; }

            /// <summary>  optional avatar file path (Pro/Gold feature) </summary>
            public string AvatarFile { get; set; }

            /// <summary>  optional custom field </summary>
            public string Custom { get; set; }

            /// <summary>  /// <summary>  optional custom field </summary> </summary>
            public string Note { get; set; }


            /// <summary>  Used to get ERake from JSON reply</summary>
             public string ERake { get; set; }

            /// <summary>  Used to get PRake from JSON reply</summary>
             public string PRake { get; set; }

            /// <summary>  Used to get TFees from JSON reply</summary>
             public string TFees { get; set; }

    }
}
