using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionAppDemo3.Backend.DataObjects
{
    public class AuctionItem : EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double StartingBid { get; set; }
        //calculated field
        public double CurrentBid { get; set; }
        public string AuctionId { get; set; }
        

    }
}