using System;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using TorrentWEB.Core.Interfaces;
using TorrentWEB.Core.Sites;

namespace TorrentWEB.Core.Parse
{
    public class HtmlLoader
    {
         private IHttpClientFactory _client;
         private readonly UsualParse _parse;
        public HtmlLoader(IHttpClientFactory client,UsualParse parse)
        {
            _client = client;
            _parse = parse;
        }

        public async Task<string> GetHtmlByPage(UsualSetting setting)
        {
            var client = _client.CreateClient();
            var response =   client.GetAsync(setting.BaseUrl).Result;
                        
            var content = await response.Content.ReadAsStringAsync();
           
            string source = null;
            if (content != null)
            {
                var p = new HtmlParser();
             var c=   p.ParseDocument(content);
                _parse.GetObjects(c);
            }

            return source;
        }
    }
}