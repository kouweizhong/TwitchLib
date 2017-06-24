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
        private string code;
        private OAuth oauth;
        private Fuel fuel;
        public TwitchApp(string code)
        {
            this.code = code;
        }

        public async void Login()
        {
            oauth = await Internal.Requests.TwitchApp.Auth(code);
            fuel = await Internal.Requests.TwitchApp.Fuel(oauth.Session.Token);
        }
    }
}
