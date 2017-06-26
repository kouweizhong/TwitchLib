using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Enums
{
    public enum CurseRequestType
    {
        Login = -2101997347,
        Ping = -476754606
    }

    public enum CurseResponseType
    {
        Ping = -476754606,
        ChannelStatusChanged = 72981382,
        UserActivityChange = 1260535191,
        ChannelMarkedRead = -695526586,
        ChatMessage = -635182161,
        Login = -815187584,
        ClientPreferences = 937250613,
        MessageChanged = 149631008,
        MessageStatus = 705131365,
        FriendshipStatus = 580569888,
        FriendRemoved = 1216900677,
    }
}
