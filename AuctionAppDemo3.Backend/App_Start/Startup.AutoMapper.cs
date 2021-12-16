using AuctionAppDemo3.Backend.DataObjects;
using AuctionAppDemo3.Backend.Models;
using System.Web.Http;

namespace AuctionAppDemo3.Backend
{
    public partial class Startup
    {
        public static void ConfigureAutoMapper(HttpConfiguration config)
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AuctionItem, AuctionItemDTO>();
                cfg.CreateMap<AuctionItemDTO, AuctionItem>().ForMember(
                    ai => ai.CurrentBid, map => map.UseValue(0.0));
            });
        }
    }
}