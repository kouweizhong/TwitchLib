using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class GroupMembership
    {
        [JsonProperty(PropertyName = "Nickname")]
        public string Nickname { get; protected set; }
        [JsonProperty(PropertyName = "CanChangeNickname")]
        public bool CanChangeNickname { get; protected set; }
        [JsonProperty(PropertyName = "BestRole")]
        public int BestRole { get; protected set; }
        //[JsonProperty(PropertyName = "Roles")]
        //public KeyValuePair<int, int>[] Roles { get; protected set; }
        [JsonProperty(PropertyName = "DateJoined")]
        public string DateJoined { get; protected set; }
        [JsonProperty(PropertyName = "DateMessaged")]
        public string DateMessaged { get; protected set; }
        [JsonProperty(PropertyName = "DateRead")]
        public string DateRead { get; protected set; }
        [JsonProperty(PropertyName = "DateRemoved")]
        public string DateRemoved { get; protected set; }
        [JsonProperty(PropertyName = "UnreadCount")]
        public int UnreadCount { get; protected set; }
        [JsonProperty(PropertyName = "IsFavorite")]
        public bool IsFavorite { get; protected set; }
        [JsonProperty(PropertyName = "NotificationPreference")]
        public int NotificationPreference { get; protected set; }
        [JsonProperty(PropertyName = "NotificationMuteDate")]
        public string NotificationMuteDate { get; protected set; }
        [JsonProperty(PropertyName = "IsVoiceMuted")]
        public bool IsVoiceMuted { get; protected set; }
        [JsonProperty(PropertyName = "IsVoiceDeafened")]
        public bool IsVoiceDeafened { get; protected set; }
        [JsonProperty(PropertyName = "IsBanned")]
        public bool IsBanned { get; protected set; }
    }
}
