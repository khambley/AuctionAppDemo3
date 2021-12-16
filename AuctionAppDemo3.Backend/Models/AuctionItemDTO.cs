using AuctionAppDemo3.Backend.DataObjects;
using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionAppDemo3.Backend.Models
{
    public class AuctionItemDTO : EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double StartingBid { get; set; }

        [Column("Auction_Id")]
        public string AuctionId { get; set; }

        [ForeignKey("AuctionId")]
        public virtual Auction Auction { get; set; }

        public virtual Collection<Bid> Bids { get; set; }

    }
}