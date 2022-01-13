using System;
using System.Net.Http;
using System.Threading.Tasks;
using TorrentWEB.Core.Interfaces;
using TorrentWEB.Core.Sites;

namespace TorrentWEB.Core.Parse
{
    public class HtmlLoader
    {
         private HttpClient _client;
        
        public HtmlLoader()
        {
            _client = new HttpClient();
            _client.BaseAddress=new Uri("https://localhost:5001/");
        }

        public async Task<string> GetHtmlByPage()
        {


            var response = await _client.GetAsync("");
            string source = "pisun";
            
            // if (response != null && response.IsSuccessStatusCode)
            // {
            //     source= await response.Content.ReadAsStringAsync();
            // }

            return source;
        }
    }
}