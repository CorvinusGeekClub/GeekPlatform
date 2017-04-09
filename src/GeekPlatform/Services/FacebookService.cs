using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GeekPlatform.Services
{
    public class FacebookService
    {
        private const string URL_BASE = "https://graph.facebook.com/v2.8";
        private readonly String _appID = "233932450419402";
        private readonly String _appSecret = "1bb597ba7bc4a9939da1d4d3b699f816";

        public FacebookService(string appSecret)
        {
            _appSecret = appSecret;
        }

        public async Task<IEnumerable<FacebookEvent>> GetEventsAsync(string entity)
        {
            var url = URL_BASE + "/" + entity + "/events?fields=id,cover,name,description,start_time,end_time,place&access_token="+_appID+"|"+_appSecret;
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(url);
                return JsonConvert.DeserializeAnonymousType(response, new {data = new List<FacebookEvent>()}).data;
            }
        }
    }
}
