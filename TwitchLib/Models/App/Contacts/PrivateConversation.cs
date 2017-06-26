using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class PrivateConversation
    {
        [JsonProperty(PropertyName = "OtherUserID")]
        public string OtherUserID { get; protected set; }
        [JsonProperty(PropertyName = "ConversationID")]
        public string ConversationID { get; protected set; }
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; protected set; }
        [JsonProperty(PropertyName = "DateMessaged")]
        public string DateMessaged { get; protected set; }
        [JsonProperty(PropertyName = "DateRead")]
        public string DateRead { get; protected set; }
        [JsonProperty(PropertyName = "UnreadCount")]
        public int UnreadCount { get; protected set; }
    }
}
