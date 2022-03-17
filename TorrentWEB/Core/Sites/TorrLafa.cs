using TorrentWEB.Core.Interfaces;

namespace TorrentWEB.Core.Sites
{
    public class TorrLafa:ISettingsParse
    {
        public string BaseUrl { get; set; } = "https://tor.lafa.site";
        public string UrlPhoto { get; set; } = "https://tor.lafa.site";
        public string PrefixPage { get; set; } = "page/";
        public string Prefix { get; set; }= "/film/";
        public string Description { get; set; }= "";
        public string ClassPages { get; set; }= "";
        public string ClassItems { get; set; }= "in_cinema";
        public string TagOfItem { get; set; } = "tr";
        public string TagOfPage { get; set; } = "";

        public string ClassOfObject { get; set; } = "c_title";

        public string AttributePhoto { get; set; } = "data-original";

        public string ParentTagName { get; set; } = "";
        public string ParentTagPhoto { get; set; }= "div.tt_container";
        public string ParentTagRating { get; set; }= "current";
        public string ParentTagDescription { get; set; }= "";
        public string ParentTagHrefFilm { get; set; }= "a";
        
        public string ChildTagName { get; set; }= "";
        public string ChildTagPhoto { get; set; }= "img";
        public string ChildTagRating { get; set; }= "";
        public string ChildTagDescription { get; set; }= "";
        public string ChildTagHrefFilm { get; set; }= "";
    }
}