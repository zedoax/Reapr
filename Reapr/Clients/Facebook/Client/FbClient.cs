using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using fbchat_sharp.API;

namespace Reapr.Clients.Facebook.Client
{
    public class FbClient : MessengerClient
    {

        protected override async Task DeleteCookiesAsync()
        {
            await Task.Yield();
        }      

        protected override async Task<List<Cookie>> ReadCookiesFromDiskAsync()
        {
            await Task.Yield();
            return null;
        }

        protected override async Task WriteCookiesToDiskAsync(List<Cookie> cookieJar)
        {
            await Task.Yield();
        }
    }
}