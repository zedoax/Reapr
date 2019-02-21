using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SlackAPI;

namespace Reapr.Clients.Slack
{
    public class Slack
    {
        private SlackClient _client;

        public Slack()
        {
            Login();
        }

        public void Login()
        {
            RunAuthentication().GetAwaiter().GetResult();
        }

        public async Task RunAuthentication()
        {
            var username = "";
            var password = "";
            var team = "";
            var api_response = await SlackTaskClient.AuthSignin(username, team, password);
            _client = new SlackClient(api_response.token);
            var loggedIn = false;
            _client.TestAuth(callback => { loggedIn = callback.ok; });
            if (loggedIn)
            {
                Console.WriteLine("[Log] Slack Login Successful: " + DateTime.Now);
            }

        }

        public List<DirectMessageConversation> GetChats()
        {
            return _client.DirectMessages;
        }

        public List<Channel> GetGroups()
        {
            return _client.Groups;
        }
        
        public List<Channel> GetChannels()
        {
            return _client.Channels;
        }
    }
}