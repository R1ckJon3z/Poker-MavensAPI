using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerMavensAPI
{
    /// <summary>   gets the value for the specified Property parameter.   </summary>
    public class SystemGet
    {
        /// <summary>  check api docs for all the available properties.  </summary>
        public string Property { get; set; }

        /// <summary>  Used to get Value from JSON reply</summary>
        public string Value { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Result { get; set; }

        /// <summary>  get the JSON response for Result </summary>
        public string Error { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LicenseKey { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteName { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteDescription { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SitePassword { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteNews { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteNewsShow { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteNewsFAQ { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string DirListing { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SiteEmail { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebSite { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string InternetIP { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AppendPort { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AutoLookup { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string FilePort { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string PacketPort { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LocalIP { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SSL { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SSLKey { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SSLPassword { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SSLCert { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SSLRoot { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxSessions { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxIdleMinutes { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxDisconMinutes { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowDupeIPs { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string DupeIPWhitelist { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowDupePCs { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AutoStart { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LoginChime { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string KeepAlive { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ConnectionSweep { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxFPConnections { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxFPConnectionsIP { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxPPConnections { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string MaxPPConnectionsIP { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BadPasswordMax { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ProxyIPHeader { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ProxyWSS { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SameOriginPolicy { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowRemoteAdmin { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AdminHash { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AdminTimeout { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AdminWhitelist { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AdminPath { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string EnableAPI { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string APIHash { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string APIWhitelist { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string APIPath { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string FormatPrimary { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceStarting { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceNegative { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowBalanceResets { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceReset { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowTransfers { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SecondaryCurrency { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string FormatSecondary { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceStarting2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceNegative2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowBalanceResets2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string BalanceReset2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowTransfers2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPHost { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPPort { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPUserName { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPPassword { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPFrom { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SMTPSecure { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebMinWidth { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebMinHeight { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebHeadHTML { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebTopHTML { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebTopSize { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebBottomHTML { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebBottomSize { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebLeftHTML { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebLeftSize { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebRightHTML { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebRightSize { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string WebFolder { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogSave { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogDays { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogMaxItems { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogError { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogFile { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogResource { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogSystem { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogConnect { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogLogin { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogLogout { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogAccount { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogHouse { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogTable { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogListing { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogRemote { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogAPI { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogAPIExempt { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string HistorySave { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string HistoryChat { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string HistoryDays { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TourneySave { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TourneyDays { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LobbyChatSave { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LobbyChatDays { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TrafficInterval { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string RequireSessionKeys { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string PlayerNameMin { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowUnicodeNames { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowNewAccounts { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowAccountChanges { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowPasswordRecovery { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ValidateEmails { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowDupeEmails { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string CrashRecovery { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string CustomCaption { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string CustomDescription { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string CustomEdit { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string CustomMouseOver { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowDupeTickets { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Language1 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Language2 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Language3 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Language4 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string Language5 { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ClientRemoveAbout { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string SitAndGoTab { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LogoutLink { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatTitle { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TableChat { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LobbyChat { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string LobbyChatPermission { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatFilter { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatEmoticons { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatFloodMax { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatFloodPeriod { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ChatFloodPenalty { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string InviteSeconds { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TourneyStartSeconds { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ShowdownSeconds { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string HandHighlight { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AllowLurkers { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string PlayerProfileURL { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string AutoCheck { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ClientRealNames { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string ClientNetChips { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string StrictLimitCap { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string TicketsMenu { get; set; }

        /// <summary>  Used to get Result from JSON reply</summary>
        public string PermissionsMenu { get; set; }


    }
}
