using System.Collections.Generic;
using System.Linq;
using AngleSharp.Html.Dom;
using TorrentWEB.Core.Interfaces;

namespace TorrentWEB.Core.Parse
{
    public class UsualParse
    {
       public string[] GetObjects(IHtmlDocument document)
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

       public  string[]  GetCountPages(IHtmlDocument document)
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