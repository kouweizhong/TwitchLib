using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.App.RequestModels
{
    public class CreateSession : BaseModel
    {
        public string MachineKey { get; protected set; }
        public int Platform { get; protected set; }
        public string DeviceID { get; protected set; }
        public string PushKitToken { get; protected set; }

        public CreateSession()
        {
            MachineKey = Guid.NewGuid().ToString();
            Platform = 0;
        }
    }
}
