using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionAppDemo3.Backend.DataObjects
{
    public class Bid : EntityData
    {
        public double BidAmount { get; set; }
        public string Bidder { get; set; }

        public string AuctionItemId { get; set; }
        public virtual AuctionItem AuctionItem { get; set; }

    }
}