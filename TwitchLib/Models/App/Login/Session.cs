using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Login
{
    public class Session
    {
        [JsonProperty(PropertyName = "UserID")]
        public int UserId { get; protected set; }
        [JsonProperty(PropertyName = "Username")]
        public string Username { get; protected set; }
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; protected set; }
        [JsonProperty(PropertyName = "SessionId")]
        public string SessionId { get; protected set; }
        [JsonProperty(PropertyName = "Token")]
        public string Token { get; protected set; }
        [JsonProperty(PropertyName = "EmailAddress")]
        public string EmailAddress { get; protected set; }
        [JsonProperty(PropertyName = "EffectivePremiumStatus")]
        public bool EffectivePremiumStatus { get; protected set; }
        [JsonProperty(PropertyName = "ActualPremiumStatus")]
        public bool ActualPremiumStatus { get; protected set; }
        [JsonProperty(PropertyName = "SubscriptionToken")]
        public string SubscriptionToken { get; protected set; }
        [JsonProperty(PropertyName = "Expires")]
        public string Expires { get; protected set; }
        [JsonProperty(PropertyName = "RenewAfter")]
        public string RenewAfter { get; protected set; }
        [JsonProperty(PropertyName = "IsTemporaryAccount")]
        public bool IsTemporaryAccount { get; protected set; }
        [JsonProperty(PropertyName = "IsMerged")]
        public bool IsMerged { get; protected set; }
        [JsonProperty(PropertyName = "Bans")]
        public int Bans { get; protected set; }
    }
}
