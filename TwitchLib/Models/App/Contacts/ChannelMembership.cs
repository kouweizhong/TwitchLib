using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class ChannelMembership
    {
        [JsonProperty(PropertyName = "DateMessaged")]
        public string DateMessaged { get; protected set; }
        [JsonProperty(PropertyName = "DateRead")]
        public string DateRead { get; protected set; }
        [JsonProperty(PropertyName = "UnreadCount")]
        public int UnreadCount { get; protected set; }
        [JsonProperty(PropertyName = "IsFavorite")]
        public bool IsFavorite { get; protected set; }
        [JsonProperty(PropertyName = "NotificationPreference")]
        public int NotificationPreference { get; protected set; }
        [JsonProperty(PropertyName = "NotificationMuteDate")]
        public string NotificationMuteDate { get; protected set; }
    }
}
