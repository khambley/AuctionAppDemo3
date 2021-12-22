using Microsoft.Azure.Mobile.Server;

namespace AuctionAppDemo3.Backend.DataObjects
{
    public class Comment : StorageData 
    {
        public string CommentText { get; set; }
    }
}