namespace TorrentWEB.Core.Interfaces
{
    public interface ISettingsParse
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
        string Description { get; set; }
        string ClassPages { get; set; }
        string ClassItems { get; set; }
        string TagOfItem { get; set; }
        
        string TagOfPage { get; set; }
        string AttributePhoto { get; set; } 
        
        string ClassOfObject { get; set; }
         string ParentTagName { get; set; }
         string ParentTagPhoto { get; set; }
         string ParentTagRating { get; set; }
         string ParentTagDescription { get; set; } 
         string ParentTagHrefFilm { get; set; }
        
         string ChildTagName { get; set; }
         string ChildTagPhoto { get; set; }
         string ChildTagRating { get; set; }
         string ChildTagDescription { get; set; } 
         string ChildTagHrefFilm { get; set; }
    }
}