using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class Friend
    {
        [JsonProperty(PropertyName = "Status")]
        public int Status { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserID")]
        public string OtherUserID { get; protected set; }
        [JsonProperty(PropertyName = "OtherUsername")]
        public string OtherUsername { get; protected set; }
        [JsonProperty(PropertyName = "OtherDisplayName")]
        public string OtherDisplayName { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserNickname")]
        public string OtherUserNickname { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserRegionID")]
        public int OtherUserRegionID { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserConnectionStatus")]
        public int OtherUserConnectionStatus { get; protected set; }
        [JsonProperty(PropertyName = "InvitationMessage")]
        public string InvitationMessage { get; protected set; }
        [JsonProperty(PropertyName = "IsFavorite")]
        public bool IsFavorite { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserStatusMessage")]
        public string OtherUserStatusMessage { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserGameID")]
        public string OtherUserGameID { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserGameState")]
        public string OtherUserGameState { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserGameTimestamp")]
        public string OtherUserGameTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserAvatarUrl")]
        public string OtherUserAvatarUrl { get; protected set; }
        [JsonProperty(PropertyName = "DateConfirmed")]
        public string DateConfirmed { get; protected set; }
        [JsonProperty(PropertyName = "DateMessage")]
        public string DateMessage { get; protected set; }
        [JsonProperty(PropertyName = "DateRead")]
        public string DateRead { get; protected set; }
        [JsonProperty(PropertyName = "UnreadCount")]
        public int UnreadCount { get; protected set; }
        [JsonProperty(PropertyName = "MutualFriendCount")]
        public int MutualFriendCount { get; protected set; }
        [JsonProperty(PropertyName = "OtherUserConnectionStatusTimestamp")]
        public string OtherUserConnectionStatusTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "RequestedTimestamp")]
        public string RequestedTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "AvatarTimestamp")]
        public string AvatarTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "Capabilities")]
        public int Capabilities { get; protected set; }
        [JsonProperty(PropertyName = "OtherWatchingChannelID")]
        public string OtherWatchingChannelID { get; protected set; }
        [JsonProperty(PropertyName = "OtherWatchingChannelName")]
        public string OtherWatchingChannelName { get; protected set; }
        [JsonProperty(PropertyName = "OtherWatchingChannelUrl")]
        public string OtherWatchingChannelUrl { get; protected set; }
        [JsonProperty(PropertyName = "OtherBroadcastingGameID")]
        public int OtherBroadcastingGameID { get; protected set; }
        [JsonProperty(PropertyName = "OtherIsBroadcasting")]
        public bool OtherIsBroadcasting { get; protected set; }
    }
}
