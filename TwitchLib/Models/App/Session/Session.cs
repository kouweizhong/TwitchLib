using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Session
{
    public class Session
    {
        [JsonProperty(PropertyName = "SessionID")]
        public string SessionID { get; protected set; }
        [JsonProperty(PropertyName = "MachineKey")]
        public string MachineKey { get; protected set; }
        [JsonProperty(PropertyName = "User")]
        public User User { get; protected set; }
        [JsonProperty(PropertyName = "NotificationServiceUrl")]
        public string NotificationServiceUrl { get; protected set; }
    }
}
