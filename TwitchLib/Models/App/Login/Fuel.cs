using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Login
{
    public class Fuel
    {
        [JsonProperty(PropertyName = "AccessToken")]
        public string AccessToken { get; protected set; }
        [JsonProperty(PropertyName = "RefreshToken")]
        public string RefreshToken { get; protected set; }
        [JsonProperty(PropertyName = "Expires")]
        public int Expires { get; protected set; }
        [JsonProperty(PropertyName = "Scopes")]
        public string[] Scopes { get; protected set; }
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; protected set; }
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; protected set; }
        [JsonProperty(PropertyName = "Error")]
        public string Error { get; protected set; }
    }
}
