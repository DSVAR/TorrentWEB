using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Microsoft.AspNetCore.Http;
using TorrentWEB.Core.Interfaces;
using TorrentWEB.Core.Sites;
using TorrentWEB.Models;

namespace TorrentWEB.Core.Parse
{
    public class HtmlLoader
    {
        private IHttpClientFactory _client;
        private readonly UsualParse _parse;

        public HtmlLoader(IHttpClientFactory client, UsualParse parse)
        {
            _client = client;
            _parse = parse;
        }

        public async Task<IHtmlDocument> GetHtmlByPage(UsualSetting setting)
        {
            var client = _client.CreateClient();
            var response = client.GetAsync(setting.BaseUrl).Result;

            if (response.StatusCode==HttpStatusCode.OK)
            {
                var content = response.Content.ReadAsStreamAsync().Result;

                if (content != null)
                {
                    var p = new HtmlParser();
                    return p.ParseDocument(content);
                }
            }

            return null;
        }
    }
}