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
            CreateMap< TorrLafa,UsualSetting>();
            CreateMap<UsualSetting, TorrLafa>();
        }
    }
}