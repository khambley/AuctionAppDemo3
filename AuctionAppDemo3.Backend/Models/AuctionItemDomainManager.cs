using AuctionAppDemo3.Backend.DataObjects;
using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AuctionAppDemo3.Backend.Models
{
    public class AuctionItemDomainManager : MappedEntityDomainManager<AuctionItem, AuctionItemDTO>
    {
        public AuctionItemDomainManager(DbContext context, System.Net.Http.HttpRequestMessage request): base(context, request)
        { }

        public override IQueryable<AuctionItem> Query()
        {
            return base.Query();
        }
        public override System.Web.Http.SingleResult<AuctionItem> Lookup(string id)
        {
            return base.LookupEntity((ai) => ai.Id == id);
        }

        public override Task<bool> DeleteAsync(string id)
        {
            return base.DeleteItemAsync(id);
        }
        public override Task<AuctionItem> UpdateAsync(string id, System.Web.Http.OData.Delta<AuctionItem> patch)
        {
            return base.UpdateEntityAsync(patch, id);
        }
    }
}