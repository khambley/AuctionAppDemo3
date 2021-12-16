using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AuctionAppDemo3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            message.Text = "Loading items...";

            //MobileServiceClient client = new MobileServiceClient("http://localhost:2847");
            MobileServiceClient client = new MobileServiceClient("https://auctionappdemo3.azurewebsites.net/");
            var items = await client.GetTable<TodoItem>().ReadAsync();
            var item = items.First();
            message.Text = item.Text;
        }
    }
}
