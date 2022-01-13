using AngleSharp.Html.Dom;

namespace TorrentWEB.Core.Interfaces
{
    public interface IParse
    {
        string GetObjects(IHtmlDocument document);
        string GetCountPages(IHtmlDocument document);
    }
}