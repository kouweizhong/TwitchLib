using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class Contacts
    {
        [JsonProperty(PropertyName = "Friends")]
        public Friend[] Friends { get; protected set; }
        [JsonProperty(PropertyName = "Groups")]
        public Group[] Groups { get; protected set; }
        [JsonProperty(PropertyName = "PrivateConversations")]
        public PrivateConversation[] PrivateConversations { get; protected set; }
        [JsonProperty(PropertyName = "BlockedUsers")]
        public BlockedUser[] BlockedUsers { get; protected set; }
    }
}
