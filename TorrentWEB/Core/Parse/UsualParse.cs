using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;
using TorrentWEB.Core.Interfaces;
using TorrentWEB.Core.Sites;
using TorrentWEB.Models;

namespace TorrentWEB.Core.Parse
{
    public class UsualParse
    {
        private HtmlParser _html;
  //      private List<string> _list;
        private Cart _usual;
        private List<Cart> _pars;
        public UsualParse(HtmlParser html,Cart usual)
        {
            _html = html;
            _usual = usual;
        }
        
       public List<Cart> GetObjects(IHtmlDocument document,UsualSetting setting)
       {
           if (_pars==null)
           {
               _pars = new List<Cart>();
           }
           else
           {
               _pars.Clear();
           }
           
           
            var items = document.QuerySelectorAll(setting.TagOfItem)
                .Where(item => item.ClassName == setting.ClassItems);
            
            foreach (var item in items)
            {
                var doc = _html.ParseDocument( item.InnerHtml);
                
                var na = doc.GetElementsByClassName(setting.ClassOfObject);//родитель объекта
                var itemPhoto = doc.QuerySelectorAll(setting.ParentTagPhoto);//родитель фото
                var rating = doc.GetElementById(setting.ParentTagRating);
                var hrefChild = na[0].QuerySelectorAll(setting.ParentTagHrefFilm).OfType<IHtmlAnchorElement>().ToArray();
                
                
                var photo = itemPhoto[0].QuerySelectorAll(setting.ChildTagPhoto)
                    .Select(atr=>atr.GetAttribute(setting.AttributePhoto)).ToArray().Where(at=>at!=null).ToArray();//ссылка на фото
                

               // var despriptionChild = item.TextContent;
                
                _usual.Rating = rating.TextContent;
                _usual.Name = na[0].TextContent;//получении текста фильма
                _usual.Href = hrefChild[0].Href.Remove(0,9);//ссылнка на фильм
                _usual.PhotoUrl = setting.UrlPhoto+ photo[0];//ссылка фото
               
                
                
                _pars.Add(_usual);
                
                _usual = new Cart();

            }

            return _pars;
        }

       public  int GetCountPages(IHtmlDocument document,UsualSetting setting)
        {
            var list = new List<int>();
            var items = document.QuerySelectorAll("a")
                .Select(atr=>atr.GetAttribute("href")).ToArray().Where(atr=>atr.Contains("page/")).Distinct();

          
            
            foreach (var item in items)
            {
             var number = Regex.Replace(item, "[^0-9]", "");

             list.Add(int.Parse(number));
            }


            return list.Max();
        }
    }
}