using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AuctionAppDemo3.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace AuctionAppDemo3
{
    public class AuctionService
    {
        private static MobileServiceClient azClient;

        public AuctionService(string serviceBaseUri)
        {
            azClient = new MobileServiceClient(serviceBaseUri);
        }

        public async Task<IEnumerable<Auction>> GetAuctions()
        {
            var table = azClient.GetTable<Auction>();
            return await table.ReadAsync();
        }

        public async Task<IEnumerable<AuctionItem>> GetItems(string auctionId)
        {
            var table = azClient.GetTable<AuctionItem>();
            var query = table.Where(ai => ai.AuctionId == auctionId);
            return await table.ReadAsync();
        }

        public async Task<Bid> PlaceBid(Bid newBid)
        {
            var table = azClient.GetTable<Bid>();
            await table.InsertAsync(newBid);
            return newBid;
        }

        public async Task<IEnumerable<MyAuctionItem>> GetMyItems()
        {
            //NOTE: use non-generic overload to return data without serialization
            return await azClient.InvokeApiAsync<IEnumerable<MyAuctionItem>>("MyItems", HttpMethod.Get, null);
        }
    }
}
