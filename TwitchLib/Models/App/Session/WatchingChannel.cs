using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Session
{
    public class WatchingChannel
    {
        [JsonProperty(PropertyName = "ExternalID")]
        public string ExternalID { get; protected set; }
        [JsonProperty(PropertyName = "Type")]
        public int Type { get; protected set; }
        [JsonProperty(PropertyName = "ExternalName")]
        public string ExternalName { get; protected set; }
        [JsonProperty(PropertyName = "ExternalDisplayName")]
        public string ExternalDisplayName { get; protected set; }
        [JsonProperty(PropertyName = "GameID")]
        public int GameID { get; protected set; }
        [JsonProperty(PropertyName = "ExternalGameName")]
        public string ExternalGameName { get; protected set; }
        [JsonProperty(PropertyName = "ExternalStatus")]
        public string ExternalStatus { get; protected set; }
        [JsonProperty(PropertyName = "ExternalUrl")]
        public string ExternalUrl { get; protected set; }
    }
}
