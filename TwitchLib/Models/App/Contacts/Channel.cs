using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class Channel
    {
        [JsonProperty(PropertyName = "GroupTitle")]
        public string GroupTitle { get; protected set; }
        [JsonProperty(PropertyName = "GroupID")]
        public string GroupID { get; protected set; }
        [JsonProperty(PropertyName = "ParentGroupID")]
        public string ParentGroupID { get; protected set; }
        [JsonProperty(PropertyName = "RootGroupID")]
        public string RootGroupID { get; protected set; }
        [JsonProperty(PropertyName = "VoiceSessionCode")]
        public string VoiceSessionCode { get; protected set; }
        [JsonProperty(PropertyName = "MessageOfTheDay")]
        public string MessageOfTheDay { get; protected set; }
        [JsonProperty(PropertyName = "GroupMode")]
        public int GroupMode { get; protected set; }
        [JsonProperty(PropertyName = "GroupType")]
        public int GroupType { get; protected set; }
        [JsonProperty(PropertyName = "GroupStatus")]
        public int GroupStatus { get; protected set; }
        [JsonProperty(PropertyName = "DisplayOrder")]
        public int DisplayOrder { get; protected set; }
        [JsonProperty(PropertyName = "DisplayCategoryID")]
        public string DisplayCategryID { get; protected set; }
        [JsonProperty(PropertyName = "DisplayCategory")]
        public string DisplayCategory { get; protected set; }
        [JsonProperty(PropertyName = "DisplayCategoryRank")]
        public int DisplayCategoryRank { get; protected set; }
        [JsonProperty(PropertyName = "AllowTemporaryChildGroups")]
        public bool AllowTemporaryChildGroups { get; protected set; }
        [JsonProperty(PropertyName = "ForcePushToTalk")]
        public bool ForcePushToTalk { get; protected set; }
        [JsonProperty(PropertyName = "IsDefaultChannel")]
        public bool IsDefaultChannel { get; protected set; }
        //[JsonProperty(PropertyName = "RolePermissions")]
        //public KeyValuePair<int, int>[] RolePermissions { get; protected set; }
        [JsonProperty(PropertyName = "IsPublic")]
        public bool IsPublic { get; protected set; }
        [JsonProperty(PropertyName = "Membership")]
        public ChannelMembership Membership { get; protected set; }
        [JsonProperty(PropertyName = "UrlPath")]
        public string UrlPath { get; protected set; }
        [JsonProperty(PropertyName = "VoiceMembers")]
        public string VoiceMembers { get; protected set; }
        [JsonProperty(PropertyName = "HideNoAccess")]
        public bool HideNoAccess { get; protected set; }
        [JsonProperty(PropertyName = "HideCallMembersNoAccess")]
        public bool HideCallMembersNoAccess { get; protected set; }
        [JsonProperty(PropertyName = "ExternalChannelID")]
        public string ExternalChannelID { get; protected set; }
    }
}
