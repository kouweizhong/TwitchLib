using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Login
{
    public class OAuth
    {
        [JsonProperty(PropertyName = "Status")]
        public int Status { get; protected set; }
        [JsonProperty(PropertyName = "Session")]
        public Session Session { get; protected set; }
        [JsonProperty(PropertyName = "Timestamp")]
        public string Timestamp { get; protected set; }
        [JsonProperty(PropertyName = "MergeToken")]
        public string MergeToken { get; protected set; }
        [JsonProperty(PropertyName = "TwitchUsername")]
        public string TwitchUsername { get; protected set; }
        [JsonProperty(PropertyName = "TwitchDisplayName")]
        public string TwitchDisplayName { get; protected set; }
        [JsonProperty(PropertyName = "TwitchAvatar")]
        public string TwitchAvatar { get; protected set; }
        [JsonProperty(PropertyName = "TwitchUserID")]
        public string TwitchUserId { get; protected set; }
    }
}
