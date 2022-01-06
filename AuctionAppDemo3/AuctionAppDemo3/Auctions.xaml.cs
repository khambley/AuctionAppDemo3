using System;
using System.Collections.Generic;
using AuctionAppDemo3.ViewModels;
using Xamarin.Forms;

namespace AuctionAppDemo3
{
    public partial class Auctions
    {
        public Auctions()
        {
            InitializeComponent();
            this.BindingContext = new AuctionsViewModel(this.Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((AuctionsViewModel)BindingContext).Load();
        }
    }
}
