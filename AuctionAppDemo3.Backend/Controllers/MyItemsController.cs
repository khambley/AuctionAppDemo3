using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using System.Collections.Generic;
using AuctionAppDemo3.Backend.DataObjects;
using AuctionAppDemo3.Backend.Models;
using System.Linq;

namespace AuctionAppDemo3.Backend.Controllers
{
    [MobileAppController]
    public class MyItemsController : ApiController
    {
        public IEnumerable<MyAuctionItem> Get()
        {
            MobileServiceContext ctx = new MobileServiceContext();

            var myItems = from ai in ctx.AuctionItems
                          select new MyAuctionItem
                          {
                              Id = ai.Id,
                              Name = ai.Name,
                              Description = ai.Description,
                              CurrentBid = ai.Bids.Count == 0 ? 0 : ai.Bids.Max(b => b.BidAmount),
                              MyHighestBid = 0 //TODO: we'll fix this later
                          };
            return myItems;
        }
    }
}
