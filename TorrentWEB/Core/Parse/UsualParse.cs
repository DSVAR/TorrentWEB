using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;
using TorrentWEB.Core.Interfaces;

namespace TorrentWEB.Core.Parse
{
    public class UsualParse
    {
        string[] GetObjects(IHtmlDocument document,ISettingsParse settingsParse)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("")
                .Where(item => item.ClassName != null && item.ClassName == " ");
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }

        string[]  GetCountPages(IHtmlDocument document,ISettingsParse settingsParse)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("")
                .Where(item => item.ClassName != null && item.ClassName == " "); 
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}