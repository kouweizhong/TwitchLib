using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Session
{
    public class PrivacySettings
    {
        [JsonProperty(PropertyName = "PrivateMessagePrivacy")]
        public int PrivateMessagePrivacy { get; protected set; }
        [JsonProperty(PropertyName = "FriendRequestPrivacy")]
        public int FriendRequestPrivacy { get; protected set; }
        [JsonProperty(PropertyName = "ShareActivityPrivacy")]
        public int ShareActivityPrivacy { get; protected set; }
    }
}
