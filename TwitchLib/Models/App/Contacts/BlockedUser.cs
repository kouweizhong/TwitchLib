using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Contacts
{
    public class BlockedUser
    {
        [JsonProperty(PropertyName = "UserID")]
        public string UserID { get; protected set; }
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; protected set; }
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; protected set; }
    }
}
