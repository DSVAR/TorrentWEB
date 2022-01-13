using TorrentWEB.Core.Interfaces;

namespace TorrentWEB.Core.Sites
{
    public class NNMCLUB:ISettingsParse
    {
        public string BaseUrl { get; set; } = "";
        public string Prefix { get; set; } = "";
        public string Description { get; set; } = "";
        public string ClassPages { get; set; }= "";
        public string ClassItems { get; set; }= "";
    }
}