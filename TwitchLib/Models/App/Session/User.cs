using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Session
{
    public class User
    {
        [JsonProperty(PropertyName = "UserID")]
        public string UserID { get; protected set; }
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; protected set; }
        [JsonProperty(PropertyName = "ConnectionStatus")]
        public int ConnectionStatus { get; protected set; }
        [JsonProperty(PropertyName = "CustomStatusMessage")]
        public string CustomStatusMessage { get; protected set; }
        [JsonProperty(PropertyName = "CustomStatusTimestamp")]
        public string CustomStatusTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "FriendCount")]
        public int FriendCount { get; protected set; }
        [JsonProperty(PropertyName = "CurrentGameID")]
        public int CurrentGameID { get; protected set; }
        [JsonProperty(PropertyName = "CurrentGameState")]
        public int CurrentGameState { get; protected set; }
        [JsonProperty(PropertyName = "CurrentGameStatusMessage")]
        public string CurrentGameStatusMessage { get; protected set; }
        [JsonProperty(PropertyName = "CurrentGameTimestamp")]
        public string CurrentGameTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "GroupMessagePushPReference")]
        public int GroupMessagePushPreference { get; protected set; }
        [JsonProperty(PropertyName = "FriendMessagePushPreference")]
        public int FriendMessagePushPreference { get; protected set; }
        [JsonProperty(PropertyName = "FriendRequestPushEnabled")]
        public bool FriendRequestPushEnabled { get; protected set; }
        [JsonProperty(PropertyName = "MentionsPushedEnabled")]
        public string MentionsPushedEnabled { get; protected set; }
        [JsonProperty(PropertyName = "AvatarTimestamp")]
        public string AvatarTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; protected set; }
        [JsonProperty(PropertyName = "WatchingChannel")]
        public WatchingChannel WatchingChannel { get; protected set; }
        [JsonProperty(PropertyName = "IsBroadcasting")]
        public bool IsBroadcasting { get; protected set; }
        [JsonProperty(PropertyName = "BroadcastingGameID")]
        public int BroadcastingGameID { get; protected set; }
        [JsonProperty(PropertyName = "PrivacySettings")]
        public PrivacySettings PrivacySettings { get; protected set; }
        [JsonProperty(PropertyName = "ConfirmedFriendSyncCount")]
        public int ConfirmedFriendSyncCount { get; protected set; }
        [JsonProperty(PropertyName = "DeclinedFriendSyncCount")]
        public int DeclinedFriendSyncCount { get; protected set; }
        [JsonProperty(PropertyName = "IsPartner")]
        public bool IsPartner { get; protected set; }
        [JsonProperty(PropertyName = "HasSeenPartnerUpsell")]
        public bool HasSeenPartnerUpsell { get; protected set; }
    }
}
