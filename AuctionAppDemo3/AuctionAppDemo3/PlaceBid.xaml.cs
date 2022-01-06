using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AuctionAppDemo3.ViewModels;
using AuctionAppDemo3.Models;

namespace AuctionAppDemo3
{
    public partial class PlaceBid
    {
        public PlaceBid(AuctionItem item)
        {
            InitializeComponent();
            this.BindingContext = new PlaceBidViewModel(item, Navigation);
        }
    }
}
