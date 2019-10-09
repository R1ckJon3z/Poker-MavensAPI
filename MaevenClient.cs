using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Web;
using System.Threading.Tasks;
namespace PokerMavensAPI {
    public class MaevenClient<T>
    {
        private static readonly HttpClient client = new HttpClient(); 
        public string URL  {get; set;}
        private string Password {get; set;}
        public MaevenClient(string Url, string Password) {
            this.URL = Url;
            this.Password = Password;
        }
        private async Task<string> Request(Dictionary<string, string> Parameters) 
        {
            Parameters.Add("Password", Password);
            Parameters.Add("JSON", "Yes");
            var encodedContent = new FormUrlEncodedContent (Parameters);
            var response = await client.PostAsync (URL, encodedContent).ConfigureAwait (false);
            if (response.StatusCode == HttpStatusCode.OK) {
                // Do something with response. Example get content:
                var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait (false);
                return responseContent;
            }
            else {
                return "Shit be fucked.";
            }
        }
        public T Post(Dictionary<string,string> Parameters) {
            string response = Request(Parameters).Result;
            return JsonConvert.DeserializeObject<T>(response);
        }
    }

}
//A c# class to interface with Maeven Poker software 6.11
