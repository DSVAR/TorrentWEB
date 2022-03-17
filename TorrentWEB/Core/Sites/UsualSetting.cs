using TorrentWEB.Core.Interfaces;

namespace TorrentWEB.Core.Sites
{
    public class UsualSetting:ISettingsParse
    {
        public string BaseUrl { get; set; }
        public  string UrlPhoto { get; set; }
        public string PrefixPage { get; set; }
        public string Prefix { get; set; }
        public string Description { get; set; }
        public string ClassPages { get; set; }
        public string ClassItems { get; set; }
        public string TagOfItem { get; set; }
        public string TagOfPage { get; set; }
        
        public string AttributePhoto { get; set; }
        public string ClassOfObject { get; set; }

        public string ParentTagName { get; set; }
        public string ParentTagPhoto { get; set; }
        public string ParentTagRating { get; set; }
        public string ParentTagDescription { get; set; } 
        public string ParentTagHrefFilm { get; set; }
        
        public string ChildTagName { get; set; }
        public string ChildTagPhoto { get; set; }
        public string ChildTagRating { get; set; }
        public string ChildTagDescription { get; set; } 
        public string ChildTagHrefFilm { get; set; }
        
      
    }
}