using AutoMapper;
using TorrentWEB.Core.Sites;

namespace TorrentWEB.Core
{
    public class ConfigureMapping:Profile
    {
        public ConfigureMapping()
        {
            CreateMap<UsualSetting, Kinozavl>();
            CreateMap< Kinozavl,UsualSetting>();
        }
    }
}