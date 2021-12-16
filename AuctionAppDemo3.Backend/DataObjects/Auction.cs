﻿using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionAppDemo3.Backend.DataObjects
{
    public class Auction : EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<AuctionItem> AuctionItems { get; set; }


    }
}