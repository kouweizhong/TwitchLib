using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Models.App.Login;

namespace TwitchLib
{
    public class TwitchApp
    {
        private OAuth oauth;
        private Fuel fuel;
        private Models.App.Session.Session session;
        public TwitchApp() { }

        /// <summary>
        /// Calls two authorization calls to create OAuth and Fuel models which are used to access the rest of the curse service.
        /// </summary>
        /// <param name="code">This code comes from here: https://api.twitch.tv/kraken/oauth2/authorize?action=callback&client_id=jf3xu125ejjjt5cl4osdjci6oz6p93r&redirect_uri=https%3A%2F%2Fweb.curseapp.net%2Flaguna%2Fpassport-callback.html&response_type=code Go there, login, and after being redirected, look at the new URL in the browser and copy the code parameter.</param>
        public async void Connect(string code)
        {
            // login stuffs
            oauth = await Internal.Requests.TwitchApp.Auth(code);
            fuel = await Internal.Requests.TwitchApp.Post<Models.App.Login.Fuel>("https://logins-v1.curseapp.net/login/fuel", oauth.Session.Token);

            // download contacts/servers


            // create session
            session = await Internal.Requests.TwitchApp.PostModel<Models.App.Session.Session>("https://sessions-v1.curseapp.net/sessions", oauth.Session.Token, new Models.App.RequestModels.CreateSession());
        }
    }
}
