using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    public class SystemStats
    {
        /// <summary>  Used to get Logins from JSON reply</summary>
        public string Logins { get; set; }

        /// <summary>  Used to get FilledSeats from JSON reply</summary>
        public string FilledSeats { get; set; }

        /// <summary>  Used to get OccupiedTables from JSON reply</summary>
        public string OccupiedTables { get; set; }

        /// <summary>  Used to get UpSeconds from JSON reply</summary>
        public string UpSeconds { get; set; }

        /// <summary>  Used to get UpTime from JSON reply</summary>
        public string UpTime { get; set; }

        /// <summary>  Used to get LocalTime from JSON reply</summary>
        public string LocalTime { get; set; }

        /// <summary>  Used to get UTCTime from JSON reply</summary>
        public string UTCTime { get; set; }
    }
}
