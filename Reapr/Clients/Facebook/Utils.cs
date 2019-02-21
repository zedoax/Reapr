using System.Collections.Generic;
using fbchat_sharp.API;
using Reapr.Clients.Facebook.Client;

namespace Reapr.Clients.Facebook
{
    public class Utils
    {
        public static List<FB_Thread> GetChats(FbClient client)
        {
            return client.fetchThreadList().GetAwaiter().GetResult();
        }

        public static List<FB_Message> GetChat(FbClient client, string chat_id)
        {
            return client.FetchThreadMessages(chat_id).GetAwaiter().GetResult();
        }

    }
}