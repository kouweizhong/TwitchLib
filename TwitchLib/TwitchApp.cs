using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Models.App.Client;
using TwitchLib.Models.App.Login;
using WebSocketSharp;

namespace TwitchLib
{
    public class TwitchApp
    {
        private WebSocket client;
        private OAuth oauth;
        private Fuel fuel;
        private Models.App.Session.Session session;
        private Models.App.Contacts.Contacts contacts;
        
        public TwitchApp() { }

        /// <summary>
        /// Calls two authorization calls to create OAuth and Fuel models which are used to access the rest of the curse service.
        /// </summary>
        /// <param name="code">This code comes from here: https://api.twitch.tv/kraken/oauth2/authorize?action=callback&client_id=jf3xu125ejjjt5cl4osdjci6oz6p93r&redirect_uri=https%3A%2F%2Fweb.curseapp.net%2Flaguna%2Fpassport-callback.html&response_type=code Go there, login, and after being redirected, look at the new URL in the browser and copy the code parameter.</param>
        public async void Connect(string code)
        {
            // login/auth stuffs
            oauth = await Internal.Requests.TwitchApp.Auth(code);
            fuel = await Internal.Requests.TwitchApp.Post<Models.App.Login.Fuel>("https://logins-v1.curseapp.net/login/fuel", oauth.Session.Token);

            // download contacts/servers
            contacts = await Internal.Requests.TwitchApp.Get<Models.App.Contacts.Contacts>("https://contacts-v1.curseapp.net/contacts", oauth.Session.Token);

            // create session
            session = await Internal.Requests.TwitchApp.PostModel<Models.App.Session.Session>("https://sessions-v1.curseapp.net/sessions", oauth.Session.Token, new Models.App.RequestModels.CreateSession());

            // create socket connection for events
            createSocketConnection();
        }






        private void createSocketConnection()
        {
            client = new WebSocket(session.NotificationServiceUrl);
            client.SetCookie(new WebSocketSharp.Net.Cookie("CurseAuthToken", oauth.Session.Token));
            client.Origin = "https://www.curse.com";
            client.OnMessage += OnMessage;
            client.Connect();
        }

        private void OnMessage(object sender, MessageEventArgs e)
        {
            var data = e.Data;
            string body = JObject.Parse(data)["Body"].ToString();
            var model = JsonConvert.DeserializeObject<CurseMessage>(data);
            switch(model.ResponseType)
            {
                case Enums.CurseResponseType.ChatMessage:

                    break;
                case Enums.CurseResponseType.Login:
                    break;
                case Enums.CurseResponseType.MessageChanged:
                    break;
                case Enums.CurseResponseType.UserActivityChange:
                    break;
                case Enums.CurseResponseType.ChannelMarkedRead:
                    break;
                case Enums.CurseResponseType.MessageStatus:
                    break;
                case Enums.CurseResponseType.ClientPreferences:
                    break;
                case Enums.CurseResponseType.ChannelStatusChanged:
                    break;
                case Enums.CurseResponseType.FriendshipStatus:
                    break;
                case Enums.CurseResponseType.FriendRemoved:
                    break;
                case Enums.CurseResponseType.Ping:
                    break;
            }
        }
    }
}
