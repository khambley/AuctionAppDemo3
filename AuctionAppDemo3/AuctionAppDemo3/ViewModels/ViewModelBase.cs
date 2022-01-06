using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AuctionAppDemo3.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private INavigation nav;
        public INavigation Navigation { get { return nav; } }

        public ViewModelBase(INavigation navigation)
        {
            nav = navigation;
        }

        private bool loading;

        public bool IsLoading
        {
            get { return loading; }
            set
            {
                loading = value;
                NotifyPropertyChanged("IsLoading");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }   
    }
}
