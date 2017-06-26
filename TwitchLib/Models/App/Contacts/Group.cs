using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class Group
    {
        [JsonProperty(PropertyName = "GroupTitle")]
        public string GroupTitle { get; protected set; }
        [JsonProperty(PropertyName = "GroupID")]
        public string GroupID { get; protected set; }
        [JsonProperty(PropertyName = "HomeRegionID")]
        public string HomeRegionID { get; protected set; }
        [JsonProperty(PropertyName = "HomeRegionKey")]
        public string HomeRegionKey { get; protected set; }
        [JsonProperty(PropertyName = "ParentGroupID")]
        public string ParentGroupID { get; protected set; }
        [JsonProperty(PropertyName = "RootGroupID")]
        public string RootGroupID { get; protected set; }
        [JsonProperty(PropertyName = "VoiceSessionCode")]
        public string VoiceSessionCode { get; protected set; }
        [JsonProperty(PropertyName = "MessageOfTheDay")]
        public string MessageOfTheDay { get; protected set; }
        [JsonProperty(PropertyName = "GroupType")]
        public int GroupType { get; protected set; }
        [JsonProperty(PropertyName = "GroupSubtype")]
        public int GroupSubType { get; protected set; }
        [JsonProperty(PropertyName = "DisplayOrder")]
        public int DisplayOrder { get; protected set; }
        [JsonProperty(PropertyName = "MetaDataOnly")]
        public bool MetaDataOnly { get; protected set; }
        [JsonProperty(PropertyName = "AllowTemporaryChildGroups")]
        public bool AllowTemporaryChildGroups { get; protected set; }
        [JsonProperty(PropertyName = "ForcePushToTalk")]
        public bool ForcePushToTalk { get; protected set; }
        [JsonProperty(PropertyName = "Status")]
        public int Status { get; protected set; }
        [JsonProperty(PropertyName = "IsDefaultChannel")]
        public bool IsDefaultChannel { get; protected set; }
        [JsonProperty(PropertyName = "Roles")]
        public string Roles { get; protected set; }
        //[JsonProperty(PropertyName = "RolePermissions")]
        //public KeyValuePair<int, int>[] RolePermissions { get; protected set; }
        [JsonProperty(PropertyName = "Membership")]
        public GroupMembership Membership { get; protected set; }
        [JsonProperty(PropertyName = "MemberCount")]
        public int MemberCount { get; protected set; }
        [JsonProperty(PropertyName = "Emotes")]
        public string Emotes { get; protected set; }
        [JsonProperty(PropertyName = "Members")]
        public string Members { get; protected set; }
        [JsonProperty(PropertyName = "Channels")]
        public Channel[] Channels { get; protected set; }
        [JsonProperty(PropertyName = "GroupMode")]
        public int GroupMode { get; protected set; }
        [JsonProperty(PropertyName = "IsPublic")]
        public bool IsPublic { get; protected set; }
        [JsonProperty(PropertyName = "UrlPath")]
        public string UrlPath { get; protected set; }
        [JsonProperty(PropertyName = "UrlHost")]
        public string UrlHost { get; protected set; }
        [JsonProperty(PropertyName = "ChatThrottleEnabled")]
        public bool ChatThrottleEnabled { get; protected set; }
        [JsonProperty(PropertyName = "ChatThrottledSeconds")]
        public int ChatThrottledSeconds { get; protected set; }
        [JsonProperty(PropertyName = "IsStreamer")]
        public bool IsStreamer { get; protected set; }
        [JsonProperty(PropertyName = "LinkedCommunities")]
        public string LinkedCommunities { get; protected set; }
        [JsonProperty(PropertyName = "AfkTimerMins")]
        public int AfkTimerMins { get; protected set; }
        [JsonProperty(PropertyName = "AvatarTimestamp")]
        public string AvatarTimestamp { get; protected set; }
        [JsonProperty(PropertyName = "FlaggedAsInappropriate")]
        public bool FlaggedAsInappropriate { get; protected set; }
        [JsonProperty(PropertyName = "MembersOnline")]
        public int MembersOnline { get; protected set; }
        [JsonProperty(PropertyName = "HideNoAccess")]
        public bool HideNoAccess { get; protected set; }
        [JsonProperty(PropertyName = "HideCallMembersNoAccess")]
        public bool HideCallMembersNoAccess { get; protected set; }
        [JsonProperty(PropertyName = "LinkedGuilds")]
        public string LinkedGuilds { get; protected set; }
        [JsonProperty(PropertyName = "ExternalChannelID")]
        public string ExternalChannelID { get; protected set; }
    }
}
