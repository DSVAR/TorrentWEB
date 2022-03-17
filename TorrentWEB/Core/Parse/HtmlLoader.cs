using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Io;
using TorrentWEB.Core.Sites;
using HttpMethod = System.Net.Http.HttpMethod;

namespace TorrentWEB.Core.Parse
{
    public class HtmlLoader
    {
        private IHttpClientFactory _client;
        
        public HtmlLoader(IHttpClientFactory client)
        {
            _client = client;
        }

        public async Task<IHtmlDocument> GetHtmlByPage(UsualSetting setting,int currentPage)
        {
            try
            {
                var client = _client.CreateClient();

                
                var response =  await client.GetAsync(setting.BaseUrl + setting.Prefix + setting.PrefixPage + currentPage).ConfigureAwait(false);
                
            
                if (response.StatusCode==HttpStatusCode.OK)
                {
                    var content = await response.Content.ReadAsStreamAsync();

                    if (content != null)
                    {
                        var p = new HtmlParser();
                        return p.ParseDocument(content);
                    }
                }
            }
            catch (Exception ex)
            {
                var p = 2;
            }
           

            return null;
            
        }
    }
}