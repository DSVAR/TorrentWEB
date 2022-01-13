namespace TorrentWEB.Core.Interfaces
{
    public interface ISettingsParse
    {
        string BaseUrl { get; set; }
        string Prefix { get; set; }
        string Description { get; set; }
        string ClassPages { get; set; }
        string ClassItems { get; set; }
    }
}