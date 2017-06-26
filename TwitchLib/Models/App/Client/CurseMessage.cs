using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.Client
{
    public class CurseMessage
    {
        public Enums.CurseResponseType ResponseType { get; set; }
        public CurseResponseBody ResponseBody { get; set; }
    }
}
